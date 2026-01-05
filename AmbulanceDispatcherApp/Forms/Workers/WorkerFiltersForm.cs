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
        public int? ID;
        public int? BrigadeID;
        public string? Surname;
        new public string? Name;
        public string? Patriarchic;
        public string? Tel;
        public char? Sex;
        public string? KPP;
        public string? License;
        public string? Role;
        public (DateTime? Min, DateTime? Max) DOB;

        public WorkerFilters Filters
        {
            get
            {
                return new WorkerFilters()
                {
                    ID = ID,
                    Name = Name,
                    Surname = Surname,
                    Patriarchic = Patriarchic,
                    Sex = Sex,
                    Tel = Tel,
                    DOB = DOB,
                    KPP = KPP,
                    License = License,
                    Role = Role,
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

            textbox_surname.Text = existingFilters.Surname ?? "";
            textbox_name.Text = existingFilters.Name ?? "";
            textbox_patriarchic.Text = existingFilters.Patriarchic ?? "";
            textbox_tel.Text = existingFilters.Tel ?? "";
            textbox_kpp.Text = existingFilters.KPP ?? "";
            textbox_role.Text = existingFilters.Role ?? "";
            textbox_license.Text = existingFilters.License ?? "";

            if (existingFilters.Sex.HasValue)
            {
                switch (existingFilters.Sex.Value.ToString())
                {
                    case "Ч":
                        radio_sex_male.Checked = true;
                        break;
                    case "Ж":
                        radio_sex_female.Checked = true;
                        break;
                }
            }

            if (existingFilters.DOB.Min.HasValue)
                datetime_dob_from.Value = existingFilters.DOB.Min.Value;

            if (existingFilters.DOB.Max.HasValue)
                datetime_dob_to.Value = existingFilters.DOB.Max.Value;

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
                Surname = textbox_surname.Text;

            if (textbox_name.Text.Trim() != "")
                Name = textbox_name.Text;

            if (textbox_patriarchic.Text.Trim() != "")
                Patriarchic = textbox_patriarchic.Text;

            if (textbox_tel.Text.Trim() != "")
                Tel = textbox_tel.Text;

            if (textbox_kpp.Text.Trim() != "")
                KPP = textbox_kpp.Text;

            if (textbox_license.Text.Trim() != "")
                License = textbox_license.Text;

            if (textbox_role.Text.Trim() != "")
                Role = textbox_role.Text;

            if ((int)combo_brigade.SelectedValue! > 0)
                BrigadeID = (int)combo_brigade.SelectedValue;

            Sex = radio_sex_unknown.Checked ? null : (radio_sex_male.Checked ? 'Ч' : 'Ж');

            DOB.Min = datetime_dob_from.Value;
            DOB.Max = datetime_dob_to.Value;

            DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
