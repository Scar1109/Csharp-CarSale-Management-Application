using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ABC_Car_Traders
{
    public class CarData
    {
        // Car properties
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public string EngineCapacity { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImageUrl { get; set; }

        // Use the SQLConnection class
        SQLConnection sql = new SQLConnection();

        // Method to get a list of all cars
        public List<CarData> CarListData()
        {
            List<CarData> listData = new List<CarData>();

            try
            {
                sql.OpenConnection();

                string selectData = "SELECT * FROM Cars";

                using (SqlCommand cmd = new SqlCommand(selectData, sql.GetConnection()))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CarData car = new CarData
                        {
                            Id = (int)reader["id"],
                            Make = reader["make"].ToString(),
                            Model = reader["model"].ToString(),
                            Year = (int)reader["year"],
                            Price = (decimal)reader["price"],
                            Mileage = (int)reader["mileage"],
                            Transmission = reader["transmission"].ToString(),
                            EngineCapacity = reader["engine_capacity"].ToString(),
                            RegistrationNumber = reader["registration_number"].ToString(),
                            DateAdded = (DateTime)reader["date_added"],
                            ImageUrl = reader["image_url"].ToString()
                        };

                        listData.Add(car);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }

            return listData;
        }

        // Method to get a list of cars filtered by a certain criterion (e.g., year, make, etc.)
        public List<CarData> FilteredCarListData(string make)
        {
            List<CarData> listData = new List<CarData>();

            try
            {
                sql.OpenConnection();

                string selectData = "SELECT * FROM Cars WHERE make = @Make";

                using (SqlCommand cmd = new SqlCommand(selectData, sql.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Make", make);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CarData car = new CarData
                        {
                            Id = (int)reader["id"],
                            Make = reader["make"].ToString(),
                            Model = reader["model"].ToString(),
                            Year = (int)reader["year"],
                            Price = (decimal)reader["price"],
                            Mileage = (int)reader["mileage"],
                            Transmission = reader["transmission"].ToString(),
                            EngineCapacity = reader["engine_capacity"].ToString(),
                            RegistrationNumber = reader["registration_number"].ToString(),
                            DateAdded = (DateTime)reader["date_added"],
                            ImageUrl = reader["image_url"].ToString()
                        };

                        listData.Add(car);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }

            return listData;
        }
    }
}
