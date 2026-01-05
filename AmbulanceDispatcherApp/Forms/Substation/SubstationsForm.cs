using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms.Substation;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms
{
    public partial class SubstationsForm : Form
    {
        SubstationFilters filters = new SubstationFilters();

        public SubstationsForm(bool readOnly = false)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlSubstationTable;
            datagridview_main.Sort(column_substation_code, ListSortDirection.Ascending);

            if(readOnly)
            {
                button_refresh.Visible = false;
                panel_crud.Visible = false;
                datagridview_main.Size = new Size(748, datagridview_main.Size.Height);
            }
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            CreateEditSubstationForm subform = new CreateEditSubstationForm(false, null);
            subform.ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;
            CreateEditSubstationForm subform = new CreateEditSubstationForm(true, row_data);
            subform.ShowDialog();
        }

        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення підстанції {row_data!["substation_code"]} по адресі {row_data!["substation_address"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `substation` WHERE `substation_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["substation_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити дану підстанцію. Скоріш за все, дані цієї підстанції ще використовуються.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.SyncTableSubstation();
            }
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new SubstationFilters();
            datagridview_main.DataSource = Program.SqlSubstationTable;
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            SubstationFiltersForm filtersForm = new SubstationFiltersForm(filters);
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                filters = filtersForm.Filters;
                MySqlCommand command = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredSubstationAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredSubstationAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredSubstationTable = new DataTable();
                Program.SqlFilteredSubstationAdapter.Fill(Program.SqlFilteredSubstationTable);
                datagridview_main.DataSource = Program.SqlFilteredSubstationTable;
                datagridview_main.Sort(column_substation_code, ListSortDirection.Ascending);
            }
        }

        private void checkbox_auto_resize_columns_CheckedChanged(object sender, EventArgs e)
        {
            datagridview_main.AutoSizeColumnsMode = checkbox_auto_resize_columns.Checked ? DataGridViewAutoSizeColumnsMode.AllCells : DataGridViewAutoSizeColumnsMode.None;
            datagridview_main.AutoResizeColumns();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["substation_code"] as string)!.ToLower().Contains(textbox_search.Text.ToLower()) || (row_data["substation_address"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());
                    
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
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
    }
}
