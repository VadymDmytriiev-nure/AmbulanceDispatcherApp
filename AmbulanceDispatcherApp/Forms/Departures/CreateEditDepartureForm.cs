using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AmbulanceDispatcherApp.Forms.Departures
{
    public partial class CreateEditDepartureForm : Form
    {
        DataRowView? departure;
        bool isEdit;

        public CreateEditDepartureForm(bool edit, DataRowView? departure)
        {
            InitializeComponent();

            spin_callout.Text = "";

            isEdit = edit;

            if (edit)
            {
                this.departure = departure;
                Text = "Редагування виїзду";

                textbox_from_address.Text = departure!["departure_from_address"] as string;
                textbox_to_address.Text = departure!["departure_to_address"] as string;
                spin_mileage.Value = (departure!["departure_mileage_km"] as decimal?)!.Value;
                spin_callout.Value = (departure!["callout_id"] as int?)!.Value;
                datetime_departed.Value = (DateTime)departure!["departure_time_departed"];
                datetime_arrived.Value = (DateTime)departure!["departure_time_arrived"];
            }
            else
            {
                Text = "Створення виїзду";
                datetime_departed.Value = DateTime.Now;
                datetime_arrived.Value = DateTime.Now;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Program.SqlCalloutTable.Rows.Contains(spin_callout.Value) || spin_callout.Value == 0)
            {
                MessageBox.Show("Обраного виклику не існує", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_from_address.Text.Trim() == "")
            {
                MessageBox.Show("Початкова адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textbox_to_address.Text.Trim() == "")
            {
                MessageBox.Show("Кінцева адреса не може бути порожньою", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (spin_mileage.Value < 0)
            {
                MessageBox.Show("Кілометраж не може бути від'ємним", "Помилка форматування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEdit)
            {
                var command = new MySqlCommand(
                    "UPDATE `departure` SET " +
                    "`departure_from_address` = @from_addy, " +
                    "`departure_to_address` = @to_addy, " +
                    "`departure_mileage_km` = @km, " +
                    "`departure_time_departed` = @dtd, " +
                    "`departure_time_arrived` = @dta, " +
                    "`callout_id` = @callout " +
                    "WHERE `departure` = @id",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@from_addy", textbox_from_address.Text.Trim());
                command.Parameters.AddWithValue("@to_addy", textbox_to_address.Text.Trim());
                command.Parameters.AddWithValue("@km", spin_mileage.Value);
                command.Parameters.AddWithValue("@dtd", datetime_departed.Value);
                command.Parameters.AddWithValue("@dta", datetime_arrived.Value);
                command.Parameters.AddWithValue("@callout", (int)spin_callout.Value);
                command.Parameters.AddWithValue("@id", (int)departure!["departure_id"]);

                command.ExecuteNonQuery();
            }
            else
            {
                var command = new MySqlCommand(
                    "INSERT INTO `departure` " +
                    "(`departure_from_address`,`departure_to_address`,`departure_mileage_km`,`departure_time_departed`,`departure_time_arrived`,`callout_id`) " +
                    "VALUES (@from_addy,@to_addy,@km,@dtd,@dta,@callout)",
                    Program.SqlConnection);

                command.Parameters.AddWithValue("@from_addy", textbox_from_address.Text.Trim());
                command.Parameters.AddWithValue("@to_addy", textbox_to_address.Text.Trim());
                command.Parameters.AddWithValue("@km", spin_mileage.Value);
                command.Parameters.AddWithValue("@dtd", datetime_departed.Value);
                command.Parameters.AddWithValue("@dta", datetime_arrived.Value);
                command.Parameters.AddWithValue("@callout", (int)spin_callout.Value);

                command.ExecuteNonQuery();
            }

            Program.SyncTableDeparture();
            Close();
        }
    }
}
