using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ABC_Car_Traders.Data
{
    public class PartData
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string Manufacturer { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateAdded { get; set; }

        // Method to retrieve all parts
        public List<PartData> GetAllParts()
        {
            List<PartData> partsList = new List<PartData>();

            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "SELECT * FROM SpareParts";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PartData part = new PartData
                            {
                                PartID = (int)reader["PartID"],
                                PartName = reader["PartName"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString(),
                                VehicleMake = reader["VehicleMake"].ToString(),
                                VehicleModel = reader["VehicleModel"].ToString(),
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["StockQuantity"],
                                ImageUrl = reader["ImageUrl"].ToString(),
                                DateAdded = (DateTime)reader["DateAdded"]
                            };

                            partsList.Add(part);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving parts: " + ex.Message);
            }

            return partsList;
        }

        // Method to add a new part
        public void AddPart(PartData part)
        {
            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "INSERT INTO SpareParts (PartName, Manufacturer, VehicleMake, VehicleModel, Price, StockQuantity, ImageUrl, DateAdded) " +
                                   "VALUES (@PartName, @Manufacturer, @VehicleMake, @VehicleModel, @Price, @StockQuantity, @ImageUrl, @DateAdded)";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@PartName", part.PartName);
                        cmd.Parameters.AddWithValue("@Manufacturer", part.Manufacturer);
                        cmd.Parameters.AddWithValue("@VehicleMake", part.VehicleMake);
                        cmd.Parameters.AddWithValue("@VehicleModel", part.VehicleModel);
                        cmd.Parameters.AddWithValue("@Price", part.Price);
                        cmd.Parameters.AddWithValue("@StockQuantity", part.StockQuantity);
                        cmd.Parameters.AddWithValue("@ImageUrl", part.ImageUrl);
                        cmd.Parameters.AddWithValue("@DateAdded", part.DateAdded);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding part: " + ex.Message);
            }
        }

        // Method to update an existing part
        public void UpdatePart(PartData part)
        {
            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "UPDATE SpareParts SET PartName = @PartName, Manufacturer = @Manufacturer, " +
                                   "VehicleMake = @VehicleMake, VehicleModel = @VehicleModel, Price = @Price, " +
                                   "StockQuantity = @StockQuantity, ImageUrl = @ImageUrl WHERE PartID = @PartID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@PartID", part.PartID);
                        cmd.Parameters.AddWithValue("@PartName", part.PartName);
                        cmd.Parameters.AddWithValue("@Manufacturer", part.Manufacturer);
                        cmd.Parameters.AddWithValue("@VehicleMake", part.VehicleMake);
                        cmd.Parameters.AddWithValue("@VehicleModel", part.VehicleModel);
                        cmd.Parameters.AddWithValue("@Price", part.Price);
                        cmd.Parameters.AddWithValue("@StockQuantity", part.StockQuantity);
                        cmd.Parameters.AddWithValue("@ImageUrl", part.ImageUrl);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating part: " + ex.Message);
            }
        }

        // Method to delete a part
        public void DeletePart(int partID)
        {
            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "DELETE FROM SpareParts WHERE PartID = @PartID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@PartID", partID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting part: " + ex.Message);
            }
        }
    }
}
