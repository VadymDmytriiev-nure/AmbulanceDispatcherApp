using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms.Patient;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms
{
    public enum FormMode
    {
        View = 0,
        Create = 1,
        Edit = 2,
        Select = 3
    }

    public partial class CreateEditViewCalloutForm : Form
    {
        FormMode mode;
        DataRowView? callout;
        DataRowView? call;

        DataTable patientsTable = new DataTable();
        MySqlDataAdapter patientsAdapter;

        private List<int> patientsIDs = new List<int>() { -1 };

        public CreateEditViewCalloutForm(FormMode mode = FormMode.View, DataRowView? callout = null)
        {
            InitializeComponent();
            this.mode = mode;
            datagridview_patient.AutoGenerateColumns = false;

            if (mode == FormMode.Edit)
            {
                this.callout = callout;
                Text = $"Редагування виклику №{callout!["callout_id"]}";

                textbox_address.Text = callout!["callout_address"] as string;
                textbox_reason.Text = callout!["callout_reason"] as string;
                textbox_comment.Text = callout!["callout_comment"] as string;
                datetime_time_created.Value = (DateTime)callout!["callout_time_created"];
                checkbox_canceled.Checked = (bool?)callout!["callout_canceled"] ?? false;

                patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname, `patientcallout`.* FROM `patient` INNER JOIN `patientcallout` ON `patient`.`patient_id` = `patientcallout`.`patient_id` WHERE `callout_id` = {callout!["callout_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                patientsAdapter.Fill(patientsTable);
                patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]!, patientsTable.Columns["callout_id"]! };
                datagridview_patient.DataSource = patientsTable;
            }
            else if (mode == FormMode.Create)
            {
                Text = "Створення виклику";
                datetime_time_created.Value = DateTime.Now;

                patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                patientsAdapter.Fill(patientsTable);
                patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]! };
                datagridview_patient.DataSource = patientsTable;
            }
            else
            {
                Text = $"Виклик №{callout!["callout_id"]}";
                textbox_address.ReadOnly = true;
                textbox_reason.ReadOnly = true;
                textbox_comment.ReadOnly = true;
                datetime_time_created.Enabled = false;
                checkbox_canceled.Enabled = false;

                textbox_address.Text = callout!["callout_address"] as string;
                textbox_reason.Text = callout!["callout_reason"] as string;
                textbox_comment.Text = callout!["callout_comment"] as string;
                datetime_time_created.Value = (DateTime)callout!["callout_time_created"];
                checkbox_canceled.Checked = (bool?)callout!["callout_canceled"] ?? false;

                button_ok.Visible = true;
                button_cancel.Visible = false;
                button_save.Visible = false;

                button_patient_add.Visible = false;
                button_patient_remove.Visible = false;
                datagridview_patient.Size = new Size(487, 337);

                patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname, `patientcallout`.* FROM `patient` INNER JOIN `patientcallout` ON `patient`.`patient_id` = `patientcallout`.`patient_id` WHERE `callout_id` = {callout!["callout_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                patientsAdapter.Fill(patientsTable);
                patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]!, patientsTable.Columns["callout_id"]! };
                datagridview_patient.DataSource = patientsTable;
            }
        }

        public CreateEditViewCalloutForm(DataRowView call)
        {
            InitializeComponent();
            this.mode = FormMode.Create;
            datagridview_patient.AutoGenerateColumns = false;

            Text = $"Створення виклику (Дзвінок №{call["call_id"]})";
            datetime_time_created.Value = DateTime.Now;

            textbox_address.Text = call["call_address"] as string;
            textbox_reason.Text = call["call_reason"] as string;

            List<int> _patientsIDs = new List<int>();
            var reader = (new MySqlCommand($"select `patient_id` from `patientcall` where `call_id` = {call!["call_id"]}", Program.SqlConnection)).ExecuteReader();
            while (reader.Read())
                _patientsIDs.Add(reader.GetInt32(0));

            reader.Close();

            foreach (int patientID in _patientsIDs)
                if (!patientsIDs.Contains(patientID))
                    patientsIDs.Add(patientID);
            patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
            patientsAdapter.Fill(patientsTable);
            patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]! };
            datagridview_patient.DataSource = patientsTable;
        }

        private void checkbox_canceled_CheckedChanged(object sender, EventArgs e) => checkbox_canceled.Text = checkbox_canceled.Checked ? "Так" : "Ні";

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_address.Text.Trim() == "")
            {
                MessageBox.Show("Адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_reason.Text.Trim() == "")
            {
                MessageBox.Show("Привід не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mode == FormMode.Edit)
            {
                var command = new MySqlCommand(
                    "UPDATE `callout` SET " +
                    "`callout_address` = @addy, " +
                    "`callout_reason` = @rs, " +
                    "`callout_comment` = @cm, " +
                    "`callout_time_created` = @ctc, " +
                    "`callout_canceled` = @can " +
                    "WHERE `callout_id` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@addy", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@rs", textbox_reason.Text.Trim());
                command.Parameters.AddWithValue("@cm", textbox_comment.Text.Trim());
                command.Parameters.AddWithValue("@ctc", datetime_time_created.Value);
                command.Parameters.AddWithValue("@can", checkbox_canceled.Checked);
                command.Parameters.AddWithValue("@id", (int)callout!["callout_id"]);

                command.ExecuteNonQuery();
            }
            else if (mode == FormMode.Create)
            {
                var command = new MySqlCommand(
                    "INSERT INTO `callout` " +
                    "(`callout_address`,`callout_reason`,`callout_comment`,`callout_time_created`,`callout_canceled`) " +
                    "VALUES (@addy,@rs,@cm,@ctc,@can); SELECT LAST_INSERT_ID()",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@addy", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@rs", textbox_reason.Text.Trim());
                command.Parameters.AddWithValue("@cm", textbox_comment.Text.Trim());
                command.Parameters.AddWithValue("@ctc", datetime_time_created.Value);
                command.Parameters.AddWithValue("@can", checkbox_canceled.Checked);

                UInt64 callout_id = (command.ExecuteScalar() as UInt64?)!.Value;

                patientsIDs.Remove(-1);

                List<string> vals = new List<string>();
                foreach (int patientID in patientsIDs)
                    vals.Add($"({patientID}, {callout_id})");
                if (vals.Count > 0)
                    (new MySqlCommand($"INSERT INTO `patientcallout` (`patient_id`,`callout_id`) VALUES {String.Join(", ", vals)}", Program.SqlConnection)).ExecuteNonQuery();

                if(call != null)
                {
                    (new MySqlCommand($"UPDATE `call` SET `callout_id` = {callout_id}", Program.SqlConnection)).ExecuteNonQuery();
                    Program.SyncTableCall();
                }
            }

            Program.SyncTableCallout();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e) => Close();

        private void button_patient_add_Click(object sender, EventArgs e)
        {
            PatientsForm form = new PatientsForm(FormMode.Select);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.SelectedPatientID == null)
                return;

            if (mode == FormMode.Edit)
            {
                try
                {
                    (new MySqlCommand($"INSERT IGNORE INTO `patientcallout` (`patient_id`,`callout_id`) VALUES ({form.SelectedPatientID}, {callout!["callout_id"]})", Program.SqlConnection)).ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося додати до списку пацієнтів виїзду даного пацієнта. Можливо цей пацієнт вже пов'язаний з даним виїздом?", "Помилка додавання");
                }

                Program.SyncTable(patientsAdapter, patientsTable);
            }
            else
            {
                int? patientID = form.SelectedPatientID;
                if (!patientsIDs.Contains(patientID.Value))
                    patientsIDs.Add(patientID.Value);

                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
            }
        }

        private void button_patient_remove_Click(object sender, EventArgs e)
        {
            if (datagridview_patient.SelectedRows.Count == 0)
                return;

            var row = datagridview_patient.SelectedRows[0].DataBoundItem as DataRowView;
            if (mode == FormMode.Edit)
            {
                (new MySqlCommand($"DELETE FROM `patientcallout` WHERE `patient_id` = {row!["patient_id"]} AND `callout_id` = {callout!["callout_id"]}", Program.SqlConnection)).ExecuteNonQuery();
                Program.SyncTable(patientsAdapter, patientsTable);
            }
            else
            {
                patientsIDs.Remove((row!["patient_id"] as int?)!.Value);
                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
            }
        }

        private void button_ok_Click(object sender, EventArgs e) => Close();
    }
}
