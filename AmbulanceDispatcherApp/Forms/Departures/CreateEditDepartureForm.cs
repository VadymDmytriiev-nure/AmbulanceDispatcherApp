using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms.Patient;
using AmbulanceDispatcherApp.Forms.Workers;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms.Departures
{
    public partial class CreateEditDepartureForm : Form
    {
        DataRowView? departure;
        FormMode mode;

        DataTable personnelTable = new DataTable();
        MySqlDataAdapter personnelAdapter;
        DataTable patientsTable = new DataTable();
        MySqlDataAdapter patientsAdapter;

        private List<int> personnelIDs = new List<int>() { -1 };
        private List<int> patientsIDs = new List<int>() { -1 };

        public CreateEditDepartureForm(FormMode mode, DataRowView? departure)
        {
            InitializeComponent();

            spin_callout.Text = "";
            this.mode = mode;

            datagridview_patient.AutoGenerateColumns = false;
            datagridview_personnel.AutoGenerateColumns = false;

            if (mode == FormMode.Edit && departure != null)
            {
                this.departure = departure;
                Text = "Редагування виїзду";

                textbox_from_address.Text = departure["departure_from_address"] as string;
                textbox_to_address.Text = departure["departure_to_address"] as string;
                spin_mileage.Value = (decimal)(departure["departure_mileage_km"] as float?)!.Value;
                spin_callout.Value = (departure["callout_id"] as int?)!.Value;
                datetime_departed.Value = (DateTime)departure["departure_time_departed"];
                datetime_arrived.Value = (DateTime)departure["departure_time_arrived"];

                personnelAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code, departure_id FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id INNER JOIN `workerdeparture` ON `worker`.`worker_id` = `workerdeparture`.`worker_id` WHERE `departure_id` = {departure!["departure_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                personnelAdapter.Fill(personnelTable);
                personnelTable.PrimaryKey = new DataColumn[] { personnelTable.Columns["worker_id"]!, personnelTable.Columns["departure_id"]! };
                datagridview_personnel.DataSource = personnelTable;

                patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname, `patientdeparture`.* FROM `patient` INNER JOIN `patientdeparture` ON `patient`.`patient_id` = `patientdeparture`.`patient_id` WHERE `departure_id` = {departure!["departure_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                patientsAdapter.Fill(patientsTable);
                patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]!, patientsTable.Columns["departure_id"]! };
                datagridview_patient.DataSource = patientsTable;
            }
            else
            {
                Text = "Створення виїзду";
                datetime_departed.Value = DateTime.Now;
                datetime_arrived.Value = DateTime.Now;

                personnelAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id WHERE `worker_id` IN ({String.Join(", ", personnelIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                personnelAdapter.Fill(personnelTable);
                personnelTable.PrimaryKey = new DataColumn[] { personnelTable.Columns["worker_id"]! };
                datagridview_personnel.DataSource = personnelTable;

                patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
                patientsAdapter.Fill(patientsTable);
                patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]! };
                datagridview_patient.DataSource = patientsTable;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Program.SqlCalloutTable.Rows.Contains(spin_callout.Value) || spin_callout.Value == 0)
            {
                MessageBox.Show("Обраного виклику не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_from_address.Text.Trim() == "")
            {
                MessageBox.Show("Початкова адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_to_address.Text.Trim() == "")
            {
                MessageBox.Show("Кінцева адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (spin_mileage.Value < 0)
            {
                MessageBox.Show("Кілометраж не може бути від'ємним", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mode == FormMode.Create && personnelIDs.Count <= 1)
            {
                MessageBox.Show("Особовий склад не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mode == FormMode.Edit)
            {
                var command = new MySqlCommand(
                    "UPDATE `departure` SET " +
                    "`departure_from_address` = @from_addy, " +
                    "`departure_to_address` = @to_addy, " +
                    "`departure_mileage_km` = @km, " +
                    "`departure_time_departed` = @dtd, " +
                    "`departure_time_arrived` = @dta, " +
                    "`callout_id` = @callout " +
                    "WHERE `departure_id` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@from_addy", textbox_from_address.Text.Trim());
                command.Parameters.AddWithValue("@to_addy", textbox_to_address.Text.Trim());
                command.Parameters.AddWithValue("@km", spin_mileage.Value);
                command.Parameters.AddWithValue("@dtd", datetime_departed.Value);
                command.Parameters.AddWithValue("@dta", datetime_arrived.Value);
                command.Parameters.AddWithValue("@callout", (int)spin_callout.Value);
                command.Parameters.AddWithValue("@id", (int)departure!["departure_id"]);

                command.ExecuteNonQuery();
            }
            else
            {
                var command = new MySqlCommand(
                    "INSERT INTO `departure` " +
                    "(`departure_from_address`,`departure_to_address`,`departure_mileage_km`,`departure_time_departed`,`departure_time_arrived`,`callout_id`) " +
                    "VALUES (@from_addy,@to_addy,@km,@dtd,@dta,@callout); SELECT LAST_INSERT_ID()",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@from_addy", textbox_from_address.Text.Trim());
                command.Parameters.AddWithValue("@to_addy", textbox_to_address.Text.Trim());
                command.Parameters.AddWithValue("@km", spin_mileage.Value);
                command.Parameters.AddWithValue("@dtd", datetime_departed.Value);
                command.Parameters.AddWithValue("@dta", datetime_arrived.Value);
                command.Parameters.AddWithValue("@callout", (int)spin_callout.Value);

                var ret = command.ExecuteScalar();
                UInt64 departure_id = (ret as UInt64?)!.Value;

                personnelIDs.Remove(-1);
                patientsIDs.Remove(-1);

                List<string> vals = new List<string>();
                foreach (int workerID in personnelIDs)
                    vals.Add($"({workerID}, {departure_id})");
                if (vals.Count > 0)
                    (new MySqlCommand($"INSERT INTO `workerdeparture` (`worker_id`,`departure_id`) VALUES {String.Join(", ", vals)}", Program.SqlConnection)).ExecuteNonQuery();

                vals.Clear();
                foreach (int patientID in patientsIDs)
                    vals.Add($"({patientID}, {departure_id})");
                if (vals.Count > 0)
                    (new MySqlCommand($"INSERT INTO `patientdeparture` (`patient_id`,`departure_id`) VALUES {String.Join(", ", vals)}", Program.SqlConnection)).ExecuteNonQuery();
            }

            Program.SyncTableDeparture();
            Close();
        }

        private void button_personnel_from_brigade_Click(object sender, EventArgs e)
        {
            PersonnelFromBrigadeForm form = new PersonnelFromBrigadeForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (mode == FormMode.Edit)
            {
                try
                {
                    (new MySqlCommand($"INSERT IGNORE INTO `workerdeparture` (`worker_id`,`departure_id`) SELECT `worker_id`, {departure!["departure_id"] as int?} as `departure_id` FROM `worker` WHERE `worker`.`brigade_id` = {form.SelectedBrigadeID}", Program.SqlConnection)).ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося додати до особового складу дану бригаду. Можливо її працівники вже в особовому складі даного виїзду?", "Помилка додавання");
                }
                Program.SyncTable(personnelAdapter, personnelTable);
            }
            else
            {
                List<int> workerIDs = new List<int>();
                var reader = (new MySqlCommand($"SELECT `worker_id` FROM `worker` WHERE `worker`.`brigade_id` = {form.SelectedBrigadeID}", Program.SqlConnection)).ExecuteReader();
                while (reader.Read())
                    workerIDs.Add(reader.GetInt32(0));

                reader.Close();

                foreach (int workerID in workerIDs)
                    if (!personnelIDs.Contains(workerID))
                        personnelIDs.Add(workerID);

                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id WHERE `worker_id` IN ({String.Join(", ", personnelIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), personnelTable);
            }
        }

        private void button_personnel_add_Click(object sender, EventArgs e)
        {
            WorkersForm form = new WorkersForm(FormMode.Select);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.SelectedWorkerID == null)
                return;

            if (mode == FormMode.Edit)
            {
                try
                {
                    (new MySqlCommand($"INSERT IGNORE INTO `workerdeparture` (`worker_id`,`departure_id`) VALUES ({form.SelectedWorkerID}, {departure!["departure_id"]})", Program.SqlConnection)).ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося додати до особового складу виїзду даного працівника. Можливо цей працівник вже в особовому складі даного виїзду?", "Помилка додавання");
                }
                Program.SyncTable(personnelAdapter, personnelTable);
            }
            else
            {
                int? workerID = form.SelectedWorkerID;
                if (!personnelIDs.Contains(workerID.Value))
                    personnelIDs.Add(workerID.Value);

                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id WHERE `worker_id` IN ({String.Join(", ", personnelIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), personnelTable);
            }
        }

        private void button_personnel_remove_Click(object sender, EventArgs e)
        {
            if (datagridview_personnel.SelectedRows.Count == 0)
                return;

            var row = datagridview_personnel.SelectedRows[0].DataBoundItem as DataRowView;
            if(mode == FormMode.Edit)
            {
                (new MySqlCommand($"DELETE FROM `workerdeparture` WHERE `worker_id` = {row!["worker_id"]} AND `departure_id` = {departure!["departure_id"]}", Program.SqlConnection)).ExecuteNonQuery();
                Program.SyncTable(personnelAdapter, personnelTable);
            }
            else
            {
                personnelIDs.Remove((row!["worker_id"] as int?)!.Value);
                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker INNER JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id WHERE `worker_id` IN ({String.Join(", ", personnelIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), personnelTable);
            }
        }

        private void button_patients_from_callout_Click(object sender, EventArgs e)
        {
            if (mode == FormMode.Edit)
            {
                try
                {
                    (new MySqlCommand("INSERT IGNORE INTO `patientdeparture` (`departure_id`, `patient_id`, `hospital_id`, `patient_denied_hospitalization`) " +
                                       "select 1 as `departure_id`, `patient_id`, null as `hospital_id`, null as `patient_denied_hospitalization` " +
                                      $"from `patientcallout` where `callout_id` = {departure!["callout_id"]}", Program.SqlConnection)).ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося додати до списку пацієнтів виїзду пацієнтів з пов'язаного виклику. Можливо ці пацієнти вже пов'язані з даним виїздом?", "Помилка додавання");
                }
                Program.SyncTable(patientsAdapter, patientsTable);
            }
            else
            {
                if (!Program.SqlCalloutTable.Rows.Contains(spin_callout.Value) || spin_callout.Value == 0)
                {
                    MessageBox.Show("Обраного виклику не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<int> _patientsIDs = new List<int>();
                var reader = (new MySqlCommand($"select `patient_id` from `patientcallout` where `callout_id` = {(int)spin_callout.Value}", Program.SqlConnection)).ExecuteReader();
                while (reader.Read())
                    _patientsIDs.Add(reader.GetInt32(0));

                reader.Close();

                foreach (int patientID in _patientsIDs)
                    if (!patientsIDs.Contains(patientID))
                        patientsIDs.Add(patientID);

                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
            }
        }

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
                    (new MySqlCommand($"INSERT IGNORE INTO `patientdeparture` (`patient_id`,`departure_id`) VALUES ({form.SelectedPatientID}, {departure!["departure_id"]})", Program.SqlConnection)).ExecuteNonQuery();
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
                (new MySqlCommand($"DELETE FROM `patientdeparture` WHERE `patient_id` = {row!["patient_id"]} AND `departure_id` = {departure!["departure_id"]}", Program.SqlConnection)).ExecuteNonQuery();
                Program.SyncTable(patientsAdapter, patientsTable);
            }
            else
            {
                patientsIDs.Remove((row!["patient_id"] as int?)!.Value);
                Program.SyncTable(new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` WHERE `patient_id` IN ({String.Join(", ", patientsIDs.ToArray())}) LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection)), patientsTable);
            }
            
        }
    }
}
