using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Dispatcher
{
    public partial class DispatcherFiltersForm : Form
    {
        public string? DispatcherSurname;
        public string? DispatcherName;
        public string? DispatcherPatriarchic;
        public string? DispatcherTel;

        public DispatcherFilters Filters
        {
            get
            {
                return new DispatcherFilters()
                {
                    DispatcherSurname = this.DispatcherSurname,
                    DispatcherName = this.DispatcherName,
                    DispatcherPatriarchic = this.DispatcherPatriarchic,
                    DispatcherTel = this.DispatcherTel
                };
            }
        }

        public DispatcherFiltersForm(DispatcherFilters existingFilters)
        {
            InitializeComponent();

            textbox_surname.Text = existingFilters.DispatcherSurname ?? "";
            textbox_name.Text = existingFilters.DispatcherName ?? "";
            textbox_patriarchic.Text = existingFilters.DispatcherPatriarchic ?? "";
            textbox_tel.Text = existingFilters.DispatcherTel ?? "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_surname.Text.Trim() != "")
                DispatcherSurname = textbox_surname.Text;

            if (textbox_name.Text.Trim() != "")
                DispatcherName = textbox_name.Text;

            if (textbox_patriarchic.Text.Trim() != "")
                DispatcherPatriarchic = textbox_patriarchic.Text;

            if (textbox_tel.Text.Trim() != "")
                DispatcherTel = textbox_tel.Text;
        }
    }
}
