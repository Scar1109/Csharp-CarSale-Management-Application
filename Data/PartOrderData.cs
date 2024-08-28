using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ABC_Car_Traders.Data
{
    public class PartOrderData
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string Manufacturer { get; set; }
        public string ImageUrl { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        // Method to retrieve all part orders
        public List<PartOrderData> GetAllPartOrders()
        {
            List<PartOrderData> partOrderList = new List<PartOrderData>();

            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = @"SELECT po.OrderID, po.CustomerID, po.PartID, sp.PartName, sp.Manufacturer, sp.ImageUrl, 
                                     po.OrderDate, po.Quantity, po.TotalPrice, po.Status
                                     FROM PartOrders po
                                     INNER JOIN SpareParts sp ON po.PartID = sp.PartID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PartOrderData partOrder = new PartOrderData
                            {
                                OrderID = (int)reader["OrderID"],
                                CustomerID = (int)reader["CustomerID"],
                                PartID = (int)reader["PartID"],
                                PartName = reader["PartName"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString(),
                                ImageUrl = reader["ImageUrl"].ToString(),
                                OrderDate = (DateTime)reader["OrderDate"],
                                Quantity = (int)reader["Quantity"],
                                TotalPrice = (decimal)reader["TotalPrice"],
                                Status = reader["Status"].ToString()
                            };

                            partOrderList.Add(partOrder);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving part orders: " + ex.Message);
            }

            return partOrderList;
        }

        // Method to retrieve all part orders for a specific customer
        public List<PartOrderData> GetPartOrdersByCustomer(int customerId)
        {
            List<PartOrderData> partOrderList = new List<PartOrderData>();

            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = @"SELECT po.OrderID, po.CustomerID, po.PartID, sp.PartName, sp.Manufacturer, sp.ImageUrl, 
                                     po.OrderDate, po.Quantity, po.TotalPrice, po.Status
                                     FROM PartOrders po
                                     INNER JOIN SpareParts sp ON po.PartID = sp.PartID
                                     WHERE po.CustomerID = @CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PartOrderData partOrder = new PartOrderData
                            {
                                OrderID = (int)reader["OrderID"],
                                CustomerID = (int)reader["CustomerID"],
                                PartID = (int)reader["PartID"],
                                PartName = reader["PartName"].ToString(),
                                Manufacturer = reader["Manufacturer"].ToString(),
                                ImageUrl = reader["ImageUrl"].ToString(),
                                OrderDate = (DateTime)reader["OrderDate"],
                                Quantity = (int)reader["Quantity"],
                                TotalPrice = (decimal)reader["TotalPrice"],
                                Status = reader["Status"].ToString()
                            };

                            partOrderList.Add(partOrder);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving part orders: " + ex.Message);
            }

            return partOrderList;
        }

        // Method to update the order status
        public void UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                using (var sqlConnection = new SQLConnection())
                {
                    sqlConnection.OpenConnection();

                    string query = "UPDATE PartOrders SET Status = @Status WHERE OrderID = @OrderID";

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
