using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms.Patient
{
    public partial class CreateEditPatientForm : Form
    {
        DataRowView? patient;
        bool isEdit;

        public CreateEditPatientForm(bool edit, DataRowView? patient)
        {
            InitializeComponent();

            isEdit = edit;

            if (edit)
            {
                this.patient = patient;
                Text = "Редагування пацієнта";

                textbox_name.Text = patient!["patient_name"] as string;
                textbox_surname.Text = patient!["patient_surname"] as string;
                textbox_patriarchic.Text = patient!["patient_patriarchic"] as string;
                textbox_tel.Text = patient!["patient_tel"] as string;
                datetime_dob.Value = (DateTime)patient!["patient_dob"];
                switch (patient!["patient_sex"].ToString())
                {
                    case "Ж":
                        radio_sex_female.Checked = true;
                        break;
                    case "Ч":
                        radio_sex_male.Checked = true;
                        break;
                }
            }
            else
            {
                Text = "Створення пацієнта";
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
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

            if (textbox_tel.Text.Trim() != "" &&
                !Regex.IsMatch(textbox_tel.Text, "^\\+([0-9]{1,4})[-\\s]?([0-9]{1,15})$"))
            {
                MessageBox.Show("Неправильний формат телефону", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEdit)
            {
                var command = new MySqlCommand(
                    "UPDATE `patient` SET " +
                    "`patient_name` = @name, " +
                    "`patient_surname` = @surname, " +
                    "`patient_patriarchic` = @patriarchic, " +
                    "`patient_tel` = @tel, " +
                    "`patient_dob` = @dob, " +
                    "`patient_sex` = @sex " +
                    "WHERE `patient_id` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@surname", textbox_surname.Text.Trim());
                command.Parameters.AddWithValue("@patriarchic", textbox_patriarchic.Text.Trim());
                command.Parameters.AddWithValue("@tel", textbox_tel.Text.Trim());
                command.Parameters.AddWithValue("@dob", datetime_dob.Value.Date);
                command.Parameters.AddWithValue("@sex", radio_sex_male.Checked ? "Ч" : "Ж");
                command.Parameters.AddWithValue("@id", (int)patient!["patient_id"]);

                command.ExecuteNonQueryAsync();
            }
            else
            {
                var command = new MySqlCommand(
                    "INSERT INTO `patient` " +
                    "(`patient_name`,`patient_surname`,`patient_patriarchic`,`patient_tel`,`patient_dob`,`patient_sex`) " +
                    "VALUES (@name,@surname,@patriarchic,@tel,@dob,@sex)",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@surname", textbox_surname.Text.Trim());
                command.Parameters.AddWithValue("@patriarchic", textbox_patriarchic.Text.Trim());
                command.Parameters.AddWithValue("@tel", textbox_tel.Text.Trim());
                command.Parameters.AddWithValue("@dob", datetime_dob.Value.Date);
                command.Parameters.AddWithValue("@sex", radio_sex_male.Checked ? "Ч" : "Ж");

                command.ExecuteNonQueryAsync();
            }

            Program.SyncTablePatient();
            Close();
        }
    }
}
