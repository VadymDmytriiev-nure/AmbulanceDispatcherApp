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

namespace AmbulanceDispatcherApp.Forms.Departures
{
    public partial class DepartureFiltersForm : Form
    {
        public (int? Min, int? Max) CalloutID;
        public string? DepartureFromAddress;
        public string? DepartureToAddress;
        public (DateTime? Min, DateTime? Max) DepartureTimeDeparted;
        public (DateTime? Min, DateTime? Max) DepartureTimeArrived;
        public (float? Min, float? Max) DepartureMileageKM;

        public DepartureFilters Filters
        {
            get
            {
                return new DepartureFilters()
                {
                    CalloutID = this.CalloutID,
                    DepartureFromAddress = this.DepartureFromAddress,
                    DepartureToAddress = this.DepartureToAddress,
                    DepartureTimeDeparted = this.DepartureTimeDeparted,
                    DepartureTimeArrived = this.DepartureTimeArrived,
                    DepartureMileageKM = this.DepartureMileageKM
                };
            }
        }

        public DepartureFiltersForm(DepartureFilters? existingFilters = null)
        {
            InitializeComponent();

            spin_callout_min.Text = "";
            spin_callout_max.Text = "";
            spin_mileage_min.Text = "";
            spin_mileage_max.Text = "";

            if (existingFilters != null)
            {
                if(existingFilters.CalloutID.Min.HasValue)
                    spin_callout_min.Value = existingFilters.CalloutID.Min.Value;

                if (existingFilters.CalloutID.Max.HasValue)
                    spin_callout_max.Value = existingFilters.CalloutID.Max.Value;

                textbox_from_address.Text = existingFilters.DepartureFromAddress ?? "";
                textbox_to_address.Text = existingFilters.DepartureToAddress ?? "";

                if (existingFilters.DepartureMileageKM.Min.HasValue)
                    spin_mileage_min.Value = (decimal)existingFilters.DepartureMileageKM.Min.Value;

                if (existingFilters.DepartureMileageKM.Max.HasValue)
                    spin_mileage_max.Value = (decimal)existingFilters.DepartureMileageKM.Max.Value;

                if (existingFilters.DepartureTimeDeparted.Min.HasValue)
                    datetime_departed_min.Value = existingFilters.DepartureTimeDeparted.Min.Value;
                if (existingFilters.DepartureTimeDeparted.Max.HasValue)
                    datetime_departed_max.Value = existingFilters.DepartureTimeDeparted.Max.Value;
                if (existingFilters.DepartureTimeArrived.Min.HasValue)
                    datetime_arrived_min.Value = existingFilters.DepartureTimeArrived.Min.Value;
                if (existingFilters.DepartureTimeArrived.Max.HasValue)
                    datetime_arrived_max.Value = existingFilters.DepartureTimeArrived.Max.Value;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (spin_callout_min.Value > spin_callout_max.Value)
            {
                MessageBox.Show(
                    "Номер виклику \"від\" не може перевищувати \"до\"",
                    "Помилка форматування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (datetime_departed_min.Value > datetime_departed_max.Value)
            {
                MessageBox.Show(
                    "Дата відбуття \"від\" не може перевищувати \"до\"",
                    "Помилка форматування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (datetime_departed_min.Value > datetime_departed_max.Value)
            {
                MessageBox.Show(
                    "Дата прибуття \"від\" не може перевищувати \"до\"",
                    "Помилка форматування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (spin_callout_min.Text != "")
                CalloutID.Min = (int)spin_callout_min.Value;

            if (spin_callout_max.Text != "")
                CalloutID.Max = (int)spin_callout_max.Value;

            DepartureTimeDeparted.Min = datetime_departed_min.Value;
            DepartureTimeDeparted.Max = datetime_departed_max.Value;
            DepartureTimeArrived.Min = datetime_arrived_min.Value;
            DepartureTimeArrived.Max = datetime_arrived_max.Value;

            if (textbox_from_address.Text.Trim() != "")
                DepartureFromAddress = textbox_from_address.Text;

            if (textbox_to_address.Text.Trim() != "")
                DepartureFromAddress = textbox_to_address.Text;

            if (spin_mileage_min.Text != "")
                DepartureMileageKM.Min = (float)spin_mileage_min.Value;

            if (spin_mileage_max.Text != "")
                DepartureMileageKM.Max = (float)spin_mileage_max.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
