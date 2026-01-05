using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Brigade
{
    public partial class BrigadeFiltersForm : Form
    {
        public string? BrigadeType;
        public string? BrigadeCode;
        public int? BrigadeSubstationId;

        public BrigadeFilters Filters
        {
            get
            {
                return new BrigadeFilters()
                {
                    BrigadeCode = this.BrigadeCode,
                    BrigadeType = this.BrigadeType,
                    BrigadeSubstationId = this.BrigadeSubstationId
                };
            }
        }

        public BrigadeFiltersForm(BrigadeFilters? existingFilters)
        {
            InitializeComponent();

            combo_substation.DataSource = Program.SqlSubstationTable;
            combo_substation.ValueMember = "substation_id";
            combo_substation.DisplayMember = "substation_code";

            combo_substation.Text = "";
            combo_substation.SelectedIndex = -1;

            if (existingFilters == null)
                return;

            textbox_code.Text = existingFilters.BrigadeCode as string;
            textbox_type.Text = existingFilters.BrigadeType as string;
            if (existingFilters.BrigadeSubstationId != null)
                combo_substation.SelectedValue = (existingFilters.BrigadeSubstationId as int?)!;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_code.Text.Trim().Length > 0)
                BrigadeCode = textbox_code.Text;

            if (textbox_type.Text.Trim().Length > 0)
                BrigadeType = textbox_type.Text;

            BrigadeSubstationId = combo_substation.SelectedIndex == -1 || combo_substation.SelectedValue == null ? null : (combo_substation.SelectedValue as int?)!;

            DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
