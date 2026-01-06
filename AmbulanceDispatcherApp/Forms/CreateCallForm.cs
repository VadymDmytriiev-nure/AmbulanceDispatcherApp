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
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp
{
    public partial class CreateCallForm : Form
    {
        MySqlConnection conn;
        DataTable calls;
        DataTable dispatchers;
        DataTable callouts;

        public bool IsClosed = false;

        public CreateCallForm()
        {
            InitializeComponent();

            datetime_time_created.Value = DateTime.Now;
            spin_callout.Text = "";

            this.conn = Program.SqlConnection;
            this.calls = Program.SqlCallTable;
            this.dispatchers = Program.SqlDispatcherTable;
            this.callouts = Program.SqlCalloutTable;

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";
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

            var command = new MySqlCommand("INSERT INTO `call` (" +
                                                                "`call_address`," +
                                                                "`call_time_created`," +
                                                                "`call_reason`," +
                                                                "`call_channel`," +
                                                                "`call_caller_name`," +
                                                                "`call_caller_surname`," +
                                                                "`call_caller_patriarchic`," +
                                                                "`call_caller_tel`," +
                                                                "`callout_id`," +
                                                                "`dispatcher_id`)" +
                                                                "VALUES (" +
                                                                       "@call_address, " +
                                                                       "@call_time_created, " +
                                                                       "@call_reason, " +
                                                                       "@call_channel, " +
                                                                       "@call_caller_name, " +
                                                                       "@call_caller_surname, " +
                                                                       "@call_caller_patriarchic, " +
                                                                       "@call_caller_tel, " +
                                                                       "@callout_id, " +
                                                                       "@dispatcher_id" +
                                                                       ")"
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

            command.ExecuteNonQuery();
            Program.SyncTableCall();
            this.Close();
        }

        private void CreateCallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }
    }
}
