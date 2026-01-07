using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceDispatcherApp.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            textbox_sql_host.Text = Program.SQL_HOST;
            spin_sql_port.Value = Program.SQL_PORT;
            textbox_sql_database.Text = Program.SQL_DATABASE;
            spin_max_rows.Value = Program.SQL_MAX_ROWS;
            spin_max_rows_filtered.Value = Program.SQL_MAX_ROWS_FILTERED;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Program.SQL_HOST = textbox_sql_host.Text;
            Program.SQL_PORT = (ushort)spin_sql_port.Value;
            Program.SQL_DATABASE = textbox_sql_database.Text;
            Program.SQL_MAX_ROWS = (uint)spin_max_rows.Value;
            Program.SQL_MAX_ROWS_FILTERED = (uint)spin_max_rows_filtered.Value;
            if (!Program.SaveSettings())
                MessageBox.Show("Не вдалося зберегти дані налаштування");

            DialogResult = DialogResult.OK;
        }
    }
}
