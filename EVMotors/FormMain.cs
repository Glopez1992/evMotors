using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using FormEVMotors;
using System.CodeDom;


namespace WinFormsApp1
{
    public partial class FormMain : Form
    {

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
                    using (connection = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
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
            LoadCarMakes();
            txtVehicleRegNo.Text = dataTable.Rows[currentIndex]["VehicleRegNo"].ToString();
            cobMake.Text = dataTable.Rows[currentIndex]["Make"].ToString();
            txtEngineSize.Text = dataTable.Rows[currentIndex]["EngineSize_Power"].ToString();
            dateTimePicker1.Text = dataTable.Rows[currentIndex]["DateRegistered"].ToString();
            txtRentalPerDay.Text = dataTable.Rows[currentIndex]["RentalPerDay"].ToString();
            chkAvailable.Checked = Convert.ToBoolean(dataTable.Rows[currentIndex]["Available"]);
            BtnPrevious.Enabled = currentIndex > 0;
            BtnFirst.Enabled = currentIndex > 0;
            BtnNext.Enabled = currentIndex < dataTable.Rows.Count - 1;
            this.Text = $"EvMotors - {DateTime.Now:dd/MM/yyyy}";
            int adjustedIndex = currentIndex + 1;
            lblRecordCount.Text = ($"{adjustedIndex.ToString()} of {dataTable.Rows.Count}");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataChanged = true;
            try
            {

                string vehicleRegNo = txtVehicleRegNo.Text;
                string make = cobMake.Text;
                string engineSize = txtEngineSize.Text;
                DateTime dateRegistered = dateTimePicker1.Value;
                string rentalPerDayInput = txtRentalPerDay.Text;
                bool available = chkAvailable.Checked;

                VehicleRegister.ValidateVehicleRegNo(vehicleRegNo, DataAccess.DataBaseConfig.ConnectionString);
                VehicleRegister.ValidateRentalPerDay(rentalPerDayInput);
                decimal rentalPerDay = decimal.Parse(rentalPerDayInput);


                VehicleRegister vehicle = new VehicleRegister(
                    vehicleRegNo, make, engineSize, dateRegistered, rentalPerDay, available);


                {

                    // create and open connection
                    using (connection = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
                    {
                        connection.Open();
                        // create and execute SQL Command with parameters
                        string query = "INSERT INTO VehicleRegister (VehicleRegNo, Make, EngineSize_Power, DateRegistered, RentalPerDay, Available)"
                            + "VALUES (@VehicleRegNo,@Make, @EngineSize_Power,@DateRegistered, @RentalPerDay, @Available)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            //use parameters to add data
                            command.Parameters.AddWithValue("@VehicleRegNo", vehicleRegNo);
                            command.Parameters.AddWithValue("@Make", make);
                            command.Parameters.AddWithValue("@EngineSize_Power", engineSize);
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
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleRegNo = txtVehicleRegNo.Text;
                string make = cobMake.Text;
                string engineSize = txtEngineSize.Text;
                DateTime dateRegistered = dateTimePicker1.Value;
                string rentalPerDayInput = txtRentalPerDay.Text;
                bool available = chkAvailable.Checked;


                VehicleRegister.ValidateRentalPerDay(rentalPerDayInput);
                decimal rentalPerDay = decimal.Parse(rentalPerDayInput);

                var vehicle = new VehicleRegister(vehicleRegNo, make, engineSize, dateRegistered, rentalPerDay, available);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (connection = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string updateQuery = @"
                    UPDATE VehicleRegister
                    SET Make = @Make,
                        EngineSize_Power = @EngineSize_Power,
                        DateRegistered = @DateRegistered,
                        RentalPerDay = @RentalPerDay,
                        Available = @Available
                    WHERE VehicleRegNo = @VehicleRegNo";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Make", cobMake.Text);
                    updateCommand.Parameters.AddWithValue("@EngineSize_Power", txtEngineSize.Text);
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!chkAvailable.Checked)
            {
                MessageBox.Show("Cannot delete currently hired vehicle.");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (connection = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
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
                    MessageBox.Show("Vehicle deleted successfully.");
                }


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
            cobMake.Items.Clear();
            using (SqlConnection conn = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Make FROM CarMake";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch searchForm = new FormSearch();
            searchForm.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


