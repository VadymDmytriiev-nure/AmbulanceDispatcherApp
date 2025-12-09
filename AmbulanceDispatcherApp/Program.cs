using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp
{
    internal static class Program
    {
        [AllowNull]
        public static MySqlConnection SqlConnection;
        [AllowNull]
        public static string SqlLogin;
        [AllowNull]
        public static string SqlRole;
        public static int SqlWorkerId = -1;
        public static int SqlDispatcherId = -1;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoginForm loginForm = new LoginForm();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand command = new MySqlCommand("SELECT `user_role`, `worker_id`, `dispatcher_id` FROM `emergencyhealthcare`.`Users` WHERE `user_login` = @userlogin;", SqlConnection);
                command.Parameters.AddWithValue("@userlogin", SqlLogin);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable roleDataTable = new DataTable();
                adapter.Fill(roleDataTable);

                if(roleDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Не вдалося отримати права користувача. Якщо ця помилка повторюється, зверніться до системного адміністратора.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                Program.SqlRole = (roleDataTable.Rows[0]["user_role"] as string)!;
                Program.SqlWorkerId = (roleDataTable.Rows[0]["worker_id"] as int?) == null ? -1 : (int)(roleDataTable.Rows[0]["worker_id"] as int?)!;
                Program.SqlDispatcherId = (roleDataTable.Rows[0]["dispatcher_id"] as int?) == null ? -1 : (int)(roleDataTable.Rows[0]["dispatcher_id"] as int?)!;

                if(Program.SqlRole == "Адміністратор")
                {
                    new MySqlCommand("SET ROLE role_admin", SqlConnection).ExecuteScalar();
                    Application.Run(new LegacyMainForm());
                }
                if(Program.SqlRole == "Диспетчер")
                {
                    new MySqlCommand("SET ROLE role_dispatcher", SqlConnection).ExecuteScalar();
                    Application.Run(new LegacyMainForm());
                }
                if (Program.SqlRole == "Лікар")
                {
                    new MySqlCommand("SET ROLE role_doctor", SqlConnection).ExecuteScalar();
                    Application.Run(new LegacyMainForm());
                }
                else
                {
                    MessageBox.Show("Не вдалося отримати права користувача. Якщо ця помилка повторюється, зверніться до системного адміністратора.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }                
            }
        }
    }
}