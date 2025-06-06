using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormEVMotors
{
    public class VehicleRegister
    {

        private string _vehicleRegNo;
        private string _make;
        private string _engineSize;
        private DateTime _dateRegistered;
        private decimal _rentalPerDay;
        private bool _available;



      public string VehicleRegNo
{
        get => _vehicleRegNo;
        set
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Vehicle Registration Number is required.");

        string pattern = @"^\d{3}-[A-Z]{1,2}-\d{3}$";
        string input = value.Trim().ToUpper();

        if (!Regex.IsMatch(input, pattern))
            throw new FormatException("Vehicle Registration Number must follow the format 123-AB-456.");

        _vehicleRegNo = input;
    }
}
        public string EngineSize
        {
            get => _engineSize;
            set
            {
                var clean = value.Replace(" ", "");
                string pattern = @"^(\d(\.\d{1})?L|\d{2,4}kW)$";

                if (!Regex.IsMatch(clean, pattern))
                    throw new FormatException("Invalid engine size format. Use 1.0L or 200kW.");

                _engineSize = clean;
            }
        }
        public DateTime DateRegistered
        {
            get => _dateRegistered;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Date Registered cannot be in the future.");
                _dateRegistered = value;
            }
        }

        public decimal RentalPerDay
        {
            get => _rentalPerDay;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Rental Per Day must be greater than zero.");
                _rentalPerDay = value;
            }
        }
        public string Make { get; set; }
        public bool Available { get; set; }
    
        public static void ValidateVehicleRegNo(string vehicleRegNo, string connectionString)
        {
            string input = vehicleRegNo.Trim().ToUpper();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT VehicleRegNo FROM VehicleRegister WHERE VehicleRegNo = @VehicleRegNo";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@VehicleRegNo", input);
                    var result = checkCmd.ExecuteScalar();
                    if (result != null)
                        throw new Exception("A vehicle with this registration number already exists.");
                }
            }
        }
        
         public static void ValidateRentalPerDay(string rentalPerDayValue)
        {
            if (!decimal.TryParse(rentalPerDayValue, out decimal value))
            {
                throw new ArgumentException("Rental Per Day must be a valid number (e.g., 99.99).");
            }

            if (value <= 0)
            {
                throw new ArgumentException("Rental Per Day must be greater than zero.");
            }
        }


        public VehicleRegister(string vehicleRegNo, string make, string engineSize, DateTime dateRegistered
            , decimal rentalPerDay, bool available)
        {
            VehicleRegNo = vehicleRegNo;
            Make = make;
            EngineSize = engineSize;
            DateRegistered = dateRegistered;
            RentalPerDay = rentalPerDay;
            Available = available;

        }
    }

}
