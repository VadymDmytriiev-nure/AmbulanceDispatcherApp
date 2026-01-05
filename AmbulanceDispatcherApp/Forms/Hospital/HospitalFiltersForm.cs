using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Hospital
{
    public partial class HospitalFiltersForm : Form
    {
        public string? HospitalName;
        public string? HospitalAddress;
        public string? HospitalSpecialization;

        public HospitalFilters Filters
        {
            get
            {
                return new HospitalFilters()
                {
                    HospitalName = this.HospitalName,
                    HospitalAddress = this.HospitalAddress,
                    HospitalSpecialization = this.HospitalSpecialization
                };
            }
        }

        public HospitalFiltersForm(HospitalFilters? existingFilters = null)
        {
            InitializeComponent();

            if (existingFilters != null)
            {
                textbox_address.Text = existingFilters.HospitalAddress;
                textbox_name.Text = existingFilters.HospitalName;
                textbox_specialization.Text = existingFilters.HospitalSpecialization;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_address.Text.Trim().Length > 0)
                HospitalAddress = textbox_address.Text;

            if (textbox_name.Text.Trim().Length > 0)
                HospitalName = textbox_name.Text;

            if (textbox_specialization.Text.Trim().Length > 0)
                HospitalSpecialization = textbox_specialization.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
