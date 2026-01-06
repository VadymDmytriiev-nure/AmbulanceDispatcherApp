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
    public partial class CallFiltersForm : Form
    {
        DataTable dispatchers = new DataTable();

        public (DateTime? Min, DateTime? Max) TimeRange;
        public (int? Min, int? Max) CallIDRange;
        public (int? Min, int? Max) CalloutIDRange;
        public int? DispatcherID;
        public string? CallerSurname;
        public string? CallerName;
        public string? CallerPatriarchic;
        public string? CallerTel;
        public string? Address;
        public string? Reason;
        public string? Channel;

        public CallFilters Filters {
            get {
                return new CallFilters()
                {
                    TimeRange = this.TimeRange,
                    CallIDRange = this.CallIDRange,
                    CalloutIDRange = this.CalloutIDRange,
                    DispatcherID = this.DispatcherID,
                    CallerSurname = this.CallerSurname,
                    CallerName = this.CallerName,
                    CallerPatriarchic = this.CallerPatriarchic,
                    CallerTel = this.CallerTel,
                    Channel = this.Channel,
                    Address = this.Address,
                    Reason = this.Reason
                };
            }
        }

        public CallFiltersForm()
        {
            InitializeComponent();

            var command = new MySqlCommand("SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher`", Program.SqlConnection);
            var adapter = new MySqlDataAdapter(command);
            adapter.Fill(dispatchers);

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";

            spin_call_min.Text = "";
            spin_call_max.Text = "";
            spin_callout_from.Text = "";
            spin_callout_to.Text = "";
            combo_dispatcher.Text = "";
            combo_dispatcher.SelectedValue = "-1";
        }

        public CallFiltersForm(CallFilters existingFilters)
        {
            InitializeComponent();

            var command = new MySqlCommand("SELECT *, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `dispatcher`", Program.SqlConnection);
            var adapter = new MySqlDataAdapter(command);
            adapter.Fill(dispatchers);

            combo_dispatcher.DataSource = dispatchers;
            combo_dispatcher.ValueMember = "dispatcher_id";
            combo_dispatcher.DisplayMember = "dispatcher_fullname";

            spin_call_min.Text = "";
            spin_call_max.Text = "";
            spin_callout_from.Text = "";
            spin_callout_to.Text = "";
            combo_dispatcher.Text = "";
            combo_dispatcher.SelectedValue = "-1";

            spin_call_min.Text = existingFilters.CallIDRange.Min?.ToString() ?? "";
            spin_call_max.Text = existingFilters.CallIDRange.Max?.ToString() ?? "";

            if (existingFilters.TimeRange.Min.HasValue)
                datetime_time_created_from.Value = existingFilters.TimeRange.Min.Value;

            if (existingFilters.TimeRange.Max.HasValue)
                datetime_time_created_to.Value = existingFilters.TimeRange.Max.Value;

            spin_callout_from.Text = existingFilters.CalloutIDRange.Min?.ToString() ?? "";
            spin_callout_to.Text = existingFilters.CalloutIDRange.Max?.ToString() ?? "";

            if (existingFilters.DispatcherID.HasValue)
                combo_dispatcher.SelectedValue = existingFilters.DispatcherID.Value;
            else
                combo_dispatcher.SelectedIndex = -1;

            textbox_surname.Text = existingFilters.CallerSurname ?? "";
            textbox_name.Text = existingFilters.CallerName ?? "";
            textbox_patriarchic.Text = existingFilters.CallerPatriarchic ?? "";
            textbox_tel.Text = existingFilters.CallerTel ?? "";

            textbox_channel.Text = existingFilters.Channel ?? "";
            textbox_reason.Text = existingFilters.Reason ?? "";
            textbox_address.Text = existingFilters.Address ?? "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(datetime_time_created_from.Value > datetime_time_created_to.Value)
            {
                MessageBox.Show("Час \"від\" не може перевищувати час \"до\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combo_dispatcher.Text.Trim() != "" && combo_dispatcher.SelectedValue == null)
            {
                MessageBox.Show("Обраного диспетчеру не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((spin_call_min.Text.Trim() != "" && spin_call_max.Text.Trim() != "") && spin_call_min.Value > spin_call_max.Value)
            {
                MessageBox.Show("Номер дзвінку \"від\" не може перевищувати номер \"до\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((spin_callout_from.Text.Trim() != "" && spin_callout_to.Text.Trim() != "") && spin_callout_from.Value > spin_callout_to.Value)
            {
                MessageBox.Show("Номер виклику \"від\" не може перевищувати номер \"до\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (spin_call_min.Text.Trim() != "")
                CallIDRange.Min = (int)spin_call_min.Value;
            if (spin_call_max.Text.Trim() != "")
                CallIDRange.Max = (int)spin_call_max.Value;

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
