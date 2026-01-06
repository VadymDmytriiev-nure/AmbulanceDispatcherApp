using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms.Brigade;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms.Departures
{
    public partial class DeparturesForm : Form
    {
        DepartureFilters filters = new DepartureFilters();

        public DeparturesForm(bool readOnly)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlDepartureTable;
            datagridview_main.Sort(column_callout_id, ListSortDirection.Ascending);
            
            if (readOnly)
            {
                button_refresh.Visible = false;
                panel_crud.Visible = false;
                datagridview_main.Size = new Size(748, datagridview_main.Size.Height);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            CreateEditDepartureForm subform = new CreateEditDepartureForm(FormMode.Create, null);
            subform.ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;
            CreateEditDepartureForm subform = new CreateEditDepartureForm(FormMode.Edit, row_data);
            subform.ShowDialog();
        }
        
        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення виїзду по виклику {row_data!["callout_id"]} до адреси {row_data!["departure_to_address"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `departure` WHERE `departure_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["departure_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити даний виїзд. Скоріш за все, дані цього виїзду ще використовуються в іншому місці.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.SyncTableDeparture();
            }
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new DepartureFilters();
            datagridview_main.DataSource = Program.SqlDepartureTable;
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            DepartureFiltersForm filtersForm = new DepartureFiltersForm(filters);
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                filters = filtersForm.Filters;
                MySqlCommand command = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredDepartureAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredDepartureAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredDepartureTable = new DataTable();
                Program.SqlFilteredDepartureAdapter.Fill(Program.SqlFilteredDepartureTable);
                datagridview_main.DataSource = Program.SqlFilteredDepartureTable;
                datagridview_main.Sort(column_callout_id, ListSortDirection.Ascending);
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["departure_time_departed"] as string)!.ToLower().Contains(textbox_search.Text.ToLower())
                                || (row_data!["departure_time_arrived"] as string)!.ToLower().Contains(textbox_search.Text.ToLower())
                                || (row_data!["departure_from_address"] as string)!.ToLower().Contains(textbox_search.Text.ToLower())
                                || (row_data!["departure_to_address"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

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

        private void checkbox_auto_resize_columns_CheckedChanged(object sender, EventArgs e)
        {
            datagridview_main.AutoSizeColumnsMode = checkbox_auto_resize_columns.Checked ? DataGridViewAutoSizeColumnsMode.AllCells : DataGridViewAutoSizeColumnsMode.None;
            datagridview_main.AutoResizeColumns();
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
