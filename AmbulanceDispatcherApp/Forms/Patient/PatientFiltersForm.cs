using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Patient
{
    public partial class PatientFiltersForm : Form
    {
        public int? PatientID;
        public string? PatientSurname;
        public string? PatientName;
        public string? PatientPatriarchic;
        public string? PatientTel;
        public string? PatientSex;
        public (DateTime? Min, DateTime? Max) PatientDOB;

        public PatientFilters Filters
        {
            get
            {
                return new PatientFilters()
                {
                    PatientSurname = this.PatientSurname,
                    PatientName = this.PatientName,
                    PatientPatriarchic = this.PatientPatriarchic,
                    PatientTel = this.PatientTel,
                    PatientSex = this.PatientSex,
                    PatientDOB = this.PatientDOB
                };
            }
        }

        public PatientFiltersForm()
        {
            InitializeComponent();

            radio_sex_unknown.Checked = true;

            foreach (var dt in Controls.OfType<DateTimePicker>())
                dt.MaxDate = DateTime.Now;

            datetime_dob_to.Value = datetime_dob_to.MaxDate;
        }

        public PatientFiltersForm(PatientFilters existingFilters)
        {
            InitializeComponent();

            textbox_surname.Text = existingFilters.PatientSurname ?? "";
            textbox_name.Text = existingFilters.PatientName ?? "";
            textbox_patriarchic.Text = existingFilters.PatientPatriarchic ?? "";
            textbox_tel.Text = existingFilters.PatientTel ?? "";

            radio_sex_unknown.Checked = true;
            if (existingFilters.PatientSex != null)
            {
                switch (existingFilters.PatientSex.ToString())
                {
                    case "Ч":
                        radio_sex_male.Checked = true;
                        break;
                    case "Ж":
                        radio_sex_female.Checked = true;
                        break;
                }
            }

            if (existingFilters.PatientDOB.Min.HasValue)
                datetime_dob_from.Value = existingFilters.PatientDOB.Min.Value;

            if (existingFilters.PatientDOB.Max.HasValue)
                datetime_dob_to.Value = existingFilters.PatientDOB.Max.Value;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (datetime_dob_from.Value > datetime_dob_to.Value)
            {
                MessageBox.Show(
                    "Дата народження \"від\" не може перевищувати \"до\"",
                    "Помилка форматування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (textbox_tel.Text.Trim() != "" &&
                !Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show(
                    "Неправильний формат телефону. Формат: +XXXXXXXXXXX",
                    "Помилка форматування",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (textbox_surname.Text.Trim() != "")
                PatientSurname = textbox_surname.Text;

            if (textbox_name.Text.Trim() != "")
                PatientName = textbox_name.Text;

            if (textbox_patriarchic.Text.Trim() != "")
                PatientPatriarchic = textbox_patriarchic.Text;

            if (textbox_tel.Text.Trim() != "")
                PatientTel = textbox_tel.Text;

            PatientSex = radio_sex_unknown.Checked ? null : (radio_sex_male.Checked ? "Ч" : "Ж");

            PatientDOB.Min = datetime_dob_from.Value;
            PatientDOB.Max = datetime_dob_to.Value;

            DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

