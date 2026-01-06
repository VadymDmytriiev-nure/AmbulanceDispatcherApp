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

namespace AmbulanceDispatcherApp.Forms.Workers
{
    public partial class WorkersForm : Form
    {
        WorkerFilters filters = new WorkerFilters();

        public int? SelectedWorkerID;

        public WorkersForm(FormMode mode = FormMode.Edit)
        {
            InitializeComponent();

            datagridview_main.AutoGenerateColumns = false;
            datagridview_main.DataSource = Program.SqlWorkerTable;
            datagridview_main.Sort(column_worker_brigade, ListSortDirection.Ascending);

            panel_dialog.Visible = false;
            if (mode == FormMode.View)
            {
                panel_crud.Visible = false;
                button_refresh.Visible = false;
                datagridview_main.Size = new Size(748, datagridview_main.Size.Height);
            }
            else if (mode == FormMode.Select)
            {
                panel_crud.Visible = false;
                panel_dialog.Visible = true;
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
                SelectedWorkerID = null;
                button_crud_edit.Enabled = false;
                button_crud_delete.Enabled = false;
            }
            else
            {
                SelectedWorkerID = ((datagridview_main.SelectedRows[0].DataBoundItem as DataRowView)!["worker_id"] as int?)!;
                button_crud_edit.Enabled = true;
                button_crud_delete.Enabled = true;
            }
        }

        private void button_crud_create_Click(object sender, EventArgs e)
        {
            new CreateEditWorkerForm(false, null).ShowDialog();
        }

        private void button_crud_edit_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0) return;
            var row = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;
            new CreateEditWorkerForm(true, row).ShowDialog();
        }

        private void button_crud_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_main.SelectedRows.Count == 0) return;
            var row = datagridview_main.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show("Підтвердити видалення працівника?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var cmd = new MySqlCommand("DELETE FROM worker WHERE worker_id=@id", Program.SqlConnection);
            cmd.Parameters.AddWithValue("@id", row!["worker_id"]);
            try { cmd.ExecuteNonQuery(); }
            catch
            {
                MessageBox.Show("Неможливо видалити працівника", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.SyncTableWorker();
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            var f = new WorkerFiltersForm(filters);
            if (f.ShowDialog() == DialogResult.OK)
            {
                filters = f.Filters;
                var cmd = filters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredWorkerAdapter = new MySqlDataAdapter(cmd);
                Program.SqlFilteredWorkerTable = new DataTable();
                Program.SqlFilteredWorkerAdapter.Fill(Program.SqlFilteredWorkerTable);
                datagridview_main.DataSource = Program.SqlFilteredWorkerTable;
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_main.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["worker_fullname"] as string)!.ToLower().Contains(textbox_search.Text.ToLower()) || (row_data["worker_tel"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

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

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new WorkerFilters();
            datagridview_main.DataSource = Program.SqlWorkerTable;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
        }
    }

}
