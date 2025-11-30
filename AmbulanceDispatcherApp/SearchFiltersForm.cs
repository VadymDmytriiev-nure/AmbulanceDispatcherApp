using System;
using System.Collections;
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

namespace AmbulanceDispatcherApp
{
    public partial class SearchFiltersForm : Form
    {
        DataTable dispatchers;

        public (DateTime? Min, DateTime? Max) TimeRange;
        public (int? Min, int? Max) CalloutIDRange;
        public int? DispatcherID;
        public string? CallerSurname;
        public string? CallerName;
        public string? CallerPatriarchic;
        public string? CallerTel;
        public string? Address;
        public string? Reason;
        public string? Channel;

        public SearchFiltersForm(DataTable dispatchers)
        {
            InitializeComponent();

            this.dispatchers = dispatchers;

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";

            spin_callout_from.Text = "";
            spin_callout_to.Text = "";
            combo_dispatcher.Text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(datetime_time_created_to.Value < datetime_time_created_from.Value)
            {
                MessageBox.Show("Час \"до\" не може перевищувати час \"від\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combo_dispatcher.SelectedValue == null)
            {
                MessageBox.Show("Обраного диспетчеру не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_tel.Text.Trim() != "" && !Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show("Ви неправильно ввели номер телефону. Правильний формат: +XXXXXXXXXXX", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeRange.Min = datetime_time_created_from.Value;
            TimeRange.Max = datetime_time_created_to.Value;
            if(spin_callout_from.Text.Trim() != "")
                CalloutIDRange.Min = (int)spin_callout_from.Value;
            if (spin_callout_to.Text.Trim() != "")
                CalloutIDRange.Max = (int)spin_callout_to.Value;

            if (combo_dispatcher.SelectedValue != null)
                DispatcherID = (int)combo_dispatcher.SelectedValue;

            if (textbox_surname.Text.Trim() != "")
                CallerSurname = textbox_surname.Text;

            if (textbox_name.Text.Trim() != "")
                CallerName = textbox_name.Text;

            if (textbox_patriarchic.Text.Trim() != "")
                CallerPatriarchic = textbox_patriarchic.Text;

            if (textbox_tel.Text.Trim() != "")
                CallerTel = textbox_tel.Text;

            if (textbox_channel.Text.Trim() != "")
                Channel = textbox_channel.Text;

            if (textbox_reason.Text.Trim() != "")
                Reason = textbox_reason.Text;

            if (textbox_address.Text.Trim() != "")
                Address = textbox_address.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
