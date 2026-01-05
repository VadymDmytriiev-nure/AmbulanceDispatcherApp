using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms
{
    public enum CreateEditViewCallFormMode
    {
        View = 0,
        Create = 1,
        Edit = 2
    }

    public partial class CreateEditViewCallForm : Form
    {
        CreateEditViewCallFormMode mode;
        DataRowView? callout;

        public CreateEditViewCallForm(CreateEditViewCallFormMode mode = CreateEditViewCallFormMode.View, DataRowView? callout = null)
        {
            InitializeComponent();

            this.mode = mode;

            if (mode == CreateEditViewCallFormMode.Edit)
            {
                this.callout = callout;
                Text = $"Редагування виклику №{callout!["callout_id"]}";

                textbox_address.Text = callout!["callout_address"] as string;
                textbox_reason.Text = callout!["callout_reason"] as string;
                textbox_comment.Text = callout!["callout_comment"] as string;
                datetime_time_created.Value = (DateTime)callout!["callout_time_created"];
                checkbox_canceled.Checked = (bool?)callout!["callout_canceled"] ?? false;
            }
            else if (mode == CreateEditViewCallFormMode.Create)
            {
                Text = "Створення виклику";
                datetime_time_created.Value = DateTime.Now;
            }
            else
            {
                Text = $"Виклик №{callout!["callout_id"]}";
                textbox_address.ReadOnly = true;
                textbox_reason.ReadOnly = true;
                textbox_comment.ReadOnly = true;
                datetime_time_created.Enabled = false;
                checkbox_canceled.Enabled = false;

                textbox_address.Text = callout!["callout_address"] as string;
                textbox_reason.Text = callout!["callout_reason"] as string;
                textbox_comment.Text = callout!["callout_comment"] as string;
                datetime_time_created.Value = (DateTime)callout!["callout_time_created"];
                checkbox_canceled.Checked = (bool?)callout!["callout_canceled"] ?? false;

                button_ok.Visible = true;
                button_cancel.Visible = false;
                button_save.Visible = false;
            }
                
        }

        private void checkbox_canceled_CheckedChanged(object sender, EventArgs e) => checkbox_canceled.Text = checkbox_canceled.Checked ? "Так" : "Ні";

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textbox_address.Text.Trim() == "")
            {
                MessageBox.Show("Адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_reason.Text.Trim() == "")
            {
                MessageBox.Show("Привід не може бути порожнім", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mode == CreateEditViewCallFormMode.Edit)
            {
                var command = new MySqlCommand(
                    "UPDATE `callout` SET " +
                    "`callout_address` = @addy, " +
                    "`callout_reason` = @rs, " +
                    "`callout_comment` = @cm, " +
                    "`callout_time_created` = @ctc, " +
                    "`callout_canceled` = @can " +
                    "WHERE `callout_id` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@addy", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@rs", textbox_reason.Text.Trim());
                command.Parameters.AddWithValue("@cm", textbox_comment.Text.Trim());
                command.Parameters.AddWithValue("@ctc", datetime_time_created.Value);
                command.Parameters.AddWithValue("@can", checkbox_canceled.Checked);
                command.Parameters.AddWithValue("@id", (int)callout!["callout_id"]);

                command.ExecuteNonQuery();
            }
            else if (mode == CreateEditViewCallFormMode.Create)
            {
                var command = new MySqlCommand(
                    "INSERT INTO `callout` " +
                    "(`callout_address`,`callout_reason`,`callout_comment`,`callout_time_created`,`callout_canceled`) " +
                    "VALUES (@addy,@rs,@cm,@ctc,@can)",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@addy", textbox_address.Text.Trim());
                command.Parameters.AddWithValue("@rs", textbox_reason.Text.Trim());
                command.Parameters.AddWithValue("@cm", textbox_comment.Text.Trim());
                command.Parameters.AddWithValue("@ctc", datetime_time_created.Value);
                command.Parameters.AddWithValue("@can", checkbox_canceled.Checked);

                command.ExecuteNonQuery();
            }

            Program.SyncTableCallout();
            Close();
        }
    }
}
