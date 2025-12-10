using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Media;
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

        public static DataTable SqlCallTable = new DataTable();
        public static DataTable SqlCalloutTable = new DataTable();
        public static DataTable SqlDispatcherTable = new DataTable();
        public static DataTable SqlDepartureTable = new DataTable();
        public static DataTable SqlHospitalTable = new DataTable();
        public static DataTable SqlPatientTable = new DataTable();
        public static DataTable SqlWorkerTable = new DataTable();
        public static DataTable SqlSubstationTable = new DataTable();
        public static DataTable SqlBrigadeTable = new DataTable();
        public static DataTable SqlUsersTable = new DataTable();

        public static MySqlDataAdapter SqlCallAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlCalloutAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlDispatcherlAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlDepartureAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlHospitalAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlPatientAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlWorkerAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlSubstationAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlBrigadeAdapter = new MySqlDataAdapter();
        public static MySqlDataAdapter SqlUsersAdapter = new MySqlDataAdapter();

        public static void Logout()
        {
            SqlConnection.Close();
            SqlRole = "";
            SqlWorkerId = -1;
            SqlDispatcherId = -1;

            SqlCallTable = new DataTable();
            SqlCalloutTable = new DataTable();
            SqlDispatcherTable = new DataTable();
            SqlDepartureTable = new DataTable();
            SqlHospitalTable = new DataTable();
            SqlPatientTable = new DataTable();
            SqlWorkerTable = new DataTable();
            SqlSubstationTable = new DataTable();
            SqlBrigadeTable = new DataTable();
            SqlUsersTable = new DataTable();

            SqlCallAdapter = new MySqlDataAdapter();
            SqlCalloutAdapter = new MySqlDataAdapter();
            SqlDispatcherlAdapter = new MySqlDataAdapter();
            SqlDepartureAdapter = new MySqlDataAdapter();
            SqlHospitalAdapter = new MySqlDataAdapter();
            SqlPatientAdapter = new MySqlDataAdapter();
            SqlWorkerAdapter = new MySqlDataAdapter();
            SqlSubstationAdapter = new MySqlDataAdapter();
            SqlBrigadeAdapter = new MySqlDataAdapter();
            SqlUsersAdapter = new MySqlDataAdapter();

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
            SqlCallAdapter.Fill(SqlCallTable);
        }

        private static void RetrieveCallouts()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `callout`", SqlConnection);
            SqlCalloutAdapter = new MySqlDataAdapter(command);
            SqlCalloutAdapter.Fill(SqlCalloutTable);
        }

        private static void RetrieveDispatchers()
        {
            MySqlCommand command = new MySqlCommand("SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher`", SqlConnection);
            SqlDispatcherlAdapter = new MySqlDataAdapter(command);
            SqlDispatcherlAdapter.Fill(SqlDispatcherTable);
        }

        private static void RetrieveSubstations()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `substation`", SqlConnection);
            SqlSubstationAdapter = new MySqlDataAdapter(command);
            SqlSubstationAdapter.Fill(SqlSubstationTable);
        }

        private static void RetrieveBrigades()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `brigade`", SqlConnection);
            SqlBrigadeAdapter = new MySqlDataAdapter(command);
            SqlBrigadeAdapter.Fill(SqlBrigadeTable);
        }

        private static void RetrieveHospitals()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `hospital`", SqlConnection);
            SqlHospitalAdapter = new MySqlDataAdapter(command);
            SqlHospitalAdapter.Fill(SqlHospitalTable);
        }

        private static void RetrieveWorkers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `worker`", SqlConnection);
            SqlWorkerAdapter = new MySqlDataAdapter(command);
            SqlWorkerAdapter.Fill(SqlWorkerTable);
        }

        private static void RetrieveDepartures()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `departure`", SqlConnection);
            SqlDepartureAdapter = new MySqlDataAdapter(command);
            SqlDepartureAdapter.Fill(SqlDepartureTable);
        }

        private static void RetrieveUsers()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", SqlConnection);
            SqlUsersAdapter = new MySqlDataAdapter(command);
            SqlUsersAdapter.Fill(SqlUsersTable);
        }

        private static void RetrievePatients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `patient`", SqlConnection);
            SqlPatientAdapter = new MySqlDataAdapter(command);
            SqlPatientAdapter.Fill(SqlPatientTable);
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AskLogin();
        }
    }
}