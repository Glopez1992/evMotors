using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace WinFormsApp1
{
    public partial class FormMain : Form
    {

        private string connectionString = "Server=KYLEPC\\SQLEXPRESS;Database=EvMotorsDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection connection = null;
        private SqlDataReader reader = null;
        private DataTable dataTable = null;
        private bool dataChanged = true;

        private int currentIndex = 0;


        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Connected to Database");
            DisplayRecord();
            cobMake.DropDownHeight = 300;

        }

        private void LoadData()
        {
            if (dataChanged == true)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM VehicleRegister";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayRecord()
        {

            txtVehicleRegNo.Text = dataTable.Rows[currentIndex]["VehicleRegNo"].ToString();
            cobMake.Text = dataTable.Rows[currentIndex]["Make"].ToString();
            txtEngineSize.Text = dataTable.Rows[currentIndex]["EngineSize"].ToString();
            dateTimePicker1.Text = dataTable.Rows[currentIndex]["DateRegistered"].ToString();
            txtRentalPerDay.Text = dataTable.Rows[currentIndex]["RentalPerDay"].ToString();
            chkAvailable.Checked = Convert.ToBoolean(dataTable.Rows[currentIndex]["Available"]);


            BtnPrevious.Enabled = currentIndex > 0;
            BtnFirst.Enabled = currentIndex > 0;
            BtnNext.Enabled = currentIndex < dataTable.Rows.Count - 1;
            this.Text = $"EvMotors - {DateTime.Now:dd/MM/yyyy}";
            int adjustedIndex = currentIndex + 1;
            lblRecordCount.Text = ($"{adjustedIndex.ToString()} of {dataTable.Rows.Count}");
            LoadCarMakes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataChanged = true;
            try
            {
                string vehicleRegNo = txtVehicleRegNo.Text;
                if (string.IsNullOrWhiteSpace(vehicleRegNo))
                {
                    MessageBox.Show("Vehicle Registration Number cannot be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehicleRegNo.Clear();
                    return;
                }
                if (vehicleRegNo.Length > 10) // Assuming 10 is the SQL limit
                {
                    MessageBox.Show("Vehicle Registration Number cannot exceed 10 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehicleRegNo.Clear();
                    return; // Stop execution if validation fails
                }

                string make = cobMake.Text;
                if (string.IsNullOrWhiteSpace(make))
                {
                    MessageBox.Show("Make is a required field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (make.Length > 50)
                {
                    MessageBox.Show("Make cannot exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string engineSize = txtEngineSize.Text;

                DateTime dateRegistered;
                if (!DateTime.TryParse(dateTimePicker1.Value.ToString(), out dateRegistered) || dateRegistered > DateTime.Now)
                {
                    MessageBox.Show("Date Registered must be a valid date and not in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal rentalPerDay;
                if (!decimal.TryParse(txtRentalPerDay.Text, out rentalPerDay))
                {
                    MessageBox.Show("Rental Per Day must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool available = chkAvailable.Checked;

                //Check if the vehicleRegNo already exists in the database

                try
                {
                    ValidateUniqueVehicleRegNo(vehicleRegNo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // create and open connection
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // create and execute SQL Command with parameters
                    string query = "INSERT INTO VehicleRegister (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available)"
                        + "VALUES (@VehicleRegNo,@Make, @EngineSize,@DateRegistered, @RentalPerDay, @Available)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //use parameters to add data
                        command.Parameters.AddWithValue("@VehicleRegNo", vehicleRegNo);
                        command.Parameters.AddWithValue("@Make", make);
                        command.Parameters.AddWithValue("@EngineSize", engineSize);
                        command.Parameters.AddWithValue("@DateRegistered", dateRegistered);
                        command.Parameters.AddWithValue("@RentalPerDay", rentalPerDay);
                        command.Parameters.AddWithValue("@Available", available);
                        command.ExecuteNonQuery(); // execute SQL INSERT statement 

                    }// end Using SQL Command - command closes
                } // end Using SQL connection - connection closes
                LoadData();
                currentIndex = dataTable.Rows.Count - 1;
                DisplayRecord();
                MessageBox.Show("Record Inserted");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = @"
                    UPDATE VehicleRegister
                    SET Make = @Make,
                        EngineSize = @EngineSize,
                        DateRegistered = @DateRegistered,
                        RentalPerDay = @RentalPerDay,
                        Available = @Available
                    WHERE VehicleRegNo = @VehicleRegNo";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Make", cobMake.Text);
                    updateCommand.Parameters.AddWithValue("@EngineSize", txtEngineSize.Text);
                    updateCommand.Parameters.AddWithValue("@DateRegistered", dateTimePicker1.Value.Date);
                    try
                    {
                        string rentalPerDayWithoutEuro = txtRentalPerDay.Text.Replace("€", "").Trim();
                        decimal sf = decimal.Parse(rentalPerDayWithoutEuro);
                        updateCommand.Parameters.AddWithValue("@RentalPerDay", sf);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                    updateCommand.Parameters.AddWithValue("@Available", chkAvailable.Checked);

                    updateCommand.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text);

                    int rowsUpdated = updateCommand.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given ID.");
                    }
                }
            }
            dataChanged = true;
            LoadData();
            DisplayRecord();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            currentIndex = dataTable.Rows.Count > 0 ? 0 : -1;
            DisplayRecord();
            dataChanged = false;

        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            currentIndex = dataTable.Rows.Count - 1;
            DisplayRecord();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            DisplayRecord();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            DisplayRecord();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            DisplayRecord();
        }

        private void InputValidate(string vehicleRegNo)
        {
            if (vehicleRegNo.Length > 10)
            {
                MessageBox.Show("Vehicle Registration Number cannot exceed 10 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ValidateUniqueVehicleRegNo(String vehicleRegNo)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT vehicleRegNo FROM VehicleRegister WHERE VehicleRegNo = @VehicleRegNo";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@vehicleRegNo", vehicleRegNo);
                    var result = checkCmd.ExecuteScalar();
                    if (result != null)
                    {
                        throw new Exception("A vehicle with this registration number already exists.");
                    }
                }
            }


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!chkAvailable.Checked)
            {
                MessageBox.Show("Cannot delete currently rented vehicle.");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteCommand = "DELETE FROM VehicleRegister WHERE VehicleRegNo = @VehicleRegNo";
                    using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text);
                        command.ExecuteNonQuery();
                    }
                }
                dataChanged = true;
                LoadData();
                if (currentIndex > 0)
                    currentIndex = 0;

                if (currentIndex < dataTable.Rows.Count - 1)
                    currentIndex = dataTable.Rows.Count - 1;

                DisplayRecord();
                MessageBox.Show("Record deleted successfully.");

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void LoadCarMakes()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Make FROM VehicleRegister";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cobMake.Items.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading car makes: " + ex.Message);
                }
            }

        }
    }
}


