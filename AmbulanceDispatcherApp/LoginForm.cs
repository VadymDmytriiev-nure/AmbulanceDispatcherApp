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
                Server = "localhost",
                Port = 3306,
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
