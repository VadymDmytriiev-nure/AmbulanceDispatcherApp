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
    public partial class QueryEditForm : Form
    {
        MySqlConnection conn;

        public QueryEditForm(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richtextbox.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_doSQL_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(richtextbox.Text, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            datagridview.DataSource = table;
        }
    }
}
