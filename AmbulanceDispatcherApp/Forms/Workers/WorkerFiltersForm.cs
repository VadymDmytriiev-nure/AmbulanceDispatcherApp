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

namespace AmbulanceDispatcherApp.Forms.Workers
{
    public partial class WorkerFiltersForm : Form
    {
        public int? WorkerID;
        public int? BrigadeID;
        public string? WorkerSurname;
        public string? WorkerName;
        public string? WorkerPatriarchic;
        public string? WorkerTel;
        public char? WorkerSex;
        public string? WorkerKPP;
        public string? WorkerLicense;
        public string? WorkerRole;
        public (DateTime? Min, DateTime? Max) WorkerDOB;

        public WorkerFilters Filters
        {
            get
            {
                return new WorkerFilters()
                {
                    WorkerID = WorkerID,
                    WorkerName = WorkerName,
                    WorkerSurname = WorkerSurname,
                    WorkerPatriarchic = WorkerPatriarchic,
                    WorkerSex = WorkerSex,
                    WorkerTel = WorkerTel,
                    WorkerDOB = WorkerDOB,
                    WorkerKPP = WorkerKPP,
                    WorkerLicense = WorkerLicense,
                    WorkerRole = WorkerRole,
                    BrigadeID = BrigadeID,
                };
            }
        }

        public WorkerFiltersForm(WorkerFilters? existingFilters)
        {
            InitializeComponent();

            combo_brigade.DataSource = Program.SqlBrigadeTable;
            combo_brigade.ValueMember = "brigade_id";
            combo_brigade.DisplayMember = "brigade_code";

            combo_brigade.Text = "";
            combo_brigade.SelectedIndex = -1;

            radio_sex_unknown.Checked = true;

            if (existingFilters == null)
                return;

            textbox_surname.Text = existingFilters.WorkerSurname ?? "";
            textbox_name.Text = existingFilters.WorkerName ?? "";
            textbox_patriarchic.Text = existingFilters.WorkerPatriarchic ?? "";
            textbox_tel.Text = existingFilters.WorkerTel ?? "";
            textbox_kpp.Text = existingFilters.WorkerKPP ?? "";
            textbox_role.Text = existingFilters.WorkerRole ?? "";
            textbox_license.Text = existingFilters.WorkerLicense ?? "";

            if (existingFilters.WorkerSex.HasValue)
            {
                switch (existingFilters.WorkerSex.Value.ToString())
                {
                    case "Ч":
                        radio_sex_male.Checked = true;
                        break;
                    case "Ж":
                        radio_sex_female.Checked = true;
                        break;
                }
            }

            if (existingFilters.WorkerDOB.Min.HasValue)
                datetime_dob_from.Value = existingFilters.WorkerDOB.Min.Value;

            if (existingFilters.WorkerDOB.Max.HasValue)
                datetime_dob_to.Value = existingFilters.WorkerDOB.Max.Value;

            if (existingFilters.BrigadeID != null)
                combo_brigade.SelectedValue = (existingFilters.BrigadeID as int?)!;
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
                WorkerSurname = textbox_surname.Text;

            if (textbox_name.Text.Trim() != "")
                WorkerName = textbox_name.Text;

            if (textbox_patriarchic.Text.Trim() != "")
                WorkerPatriarchic = textbox_patriarchic.Text;

            if (textbox_tel.Text.Trim() != "")
                WorkerTel = textbox_tel.Text;

            if (textbox_kpp.Text.Trim() != "")
                WorkerKPP = textbox_kpp.Text;

            if (textbox_license.Text.Trim() != "")
                WorkerLicense = textbox_license.Text;

            if (textbox_role.Text.Trim() != "")
                WorkerRole = textbox_role.Text;

            if ((int)combo_brigade.SelectedValue! > 0)
                BrigadeID = (int)combo_brigade.SelectedValue;

            WorkerSex = radio_sex_unknown.Checked ? null : (radio_sex_male.Checked ? 'Ч' : 'Ж');

            WorkerDOB.Min = datetime_dob_from.Value;
            WorkerDOB.Max = datetime_dob_to.Value;

            DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
