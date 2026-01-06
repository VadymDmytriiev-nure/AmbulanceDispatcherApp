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
    public partial class EditCallForm : Form
    {
        MySqlConnection conn;
        DataRowView call;
        DataTable dispatchers;
        DataTable callouts;

        DataTable patientsTable = new DataTable();
        MySqlDataAdapter patientsAdapter;

        public bool IsClosed;

        public EditCallForm(DataRowView call)
        {
            InitializeComponent();

            this.conn = Program.SqlConnection;
            this.call = call;
            this.dispatchers = Program.SqlDispatcherTable;
            this.callouts = Program.SqlCalloutTable;

            textbox_address.Text = call["call_address"] as string;
            textbox_reason.Text = call["call_reason"] as string;
            textbox_name.Text = call["call_caller_name"] as string;
            textbox_surname.Text = call["call_caller_surname"] as string;
            textbox_patriarchic.Text = call["call_caller_patriarchic"] as string;
            textbox_tel.Text = call["call_caller_tel"] as string;
            textbox_channel.Text = call["call_channel"] as string;
            object callout_id = call["callout_id"];
            if (callout_id != DBNull.Value)
                spin_callout.Value = (decimal)(callout_id as int?)!;
            else
                spin_callout.Text = "";

            datetime_time_created.Value = Convert.ToDateTime(call["call_time_created"]);

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";
            if (call["dispatcher_id"] != DBNull.Value)
                combo_dispatcher.SelectedValue = (call["dispatcher_id"] as int?)!;
            else
            {
                combo_dispatcher.SelectedIndex = -1;
                combo_dispatcher.Text = "";
            }

            datagridview_patient.AutoGenerateColumns = false;
            patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname, `patientcall`.* FROM `patient` INNER JOIN `patientcall` ON `patient`.`patient_id` = `patientcall`.`patient_id` WHERE `call_id` = {call["call_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
            patientsAdapter.Fill(patientsTable);
            patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]!, patientsTable.Columns["departure_id"]! };
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

            var command = new MySqlCommand("UPDATE `Call` SET " +
                                           "`call_address` = @call_address, " +
                                           "`call_reason` = @call_reason, " +
                                           "`call_channel` = @call_channel, " +
                                           "`call_time_created` = @call_time_created, " +
                                           "`call_caller_name` = @call_caller_name, " +
                                           "`call_caller_surname` = @call_caller_surname, " +
                                           "`call_caller_patriarchic` = @call_caller_patriarchic, " +
                                           "`call_caller_tel` = @call_caller_tel, " +
                                           "`dispatcher_id` = @dispatcher_id, " +
                                           "`callout_id` = @callout_id " +
                                           "WHERE `call_id` = @call_id"
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
            command.Parameters.AddWithValue("@call_id", (call["call_id"] as int?)!);

            command.ExecuteNonQuery();
            Program.SyncTableCall();
            this.Close();
        }

        private void EditCallForm_FormClosed(object sender, FormClosedEventArgs e)
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

            try
            {
                (new MySqlCommand($"INSERT IGNORE INTO `patientcall` (`call_id`,`patient_id`) VALUES ({call["call_id"]}, {form.SelectedPatientID})", Program.SqlConnection)).ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Не вдалося додати до списку пацієнтів виїзду даного пацієнта. Можливо цей пацієнт вже пов'язаний з даним виїздом?", "Помилка додавання");
            }
            Program.SyncTable(patientsAdapter, patientsTable);
        }

        private void button_patient_remove_Click(object sender, EventArgs e)
        {
            if (datagridview_patient.SelectedRows.Count == 0)
                return;

            var row = datagridview_patient.SelectedRows[0].DataBoundItem as DataRowView;
            (new MySqlCommand($"DELETE FROM `patientcall` WHERE `patient_id` = {row!["patient_id"]} AND `call_id` = {call["call_id"]}", Program.SqlConnection)).ExecuteNonQuery();
            Program.SyncTable(patientsAdapter, patientsTable);
        }
    }
}
