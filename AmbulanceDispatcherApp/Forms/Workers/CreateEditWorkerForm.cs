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
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms.Workers
{
    public partial class CreateEditWorkerForm : Form
    {
        DataRowView? worker;
        bool isEdit;

        public CreateEditWorkerForm(bool edit, DataRowView? worker)
        {
            InitializeComponent();
            isEdit = edit;

            combo_brigade.DataSource = Program.SqlBrigadeTable;
            combo_brigade.ValueMember = "brigade_id";
            combo_brigade.DisplayMember = "brigade_code";

            if (edit)
            {
                this.worker = worker;
                Text = "Редагування працівника";

                textbox_name.Text = worker!["worker_name"].ToString();
                textbox_surname.Text = worker["worker_surname"].ToString();
                textbox_patriarchic.Text = worker["worker_patriarchic"].ToString();
                textbox_tel.Text = worker["worker_tel"].ToString();
                textbox_kpp.Text = worker["worker_kpp"].ToString();
                textbox_role.Text = worker["worker_role"].ToString();
                textbox_license.Text = worker["worker_license"].ToString();
                datetime_dob.Value = (DateTime)worker["worker_dob"];
                switch (worker["worker_sex"].ToString())
                {
                    case "Ч":
                        radio_sex_male.Checked = true;
                        break;
                    case "Ж":
                        radio_sex_female.Checked = true;
                        break;
                }
                combo_brigade.SelectedValue = worker["brigade_id"];
            }
            else Text = "Створення працівника";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_name.Text.Trim() == "")
            {
                MessageBox.Show("Ім`я не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_surname.Text.Trim() == "")
            {
                MessageBox.Show("Прізвище не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radio_sex_male.Checked && !radio_sex_female.Checked)
            {
                MessageBox.Show("Стать повинна бути обрана", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((int?)combo_brigade.SelectedValue == null || (int)combo_brigade.SelectedValue! == -1)
            {
                MessageBox.Show("Бригада повинна бути обрана", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_kpp.Text.Trim() == "")
            {
                MessageBox.Show("ІНПН не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_role.Text.Trim() == "")
            {
                MessageBox.Show("Роль не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_tel.Text.Trim() != "" &&
                !Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show("Неправильний формат телефону", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlCommand cmd;

            if (isEdit)
            {
                cmd = new MySqlCommand(
                    "UPDATE worker SET worker_name=@n,worker_surname=@s,worker_patriarchic=@p," +
                    "worker_tel=@t,worker_dob=@d,worker_sex=@sx,worker_kpp=@k,worker_role=@r," +
                    "worker_license=@l,brigade_id=@b WHERE worker_id=@id",
                    Program.SqlConnection);

                cmd.Parameters.AddWithValue("@id", worker!["worker_id"]);
            }
            else
            {
                cmd = new MySqlCommand(
                    "INSERT INTO worker (worker_name,worker_surname,worker_patriarchic,worker_tel," +
                    "worker_dob,worker_sex,worker_kpp,worker_role,worker_license,brigade_id) " +
                    "VALUES (@n,@s,@p,@t,@d,@sx,@k,@r,@l,@b)",
                    Program.SqlConnection);
            }

            cmd.Parameters.AddWithValue("@n", textbox_name.Text.Trim());
            cmd.Parameters.AddWithValue("@s", textbox_surname.Text.Trim());
            cmd.Parameters.AddWithValue("@p", textbox_patriarchic.Text.Trim());
            cmd.Parameters.AddWithValue("@t", textbox_tel.Text.Trim());
            cmd.Parameters.AddWithValue("@d", datetime_dob.Value.Date);
            cmd.Parameters.AddWithValue("@sx", radio_sex_male.Checked ? "Ч" : "Ж");
            cmd.Parameters.AddWithValue("@k", textbox_kpp.Text.Trim());
            cmd.Parameters.AddWithValue("@r", textbox_role.Text.Trim());
            cmd.Parameters.AddWithValue("@l", textbox_license.Text.Trim());
            cmd.Parameters.AddWithValue("@b", combo_brigade.SelectedValue);

            cmd.ExecuteNonQuery();
            Program.SyncTableWorker();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e) => Close();
    }

}
