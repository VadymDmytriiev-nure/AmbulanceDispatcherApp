using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp
{
    public partial class LoginForm : Form
    {
        [AllowNull]
        MySqlConnection sqlConnection;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (Program.DEBUG_MODE == true)
            {
                sqlConnection = new MySqlConnection();
                MySqlConnectionStringBuilder connStringBuilderDbg = new MySqlConnectionStringBuilder()
                {
                    Server = Program.SQL_HOST,
                    Port = Program.SQL_PORT,
                    UserID = Program.DEBUG_USER,
                    Password = Program.DEBUG_PASSWORD,
                    DefaultAuthenticationPlugin = "mysql_native_password"
                };
                sqlConnection.ConnectionString = connStringBuilderDbg.ConnectionString;
                sqlConnection.Open();

                Program.SqlLogin = Program.DEBUG_USER;
                Program.SqlConnection = sqlConnection;
                DialogResult = DialogResult.OK;
                return;
            }

            if (textbox_login.Text.Trim().Length == 0)
            {
                MessageBox.Show("Логін не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textbox_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Пароль не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlConnection = new MySqlConnection();
            MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder()
            {
                Server = Program.SQL_HOST,
                Port = Program.SQL_PORT,
                UserID = textbox_login.Text,
                Password = textbox_password.Text,
                DefaultAuthenticationPlugin = "mysql_native_password"
            };
            sqlConnection.ConnectionString = connStringBuilder.ConnectionString;
            try
            {
                sqlConnection.Open();
            }
            catch
            {
                MessageBox.Show("Неправильний логін або пароль. Якщо ця помилка повторюється, зверніться до системного адміністратора.", "Помилка авторизації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.SqlLogin = textbox_login.Text;
            Program.SqlConnection = sqlConnection;
            DialogResult = DialogResult.OK;
        }
    }
}
