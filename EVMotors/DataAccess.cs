using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;


namespace FormEVMotors
{
    public static class DataAccess
    {

        public static class DataBaseConfig
        {
            public static string ConnectionString { get; } = "Server=KYLEPC\\SQLEXPRESS;Database=EvMotors;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        public static bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE [username] = @username AND [password] = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int result = (int)command.ExecuteScalar();
                    return result > 0;
                }
            }
        }
        public static DataTable GetAllVehicles()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                string query = "SELECT * FROM VehicleRegister";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
            }
            return dt;
        }
        public static void InsertVehicle(VehicleRegister vehicle)
        {
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string query = @"INSERT INTO VehicleRegister 
                                (VehicleRegNo, Make, EngineSize_Power, DateRegistered, RentalPerDay, Available)
                                VALUES (@VehicleRegNo,@Make, @EngineSize_Power,@DateRegistered, @RentalPerDay, @Available)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VehicleRegNo", vehicle.VehicleRegNo);
                    command.Parameters.AddWithValue("@Make", vehicle.Make);
                    command.Parameters.AddWithValue("@EngineSize_Power", vehicle.EngineSize);
                    command.Parameters.AddWithValue("@DateRegistered", vehicle.DateRegistered);
                    command.Parameters.AddWithValue("@RentalPerDay", vehicle.RentalPerDay);
                    command.Parameters.AddWithValue("@Available", vehicle.Available);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static int UpdateVehicle(VehicleRegister vehicle)
        {
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string query = @"UPDATE VehicleRegister
                        SET Make = @Make,
                            EngineSize_Power = @EngineSize_Power,
                            DateRegistered = @DateRegistered,
                            RentalPerDay = @RentalPerDay,
                            Available = @Available
                        WHERE VehicleRegNo = @VehicleRegNo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // create and execute SQL Command with parameters
                    command.Parameters.AddWithValue("@Make", vehicle.Make);
                    command.Parameters.AddWithValue("@EngineSize_Power", vehicle.EngineSize);
                    command.Parameters.AddWithValue("@DateRegistered", vehicle.DateRegistered);
                    command.Parameters.AddWithValue("@RentalPerDay", vehicle.RentalPerDay);
                    command.Parameters.AddWithValue("@Available", vehicle.Available);
                    command.Parameters.AddWithValue("@VehicleRegNo", vehicle.VehicleRegNo);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected; // returns how many rows were updated
                } // end Using SQL Command - command closes
            } // end Using SQL connection - connection closes
        }
        public static int DeleteVehicle(string vehicleRegNo)
        {
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM VehicleRegister WHERE VehicleRegNo = @VehicleRegNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VehicleRegNo", vehicleRegNo);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected; // Return the number of rows deleted
                }
            }
        }
        public static List<string> GetCarMakes()
        {
            List<string> makes = new List<string>();
            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                string query = "SELECT Make FROM CarMake";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        makes.Add(reader.GetString(0));
                    }
                }
            }
            return makes;
        }

        public static DataTable SearchVehicles(string query, SqlParameter[] parameters)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(DataBaseConfig.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }

            return resultTable;
        }

       

    }  
}