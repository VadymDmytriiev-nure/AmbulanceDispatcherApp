using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Substation
{
    public partial class SubstationFiltersForm : Form
    {
        public string? Address;
        public string? Code;

        public SubstationFilters Filters
        {
            get
            {
                return new SubstationFilters()
                {
                    SubstationAddress = this.Address,
                    SubstationCode = this.Code
                };
            }
        }

        public SubstationFiltersForm(SubstationFilters? existingFilters = null)
        {
            InitializeComponent();

            if (existingFilters != null)
            {
                textbox_address.Text = existingFilters.SubstationAddress;
                textbox_code.Text = existingFilters.SubstationCode;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_address.Text.Trim().Length > 0)
                Address = textbox_address.Text;

            if (textbox_code.Text.Trim().Length > 0)
                Code = textbox_code.Text;

            DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
