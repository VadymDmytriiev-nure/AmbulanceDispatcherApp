using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp
{
    public partial class ViewCallForm : Form
    {
        MySqlConnection conn;
        DataTable calls;
        DataTable dispatchers;
        DataTable callouts;
        DataRowView call;

        DataTable patientsTable = new DataTable();
        MySqlDataAdapter patientsAdapter;

        public bool IsClosed = false;

        public ViewCallForm(DataRowView call)
        {
            InitializeComponent();

            this.call = call;

            this.conn = Program.SqlConnection;
            this.calls = Program.SqlCallTable;
            this.dispatchers = Program.SqlDispatcherTable;
            this.callouts = Program.SqlCalloutTable;

            textbox_address.Text = call["call_address"] as string;
            textbox_reason.Text = call["call_reason"] as string;
            textbox_fullname.Text = $"{call["call_caller_surname"]} {call["call_caller_name"]} {call["call_caller_patriarchic"]}".Trim();
            textbox_tel.Text = call["call_caller_tel"] as string;
            textbox_channel.Text = call["call_channel"] as string;
            object callout_id = call["callout_id"];
            if (callout_id != DBNull.Value)
                textbox_callout.Text = (callout_id as int?).ToString();
            else
                textbox_callout.Text = "";

            textbox_dispatcher.Text = Convert.ToDateTime(call["call_time_created"]).ToString("yyyy-MM-dd HH:mm:ss");
            textbox_dispatcher.Text = call["dispatcher_fullname"].ToString();

            this.Text = $"Дзвінок №{call["call_id"]}";

            datagridview_patient.AutoGenerateColumns = false;
            patientsAdapter = new MySqlDataAdapter(new MySqlCommand($"SELECT `patient`.*, CONCAT(`patient`.patient_surname, ' ', `patient`.patient_name, ' ', `patient`.patient_patriarchic) AS patient_fullname, `patientcall`.`call_id` FROM `patient` INNER JOIN `patientcall` ON `patient`.`patient_id` = `patientcall`.`patient_id` WHERE `call_id` = {call!["call_id"] as int?} LIMIT {Program.SQL_MAX_ROWS_FILTERED}", Program.SqlConnection));
            patientsAdapter.Fill(patientsTable);
            patientsTable.PrimaryKey = new DataColumn[] { patientsTable.Columns["patient_id"]!, patientsTable.Columns["call_id"]! };
            datagridview_patient.DataSource = patientsTable;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCallForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }
    }
}
