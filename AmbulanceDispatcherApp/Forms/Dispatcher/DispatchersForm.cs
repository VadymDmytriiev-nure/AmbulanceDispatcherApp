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

namespace AmbulanceDispatcherApp.Forms.Dispatcher
{
    public partial class DispatchersForm : Form
    {
        DispatcherFilters filters = new DispatcherFilters();

        public DispatchersForm(FormMode mode = FormMode.View)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlDispatcherTable;
            datagridview_main.Sort(column_dispatcher_name, ListSortDirection.Ascending);

            if (mode == FormMode.View)
            {
                button_refresh.Visible = false;
                panel_crud.Visible = false;
                datagridview_main.Size = new Size(748, datagridview_main.Size.Height);
            }
            else if (mode == FormMode.Select)
            {
                panel_crud.Visible = false;
            }
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            CreateEditDispatcherForm subform = new CreateEditDispatcherForm(FormMode.Create, null);
            subform.ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;
            CreateEditDispatcherForm subform = new CreateEditDispatcherForm(FormMode.Edit, row_data);
            subform.ShowDialog();
        }

        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення диспетчера {row_data!["dispatcher_fullname"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `dispatcher` WHERE `dispatcher_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["dispatcher_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити даного диспетчера. Скоріш за все, дані цього диспетчера ще використовуються в іншому місці.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.SyncTableDispatcher();
            }
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            DispatcherFiltersForm filtersForm = new DispatcherFiltersForm(filters);
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                filters = filtersForm.Filters;
                MySqlCommand command = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredDispatcherAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredDispatcherAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredDispatcherTable = new DataTable();
                Program.SqlFilteredDispatcherAdapter.Fill(Program.SqlFilteredDispatcherTable);
                datagridview_main.DataSource = Program.SqlFilteredDispatcherTable;
                datagridview_main.Sort(column_dispatcher_name, ListSortDirection.Ascending);
            }
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new DispatcherFilters();
            datagridview_main.DataSource = Program.SqlDispatcherTable;
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
                    bool isGreen = (row_data!["dispatcher_fullname"] as string)!.ToLower().Contains(textbox_search.Text.ToLower()) || (row_data["dispatcher_tel"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

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
