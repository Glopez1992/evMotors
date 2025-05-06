using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormEVMotors
{
    public partial class FormSearch : Form
    {
        string[] operatorsArray = { "=", ">", "<", "<=", ">=" };
        string[] fields = { "VehicleRegNo", "Make", "EngineSize", "DateRegistered",
                "RentalPerDay", "Available" };
        private string connectionString = "Server=KYLEPC\\SQLEXPRESS;Database=EvMotorsDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection connection = null;
        private SqlDataReader reader = null;
        private DataTable dataTable = null;
        public FormSearch()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtVehicleRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAvailable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            var selectedOperator = comboBoxOperator.Text;
            var selectedField = comboBoxField.Text;
            var selectedValue = comboBoxValue.Text;

            if (selectedOperator == "" || selectedField == "" || selectedValue == "")
            {
                MessageBox.Show("Inputs cannot be empty.");
                return;
            }
            else
            {

                using (connection = new SqlConnection(connectionString))
                {


                    connection.Open();
                    string query = $"SELECT * FROM VehicleRegister WHERE [{selectedField}] {selectedOperator} @value";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!operatorsArray.Contains(selectedOperator))
                        {
                            MessageBox.Show("Please select a valid operator.");
                            return;
                        }
                        if (!fields.Contains(selectedField))
                        {
                            MessageBox.Show("Please select a valid field.");
                            return;
                        }
                        if (selectedField == "DateRegistered") // or whatever your field is called
                        {
                            DateTime parsedDate;
                            if (!DateTime.TryParse(selectedValue, out parsedDate))
                            {
                                MessageBox.Show("Please enter a valid date in the format DD/MM/YYYY", "Invalid Date");
                                return;
                            }

                            command.Parameters.AddWithValue("@value", parsedDate);
                        }

                        else if (selectedField == "Available")

                        {
                            if (selectedValue.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase))
                                selectedValue = "1";
                            else if (selectedValue.Trim().Equals("No", StringComparison.OrdinalIgnoreCase))
                                selectedValue = "0";
                            else
                            {
                                MessageBox.Show("Please enter 'Yes' or 'No' for availability.", "Input Error");
                                return;
                            }

                            // Add parameter as BIT (Boolean)
                            command.Parameters.AddWithValue("@value", selectedValue == "1");

                        }

                        else if (selectedField == "RentalPerDay")
                        {
                            decimal rentalPerDay; 
                            if (!decimal.TryParse(comboBoxValue.Text, out rentalPerDay))
                            {
                                MessageBox.Show("Rental Per Day must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                                command.Parameters.AddWithValue("@value", rentalPerDay);
                        }
                        else
                        {
                            // For all other fields, add parameter normally
                            command.Parameters.AddWithValue("@value", selectedValue);
                        }

                      







                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataTable results = new DataTable();
                            adapter.Fill(results); // Fills the DataTable with SQL results

                            dataGridView.DataSource = null;
                            dataGridView.Columns.Clear();

                            dataGridView.DataSource = results;

                        }// end Using SQL Command - command closes
                    }
                }




            }

           
        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            this.Text = $"EvMotors - {DateTime.Now:dd/MM/yyyy}";
            this.AcceptButton = btnSearchForm;
            this.ActiveControl = lblSearch;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxField.ResetText();
            comboBoxOperator.ResetText();
           
        }

        private void LoadComboBoxes()
        {
            
            
            comboBoxField.Items.AddRange(fields);
            comboBoxOperator.Items.AddRange(operatorsArray);
        }
    }
}
