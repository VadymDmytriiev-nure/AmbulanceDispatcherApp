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

namespace AmbulanceDispatcherApp.Forms.Brigade
{
    public partial class BrigadesForm : Form
    {
        BrigadeFilters filters = new BrigadeFilters();

        public BrigadesForm(bool readOnly)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlBrigadeTable;
            datagridview_main.Sort(column_substation_code, ListSortDirection.Ascending);

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
            CreateEditBrigadeForm subform = new CreateEditBrigadeForm(false, null);
            subform.ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;
            CreateEditBrigadeForm subform = new CreateEditBrigadeForm(true, row_data);
            subform.ShowDialog();
        }

        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення бригади {row_data!["brigade_code"]} на підстанції по адресі {row_data!["substation_address"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                row_data!.Delete();
                Program.SyncWithRemote();
            }
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new BrigadeFilters();
            datagridview_main.DataSource = Program.SqlBrigadeTable;
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            BrigadeFiltersForm filtersForm = new BrigadeFiltersForm(filters);
            if (filtersForm.ShowDialog() == DialogResult.OK)
            {
                filters = filtersForm.Filters;
                MySqlCommand command = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredBrigadeAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredBrigadeAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredBrigadeTable = new DataTable();
                Program.SqlFilteredBrigadeAdapter.Fill(Program.SqlFilteredBrigadeTable);
                datagridview_main.DataSource = Program.SqlFilteredBrigadeTable;
                datagridview_main.Sort(column_brigade_code, ListSortDirection.Ascending);
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["brigade_code"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

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
