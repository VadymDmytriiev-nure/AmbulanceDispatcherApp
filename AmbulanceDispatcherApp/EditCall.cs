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
    public partial class EditCall : Form
    {
        MySqlConnection conn;
        DataRowView call;
        DataTable dispatchers;
        DataTable callouts;

        public EditCall(MySqlConnection conn, DataRowView call, DataTable dispatchers, DataTable callouts)
        {
            InitializeComponent();

            button_cancel.CausesValidation = false;

            this.conn = conn;
            this.call = call;
            this.dispatchers = dispatchers;
            this.callouts = callouts;

            textbox_address.Text = call["call_address"] as string;
            textbox_reason.Text = call["call_reason"] as string;
            textbox_name.Text = call["call_caller_name"] as string;
            textbox_surname.Text = call["call_caller_surname"] as string;
            textbox_patriarchic.Text = call["call_caller_patriarchic"] as string;
            textbox_tel.Text = call["call_caller_tel"] as string;
            textbox_channel.Text = call["call_channel"] as string;
            spin_callout.Value = Convert.ToDecimal(call["callout_id"]);
            datetime_time_created.Value = Convert.ToDateTime(call["call_time_created"]);

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

            if (!Regex.IsMatch(textbox_tel.Text, @"^\\+380\\d{9}$\r\n"))
            {
                MessageBox.Show("Ви неправильно ввели номер телефону. Правильний формат: +380XXXXXXXX", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_channel.Text.Trim() == "")
            {
                MessageBox.Show("Канал зв'язку не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            call.BeginEdit();
            call["call_address"] = textbox_address.Text.Trim() == "" ? null : textbox_address.Text.Trim();
            call["call_channel"] = textbox_channel.Text;
            call["call_reason"] = textbox_reason.Text.Trim() == "" ? null : textbox_reason.Text.Trim();
            call["call_time_created"] = datetime_time_created.Text;
            call["call_caller_name"] = textbox_name.Text.Trim() == "" ? null : textbox_name.Text.Trim();
            call["call_caller_surname"] = textbox_surname.Text.Trim() == "" ? null : textbox_surname.Text.Trim();
            call["call_caller_patriarchic"] = textbox_patriarchic.Text.Trim() == "" ? null : textbox_patriarchic.Text.Trim();
            call["call_caller_tel"] = textbox_tel.Text;
            call["dispatcher_id"] = combo_dispatcher.SelectedValue;
            call["callout_id"] = spin_callout.Text == "" ? null : spin_callout.Value;
            call.EndEdit();
            this.Close();
        }
    }
}
