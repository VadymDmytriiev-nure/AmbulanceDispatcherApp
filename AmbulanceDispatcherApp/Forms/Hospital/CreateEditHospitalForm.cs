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

namespace AmbulanceDispatcherApp.Forms.Hospital
{
    public partial class CreateEditHospitalForm : Form
    {
        bool isEdit = false;
        DataRowView? hospital;

        public CreateEditHospitalForm(bool edit, DataRowView? hospital)
        {
            InitializeComponent();

            isEdit = edit;
            if (edit)
            {
                this.hospital = hospital;
                this.Text = "Редагування лікарні";
                textbox_name.Text = hospital!["hospital_name"] as string;
                textbox_address.Text = hospital!["hospital_address"] as string;
                textbox_specialization.Text = hospital!["hospital_specialization"] as string;
            }
            else
            {
                this.Text = "Створення лікарні";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_name.Text.Trim() == "")
            {
                MessageBox.Show("Назва не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_address.Text.Trim() == "")
            {
                MessageBox.Show("Адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEdit)
            {
                var command = new MySqlCommand("UPDATE `hospital` SET " +
                               "`hospital_name` = @name, " +
                               "`hospital_address` = @address, " +
                               "`hospital_specialization` = @spec " +
                               "WHERE `hospital_id` = @id"
                               , Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@address", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@spec", textbox_specialization.Text.Trim());
                command.Parameters.AddWithValue("@id", (hospital!["hospital_id"] as int?)!);

                command.ExecuteNonQuery();
            }
            else
            {
                var command = new MySqlCommand("INSERT INTO `hospital` (`hospital_name`,`hospital_address`,`hospital_specialization`) VALUES (" +
                                                                                                                       "@name, " +
                                                                                                                       "@address, " +
                                                                                                                       "@spec)"
                                                                                                                       , Program.SqlConnection);

                command.Parameters.AddWithValue("@name", textbox_name.Text.Trim());
                command.Parameters.AddWithValue("@address", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@spec", textbox_specialization.Text.Trim());

                command.ExecuteNonQuery();
            }

            Program.SyncTableHospital();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
