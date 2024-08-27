using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class OrderForm : Form
    {
        private CarData car;
        public OrderForm(CarData selectedCar)
        {
            InitializeComponent();
            car = selectedCar;

            // Set the car details
            OrderForm_Load();

        }

        private void OrderForm_Load()
        {
            // Set the car details
            make_lable.Text = car.Make;
            model_lable.Text = car.Model;
            year_lable.Text = car.Year.ToString();
            milage_lable.Text = car.Mileage.ToString();
            transmisson_lable.Text = car.Transmission;
            capacity_lable.Text = car.EngineCapacity.ToString();
            reg_lable.Text = car.RegistrationNumber.ToString();
            price_lable.Text ="LKR " + car.Price.ToString();

            car_Image.ImageLocation = car.ImageUrl;

        }

        private void orderNow_btn_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog before placing the order
            DialogResult confirmationResult = MessageBox.Show(
                $"Are you sure you want to place an order for {car.Make} {car.Model}?",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If the user clicks 'Yes', proceed with the order
            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    // Assuming you have a SQLConnection class for handling database connections
                    using (var sqlConnection = new SQLConnection())
                    {
                        sqlConnection.OpenConnection();

                        string query = "INSERT INTO CarOrders (CustomerID, CarID, Quantity, TotalPrice, Status, AdditionalInfo) " +
                                       "VALUES (@CustomerID, @CarID, @Quantity, @TotalPrice, @Status, @AdditionalInfo)";

                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                        {
                            // Assuming you have a way to get the currently logged-in customer's ID
                            int customerID = CurrentUser.Id; // Replace with actual customer ID fetching logic
                            int quantity = 1; // For now, assume 1 car is ordered
                            decimal totalPrice = car.Price * quantity; // Calculate total price

                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd.Parameters.AddWithValue("@CarID", car.Id);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@Status", "Pending"); // Default status
                            cmd.Parameters.AddWithValue("@AdditionalInfo", DBNull.Value); // You can add more info if needed

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the order form
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If the user clicks 'No', do nothing and return
                MessageBox.Show("Order canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
