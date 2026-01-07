using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms.Patient;
using AmbulanceDispatcherApp.Forms;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace AmbulanceDispatcherApp
{
    public partial class CreateCallForm : Form
    {
        MySqlConnection conn;
        DataTable calls;
        DataTable dispatchers;
        DataTable callouts;

        DataTable patientsTable = new DataTable();
        MySqlDataAdapter patientsAdapter;
        private List<int> patientsIDs = new List<int>() { -1 };

        public bool IsClosed = false;

        public CreateCallForm()
        {
            InitializeComponent();

            datetime_time_created.Value = DateTime.Now;
            spin_callout.Text = "";

            this.conn = Program.SqlConnection;
            this.calls = Program.SqlCallTable;
            this.dispatchers = Program.SqlDispatcherTable;
            this.callouts = Program.SqlCalloutTable;

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";
            if(Program.SqlDispatcherId != -1)
                combo_dispatcher.SelectedValue = Program.SqlDispatcherId;

            datagridview_patient.AutoGenerateColumns = false;
            patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
            patientsAdapter.Fill(patientsTable);
            patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]! };
            datagridview_patient.DataSource = patientsTable;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!callouts.Rows.Contains(spin_callout.Value) && spin_callout.Text != "")
            {
                MessageBox.Show("Обраного виклику не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combo_dispatcher.SelectedValue == null)
            {
                MessageBox.Show("Обраного диспетчеру не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show("Ви неправильно ввели номер телефону. Правильний формат: +XXXXXXXXXXX", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_channel.Text.Trim() == "")
            {
                MessageBox.Show("Канал зв'язку не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var command = new MySqlCommand("INSERT INTO `call` (" +
                                                                "`call_address`," +
                                                                "`call_time_created`," +
                                                                "`call_reason`," +
                                                                "`call_channel`," +
                                                                "`call_caller_name`," +
                                                                "`call_caller_surname`," +
                                                                "`call_caller_patriarchic`," +
                                                                "`call_caller_tel`," +
                                                                "`callout_id`," +
                                                                "`dispatcher_id`)" +
                                                                "VALUES (" +
                                                                       "@call_address, " +
                                                                       "@call_time_created, " +
                                                                       "@call_reason, " +
                                                                       "@call_channel, " +
                                                                       "@call_caller_name, " +
                                                                       "@call_caller_surname, " +
                                                                       "@call_caller_patriarchic, " +
                                                                       "@call_caller_tel, " +
                                                                       "@callout_id, " +
                                                                       "@dispatcher_id" +
                                                                       "); SELECT LAST_INSERT_ID()"
                                                                       , Program.SqlConnection);

            command.Parameters.AddWithValue("@call_address", textbox_address.Text.Trim() == "" ? DBNull.Value : textbox_address.Text.Trim());
            command.Parameters.AddWithValue("@call_channel", textbox_channel.Text);
            command.Parameters.AddWithValue("@call_reason", textbox_reason.Text.Trim() == "" ? DBNull.Value : textbox_reason.Text.Trim());
            command.Parameters.AddWithValue("@call_time_created", Convert.ToDateTime(datetime_time_created.Text));
            command.Parameters.AddWithValue("@call_caller_name", textbox_name.Text.Trim() == "" ? DBNull.Value : textbox_name.Text.Trim());
            command.Parameters.AddWithValue("@call_caller_surname", textbox_surname.Text.Trim() == "" ? DBNull.Value : textbox_surname.Text.Trim());
            command.Parameters.AddWithValue("@call_caller_patriarchic", textbox_patriarchic.Text.Trim() == "" ? DBNull.Value : textbox_patriarchic.Text.Trim());
            command.Parameters.AddWithValue("@call_caller_tel", textbox_tel.Text);
            command.Parameters.AddWithValue("@dispatcher_id", combo_dispatcher.SelectedValue);
            command.Parameters.AddWithValue("@callout_id", spin_callout.Text == "" ? DBNull.Value : spin_callout.Value);

            UInt64 call_id = (command.ExecuteScalar() as UInt64?)!.Value;

            patientsIDs.Remove(-1);
            List<string> vals = new List<string>();
            foreach (int patientID in patientsIDs)
                vals.Add($"({patientID}, {call_id})");
            if (vals.Count > 0)
                (new MySqlCommand($"INSERT INTO `patientcall` (`patient_id`,`call_id`) VALUES {String.Join(", ", vals)}", Program.SqlConnection)).ExecuteNonQuery();

            Program.SyncTableCall();
            this.Close();
        }

        private void CreateCallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }

        private void button_patient_add_Click(object sender, EventArgs e)
        {
            PatientsForm form = new PatientsForm(FormMode.Select);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.SelectedPatientID == null)
                return;

            int? patientID = form.SelectedPatientID;
            if (!patientsIDs.Contains(patientID.Value))
                patientsIDs.Add(patientID.Value);

            Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
        }

        private void button_patient_remove_Click(object sender, EventArgs e)
        {
            if (datagridview_patient.SelectedRows.Count == 0)
                return;

            var row = datagridview_patient.SelectedRows[0].DataBoundItem as DataRowView;
            patientsIDs.Remove((row!["patient_id"] as int?)!.Value);
            Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
        }
    }
}
