using ABC_Car_Traders.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Car_Traders.HomePanels
{
    public partial class PartsView : UserControl
    {
        public PartsView()
        {
            InitializeComponent();
            LoadParts(); // Load the parts initially
        }

        // Method to load parts initially
        public void LoadParts()
        {
            DisplayParts(new PartData().GetAllParts());
        }

        // Method to display the parts based on a list of PartData
        private void DisplayParts(List<PartData> partsList)
        {
            partViewPanel.Controls.Clear(); // Clear any existing controls

            int x = 10;
            int y = 10;
            int cardWidth = 200;
            int cardHeight = 300;
            int spacing = 15;

            Debug.WriteLine("Starting to display parts...");

            foreach (var part in partsList)
            {
                Debug.WriteLine($"Creating card for part: {part.PartName}");

                // Create the card panel for each part
                Panel cardPanel = new Panel
                {
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // PictureBox for part image
                PictureBox partImage = new PictureBox
                {
                    Size = new Size(180, 180),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = part.ImageUrl // Set the image path from the database
                };
                cardPanel.Controls.Add(partImage);

                // Labels for part details
                Label nameLabel = new Label
                {
                    Text = "Part: " + part.PartName,
                    Location = new Point(10, 200),
                    AutoSize = true
                };
                cardPanel.Controls.Add(nameLabel);

                Label manufacturerLabel = new Label
                {
                    Text = "Manufacturer: " + part.Manufacturer,
                    Location = new Point(10, 220),
                    AutoSize = true
                };
                cardPanel.Controls.Add(manufacturerLabel);

                Label priceLabel = new Label
                {
                    Text = "Price: $" + part.Price.ToString("N2"),
                    Location = new Point(10, 240),
                    AutoSize = true
                };
                cardPanel.Controls.Add(priceLabel);

                // "Order Now" Button
                Button orderNowButton = new Button
                {
                    Text = "Order Now",
                    Location = new Point(10, 260),
                    Size = new Size(180, 30),
                    BackColor = Color.FromArgb(18, 63, 142),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                orderNowButton.Click += (s, e) => OrderPart(part);
                cardPanel.Controls.Add(orderNowButton);

                // Add the card to the panel
                partViewPanel.Controls.Add(cardPanel);

                Debug.WriteLine($"Added card for {part.PartName} to panel.");

                // Adjust the position for the next card
                x += cardWidth + spacing;
                if (x + cardWidth > this.partViewPanel.Width - 20)
                {
                    x = 10;
                    y += cardHeight + spacing;
                }
            }

            Debug.WriteLine("Finished displaying parts.");
        }

        // Event handler for search button click
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchInput.Text.Trim().ToLower();
            List<PartData> partsList = new PartData().GetAllParts();

            // Filter the parts list based on the search query
            List<PartData> filteredList = partsList.Where(part =>
                part.PartName.ToLower().Contains(searchQuery) ||
                part.Manufacturer.ToLower().Contains(searchQuery) ||
                part.VehicleMake.ToLower().Contains(searchQuery) ||
                part.VehicleModel.ToLower().Contains(searchQuery)
            ).ToList();

            DisplayParts(filteredList); // Display the filtered parts
        }

        // Placeholder method for the "Order Now" button
        private void OrderPart(PartData part)
        {
            // You can implement the actual ordering logic here
            MessageBox.Show($"Order placed for {part.PartName}!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
