using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace AmbulanceDispatcherApp
{
    internal static class Program
    {
        public static bool DEBUG_MODE = true;
        public static string DEBUG_USER = "admin";
        public static string DEBUG_PASSWORD = "admin_password";
        public static string DEBUG_DATABASE = "emergencyhealthcare";

        public static string SQL_HOST = "localhost";
        public static string SQL_DATABASE = "emergencyhealthcare";
        public static ushort SQL_PORT = 3306;

        public static uint SQL_MAX_ROWS = 500;
        public static uint SQL_MAX_ROWS_FILTERED = 100;

        private static bool ApplicationAlreadyRunning = false;
        [AllowNull]
        public static MySqlConnection SqlConnection;
        [AllowNull]
        public static string SqlLogin;
        [AllowNull]
        public static string SqlRole;
        public static int SqlWorkerId = -1;
        public static int SqlDispatcherId = -1;
        public static DataRow? SqlAuthorizedAs;

        [AllowNull]
        public static DataTable SqlCallTable;
        [AllowNull]
        public static DataTable SqlCalloutTable;
        [AllowNull]
        public static DataTable SqlDispatcherTable;
        [AllowNull]
        public static DataTable SqlDepartureTable;
        [AllowNull]
        public static DataTable SqlHospitalTable;
        [AllowNull]
        public static DataTable SqlPatientTable;
        [AllowNull]
        public static DataTable SqlWorkerTable;
        [AllowNull]
        public static DataTable SqlSubstationTable;
        [AllowNull]
        public static DataTable SqlBrigadeTable;
        [AllowNull]
        public static DataTable SqlUsersTable;

        [AllowNull]
        public static DataTable SqlFilteredCallTable;
        [AllowNull]
        public static DataTable SqlFilteredCalloutTable;
        [AllowNull]
        public static DataTable SqlFilteredDispatcherTable;
        [AllowNull]
        public static DataTable SqlFilteredDepartureTable;
        [AllowNull]
        public static DataTable SqlFilteredHospitalTable;
        [AllowNull]
        public static DataTable SqlFilteredPatientTable;
        [AllowNull]
        public static DataTable SqlFilteredWorkerTable;
        [AllowNull]
        public static DataTable SqlFilteredSubstationTable;
        [AllowNull]
        public static DataTable SqlFilteredBrigadeTable;
        [AllowNull]
        public static DataTable SqlFilteredUsersTable;

        [AllowNull]
        public static MySqlDataAdapter SqlCallAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlCalloutAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlDispatcherAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlDepartureAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlHospitalAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlPatientAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlWorkerAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlSubstationAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlBrigadeAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlUsersAdapter;

        [AllowNull]
        public static MySqlDataAdapter SqlFilteredCallAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredCalloutAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredDispatcherAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredDepartureAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredHospitalAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredPatientAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredWorkerAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredSubstationAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredBrigadeAdapter;
        [AllowNull]
        public static MySqlDataAdapter SqlFilteredUsersAdapter;

        public static void Logout()
        {
            SqlConnection.Close();
            SqlRole = "";
            SqlWorkerId = -1;
            SqlDispatcherId = -1;

            SqlCallTable = null;
            SqlCalloutTable = null;
            SqlDispatcherTable = null;
            SqlDepartureTable = null;
            SqlHospitalTable = null;
            SqlPatientTable = null;
            SqlWorkerTable = null;
            SqlSubstationTable = null;
            SqlBrigadeTable = null;
            SqlUsersTable = null;

            SqlCallAdapter = null;
            SqlCalloutAdapter = null;
            SqlDispatcherAdapter = null;
            SqlDepartureAdapter = null;
            SqlHospitalAdapter = null;
            SqlPatientAdapter = null;
            SqlWorkerAdapter = null;
            SqlSubstationAdapter = null;
            SqlBrigadeAdapter = null;
            SqlUsersAdapter = null;

            SqlFilteredCallTable = null;
            SqlFilteredCalloutTable = null;
            SqlFilteredDispatcherTable = null;
            SqlFilteredDepartureTable = null;
            SqlFilteredHospitalTable = null;
            SqlFilteredPatientTable = null;
            SqlFilteredWorkerTable = null;
            SqlFilteredSubstationTable = null;
            SqlFilteredBrigadeTable = null;
            SqlFilteredUsersTable = null;

            SqlFilteredCallAdapter = null;
            SqlFilteredCalloutAdapter = null;
            SqlFilteredDispatcherAdapter = null;
            SqlFilteredDepartureAdapter = null;
            SqlFilteredHospitalAdapter = null;
            SqlFilteredPatientAdapter = null;
            SqlFilteredWorkerAdapter = null;
            SqlFilteredSubstationAdapter = null;
            SqlFilteredBrigadeAdapter = null;
            SqlFilteredUsersAdapter = null;

            AskLogin();
        }

        public static string AssignRole()
        {
            if(SqlConnection.State != ConnectionState.Open)
                throw new Exception("Connection is not open");

            MySqlCommand command = new MySqlCommand("SELECT `user_role`, `worker_id`, `dispatcher_id` FROM `emergencyhealthcare`.`Users` WHERE `user_login` = @userlogin;", SqlConnection);
            command.Parameters.AddWithValue("@userlogin", SqlLogin);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable roleDataTable = new DataTable();
            adapter.Fill(roleDataTable);

            if (roleDataTable.Rows.Count == 0)
                throw new Exception("User isn't correctly registered");

            Program.SqlRole = (roleDataTable.Rows[0]["user_role"] as string)!;
            Program.SqlWorkerId = (roleDataTable.Rows[0]["worker_id"] as int?) == null ? -1 : (int)(roleDataTable.Rows[0]["worker_id"] as int?)!;
            Program.SqlDispatcherId = (roleDataTable.Rows[0]["dispatcher_id"] as int?) == null ? -1 : (int)(roleDataTable.Rows[0]["dispatcher_id"] as int?)!;

            if (Program.SqlRole == "Адміністратор")
                new MySqlCommand("SET ROLE role_admin", SqlConnection).ExecuteScalar();
            else if (Program.SqlRole == "Диспетчер")
                new MySqlCommand("SET ROLE role_dispatcher", SqlConnection).ExecuteScalar();
            else if (Program.SqlRole == "Лікар")
                new MySqlCommand("SET ROLE role_doctor", SqlConnection).ExecuteScalar();
            else
                throw new Exception("User isn't correctly registered");

            return Program.SqlRole;
        }

        public static void AskLogin()
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AssignRole();
                    SqlConnection.ChangeDatabase(DEBUG_MODE ? DEBUG_DATABASE : SQL_DATABASE);
                }
                catch
                {
                    if (DEBUG_MODE)
                        throw;

                    MessageBox.Show("Не вдалося отримати права користувача. Якщо ця помилка повторюється, зверніться до системного адміністратора.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                // Отримання необхідної загальної інформації з БД
                RetrieveNecessary();

                if (Program.SqlRole == "Адміністратор")
                {
                    RetrieveUsers();
                    new DispatcherMainForm().Show();
                }
                else if (Program.SqlRole == "Диспетчер")
                {
                    new DispatcherMainForm().Show();
                }
                else if (Program.SqlRole == "Лікар")
                {

                }

                if (!ApplicationAlreadyRunning)
                {
                    ApplicationAlreadyRunning = true;
                    Application.Run();
                } 
            }
            else
            {
                if (ApplicationAlreadyRunning)
                    Application.Exit();
            }
        }
        
        private static void RetrieveNecessary()
        {
            RetrievePatients();
            RetrieveHospitals();
            RetrieveSubstations();
            RetrieveBrigades();
            RetrieveDispatchers();
            RetrieveCalls();
            RetrieveCallouts();
            RetrieveDepartures();
            RetrieveWorkers();
        }

        private static void RetrieveCalls()
        {
            MySqlCommand command = new MySqlCommand($"SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` LEFT JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlCallAdapter = new MySqlDataAdapter(command);
            SqlCallTable = new DataTable();
            SqlCallAdapter.Fill(SqlCallTable);

            SqlCallTable.PrimaryKey = new DataColumn[]{ SqlCallTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlCallAdapter);

            if (SqlFilteredCallTable == null)
                SqlFilteredCallTable = SqlCallTable;
            if (SqlFilteredCallAdapter == null)
                SqlFilteredCallAdapter = SqlCallAdapter;
        }

        private static void RetrieveCallouts()
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `callout` ORDER BY `callout_time_created` LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlCalloutAdapter = new MySqlDataAdapter(command);
            SqlCalloutTable = new DataTable();
            SqlCalloutAdapter.Fill(SqlCalloutTable);

            SqlCalloutTable.PrimaryKey = new DataColumn[] { SqlCalloutTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlCalloutAdapter);

            if (SqlFilteredCalloutTable == null)
                SqlFilteredCalloutTable = SqlCalloutTable;
            if (SqlFilteredCalloutAdapter == null)
                SqlFilteredCalloutAdapter = SqlCalloutAdapter;
        }

        private static void RetrieveDispatchers()
        {
            MySqlCommand command = new MySqlCommand($"SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher` LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlDispatcherAdapter = new MySqlDataAdapter(command);
            SqlDispatcherTable = new DataTable();
            SqlDispatcherAdapter.Fill(SqlDispatcherTable);

            SqlDispatcherTable.PrimaryKey = new DataColumn[] { SqlDispatcherTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlDispatcherAdapter);

            if (SqlFilteredDispatcherTable == null)
                SqlFilteredDispatcherTable = SqlDispatcherTable;
            if (SqlFilteredDispatcherAdapter == null)
                SqlFilteredDispatcherAdapter = SqlDispatcherAdapter;
        }

        private static void RetrieveSubstations()
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `substation` ORDER BY `substation`.`substation_code` ASC LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlSubstationAdapter = new MySqlDataAdapter(command);
            SqlSubstationTable = new DataTable();
            SqlSubstationAdapter.Fill(SqlSubstationTable);

            SqlSubstationTable.PrimaryKey = new DataColumn[] { SqlSubstationTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlSubstationAdapter);

            if (SqlFilteredSubstationTable == null)
                SqlFilteredSubstationTable = SqlSubstationTable;
            if (SqlFilteredSubstationAdapter == null)
                SqlFilteredSubstationAdapter = SqlSubstationAdapter;
        }

        private static void RetrieveBrigades()
        {
            MySqlCommand command = new MySqlCommand($"SELECT b.*, s.`substation_address`, s.`substation_code`, COUNT(worker_id) as brigade_worker_count FROM `brigade` b LEFT JOIN `worker` w ON w.`brigade_id` = b.`brigade_id` LEFT join `substation` s on s.`substation_id` = b.`substation_id` GROUP BY b.`brigade_id` LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlBrigadeAdapter = new MySqlDataAdapter(command);
            SqlBrigadeTable = new DataTable();
            SqlBrigadeAdapter.Fill(SqlBrigadeTable);

            SqlBrigadeTable.PrimaryKey = new DataColumn[] { SqlBrigadeTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlBrigadeAdapter);

            if (SqlFilteredBrigadeTable == null)
                SqlFilteredBrigadeTable = SqlBrigadeTable;
            if (SqlFilteredBrigadeAdapter == null)
                SqlFilteredBrigadeAdapter = SqlBrigadeAdapter;
        }

        private static void RetrieveHospitals()
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `hospital` LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlHospitalAdapter = new MySqlDataAdapter(command);
            SqlHospitalTable = new DataTable();
            SqlHospitalAdapter.Fill(SqlHospitalTable);

            SqlHospitalTable.PrimaryKey = new DataColumn[] { SqlHospitalTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlHospitalAdapter);

            if (SqlFilteredHospitalTable == null)
                SqlFilteredHospitalTable = SqlHospitalTable;
            if (SqlFilteredHospitalAdapter == null)
                SqlFilteredHospitalAdapter = SqlHospitalAdapter;
        }

        private static void RetrieveWorkers()
        {
            MySqlCommand command = new MySqlCommand($"SELECT worker.*, CONCAT(worker_surname,' ',worker_name,' ',worker_patriarchic) AS worker_fullname, brigade_code FROM worker LEFT JOIN `brigade` ON `brigade`.brigade_id = `worker`.brigade_id LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlWorkerAdapter = new MySqlDataAdapter(command);
            SqlWorkerTable = new DataTable();
            SqlWorkerAdapter.Fill(SqlWorkerTable);

            SqlWorkerTable.PrimaryKey = new DataColumn[] { SqlWorkerTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlWorkerAdapter);

            if (SqlFilteredWorkerTable == null)
                SqlFilteredWorkerTable = SqlWorkerTable;
            if (SqlFilteredWorkerAdapter == null)
                SqlFilteredWorkerAdapter = SqlWorkerAdapter;
        }

        private static void RetrieveDepartures()
        {
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `departure` ORDER BY `departure_time_departed` DESC LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlDepartureAdapter = new MySqlDataAdapter(command);
            SqlDepartureTable = new DataTable();
            SqlDepartureAdapter.Fill(SqlDepartureTable);

            SqlDepartureTable.PrimaryKey = new DataColumn[] { SqlDepartureTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlDepartureAdapter);

            if (SqlFilteredDepartureTable == null)
                SqlFilteredDepartureTable = SqlDepartureTable;
            if (SqlFilteredDepartureAdapter == null)
                SqlFilteredDepartureAdapter = SqlDepartureAdapter;
        }

        private static void RetrievePatients()
        {
            MySqlCommand command = new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname FROM `patient` LIMIT {SQL_MAX_ROWS}", SqlConnection);
            SqlPatientAdapter = new MySqlDataAdapter(command);
            SqlPatientTable = new DataTable();
            SqlPatientAdapter.Fill(SqlPatientTable);

            SqlPatientTable.PrimaryKey = new DataColumn[] { SqlPatientTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlPatientAdapter);

            if (SqlFilteredPatientTable == null)
                SqlFilteredPatientTable = SqlPatientTable;
            if (SqlFilteredPatientAdapter == null)
                SqlFilteredPatientAdapter = SqlPatientAdapter;
        }

        private static void RetrieveUsers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` LIMIT 200", SqlConnection);
            SqlUsersAdapter = new MySqlDataAdapter(command);
            SqlUsersTable = new DataTable();
            SqlUsersAdapter.Fill(SqlUsersTable);

            SqlUsersTable.PrimaryKey = new DataColumn[] { SqlUsersTable.Columns[0] };

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlUsersAdapter);

            if (SqlFilteredUsersTable == null)
                SqlFilteredUsersTable = SqlUsersTable;
            if (SqlFilteredUsersAdapter == null)
                SqlFilteredUsersAdapter = SqlUsersAdapter;
        }

        sealed class StructuralComparer : IEqualityComparer<int[]>
        {
            public bool Equals(int[]? a, int[]? b) =>
                a!.SequenceEqual(b!);

            public int GetHashCode(int[] a) =>
                a.Aggregate(17, (h, v) => h * 31 + v.GetHashCode());
        }

        public static void SyncTable(MySqlDataAdapter adapter, DataTable table)
        {
            if (adapter == null || table == null)
                return;

            var incoming = table.Clone();
            adapter.Fill(incoming);

            table.BeginLoadData();

            if (table.PrimaryKey.Length == 0)
                throw new InvalidOperationException("PrimaryKey required");

            else if (table.PrimaryKey.Length == 1)
            {
                var pkCol = table.PrimaryKey[0];

                foreach (DataRow row in table.Rows.Cast<DataRow>().ToList())
                {
                    var key = row[pkCol, DataRowVersion.Original];

                    if (incoming.Rows.Find(key) == null)
                        row.Delete();
                }

                foreach (DataRow src in incoming.Rows)
                {
                    var dst = table.Rows.Find(src[src.Table.PrimaryKey[0]]);
                    if (dst == null)
                        table.ImportRow(src);
                    else
                        dst.ItemArray = src.ItemArray;
                }
            }
            else if (table.PrimaryKey.Length == 2)
            {
                var pkCol1 = table.PrimaryKey[0];
                var pkCol2 = table.PrimaryKey[1];

                foreach (DataRow row in table.Rows.Cast<DataRow>().ToList())
                {
                    var key1 = row[pkCol1, DataRowVersion.Original];
                    var key2 = row[pkCol2, DataRowVersion.Original];

                    if (incoming.Rows.Find(new object[] { key1, key2 }) == null)
                        row.Delete();
                }

                foreach (DataRow src in incoming.Rows)
                {
                    var key1 = src[pkCol1, DataRowVersion.Original];
                    var key2 = src[pkCol2, DataRowVersion.Original];

                    var dst = table.Rows.Find(new object[] { key1, key2 });
                    if (dst == null)
                        table.ImportRow(src);
                    else
                        dst.ItemArray = src.ItemArray;
                }
            }

            table.EndLoadData();
        }

        public static void SyncTableCall()
        {
            SyncTable(Program.SqlCallAdapter, Program.SqlCallTable);
            if (SqlFilteredCallAdapter != SqlCallAdapter)
                SyncTable(Program.SqlFilteredCallAdapter, Program.SqlFilteredCallTable);
        }

        public static void SyncTableCallout()
        {
            SyncTable(Program.SqlCalloutAdapter, Program.SqlCalloutTable);
            if (SqlFilteredCalloutAdapter != SqlCalloutAdapter)
                SyncTable(Program.SqlFilteredCalloutAdapter, Program.SqlFilteredCalloutTable);
        }

        public static void SyncTableDispatcher()
        {
            SyncTable(Program.SqlDispatcherAdapter, Program.SqlDispatcherTable);
            if (SqlFilteredDispatcherAdapter != SqlDispatcherAdapter)
                SyncTable(Program.SqlFilteredDispatcherAdapter, Program.SqlFilteredDispatcherTable);
        }

        public static void SyncTableSubstation()
        {
            SyncTable(Program.SqlSubstationAdapter, Program.SqlSubstationTable);
            if (SqlFilteredSubstationAdapter != SqlSubstationAdapter)
                SyncTable(Program.SqlFilteredSubstationAdapter, Program.SqlFilteredSubstationTable);
        }

        public static void SyncTableHospital()
        {
            SyncTable(Program.SqlHospitalAdapter, Program.SqlHospitalTable);
            if (SqlFilteredHospitalAdapter != SqlHospitalAdapter)
                SyncTable(Program.SqlFilteredHospitalAdapter, Program.SqlFilteredHospitalTable);
        }

        public static void SyncTableBrigade()
        {
            SyncTable(Program.SqlBrigadeAdapter, Program.SqlBrigadeTable);
            if (SqlFilteredBrigadeAdapter != SqlBrigadeAdapter)
                SyncTable(Program.SqlFilteredBrigadeAdapter, Program.SqlFilteredBrigadeTable);
        }

        public static void SyncTableWorker()
        {
            SyncTable(Program.SqlWorkerAdapter, Program.SqlWorkerTable);
            if (SqlFilteredWorkerAdapter != SqlWorkerAdapter)
                SyncTable(Program.SqlFilteredWorkerAdapter, Program.SqlFilteredWorkerTable);
        }

        public static void SyncTableDeparture()
        {
            SyncTable(Program.SqlDepartureAdapter, Program.SqlDepartureTable);
            if (SqlFilteredDepartureAdapter != SqlDepartureAdapter)
                SyncTable(Program.SqlFilteredDepartureAdapter, Program.SqlFilteredDepartureTable);
        }

        public static void SyncTablePatient()
        {
            SyncTable(Program.SqlPatientAdapter, Program.SqlPatientTable);
            if (SqlFilteredPatientAdapter != SqlPatientAdapter)
                SyncTable(Program.SqlFilteredPatientAdapter, Program.SqlFilteredPatientTable);
        }

        public static void SyncTableUsers()
        {
            SyncTable(Program.SqlUsersAdapter, Program.SqlUsersTable);
            if (SqlFilteredUsersAdapter != SqlUsersAdapter)
                SyncTable(Program.SqlFilteredUsersAdapter, Program.SqlFilteredUsersTable);
        }

        public static void SyncWithRemote()
        {
            SyncTableCall();
            SyncTableCallout();
            SyncTableDispatcher();
            SyncTableSubstation();
            SyncTableBrigade();
            SyncTableHospital();
            SyncTableDeparture();
            SyncTablePatient();
            SyncTableUsers();
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AskLogin();
        }
    }
}