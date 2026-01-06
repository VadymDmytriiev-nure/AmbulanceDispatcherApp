using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms
{
    public partial class CalloutFiltersForm : Form
    {
        public (DateTime? Min, DateTime? Max) CalloutTimeCreated;
        public (int? Min, int? Max) CalloutIDRange;
        public string? CalloutAddress;
        public string? CalloutReason;
        public string? CalloutComment;
        public bool? CalloutCanceled;

        public CalloutFilters Filters
        {
            get
            {
                return new CalloutFilters()
                {
                    CalloutTimeCreated = this.CalloutTimeCreated,
                    CalloutIDRange = this.CalloutIDRange,
                    CalloutAddress = this.CalloutAddress,
                    CalloutReason = this.CalloutReason,
                    CalloutComment = this.CalloutComment,
                    CalloutCanceled = this.CalloutCanceled
                };
            }
        }

        public CalloutFiltersForm(CalloutFilters? existingFilters = null)
        {
            InitializeComponent();

            spin_callout_from.Text = "";
            spin_callout_to.Text = "";

            if (existingFilters == null)
                return;

            spin_callout_from.Text = existingFilters.CalloutIDRange.Min?.ToString() ?? "";
            spin_callout_to.Text = existingFilters.CalloutIDRange.Max?.ToString() ?? "";

            if (existingFilters.CalloutTimeCreated.Min.HasValue)
                datetime_time_created_from.Value = existingFilters.CalloutTimeCreated.Min.Value;

            if (existingFilters.CalloutTimeCreated.Max.HasValue)
                datetime_time_created_to.Value = existingFilters.CalloutTimeCreated.Max.Value;

            textbox_address.Text = existingFilters.CalloutAddress ?? "";
            textbox_reason.Text = existingFilters.CalloutReason ?? "";
            textbox_comment.Text = existingFilters.CalloutComment ?? "";

            radio_canceled_unknown.Checked = true;
            if (existingFilters.CalloutCanceled.HasValue)
                (existingFilters.CalloutCanceled.Value ? radio_canceled_true : radio_canceled_false).Checked = true;

            foreach (var dt in Controls.OfType<DateTimePicker>())
                dt.MaxDate = DateTime.Now;

            datetime_time_created_to.Value = datetime_time_created_to.MaxDate;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (datetime_time_created_from.Value > datetime_time_created_to.Value)
            {
                MessageBox.Show("Час \"від\" не може перевищувати час \"до\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((spin_callout_from.Text.Trim() != "" && spin_callout_to.Text.Trim() != "") && spin_callout_from.Value > spin_callout_to.Value)
            {
                MessageBox.Show("Номер виклику \"від\" не може перевищувати номер \"до\"", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CalloutTimeCreated.Min = datetime_time_created_from.Value;
            CalloutTimeCreated.Max = datetime_time_created_to.Value;

            if (spin_callout_from.Text.Trim() != "")
                CalloutIDRange.Min = (int)spin_callout_from.Value;

            if (spin_callout_to.Text.Trim() != "")
                CalloutIDRange.Max = (int)spin_callout_to.Value;

            if (textbox_address.Text.Trim() != "")
                CalloutAddress = textbox_address.Text;

            if (textbox_reason.Text.Trim() != "")
                CalloutReason = textbox_reason.Text;

            if (textbox_comment.Text.Trim() != "")
                CalloutComment = textbox_comment.Text;

            CalloutCanceled = radio_canceled_unknown.Checked ? null : (radio_canceled_true.Checked ? true : false);

            DialogResult = DialogResult.OK;
        }
    }
}
