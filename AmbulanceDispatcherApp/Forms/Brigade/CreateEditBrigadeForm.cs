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

namespace AmbulanceDispatcherApp.Forms.Brigade
{
    public partial class CreateEditBrigadeForm : Form
    {
        bool isEdit = false;
        DataRowView? brigade;

        public CreateEditBrigadeForm(bool edit, DataRowView? brigade)
        {
            InitializeComponent();

            combo_substation.DataSource = Program.SqlSubstationTable;
            combo_substation.ValueMember = "substation_id";
            combo_substation.DisplayMember = "substation_code";

            isEdit = edit;
            if (edit)
            {
                this.brigade = brigade;
                this.Text = "Редагування бригади";
                textbox_code.Text = brigade!["brigade_code"] as string;
                textbox_type.Text = brigade!["brigade_type"] as string;
                combo_substation.SelectedValue = (brigade!["substation_id"] as int?)!;
            }
            else
            {
                this.Text = "Створення бригади";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (combo_substation.SelectedValue == null)
            {
                MessageBox.Show("Обраної підстанції не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_code.Text.Trim() == "")
            {
                MessageBox.Show("Код не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_type.Text.Trim() == "")
            {
                MessageBox.Show("Тип не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEdit)
            {
                var command = new MySqlCommand("UPDATE `brigade` SET " +
                               "`brigade_code` = @code, " +
                               "`brigade_type` = @br_type, " +
                               "`substation_id` = @substation_id " +
                               "WHERE `brigade_id` = @id"
                               , Program.SqlConnection);

                command.Parameters.AddWithValue("@br_type", textbox_type.Text.Trim());
                command.Parameters.AddWithValue("@code", textbox_code.Text.Trim());
                command.Parameters.AddWithValue("@substation_id", (brigade!["substation_id"] as int?)!);
                command.Parameters.AddWithValue("@id", (brigade!["brigade_id"] as int?)!);

                command.ExecuteNonQuery();
            }
            else
            {
                var command = new MySqlCommand("INSERT INTO `brigade` (`brigade_code`,`brigade_type`,`substation_id`) VALUES (" +
                                                                                                                       "@code, " +
                                                                                                                       "@br_type, " +
                                                                                                                       "@substation_id)"
                                                                                                                       , Program.SqlConnection);

                command.Parameters.AddWithValue("@substation_id", combo_substation.SelectedValue as int?);
                command.Parameters.AddWithValue("@br_type", textbox_type.Text.Trim());
                command.Parameters.AddWithValue("@code", textbox_code.Text.Trim());

                command.ExecuteNonQuery();
            }

            Program.SyncTableBrigade();
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
