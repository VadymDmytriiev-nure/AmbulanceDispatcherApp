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

namespace AmbulanceDispatcherApp.Forms.Patient
{
    public partial class PatientsForm : Form
    {
        PatientFilters filters = new PatientFilters();

        public PatientsForm(bool readOnly = false)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlPatientTable;
            datagridview_main.Sort(column_patient_name, ListSortDirection.Ascending);

            if (readOnly)
            {
                button_refresh.Visible = false;
                panel_crud.Visible = false;
                datagridview_main.Size = new Size(748, datagridview_main.Size.Height);
            }
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            CreateEditPatientForm subform = new CreateEditPatientForm(false, null);
            subform.ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            CreateEditPatientForm subform = new CreateEditPatientForm(false, null);
            subform.ShowDialog();
        }

        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення пацієнта {row_data!["patient_fullname"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `patient` WHERE `patient_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["patient_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити даного пацієнта. Скоріш за все, дані цього пацієнта ще використовуються в іншому місці.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.SyncTablePatient();
            }
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            PatientFiltersForm filtersForm = new PatientFiltersForm(filters);
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                filters = filtersForm.Filters;
                MySqlCommand command = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredPatientAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredPatientAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredPatientTable = new DataTable();
                Program.SqlFilteredPatientAdapter.Fill(Program.SqlFilteredPatientTable);
                datagridview_main.DataSource = Program.SqlFilteredPatientTable;
                datagridview_main.Sort(column_patient_name, ListSortDirection.Ascending);
            }
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new PatientFilters();
            datagridview_main.DataSource = Program.SqlPatientTable;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["patient_fullname"] as string)!.ToLower().Contains(textbox_search.Text.ToLower()) || (row_data["patient_tel"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

                    row.DefaultCellStyle.BackColor = isGreen ? Color.DarkGreen : Color.DarkRed;
                }
            }
            else
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    row.DefaultCellStyle.BackColor = Control.DefaultBackColor;
                }
            }
        }

        private void datagridview_main_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
            {
                button_crud_edit.Enabled = false;
                button_crud_delete.Enabled = false;
            }
            else
            {
                button_crud_edit.Enabled = true;
                button_crud_delete.Enabled = true;
            }
        }

        private void checkbox_auto_resize_columns_CheckedChanged(object sender, EventArgs e)
        {
            datagridview_main.AutoSizeColumnsMode = checkbox_auto_resize_columns.Checked ? DataGridViewAutoSizeColumnsMode.AllCells : DataGridViewAutoSizeColumnsMode.None;
            datagridview_main.AutoResizeColumns();
        }
    }
}
