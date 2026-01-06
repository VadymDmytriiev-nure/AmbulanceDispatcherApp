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
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms.Dispatcher
{
    public partial class CreateEditDispatcherForm : Form
    {
        FormMode mode;
        DataRowView? dispatcher;

        public CreateEditDispatcherForm(FormMode mode = FormMode.Create, DataRowView? dispatcher = null)
        {
            InitializeComponent();

            this.mode = mode;

            if (mode == FormMode.Edit && dispatcher != null)
            {
                this.dispatcher = dispatcher;
                Text = "Редагування диспетчера";

                textbox_name.Text = dispatcher["dispatcher_name"] as string;
                textbox_surname.Text = dispatcher["dispatcher_surname"] as string;
                textbox_patriarchic.Text = dispatcher["dispatcher_patriarchic"] as string;
                textbox_tel.Text = dispatcher["dispatcher_tel"] as string;
            }
            else
            {
                Text = "Створення диспетчера";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_name.Text.Trim() == "")
            {
                MessageBox.Show("Ім`я не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_surname.Text.Trim() == "")
            {
                MessageBox.Show("Прізвище не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_tel.Text.Trim() == "")
            {
                MessageBox.Show("Номер телефону не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show("Неправильний формат телефону", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mode == FormMode.Edit)
            {
                var command = new MySqlCommand(
                    "UPDATE `dispatcher` SET " +
                    "`dispatcher_name` = @name, " +
                    "`dispatcher_surname` = @surname, " +
                    "`dispatcher_patriarchic` = @patriarchic, " +
                    "`dispatcher_tel` = @tel " +
                    "WHERE `dispatcher_id` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@surname", textbox_surname.Text.Trim());
                command.Parameters.AddWithValue("@patriarchic", textbox_patriarchic.Text.Trim() == "" ? DBNull.Value : textbox_patriarchic.Text.Trim());
                command.Parameters.AddWithValue("@tel", textbox_tel.Text.Trim());
                command.Parameters.AddWithValue("@id", dispatcher!["dispatcher_id"]);

                command.ExecuteNonQuery();
            }
            else if (mode == FormMode.Create)
            {
                var command = new MySqlCommand(
                    "INSERT INTO `dispatcher` " +
                    "(`dispatcher_name`,`dispatcher_surname`,`dispatcher_patriarchic`,`dispatcher_tel`) " +
                    "VALUES (@name,@surname,@patriarchic,@tel)",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@surname", textbox_surname.Text.Trim());
                command.Parameters.AddWithValue("@patriarchic", textbox_patriarchic.Text.Trim() == "" ? DBNull.Value : textbox_patriarchic.Text.Trim());
                command.Parameters.AddWithValue("@tel", textbox_tel.Text.Trim());

                command.ExecuteNonQuery();
            }

            Program.SyncTableDispatcher();
            Close();
        }
    }
}
