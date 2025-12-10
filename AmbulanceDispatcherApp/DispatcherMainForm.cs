using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp
{
    public partial class DispatcherMainForm : Form
    {
        private bool loggingOut = false;

        public DispatcherMainForm()
        {
            InitializeComponent();

            datagridview_call.AutoGenerateColumns = false;
            datagridview_callout.AutoGenerateColumns = false;

            datagridview_call.DataSource = Program.SqlCallTable;
            datagridview_callout.DataSource = Program.SqlCalloutTable;

            datagridview_call.Sort(column_call_time_created, ListSortDirection.Descending);
            datagridview_callout.Sort(column_callout_id, ListSortDirection.Descending);
        }

        private void DispatcherMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            loggingOut = true;
            Close();
        }

        private void DispatcherMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (loggingOut)
                Program.Logout();
            else
                Application.Exit();
        }

        private void button_call_refresh_Click(object sender, EventArgs e)
        {
            Program.SqlCallAdapter.Update(Program.SqlCallTable);
        }

        private void button_callout_refresh_Click(object sender, EventArgs e)
        {
            Program.SqlCalloutAdapter.Update(Program.SqlCalloutTable);
        }

        private void button_call_resize_columns_Click(object sender, EventArgs e)
        {
            datagridview_call.AutoResizeColumns();
        }

        private void button_callout_resize_columns_Click(object sender, EventArgs e)
        {
            datagridview_callout.AutoResizeColumns();
        }
    }
}
