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
        DataTable table = new DataTable();

        public CallsForm(MySqlConnection conn, string query)
        {
            InitializeComponent();

            datagrid_call.AutoGenerateColumns = false;

            this.conn = conn;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            datagrid_call.DataSource = table;

            MySqlCommandBuilder b = new MySqlCommandBuilder(adapter);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCallForm cc = new CreateCallForm(conn, table_call, table_dispatcher, table_callout);
            cc.Show();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = datagrid_call.SelectedRows.Count == 0 ? null : datagrid_call.SelectedRows[0];
            if (tabControl1.SelectedTab != tab_call || row == null)
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

            if (tabControl1.SelectedTab != tab_call || row == null)
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

        }
    }
}
