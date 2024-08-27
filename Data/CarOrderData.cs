using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ABC_Car_Traders.Data
{
    public class CarOrderData
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        // Method to retrieve all car orders
        public List<CarOrderData> GetAllCarOrders()
        {
            List<CarOrderData> carOrderList = new List<CarOrderData>();

            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = @"SELECT co.OrderID, co.CustomerID, co.CarID, c.Make, c.Model, c.image_url, 
                                     co.OrderDate, co.Quantity, co.TotalPrice, co.Status
                                     FROM CarOrders co
                                     INNER JOIN Cars c ON co.CarID = c.id";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CarOrderData carOrder = new CarOrderData
                            {
                                OrderID = (int)reader["OrderID"],
                                CustomerID = (int)reader["CustomerID"],
                                CarID = (int)reader["CarID"],
                                Make = reader["Make"].ToString(),
                                Model = reader["Model"].ToString(),
                                ImageUrl = reader["image_url"].ToString(),
                                OrderDate = (DateTime)reader["OrderDate"],
                                Quantity = (int)reader["Quantity"],
                                TotalPrice = (decimal)reader["TotalPrice"],
                                Status = reader["Status"].ToString()
                            };

                            carOrderList.Add(carOrder);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving car orders: " + ex.Message);
            }

            return carOrderList;
        }

        // Method to update the order status
        public void UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "UPDATE CarOrders SET Status = @Status WHERE OrderID = @OrderID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@OrderID", orderId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating order status: " + ex.Message);
            }
        }
    }
}
