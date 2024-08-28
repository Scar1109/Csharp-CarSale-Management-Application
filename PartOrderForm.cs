using ABC_Car_Traders.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class PartOrderForm : Form
    {
        private PartData selectedPart;

        public PartOrderForm(PartData part)
        {
            InitializeComponent();
            selectedPart = part;
            LoadPartDetails(); // Load the part details into the form controls
        }

        // Method to load the selected part details into the form controls
        private void LoadPartDetails()
        {
            make_lable.Text = selectedPart.PartName;
            model_lable.Text = selectedPart.Manufacturer;
            partName_lable.Text = selectedPart.PartName;
            manufacture_lable.Text = selectedPart.Manufacturer;
            price_lable.Text = "LKR " + selectedPart.Price.ToString("N2");
            quantity_input.Text = "1"; // Default quantity to 1

            part_Image.ImageLocation = selectedPart.ImageUrl;
        }

        // Event handler for "Order Now" button click
        private void orderNow_btn_Click(object sender, EventArgs e)
        {
            // Confirm the order before placing it
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int quantity = int.Parse(quantity_input.Text.Trim());
                    decimal totalPrice = quantity * selectedPart.Price;

                    using (var sqlConnection = new SQLConnection())
                    {
                        sqlConnection.OpenConnection();

                        string query = "INSERT INTO PartOrders (CustomerID, PartID, OrderDate, Quantity, TotalPrice, Status) " +
                                       "VALUES (@CustomerID, @PartID, @OrderDate, @Quantity, @TotalPrice, @Status)";

                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", CurrentUser.Id); // Assuming CurrentUser stores the logged-in user's details
                            cmd.Parameters.AddWithValue("@PartID", selectedPart.PartID);
                            cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@Status", "Pending");

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Order placed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after placing the order
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Order was canceled by the user
                MessageBox.Show("Order canceled.", "Order Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void quantity_input_TextChanged(object sender, EventArgs e)
        {
            // Validate the quantity input to ensure it's a valid integer
            if (!int.TryParse(quantity_input.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantity_input.Text = "1"; // Reset to default value if input is not valid
                quantity = 1; // Set quantity to default value
            }

            // Calculate the total price based on the selected part's price and the entered quantity
            decimal totalPrice = selectedPart.Price * quantity;

            // Update the price label to display the total price
            price_lable.Text = "LKR " + totalPrice.ToString("N2");
        }

    }
}
