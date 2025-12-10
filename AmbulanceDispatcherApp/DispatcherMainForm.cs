using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace AmbulanceDispatcherApp
{
    public partial class DispatcherMainForm : Form
    {
        CreateCallForm createCallForm = null;
        EditCallForm editCallForm = null;
        ViewCallForm viewCallForm = null;

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

        private void button_call_resize_columns_Click(object sender, EventArgs e)
        {
            datagridview_call.AutoResizeColumns();
        }

        private void button_callout_resize_columns_Click(object sender, EventArgs e)
        {
            datagridview_callout.AutoResizeColumns();
        }

        private void button_call_view_Click(object sender, EventArgs e)
        {
            viewCallForm = new ViewCallForm((datagridview_call.SelectedRows[0].DataBoundItem as DataRowView)!);
            viewCallForm.Show();
        }

        private void button_call_create_Click(object sender, EventArgs e)
        {
            if (createCallForm == null || createCallForm.IsDisposed || createCallForm.IsClosed)
            {
                createCallForm = new CreateCallForm();
                createCallForm.Show();
            }
            else
                createCallForm.Focus();
        }

        private void button_call_edit_Click(object sender, EventArgs e)
        {
            if (editCallForm == null || editCallForm.IsDisposed || editCallForm.IsClosed)
            {
                editCallForm = new EditCallForm((datagridview_call.SelectedRows[0].DataBoundItem as DataRowView)!);
                editCallForm.Show();
            }
            else
                editCallForm.Focus();
        }

        private void button_call_delete_Click(object sender, EventArgs e)
        {
            var row_data = datagridview_call.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення дзвінку о {row_data!["call_time_created"]} по привіду {row_data!["call_reason"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                row_data!.Delete();
                Program.SyncWithRemote();
            }
        }

        private void datagridview_callout_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridview_callout.SelectedRows.Count == 0)
            {
                button_callout_view.Enabled = false;
                button_callout_edit.Enabled = false;
                button_callout_delete.Enabled = false;
                return;
            }
            else
            {
                button_callout_view.Enabled = true;
                button_callout_edit.Enabled = true;
                button_callout_delete.Enabled = true;
            }

            if (createCallForm != null && !createCallForm.IsDisposed && !createCallForm.IsClosed)
            {
                var selectedValue = (decimal)((datagridview_callout.SelectedRows[0].DataBoundItem as DataRowView)!["callout_id"] as int?)!;
                createCallForm.spin_callout.Value = selectedValue;
            }
            if (editCallForm != null && !editCallForm.IsDisposed && !editCallForm.IsClosed)
            {
                var selectedValue = (decimal)((datagridview_callout.SelectedRows[0].DataBoundItem as DataRowView)!["callout_id"] as int?)!;
                editCallForm.spin_callout.Value = selectedValue;
            }
        }

        private void datagridview_call_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridview_call.SelectedRows.Count == 0)
            {
                button_call_view.Enabled = false;
                button_call_edit.Enabled = false;
                button_call_delete.Enabled = false;
            }
            else
            {
                button_call_view.Enabled = true;
                button_call_edit.Enabled = true;
                button_call_delete.Enabled = true;
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
        }

        private void timer_auto_refresh_Tick(object sender, EventArgs e)
        {
            Program.SyncWithRemote();
        }

        private void checkbox_autoupdate_CheckedChanged(object sender, EventArgs e)
        {
            timer_auto_refresh.Enabled = checkbox_autoupdate.Checked;
        }

        private void button_call_filters_Click(object sender, EventArgs e)
        {

        }

        private void button_call_filters_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
