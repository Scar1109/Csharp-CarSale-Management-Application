using ABC_Car_Traders.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ABC_Car_Traders.AdminPanels
{
    public partial class PartManagement : UserControl
    {
        SQLConnection sql = new SQLConnection();

        public PartManagement()
        {
            InitializeComponent();
            DisplayPartData(); // Load and display the parts data when the UserControl is initialized
        }

        // Method to display all parts data in the DataGridView
        public void DisplayPartData()
        {
            PartData partData = new PartData();
            List<PartData> partsList = partData.GetAllParts();

            partDataGridView.DataSource = partsList;
        }

        // Method to clear all input fields
        public void ClearFields()
        {
            addPart_name.Text = "";
            addPart_manufacture.Text = "";
            addPart_make.Text = "";
            addPart_model.Text = "";
            addPart_price.Text = "";
            addPart_qunatity.Text = "";
            addPart_picture.Image = null;
        }

        // Event handler for adding a new part
        private void addPart_addBtn_Click(object sender, EventArgs e)
        {
            if (addPart_name.Text == ""
                || addPart_manufacture.Text == ""
                || addPart_price.Text == ""
                || addPart_qunatity.Text == ""
                || addPart_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sql.OpenConnection();

                    string imagePath = SaveImage(addPart_picture);

                    PartData part = new PartData
                    {
                        PartName = addPart_name.Text.Trim(),
                        Manufacturer = addPart_manufacture.Text.Trim(),
                        VehicleMake = addPart_make.Text.Trim(),
                        VehicleModel = addPart_model.Text.Trim(),
                        Price = decimal.Parse(addPart_price.Text.Trim()),
                        StockQuantity = int.Parse(addPart_qunatity.Text.Trim()),
                        ImageUrl = imagePath,
                        DateAdded = DateTime.Today
                    };

                    part.AddPart(part);

                    DisplayPartData();

                    MessageBox.Show("Part added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
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

        // Event handler for updating an existing part
        private void addPart_updateBtn_Click(object sender, EventArgs e)
        {
            if (addPart_name.Text == ""
                || addPart_manufacture.Text == ""
                || addPart_price.Text == ""
                || addPart_qunatity.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE the part?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sql.OpenConnection();

                        string imagePath = SaveImage(addPart_picture);

                        PartData part = new PartData
                        {
                            PartID = int.Parse(partDataGridView.CurrentRow.Cells[0].Value.ToString()), // Get PartID from the selected row
                            PartName = addPart_name.Text.Trim(),
                            Manufacturer = addPart_manufacture.Text.Trim(),
                            VehicleMake = addPart_make.Text.Trim(),
                            VehicleModel = addPart_model.Text.Trim(),
                            Price = decimal.Parse(addPart_price.Text.Trim()),
                            StockQuantity = int.Parse(addPart_qunatity.Text.Trim()),
                            ImageUrl = imagePath
                        };

                        part.UpdatePart(part);

                        DisplayPartData();

                        MessageBox.Show("Part updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
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
        }

        // Event handler for deleting a part
        private void addPart_deleteBtn_Click(object sender, EventArgs e)
        {
            if (partDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select the part to delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE the part?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        sql.OpenConnection();

                        int partID = int.Parse(partDataGridView.CurrentRow.Cells[0].Value.ToString());
                        PartData partData = new PartData();
                        partData.DeletePart(partID);

                        DisplayPartData();

                        MessageBox.Show("Part deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
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
        }

        // Event handler for importing an image
        private void addPart_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addPart_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for when a cell in the DataGridView is clicked
        private void partDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = partDataGridView.Rows[e.RowIndex];
                addPart_name.Text = row.Cells[1].Value.ToString();
                addPart_manufacture.Text = row.Cells[2].Value.ToString();
                addPart_make.Text = row.Cells[3].Value.ToString();
                addPart_model.Text = row.Cells[4].Value.ToString();
                addPart_price.Text = row.Cells[5].Value.ToString();
                addPart_qunatity.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                if (imagePath != null)
                {
                    addPart_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addPart_picture.Image = null;
                }
            }
        }

        // Helper method to save the image
        private string SaveImage(PictureBox pictureBox)
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

        // Event handler for clearing input fields
        private void addPart_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Additional event handlers can be added here as needed
    }
}
