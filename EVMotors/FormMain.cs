using System;
using System.Data;
using FormEVMotors;
using Microsoft.Data.SqlClient;
using static FormEVMotors.DataAccess;


namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        private DataTable dataTable;
        private bool dataChanged = true;
        private int currentIndex = 0;
        private bool databaseConnected = false;



        public FormMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TryConnectToDatabase();
            if (databaseConnected)
            {
                LoadData();
                DisplayRecord();
                cobMake.DropDownHeight = 300;
            }
        }

        private void LoadData()
        {
            ExecuteDbAction(() =>
            {
                if (dataChanged == true)
                {
                    try
                    {
                        dataTable = DataAccess.GetAllVehicles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataChanged = false;
                }
            });

            
        }

        private void DisplayRecord()
        {
            ExecuteDbAction(() =>
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
            });
         


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExecuteDbAction(() =>
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

                        DataAccess.InsertVehicle(vehicle);
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

            });





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExecuteDbAction(() =>
            {
                try
                {
                    string vehicleRegNo = txtVehicleRegNo.Text;
                    string make = cobMake.Text;
                    string engineSize = txtEngineSize.Text;
                    DateTime dateRegistered = dateTimePicker1.Value;
                    string rentalPerDayInput = txtRentalPerDay.Text;
                    bool available = chkAvailable.Checked;

                    // Validations
                    VehicleRegister.ValidateRentalPerDay(rentalPerDayInput);
                    decimal rentalPerDay = decimal.Parse(rentalPerDayInput);

                    var vehicle = new VehicleRegister(vehicleRegNo, make, engineSize, dateRegistered, rentalPerDay, available);

                    // Call the DataAccess method to update the record
                    int rowsUpdated = DataAccess.UpdateVehicle(vehicle);

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                        dataChanged = true;
                        LoadData();
                        DisplayRecord();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given VehicleRegNo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataChanged = true;
                LoadData();
                DisplayRecord();
            });
           

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
            ExecuteDbAction(() =>
            {
                if (!chkAvailable.Checked)
                {
                    MessageBox.Show("Cannot delete currently hired vehicle.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this vehicle?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowsDeleted = DataAccess.DeleteVehicle(txtVehicleRegNo.Text);

                    if (rowsDeleted > 0)
                    {
                        dataChanged = true;
                        LoadData();
                        if (currentIndex > 0)
                            currentIndex--;

                        DisplayRecord();
                        MessageBox.Show("Vehicle deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No vehicle found with the given VehicleRegNo.");
                    }
                }
            });
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit the program?",
            "Confirm Exit",
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
            try
            {
                var makes = DataAccess.GetCarMakes();
                cobMake.Items.AddRange(makes.ToArray());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch searchForm = new FormSearch();
            searchForm.ShowDialog();
        }

        private void TryConnectToDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DataAccess.DataBaseConfig.ConnectionString))
                {
                    conn.Open();
                    // If success, hide the retry panel
                    panelRetry.Visible = false;
                    databaseConnected = true;
                }
            }
            catch (SqlException)
            {
                ShowRetryPanel();
                databaseConnected = false;
            }
        }

        private void ShowRetryPanel()
        {
            // Optional: disable all other controls
            foreach (Control c in this.Controls)
            {
                if (c != panelRetry)
                    c.Enabled = false;
            }

            panelRetry.BringToFront();
            panelRetry.Visible = true;
        }
   

        private void ExecuteDbAction(Action action)
        {
            try
            {
                action();
                TryConnectToDatabase();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowRetryPanel();
                databaseConnected = false;
            }
        }
    }
}

