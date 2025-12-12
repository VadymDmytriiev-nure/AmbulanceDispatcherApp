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

namespace AmbulanceDispatcherApp.Forms.Substation
{
    public partial class CreateEditSubstationForm : Form
    {
        DataRowView? substation;
        bool isEdit;

        public CreateEditSubstationForm(bool edit, DataRowView? substation)
        {
            InitializeComponent();

            isEdit = edit;
            if (edit)
            {
                this.substation = substation;
                this.Text = "Редагування підстанції";
                textbox_code.Text = substation!["substation_code"] as string;
                textbox_address.Text = substation!["substation_address"] as string;
            }
            else
            {
                this.Text = "Створення підстанції";
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_code.Text.Trim() == "")
            {
                MessageBox.Show("Код не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_address.Text.Trim() == "")
            {
                MessageBox.Show("Адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(isEdit)
            {
                var command = new MySqlCommand("UPDATE `substation` SET " +
                               "`substation_code` = @code, " +
                               "`substation_address` = @address " +
                               "WHERE `substation_id` = @id"
                               , Program.SqlConnection);

                command.Parameters.AddWithValue("@address", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@code", textbox_code.Text.Trim());
                command.Parameters.AddWithValue("@id", (substation!["substation_id"] as int?)!);

                command.ExecuteNonQueryAsync();
            }
            else
            {
                var command = new MySqlCommand("INSERT INTO `substation` (`substation_code`,`substation_address`) VALUES (" +
                                                                                                                       "@code, " +
                                                                                                                       "@address)"
                                                                                                                       , Program.SqlConnection);

                command.Parameters.AddWithValue("@address", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@code", textbox_code.Text.Trim());

                command.ExecuteNonQueryAsync();
            }

            Program.SyncWithRemote();
            Close();
        }
    }
}
