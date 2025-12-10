using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp
{
    internal static class Program
    {
        public static bool DEBUG_MODE = true;
        public static string DEBUG_USER = "ivanenko";
        public static string DEBUG_PASSWORD = "ivanenko_password";
        public static string DEBUG_DATABASE = "emergencyhealthcare";

        public static string SQL_HOST = "localhost";
        public static string SQL_DATABASE = "emergencyhealthcare";
        public static ushort SQL_PORT = 3306;

        private static bool ApplicationAlreadyRunning = false;
        [AllowNull]
        public static MySqlConnection SqlConnection;
        [AllowNull]
        public static string SqlLogin;
        [AllowNull]
        public static string SqlRole;
        public static int SqlWorkerId = -1;
        public static int SqlDispatcherId = -1;

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
            MySqlCommand command = new MySqlCommand("SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id", SqlConnection);
            SqlCallAdapter = new MySqlDataAdapter(command);
            SqlCallTable = new DataTable();
            SqlCallAdapter.Fill(SqlCallTable);

            SqlCallTable.PrimaryKey = new DataColumn[]{ SqlCallTable.Columns[0] };
            SqlCallTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlCallAdapter);
        }

        private static void RetrieveCallouts()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `callout`", SqlConnection);
            SqlCalloutAdapter = new MySqlDataAdapter(command);
            SqlCalloutTable = new DataTable();
            SqlCalloutAdapter.Fill(SqlCalloutTable);

            SqlCalloutTable.PrimaryKey = new DataColumn[] { SqlCalloutTable.Columns[0] };
            SqlCalloutTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlCalloutAdapter);
        }

        private static void RetrieveDispatchers()
        {
            MySqlCommand command = new MySqlCommand("SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher`", SqlConnection);
            SqlDispatcherAdapter = new MySqlDataAdapter(command);
            SqlDispatcherTable = new DataTable();
            SqlDispatcherAdapter.Fill(SqlDispatcherTable);

            SqlDispatcherTable.PrimaryKey = new DataColumn[] { SqlDispatcherTable.Columns[0] };
            SqlDispatcherTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlDispatcherAdapter);
        }

        private static void RetrieveSubstations()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `substation`", SqlConnection);
            SqlSubstationAdapter = new MySqlDataAdapter(command);
            SqlSubstationTable = new DataTable();
            SqlSubstationAdapter.Fill(SqlSubstationTable);

            SqlSubstationTable.PrimaryKey = new DataColumn[] { SqlSubstationTable.Columns[0] };
            SqlSubstationTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlSubstationAdapter);
        }

        private static void RetrieveBrigades()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `brigade`", SqlConnection);
            SqlBrigadeAdapter = new MySqlDataAdapter(command);
            SqlBrigadeTable = new DataTable();
            SqlBrigadeAdapter.Fill(SqlBrigadeTable);

            SqlBrigadeTable.PrimaryKey = new DataColumn[] { SqlBrigadeTable.Columns[0] };
            SqlBrigadeTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlBrigadeAdapter);
        }

        private static void RetrieveHospitals()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `hospital`", SqlConnection);
            SqlHospitalAdapter = new MySqlDataAdapter(command);
            SqlHospitalTable = new DataTable();
            SqlHospitalAdapter.Fill(SqlHospitalTable);

            SqlHospitalTable.PrimaryKey = new DataColumn[] { SqlHospitalTable.Columns[0] };
            SqlHospitalTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlHospitalAdapter);
        }

        private static void RetrieveWorkers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker`", SqlConnection);
            SqlWorkerAdapter = new MySqlDataAdapter(command);
            SqlWorkerTable = new DataTable();
            SqlWorkerAdapter.Fill(SqlWorkerTable);

            SqlWorkerTable.PrimaryKey = new DataColumn[] { SqlWorkerTable.Columns[0] };
            SqlWorkerTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlWorkerAdapter);
        }

        private static void RetrieveDepartures()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `departure`", SqlConnection);
            SqlDepartureAdapter = new MySqlDataAdapter(command);
            SqlDepartureTable = new DataTable();
            SqlDepartureAdapter.Fill(SqlDepartureTable);

            SqlDepartureTable.PrimaryKey = new DataColumn[] { SqlDepartureTable.Columns[0] };
            SqlDepartureTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlDepartureAdapter);
        }

        private static void RetrievePatients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `patient`", SqlConnection);
            SqlPatientAdapter = new MySqlDataAdapter(command);
            SqlPatientTable = new DataTable();
            SqlPatientAdapter.Fill(SqlPatientTable);

            SqlPatientTable.PrimaryKey = new DataColumn[] { SqlPatientTable.Columns[0] };
            SqlPatientTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlPatientAdapter);
        }

        private static void RetrieveUsers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", SqlConnection);
            SqlUsersAdapter = new MySqlDataAdapter(command);
            SqlUsersTable = new DataTable();
            SqlUsersAdapter.Fill(SqlUsersTable);

            SqlUsersTable.PrimaryKey = new DataColumn[] { SqlUsersTable.Columns[0] };
            SqlUsersTable.PrimaryKey[0].AllowDBNull = true;

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(SqlUsersAdapter);
        }

        sealed class StructuralComparer : IEqualityComparer<int[]>
        {
            public bool Equals(int[]? a, int[]? b) =>
                a!.SequenceEqual(b!);

            public int GetHashCode(int[] a) =>
                a.Aggregate(17, (h, v) => h * 31 + v.GetHashCode());
        }


        private static void SyncTable(MySqlDataAdapter adapter, DataTable table)
        {
            if (adapter == null || table == null)
                return;

            adapter.Fill(table);

            var newData = new DataTable();
            adapter.Fill(newData);

            // вся ця ***** для видалення рядків, які були видалені на віддаленій БД, але не на локальній машині
            if (table.PrimaryKey.Length == 1)
            {
                HashSet<int?> existing;
                HashSet<int?> returned;
                existing = table.AsEnumerable().Select(r => r.Field<int?>(table.PrimaryKey[0].ColumnName)).ToHashSet();
                returned = newData.AsEnumerable().Select(r => r.Field<int?>(table.PrimaryKey[0].ColumnName)).ToHashSet();

                foreach (var id in existing.Where(id => !returned.Contains(id)))
                {
                    var row = table.Rows.Find(id);
                    if(row != null)
                        table.Rows.Remove(row!);
                }
                    
            }
            else if (table.PrimaryKey.Length == 2)
            {
                int[] pk(DataRow row) => table.PrimaryKey.Select(k => k.ColumnName).Select(k => row.Field<int>(k)).ToArray();
                var existing = table.AsEnumerable().Select(pk).ToHashSet(new StructuralComparer());
                var returned = newData.AsEnumerable().Select(pk).ToHashSet(new StructuralComparer());

                foreach (var id in existing.Where(id => !returned.Contains(id)))
                {
                    var row = table.Rows.Find(id);
                    if (row != null)
                        table.Rows.Remove(row!);
                }
            }
        }

        public static void SyncWithRemote()
        {
            SyncTable(Program.SqlCallAdapter, Program.SqlCallTable);
            SyncTable(Program.SqlCalloutAdapter, Program.SqlCalloutTable);
            SyncTable(Program.SqlDispatcherAdapter, Program.SqlDispatcherTable);
            SyncTable(Program.SqlHospitalAdapter, Program.SqlHospitalTable);
            SyncTable(Program.SqlBrigadeAdapter, Program.SqlBrigadeTable);
            SyncTable(Program.SqlWorkerAdapter, Program.SqlWorkerTable);
            SyncTable(Program.SqlDepartureAdapter, Program.SqlDepartureTable);
            SyncTable(Program.SqlPatientAdapter, Program.SqlPatientTable);
            SyncTable(Program.SqlUsersAdapter, Program.SqlUsersTable);
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            AskLogin();
        }
    }
}