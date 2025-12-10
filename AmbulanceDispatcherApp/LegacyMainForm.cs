using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;

namespace AmbulanceDispatcherApp
{
    public partial class LegacyMainForm : Form
    {
        const string CONNECTION_STRING = "Server=127.0.0.1;DATABASE=emergencyhealthcare;User ID=dispatcher;Password=dispatcher_password";
        MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);

        MySqlDataAdapter adapter_callout;
        DataTable table_callout = new DataTable();

        MySqlDataAdapter adapter_call;
        DataTable table_call = new DataTable();

        MySqlDataAdapter adapter_dispatcher;
        DataTable table_dispatcher = new DataTable();

        CreateCallForm createCallForm;
        EditCallForm editCallForm;

        public LegacyMainForm()
        {
            InitializeComponent();

            datagrid_callout.AutoGenerateColumns = false;
            datagrid_call.AutoGenerateColumns = false;
            datagrid_dispatcher.AutoGenerateColumns = false;

            if (LoadDataFromDatabase())
                MessageBox.Show("Не вийшло отримати інформацію з бази даних. Перевірте налаштування системи");
        }

        public bool LoadDataFromDatabase()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                return true;
            }

            // Callout
            MySqlCommand cmd_callout_select = new MySqlCommand("SELECT * FROM `callout`", conn);
            adapter_callout = new MySqlDataAdapter(cmd_callout_select);
            adapter_callout.Fill(table_callout);
            datagrid_callout.DataSource = table_callout;

            // Dispatcher
            MySqlCommand cmd_dispatcher_select = new MySqlCommand("SELECT * FROM `dispatcher`", conn);
            adapter_dispatcher = new MySqlDataAdapter(cmd_dispatcher_select);
            adapter_dispatcher.Fill(table_dispatcher);
            datagrid_dispatcher.DataSource = table_dispatcher;

            table_dispatcher.Columns.Add(
                                    "dispatcher_fullname",
                                    typeof(string),
                                    "dispatcher_surname + ' ' + dispatcher_name + ' ' + dispatcher_patriarchic");

            // Call
            MySqlCommand cmd_call_select = new MySqlCommand("SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id", conn);
            adapter_call = new MySqlDataAdapter(cmd_call_select);
            adapter_call.Fill(table_call);
            datagrid_call.DataSource = table_call;

            MySqlCommandBuilder b1 = new MySqlCommandBuilder(adapter_call);
            MySqlCommandBuilder b2 = new MySqlCommandBuilder(adapter_callout);
            MySqlCommandBuilder b3 = new MySqlCommandBuilder(adapter_dispatcher);

            b1.ConflictOption = ConflictOption.OverwriteChanges;
            b2.ConflictOption = ConflictOption.OverwriteChanges;
            b3.ConflictOption = ConflictOption.OverwriteChanges;

            table_callout.PrimaryKey = new DataColumn[] { table_callout.Columns["callout_id"]! };
            table_call.PrimaryKey = new DataColumn[] { table_call.Columns["call_id"]! };
            table_dispatcher.PrimaryKey = new DataColumn[] { table_dispatcher.Columns["dispatcher_id"]! };

            table_callout.Columns["callout_id"]!.AllowDBNull = true;
            table_call.Columns["call_id"]!.AllowDBNull = true;
            table_dispatcher.Columns["dispatcher_id"]!.AllowDBNull = true;

            datagrid_call.Sort(datagrid_call.Columns[0], System.ComponentModel.ListSortDirection.Descending);

            return false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                adapter_call.Update(table_call);
                adapter_callout.Update(table_callout);
                adapter_dispatcher.Update(table_dispatcher);

                table_callout.Clear();
                table_call.Clear();
                table_dispatcher.Clear();

                adapter_callout.Fill(table_callout);
                adapter_dispatcher.Fill(table_dispatcher);
                adapter_call.Fill(table_call);
            }
            catch
            {
                MessageBox.Show("Не вдалося зберегти зміни! Скоріш за все у вас помилка у форматі даних.");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab_callout || tabControl1.SelectedTab == tab_dispatcher)
            {
                button_view_dispatcher.Enabled = false;
                button_view_callout.Enabled = false;
            }
            else if (tabControl1.SelectedTab == tab_call)
            {
                button_view_dispatcher.Enabled = true;
                button_view_callout.Enabled = true;
            }
        }

        private void button_view_callout_Click(object sender, EventArgs e)
        {
            DataRowView o = (datagrid_call.SelectedRows[0].DataBoundItem as DataRowView)!;
            int? callout_id = o["callout_id"] as int?;

            var row = datagrid_callout.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => ((r.DataBoundItem as DataRowView)?["callout_id"] as int?) == callout_id);

            if (row == null || row.DataBoundItem == null)
            {
                MessageBox.Show("Не знайдено");
                return;
            }

            datagrid_callout.ClearSelection();
            row!.Selected = true;
            tabControl1.SelectedTab = tab_callout;
        }

        private void button_view_dispatcher_Click(object sender, EventArgs e)
        {
            DataRowView o = (datagrid_call.SelectedRows[0].DataBoundItem as DataRowView)!;
            int? dispatcher_id = o["dispatcher_id"] as int?;

            DataGridViewRow? row = datagrid_dispatcher.Rows
                        .Cast<DataGridViewRow>()
                        .FirstOrDefault(r => ((r.DataBoundItem as DataRowView)?["dispatcher_id"] as int?) == dispatcher_id);

            if (row == null || row.DataBoundItem == null)
            {
                MessageBox.Show("Не знайдено");
                return;
            }

            datagrid_dispatcher.ClearSelection();
            row!.Selected = true;
            tabControl1.SelectedTab = tab_dispatcher;
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryEditForm qe = new QueryEditForm(conn);
            qe.Show();
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createCallForm = new CreateCallForm();
            createCallForm.Show();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = datagrid_call.SelectedRows.Count == 0 ? null : datagrid_call.SelectedRows[0];
            if (tabControl1.SelectedTab != tab_call || row == null)
            {
                MessageBox.Show("У вас не виділено жодного дзвінку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editCallForm = new EditCallForm((row.DataBoundItem as DataRowView)!);
            editCallForm.Show();
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
            редагуватиToolStripMenuItem_Click(sender, e);
        }

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallFiltersForm sff = new CallFiltersForm(table_dispatcher);
            if (sff.ShowDialog() == DialogResult.OK)
            {
                List<string> filters = new List<string>();

                if (sff.Address != null)
                    filters.Add("`call`.call_address LIKE @address");

                if (sff.Channel != null)
                    filters.Add("`call`.call_channel LIKE @channel");

                if (sff.Reason != null)
                    filters.Add("`call`.call_reason LIKE @reason");

                if (sff.CallerSurname != null)
                    filters.Add("`call`.call_caller_surname LIKE @surname");

                if (sff.CallerName != null)
                    filters.Add("`call`.call_caller_name LIKE @name");

                if (sff.CallerPatriarchic != null)
                    filters.Add("`call`.call_caller_patriarchic LIKE @patriarchic");

                if (sff.CallerTel != null)
                    filters.Add("`call`.call_caller_tel = @tel");

                if (sff.DispatcherID != null)
                    filters.Add("`call`.dispatcher_id = @dispatcher");

                var CalloutIDRange = sff.CalloutIDRange;
                if (CalloutIDRange.Min != null)
                    filters.Add("`call`.callout_id >= @callout_min");

                if (CalloutIDRange.Max != null)
                    filters.Add("`call`.callout_id <= @callout_max");

                var TimeRange = sff.TimeRange;
                filters.Add("`call`.call_time_created >= @time_from");
                filters.Add("`call`.call_time_created <= @time_to");

                string filter = "WHERE " + String.Join(" AND ", filters);

                MySqlCommand cmd = new MySqlCommand("SELECT `call`.*, CONCAT(`dispatcher`.dispatcher_surname, ' ', `dispatcher`.dispatcher_name, ' ', `dispatcher`.dispatcher_patriarchic) AS dispatcher_fullname FROM `call` INNER JOIN `dispatcher` ON `call`.dispatcher_id = `dispatcher`.dispatcher_id " + filter, conn);
                cmd.Parameters.AddWithValue("@address", "%" + sff.Address + "%");
                cmd.Parameters.AddWithValue("@channel", "%" + sff.Channel + "%");
                cmd.Parameters.AddWithValue("@reason", "%" + sff.Reason + "%");
                cmd.Parameters.AddWithValue("@surname", "%" + sff.CallerSurname + "%");
                cmd.Parameters.AddWithValue("@name", "%" + sff.CallerName + "%");
                cmd.Parameters.AddWithValue("@patriarchic", "%" + sff.CallerPatriarchic + "%");
                cmd.Parameters.AddWithValue("@tel", sff.CallerTel);
                cmd.Parameters.AddWithValue("@dispatcher", sff.DispatcherID);
                cmd.Parameters.AddWithValue("@callout_min", CalloutIDRange.Min);
                cmd.Parameters.AddWithValue("@callout_max", CalloutIDRange.Max);
                cmd.Parameters.AddWithValue("@time_from", TimeRange.Min);
                cmd.Parameters.AddWithValue("@time_to", TimeRange.Max);

                CallsForm cf = new CallsForm(conn, cmd, table_call, table_callout, table_dispatcher);
                cf.ShowDialog();
            }
        }

        private void datagrid_callout_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid_callout.SelectedRows.Count == 0)
                return;

            if (createCallForm != null && !createCallForm.IsClosed)
            {
                var selectedValue = (decimal)((datagrid_callout.SelectedRows[0].DataBoundItem as DataRowView)!["callout_id"] as int?)!;
                createCallForm.spin_callout.Value = selectedValue;
            }
            if (editCallForm != null && !editCallForm.IsClosed)
            {
                var selectedValue = (decimal)((datagrid_callout.SelectedRows[0].DataBoundItem as DataRowView)!["callout_id"] as int?)!;
                editCallForm.spin_callout.Value = selectedValue;
            }
        }

        private void datagrid_dispatcher_SelectionChanged(object sender, EventArgs e)
        {
            if (datagrid_dispatcher.SelectedRows.Count == 0)
                return;

            if (createCallForm != null && !createCallForm.IsClosed)
            {
                var selectedValue = ((datagrid_dispatcher.SelectedRows[0].DataBoundItem as DataRowView)!["dispatcher_id"] as int?)!;
                createCallForm.combo_dispatcher.SelectedValue = selectedValue;
            }
            if (editCallForm != null && !editCallForm.IsClosed)
            {
                var selectedValue = ((datagrid_dispatcher.SelectedRows[0].DataBoundItem as DataRowView)!["dispatcher_id"] as int?)!;
                editCallForm.combo_dispatcher.SelectedValue = selectedValue;
            }
        }
    }
}
