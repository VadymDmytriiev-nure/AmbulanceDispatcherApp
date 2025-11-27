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
    public partial class Calls : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public Calls(MySqlConnection conn, string query)
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
    }
}
