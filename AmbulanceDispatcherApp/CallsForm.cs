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

namespace AmbulanceDispatcherApp
{
    public partial class CallsForm : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataTable table_callout;
        DataTable table_call_filtered = new DataTable();
        DataTable table_call;
        DataTable table_dispatcher;

        public CallsForm(MySqlConnection conn, MySqlCommand filter, DataTable table_call, DataTable table_callout, DataTable table_dispatcher)
        {
            InitializeComponent();

            datagrid_call.AutoGenerateColumns = false;

            this.conn = conn;
            this.table_call = table_call;
            this.table_callout = table_callout;
            this.table_dispatcher = table_dispatcher;

            datagrid_call.DataSource = table_call_filtered;

            adapter = new MySqlDataAdapter(filter);
            MySqlCommandBuilder b = new MySqlCommandBuilder(adapter);
            adapter.Fill(table_call_filtered);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            adapter.Update(table_call);
            adapter.Update(table_call_filtered);
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCallForm cc = new CreateCallForm(conn, table_call_filtered, table_dispatcher, table_callout);
            cc.Show();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = datagrid_call.SelectedRows.Count == 0 ? null : datagrid_call.SelectedRows[0];
            if (row == null)
            {
                MessageBox.Show("У вас не виділено жодного дзвінку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditCallForm ec = new EditCallForm(conn, (row.DataBoundItem as DataRowView)!, table_dispatcher, table_callout);
            ec.Show();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = datagrid_call.SelectedRows.Count == 0 ? null : datagrid_call.SelectedRows[0];

            if (row == null)
            {
                MessageBox.Show("У вас не виділено жодного дзвінку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row_data = row.DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення дзвінку о {row_data!["call_time_created"]} по привіду {row_data!["call_reason"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                row_data!.Delete();
        }

        private void datagrid_call_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            редагуватиToolStripMenuItem_Click(sender, e);
        }
    }
}
