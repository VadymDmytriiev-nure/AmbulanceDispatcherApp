using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbulanceDispatcherApp.Forms;
using AmbulanceDispatcherApp.Forms.Brigade;
using AmbulanceDispatcherApp.Forms.Workers;
using AmbulanceDispatcherApp.Forms.Patient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using AmbulanceDispatcherApp.Forms.Hospital;
using AmbulanceDispatcherApp.Forms.Departures;

namespace AmbulanceDispatcherApp
{
    public partial class DispatcherMainForm : Form
    {
        CreateCallForm createCallForm = null;
        EditCallForm editCallForm = null;
        ViewCallForm viewCallForm = null;
        PatientsForm patientsForm = null;
        DeparturesForm departuresForm = null;
        WorkersForm workersForm = null;
        HospitalsForm hospitalsForm = null;
        SubstationsForm substationsForm = null;
        BrigadesForm brigadesForm = null;

        CallFilters callFilters = new CallFilters();
        CalloutFilters calloutFilters = new CalloutFilters();

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
            label_authorized_as.Text = $"Ви авторизовані як:\n{Program.SqlLogin}";
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
            if (datagridview_call.SelectedRows.Count == 0)
                return;

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
            if (datagridview_call.SelectedRows.Count == 0)
                return;

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
            if (datagridview_call.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_call.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення дзвінку о {row_data!["call_time_created"]} по привіду {row_data!["call_reason"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `call` WHERE `call_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["call_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити даний дзвінок. Скоріш за все, дані цього дзвінку ще використовуються.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.SyncTableCall();
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

        private void button_call_filters_Click(object sender, EventArgs e)
        {
            CallFiltersForm callFiltersForm = new CallFiltersForm(callFilters);
            if (callFiltersForm.ShowDialog() == DialogResult.OK)
            {
                callFilters = callFiltersForm.Filters;
                MySqlCommand command = callFilters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredCallAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredCallAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredCallTable = new DataTable();
                Program.SqlFilteredCallAdapter.Fill(Program.SqlFilteredCallTable);
                datagridview_call.DataSource = Program.SqlFilteredCallTable;
                datagridview_call.Sort(column_call_time_created, ListSortDirection.Descending);
            }
        }

        private void button_call_filters_reset_Click(object sender, EventArgs e)
        {
            callFilters = new CallFilters();

            datagridview_call.DataSource = Program.SqlCallTable;
        }

        private void checkbox_call_resize_columns_CheckedChanged(object sender, EventArgs e)
        {
            datagridview_call.AutoSizeColumnsMode = checkbox_call_resize_columns.Checked ? DataGridViewAutoSizeColumnsMode.AllCells : DataGridViewAutoSizeColumnsMode.None;
            datagridview_call.AutoResizeColumns();
        }

        private void checkbox_callout_resize_columns_CheckedChanged(object sender, EventArgs e)
        {
            datagridview_callout.AutoSizeColumnsMode = checkbox_callout_resize_columns.Checked ? DataGridViewAutoSizeColumnsMode.AllCells : DataGridViewAutoSizeColumnsMode.None;
            datagridview_callout.AutoResizeColumns();
        }

        private void button_view_patients_Click(object sender, EventArgs e)
        {
            if (patientsForm == null || patientsForm.IsDisposed)
            {
                patientsForm = new PatientsForm(false);
                patientsForm.Show();
            }
            else
                patientsForm.Focus();
        }

        private void button_view_departures_Click(object sender, EventArgs e)
        {
            if (departuresForm == null || departuresForm.IsDisposed)
            {
                departuresForm = new DeparturesForm(Program.SqlRole != "Адміністратор" && Program.SqlRole != "Диспетчер");
                departuresForm.Show();
            }
            else
                departuresForm.Focus();
        }

        private void button_view_hospitals_Click(object sender, EventArgs e)
        {
            if (hospitalsForm == null || hospitalsForm.IsDisposed)
            {
                hospitalsForm = new HospitalsForm(false);
                hospitalsForm.Show();
            }
            else
                hospitalsForm.Focus();
        }

        private void button_view_workers_Click(object sender, EventArgs e)
        {
            if (workersForm == null || workersForm.IsDisposed)
            {
                workersForm = new WorkersForm(Program.SqlRole != "Адміністратор");
                workersForm.Show();
            }
            else
                workersForm.Focus();
        }

        private void button_view_brigades_Click(object sender, EventArgs e)
        {
            if (brigadesForm == null || brigadesForm.IsDisposed)
            {
                brigadesForm = new BrigadesForm(Program.SqlRole != "Адміністратор");
                brigadesForm.Show();
            }
            else
                brigadesForm.Focus();
        }

        private void button_view_substations_Click(object sender, EventArgs e)
        {
            if (substationsForm == null || substationsForm.IsDisposed)
            {
                substationsForm = new SubstationsForm(Program.SqlRole != "Адміністратор");
                substationsForm.Show();
            }
            else
                substationsForm.Focus();
        }

        private void button_callout_view_Click(object sender, EventArgs e)
        {
            CreateEditViewCalloutForm f = new CreateEditViewCalloutForm(CreateEditViewCalloutFormMode.View, (datagridview_callout.SelectedRows[0].DataBoundItem as DataRowView)!);
            f.Show();
        }

        private void button_callout_create_Click(object sender, EventArgs e)
        {
            CreateEditViewCalloutForm f = new CreateEditViewCalloutForm(CreateEditViewCalloutFormMode.Create);
            f.Show();
        }

        private void button_callout_edit_Click(object sender, EventArgs e)
        {
            CreateEditViewCalloutForm f = new CreateEditViewCalloutForm(CreateEditViewCalloutFormMode.Edit, (datagridview_callout.SelectedRows[0].DataBoundItem as DataRowView)!);
            f.Show();
        }

        private void button_callout_delete_Click(object sender, EventArgs e)
        {
            if (datagridview_callout.SelectedRows.Count == 0)
                return;

            var row_data = datagridview_callout.SelectedRows[0].DataBoundItem as DataRowView;

            if (MessageBox.Show($"Підтвердити видалення виклику о {row_data!["callout_time_created"]} по привіду {row_data!["callout_reason"]}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `callout` WHERE `callout_id` = @id", Program.SqlConnection);
                cmd.Parameters.AddWithValue("@id", row_data!["callout_id"] as int?);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не вдалося видалити даний виклик. Скоріш за все, дані цього виклику ще використовуються в ішному місці.", "Помилка видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.SyncTableCallout();
            }
        }

        private void button_callout_filters_reset_Click(object sender, EventArgs e)
        {
            calloutFilters = new CalloutFilters();

            datagridview_callout.DataSource = Program.SqlCalloutTable;
        }

        private void button_callout_filters_Click(object sender, EventArgs e)
        {
            CalloutFiltersForm calloutFiltersForm = new CalloutFiltersForm(calloutFilters);
            if (calloutFiltersForm.ShowDialog() == DialogResult.OK)
            {
                calloutFilters = calloutFiltersForm.Filters;
                MySqlCommand command = calloutFilters.GetSQLCommand(Program.SqlConnection);
                Program.SqlFilteredCalloutAdapter = new MySqlDataAdapter(command);
                Program.SqlFilteredCalloutAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.SqlFilteredCalloutTable = new DataTable();
                Program.SqlFilteredCalloutAdapter.Fill(Program.SqlFilteredCalloutTable);
                datagridview_callout.DataSource = Program.SqlFilteredCalloutTable;
                datagridview_callout.Sort(column_callout_time_created, ListSortDirection.Descending);
            }
        }
    }
}
