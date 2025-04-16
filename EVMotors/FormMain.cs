using Microsoft.Data.SqlClient;
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

        private string connectionString = "Server=KylePC\\SQLEXPRESS;Database=EvMotorsDB;Trusted_Connection=True;TrustServerCertificate=True;";
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
            this.Text = $"Current Table Index:  {currentIndex}";
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
                decimal rentalPerDay = decimal.Parse(txtRentalPerDay.Text);
                bool available = chkAvailable.Checked;
                InputValidate(vehicleRegNo);
                System.Console.WriteLine("output");

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
                reader.Close();
                connection.Close();
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


        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
                throw new ArgumentOutOfRangeException
                    ("Please enter a valid Vehicle Registration Number (Less than 10 Characters");     
            }
        }
    }
}
