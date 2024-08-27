using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Car_Traders.AdminPanels
{
    public partial class CarManagement : UserControl
    {
        SQLConnection sql = new SQLConnection();

        public CarManagement()
        {
            InitializeComponent();

            // Display the data from the database to your DataGridView
            DisplayCarData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayCarData();
        }

        public void DisplayCarData()
        {
            CarData carData = new CarData();
            List<CarData> carList = carData.CarListData();

            carDataGridView.DataSource = carList;
        }

        private void addCar_addBtn_Click(object sender, EventArgs e)
        {
            if (addCar_make.Text == ""
                || addCar_model.Text == ""
                || addCar_year.Text == ""
                || addCar_engine.Text == ""
                || addCar_Price.Text == ""
                || addCar_Milage.Text == ""
                || addCar_transmission.Text == ""
                || addCar_regNo.Text == ""
                || addCar_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sql.OpenConnection();

                    string checkRegNo = "SELECT COUNT(*) FROM Cars WHERE registration_number = @regNo";

                    using (SqlCommand checkCmd = new SqlCommand(checkRegNo, sql.GetConnection()))
                    {
                        checkCmd.Parameters.AddWithValue("@regNo", addCar_regNo.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(addCar_regNo.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            string imagePath = SaveImage(addCar_picture, addCar_regNo.Text.Trim());

                            string insertData = "INSERT INTO Cars (make, model, year, price, mileage, transmission, engine_capacity, registration_number, date_added, image_url) " +
                                                "VALUES (@Make, @Model, @Year, @Price, @Mileage, @Transmission, @EngineCapacity, @RegistrationNumber, @DateAdded, @ImageUrl)";

                            using (SqlCommand cmd = new SqlCommand(insertData, sql.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@Make", addCar_make.Text.Trim());
                                cmd.Parameters.AddWithValue("@Model", addCar_model.Text.Trim());
                                cmd.Parameters.AddWithValue("@Year", int.Parse(addCar_year.Text.Trim()));
                                cmd.Parameters.AddWithValue("@Price", decimal.Parse(addCar_Price.Text.Trim()));
                                cmd.Parameters.AddWithValue("@Mileage", int.Parse(addCar_Milage.Text.Trim()));
                                cmd.Parameters.AddWithValue("@Transmission", addCar_transmission.Text.Trim());
                                cmd.Parameters.AddWithValue("@EngineCapacity", addCar_engine.Text.Trim());
                                cmd.Parameters.AddWithValue("@RegistrationNumber", addCar_regNo.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateAdded", today);
                                cmd.Parameters.AddWithValue("@ImageUrl", imagePath);

                                cmd.ExecuteNonQuery();

                                DisplayCarData();

                                MessageBox.Show("Car added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFields();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sql.CloseConnection();
                }
            }
        }


        private void addCar_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCar_make.Text == ""
                || addCar_model.Text == ""
                || addCar_year.Text == ""
                || addCar_engine.Text == ""
                || addCar_Price.Text == ""
                || addCar_Milage.Text == ""
                || addCar_transmission.Text == ""
                || addCar_regNo.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE the car with Registration No: " + addCar_regNo.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sql.OpenConnection();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Cars SET make = @Make, model = @Model, year = @Year, price = @Price, mileage = @Mileage, transmission = @Transmission, " +
                                            "engine_capacity = @EngineCapacity";

                        // Save the new image if it exists
                        string imagePath = SaveImage(addCar_picture, addCar_regNo.Text.Trim());

                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            updateData += ", image_url = @ImageUrl";
                        }

                        updateData += " WHERE registration_number = @RegistrationNumber";

                        using (SqlCommand cmd = new SqlCommand(updateData, sql.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@Make", addCar_make.Text.Trim());
                            cmd.Parameters.AddWithValue("@Model", addCar_model.Text.Trim());
                            cmd.Parameters.AddWithValue("@Year", int.Parse(addCar_year.Text.Trim()));
                            cmd.Parameters.AddWithValue("@Price", decimal.Parse(addCar_Price.Text.Trim()));
                            cmd.Parameters.AddWithValue("@Mileage", int.Parse(addCar_Milage.Text.Trim()));
                            cmd.Parameters.AddWithValue("@Transmission", addCar_transmission.Text.Trim());
                            cmd.Parameters.AddWithValue("@EngineCapacity", addCar_engine.Text.Trim());
                            cmd.Parameters.AddWithValue("@RegistrationNumber", addCar_regNo.Text.Trim());

                            if (!string.IsNullOrEmpty(imagePath))
                            {
                                cmd.Parameters.AddWithValue("@ImageUrl", imagePath);
                            }

                            cmd.ExecuteNonQuery();

                            DisplayCarData();

                            MessageBox.Show("Car updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void addCar_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addCar_regNo.Text == "")
            {
                MessageBox.Show("Please enter the registration number of the car to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE the car with Registration No: " + addCar_regNo.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sql.OpenConnection();

                        string deleteData = "DELETE FROM Cars WHERE registration_number = @RegistrationNumber";

                        using (SqlCommand cmd = new SqlCommand(deleteData, sql.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@RegistrationNumber", addCar_regNo.Text.Trim());

                            cmd.ExecuteNonQuery();

                            DisplayCarData();

                            MessageBox.Show("Car deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sql.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addCar_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addCar_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = carDataGridView.Rows[e.RowIndex];
                addCar_make.Text = row.Cells[1].Value.ToString();
                addCar_model.Text = row.Cells[2].Value.ToString();
                addCar_year.Text = row.Cells[3].Value.ToString();
                addCar_Price.Text = row.Cells[4].Value.ToString();
                addCar_Milage.Text = row.Cells[5].Value.ToString();
                addCar_transmission.Text = row.Cells[6].Value.ToString();
                addCar_engine.Text = row.Cells[7].Value.ToString();
                addCar_regNo.Text = row.Cells[8].Value.ToString();

                string imagePath = row.Cells[10].Value.ToString();

                if (imagePath != null)
                {
                    addCar_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addCar_picture.Image = null;
                }
            }
        }

        public void ClearFields()
        {
            addCar_make.Text = "";
            addCar_model.Text = "";
            addCar_year.Text = "";
            addCar_engine.Text = "";
            addCar_Price.Text = "";
            addCar_Milage.Text = "";
            addCar_transmission.SelectedIndex = -1;
            addCar_regNo.Text = "";
            addCar_picture.Image = null;
        }

        private string SaveImage(PictureBox pictureBox, string registrationNumber)
        {
            // Check if an image is selected
            if (pictureBox.ImageLocation == null)
            {
                return null;
            }

            // Generate a random file name using GUID
            string randomFileName = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox.ImageLocation);

            // Define the target directory
            string targetDirectory = @"C:\Users\kavee\OneDrive\Desktop\CodeMaster\C# - Esoft\ABC Car Traders\Uploads\";

            // Ensure the directory exists
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            // Define the full path for the new image
            string imagePath = Path.Combine(targetDirectory, randomFileName);

            // Copy the file to the target directory
            File.Copy(pictureBox.ImageLocation, imagePath, true);

            // Return the path of the saved image
            return imagePath;
        }


        private void addCar_picture_Click(object sender, EventArgs e)
        {
            // Handle the picture box click event here.
            // You can open a file dialog, show a message, or perform any other action you need.
        }

        private void addCar_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void addCar_transmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selected index change event here.
            // For example, you could display a message or update another field based on the selected transmission.
        }

        private void addCar_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_make_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_engine_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_Milage_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCar_regNo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
