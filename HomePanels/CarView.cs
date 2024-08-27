using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ABC_Car_Traders.HomePanels
{
    public partial class CarView : UserControl
    {
        public CarView()
        {
            InitializeComponent();
            LoadCars(); // Load the cars initially

        }

        // Method to load cars initially
        public void LoadCars()
        {
            DisplayCars(new CarData().CarListData());
        }

        // Method to display the cars based on a list of CarData
        private void DisplayCars(List<CarData> carList)
        {
            carViewPanel.Controls.Clear(); // Clear any existing controls

            if (carList.Count == 0)
            {
                // Show "No cars available" message if no cars are found
                Label noCarsLabel = new Label
                {
                    Text = "No cars available",
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point((carViewPanel.Width / 2) - 75, (carViewPanel.Height / 2) - 10),
                    ForeColor = Color.Red
                };
                carViewPanel.Controls.Add(noCarsLabel);
                return;
            }

            int x = 10;
            int y = 10;
            int cardWidth = 200;
            int cardHeight = 300;
            int spacing = 15;

            Debug.WriteLine("Starting to display cars...");

            foreach (var car in carList)
            {
                Debug.WriteLine($"Creating card for car: {car.Make} {car.Model}");

                // Create the card panel for each car
                Panel cardPanel = new Panel
                {
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // PictureBox for car image
                PictureBox carImage = new PictureBox
                {
                    Size = new Size(180, 180),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = car.ImageUrl // Set the image path from the database
                };
                cardPanel.Controls.Add(carImage);

                // Labels for car details
                Label makeLabel = new Label
                {
                    Text = "Make: " + car.Make,
                    Location = new Point(10, 200),
                    AutoSize = true
                };
                cardPanel.Controls.Add(makeLabel);

                Label modelLabel = new Label
                {
                    Text = "Model: " + car.Model,
                    Location = new Point(10, 220),
                    AutoSize = true
                };
                cardPanel.Controls.Add(modelLabel);

                Label priceLabel = new Label
                {
                    Text = "Price: $" + car.Price.ToString("N2"),
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
                orderNowButton.Click += (s, e) => OrderCar(car);
                cardPanel.Controls.Add(orderNowButton);

                // Add the card to the panel
                carViewPanel.Controls.Add(cardPanel);

                Debug.WriteLine($"Added card for {car.Make} {car.Model} to panel.");

                // Adjust the position for the next card
                x += cardWidth + spacing;
                if (x + cardWidth > this.carViewPanel.Width - 20)
                {
                    x = 10;
                    y += cardHeight + spacing;
                }
            }

            Debug.WriteLine("Finished displaying cars.");
        }


        // Event handler for search button click
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchInput.Text.Trim().ToLower();
            List<CarData> carList = new CarData().CarListData();

            // Filter the car list based on the search query
            List<CarData> filteredList = carList.Where(car =>
                car.Make.ToLower().Contains(searchQuery) ||
                car.Model.ToLower().Contains(searchQuery) ||
                car.RegistrationNumber.ToLower().Contains(searchQuery)
            ).ToList();

            DisplayCars(filteredList); // Display the filtered cars
        }

        // Placeholder method for the "Order Now" button
        private void OrderCar(CarData car)
        {
            // You can implement the actual ordering logic here
            MessageBox.Show($"Order placed for {car.Make} {car.Model}!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
