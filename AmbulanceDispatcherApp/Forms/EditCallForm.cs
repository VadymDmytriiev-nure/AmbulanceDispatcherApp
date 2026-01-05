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
    public partial class EditCallForm : Form
    {
        MySqlConnection conn;
        DataRowView call;
        DataTable dispatchers;
        DataTable callouts;

        public bool IsClosed;

        public EditCallForm(DataRowView call)
        {
            InitializeComponent();

            this.conn = Program.SqlConnection;
            this.call = call;
            this.dispatchers = Program.SqlDispatcherTable;
            this.callouts = Program.SqlCalloutTable;

            textbox_address.Text = call["call_address"] as string;
            textbox_reason.Text = call["call_reason"] as string;
            textbox_name.Text = call["call_caller_name"] as string;
            textbox_surname.Text = call["call_caller_surname"] as string;
            textbox_patriarchic.Text = call["call_caller_patriarchic"] as string;
            textbox_tel.Text = call["call_caller_tel"] as string;
            textbox_channel.Text = call["call_channel"] as string;
            object callout_id = call["callout_id"];
            if (callout_id != DBNull.Value)
                spin_callout.Value = (decimal)(callout_id as int?)!;
            else
                spin_callout.Text = "";

            datetime_time_created.Value = Convert.ToDateTime(call["call_time_created"]);

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";
            combo_dispatcher.SelectedValue = (call["dispatcher_id"] as int?)!;
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

            var command = new MySqlCommand("UPDATE `Call` SET " +
                                           "`call_address` = @call_address, " +
                                           "`call_reason` = @call_reason, " +
                                           "`call_channel` = @call_channel, " +
                                           "`call_time_created` = @call_time_created, " +
                                           "`call_caller_name` = @call_caller_name, " +
                                           "`call_caller_surname` = @call_caller_surname, " +
                                           "`call_caller_patriarchic` = @call_caller_patriarchic, " +
                                           "`call_caller_tel` = @call_caller_tel, " +
                                           "`dispatcher_id` = @dispatcher_id, " +
                                           "`callout_id` = @callout_id " +
                                           "WHERE `call_id` = @call_id"
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
            command.Parameters.AddWithValue("@call_id", (call["call_id"] as int?)!);

            command.ExecuteNonQuery();
            Program.SyncTableCall();
            this.Close();
        }

        private void EditCallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }
    }
}
