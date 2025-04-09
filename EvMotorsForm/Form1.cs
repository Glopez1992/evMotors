using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EvMotorsForm
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=KylePC\\SQLEXPRESS;Database=EvMotorsDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection connection = null;
        private SqlDataReader reader = null;
        private DataTable dataTable = null;
        private bool dataChanged = false;

        private int currentIndex = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Connected to Database");
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dataChanged = true;
            try
            {
                string vehicleRegNo = txtVehicleRegNo.Text;
                string make = txtMake.Text;
                string engineSize = txtEngineSize.Text;
                DateTime dateRegistered = dateTimePicker1.Value;
                decimal rentalPerDay = txt.RentalPerDay.Value;
                bool available = checkBoxAvailable.Checked;


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
                MessageBox.Show(exception.Message);
                reader.Close();
                connection.Close();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
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
                    updateCommand.Parameters.AddWithValue("@Make", txtMake.Text);
                    updateCommand.Parameters.AddWithValue("@EngineSize", txtEngineSize.Text);
                    updateCommand.Parameters.AddWithValue("@DateRegistered", txtDateRegistered.dateTimePicker1.Value);
                    updateCommand.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value.Date);

                    updateCommand.Parameters.AddWithValue("@Id", txtID.Text);

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
    }
}
