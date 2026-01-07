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

namespace AmbulanceDispatcherApp.Forms
{
    public partial class PersonnelFromBrigadeForm : Form
    {
        BrigadeFilters filters = new BrigadeFilters();

        public int? SelectedBrigadeID;

        public PersonnelFromBrigadeForm()
        {
            InitializeComponent();

            datagridview_worker.AutoGenerateColumns = false;
            datagridview_brigade.AutoGenerateColumns = false;
            datagridview_brigade.DataSource = Program.SqlBrigadeTable;
            datagridview_brigade.Sort(column_substation_code, ListSortDirection.Ascending);
        }

        private void button_filters_reset_Click(object sender, EventArgs e)
        {
            filters = new BrigadeFilters();
            datagridview_brigade.DataSource = Program.SqlBrigadeTable;
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
                datagridview_brigade.DataSource = Program.SqlFilteredBrigadeTable;
                datagridview_brigade.Sort(column_brigade_code, ListSortDirection.Ascending);
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text.Trim().Length > 0)
            {
                foreach (DataGridViewRow row in datagridview_brigade.Rows)
                {
                    var row_data = row.DataBoundItem as DataRowView;
                    bool isGreen = (row_data!["brigade_code"] as string)!.ToLower().Contains(textbox_search.Text.ToLower());

                    row.DefaultCellStyle.BackColor = isGreen ? Color.DarkGreen : Color.DarkRed;
                }
            }
            else
            {
                foreach (DataGridViewRow row in datagridview_brigade.Rows)
                {
                    row.DefaultCellStyle.BackColor = Control.DefaultBackColor;
                }
            }
        }

        private void datagridview_main_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridview_brigade.SelectedRows.Count == 0)
            {
                button_ok.Enabled = false;
                datagridview_worker.DataSource = null;
                return;
            }
            button_ok.Enabled = true;

            var row = (datagridview_brigade.SelectedRows[0].DataBoundItem as DataRowView)!;
            label_selected_brigade.Text = $"Обрана бригада: {row["brigade_code"]} ({row["brigade_worker_count"]} працівників)";

            SelectedBrigadeID = row["brigade_id"] as int?;
            var cmd = new MySqlCommand(
                $"{Queries.QUERY_RETRIEVE_WORKERS} WHERE `worker`.`brigade_id` = {SelectedBrigadeID} LIMIT {Program.SQL_MAX_ROWS_FILTERED}",
                Program.SqlConnection);
            var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            datagridview_worker.DataSource = table;
        }
    }
}
