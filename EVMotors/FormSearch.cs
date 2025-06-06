
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
using static FormEVMotors.DataAccess;



namespace FormEVMotors
{
    public partial class FormSearch : Form
    {
        string[] operatorsArray = { "=", ">", "<", "<=", ">=" };
        string[] fields = { "VehicleRegNo", "Make", "EngineSize_Power", "DateRegistered",
                "RentalPerDay", "Available" };

        private SqlConnection connection;
        private SqlDataReader reader;
        private DataTable dataTable;
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
            var selectedValue = txtValue.Text;

            // Validate that none of the inputs are empty
            if (selectedOperator == "" || selectedField == "" || selectedValue == "")
            {
                MessageBox.Show("Inputs cannot be empty.");
                return;
            }

            // Validate operator is in allowed list
            if (!operatorsArray.Contains(selectedOperator))
            {
                MessageBox.Show("Please select a valid operator.");
                return;
            }

            // Validate field is in allowed list
            if (!fields.Contains(selectedField))
            {
                MessageBox.Show("Please select a valid field.");
                return;
            }

            // Build the query dynamically with the selected field and operator
            string query = $"SELECT * FROM VehicleRegister WHERE [{selectedField}] {selectedOperator} @value";
            SqlParameter[] parameters;

            // Handle DateRegistered field specifically, parsing the input to DateTime
            if (selectedField == "DateRegistered")
            {
                DateTime parsedDate;
                if (!DateTime.TryParse(selectedValue, out parsedDate))
                {
                    MessageBox.Show("Please enter a valid date in the format DD/MM/YYYY", "Invalid Date");
                    return;
                }
                parameters = new[] { new SqlParameter("@value", parsedDate) };
            }
            // Handle Available field, converting Yes/No to boolean
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

                parameters = new[] { new SqlParameter("@value", selectedValue == "1") };
            }
            // Handle RentalPerDay field, parsing to decimal
            else if (selectedField == "RentalPerDay")
            {
                decimal rentalPerDay;
                if (!decimal.TryParse(txtValue.Text, out rentalPerDay))
                {
                    MessageBox.Show("Rental Per Day must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                parameters = new[] { new SqlParameter("@value", rentalPerDay) };
            }
            // Handle all other fields normally
            else
            {
                parameters = new[] { new SqlParameter("@value", selectedValue) };
            }

            // Execute the search query using the centralized DataAccess method
            DataTable results = DataAccess.SearchVehicles(query, parameters);

            // Clear previous data and show new search results in the DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = results;
        }

        private void lblMake_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            comboBoxField.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Text = "Search";
            this.AcceptButton = btnSearchForm;
            this.ActiveControl = lblSearch;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxField.SelectedIndex = -1;
            comboBoxOperator.SelectedIndex = -1;
            txtValue.ResetText();

        }

        private void btnSearchExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadComboBoxes()
        {
            comboBoxField.Items.AddRange(fields);
            comboBoxOperator.Items.AddRange(operatorsArray);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
