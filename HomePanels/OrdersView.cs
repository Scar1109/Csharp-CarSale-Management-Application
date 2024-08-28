using ABC_Car_Traders.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders.HomePanels
{
    public partial class OrdersView : UserControl
    {
        public OrdersView()
        {
            InitializeComponent();
            LoadOrderCards();
            LoadPartOrderCards();
        }

        // Method to load and display car order cards
        private void LoadOrderCards()
        {
            CarOrderData carOrderData = new CarOrderData();
            int currentUserId = CurrentUser.Id; // Get the current user's ID

            List<CarOrderData> carOrders = carOrderData.GetCarOrdersByCustomer(currentUserId);

            carOrders_Panel.Controls.Clear(); // Clear any existing controls

            int x = 10;
            int y = 10;
            int cardWidth = 400;
            int cardHeight = 150;
            int spacing = 15;
            int cardsPerRow = 2; // Number of cards per row

            int cardsInCurrentRow = 0;

            foreach (var order in carOrders)
            {
                // Create the card panel for each order
                Panel cardPanel = new Panel
                {
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                // PictureBox for car image
                PictureBox carImage = new PictureBox
                {
                    Size = new Size(130, 130),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = order.ImageUrl // Set the image path from the database
                };
                cardPanel.Controls.Add(carImage);

                // Labels for car order details
                Label makeLabel = new Label
                {
                    Text = "Make: " + order.Make,
                    Location = new Point(150, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(makeLabel);

                Label modelLabel = new Label
                {
                    Text = "Model: " + order.Model,
                    Location = new Point(150, 35),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(modelLabel);

                Label priceLabel = new Label
                {
                    Text = "Price: LKR " + order.TotalPrice.ToString("N2"),
                    Location = new Point(150, 60),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(priceLabel);

                Label statusLabel = new Label
                {
                    Text = "Status: " + order.Status,
                    Location = new Point(150, 85),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = order.Status == "Completed" ? Color.Green : Color.OrangeRed
                };
                cardPanel.Controls.Add(statusLabel);

                Label orderDateLabel = new Label
                {
                    Text = "Order Date: " + order.OrderDate.ToString("dd/MM/yyyy"),
                    Location = new Point(150, 110),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(orderDateLabel);

                // Add the card to the panel
                carOrders_Panel.Controls.Add(cardPanel);

                // Adjust the position for the next card
                cardsInCurrentRow++;
                if (cardsInCurrentRow < cardsPerRow)
                {
                    x += cardWidth + spacing;
                }
                else
                {
                    x = 10;
                    y += cardHeight + spacing;
                    cardsInCurrentRow = 0;
                }
            }
        }

        // Method to load and display part order cards
        private void LoadPartOrderCards()
        {
            PartOrderData partOrderData = new PartOrderData();
            int currentUserId = CurrentUser.Id; // Get the current user's ID

            List<PartOrderData> partOrders = partOrderData.GetPartOrdersByCustomer(currentUserId);

            partOrder_panal.Controls.Clear(); // Clear any existing controls

            int x = 10;
            int y = 10;
            int cardWidth = 400;
            int cardHeight = 150;
            int spacing = 15;
            int cardsPerRow = 2; // Number of cards per row

            int cardsInCurrentRow = 0;

            foreach (var order in partOrders)
            {
                // Create the card panel for each order
                Panel cardPanel = new Panel
                {
                    Size = new Size(cardWidth, cardHeight),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                // PictureBox for part image
                PictureBox partImage = new PictureBox
                {
                    Size = new Size(130, 130),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = order.ImageUrl // Set the image path from the database
                };
                cardPanel.Controls.Add(partImage);

                // Labels for part order details
                Label nameLabel = new Label
                {
                    Text = "Part: " + order.PartName,
                    Location = new Point(150, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(nameLabel);

                Label manufacturerLabel = new Label
                {
                    Text = "Manufacturer: " + order.Manufacturer,
                    Location = new Point(150, 35),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(manufacturerLabel);

                Label priceLabel = new Label
                {
                    Text = "Price: LKR " + order.TotalPrice.ToString("N2"),
                    Location = new Point(150, 60),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(priceLabel);

                Label statusLabel = new Label
                {
                    Text = "Status: " + order.Status,
                    Location = new Point(150, 85),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = order.Status == "Completed" ? Color.Green : Color.OrangeRed
                };
                cardPanel.Controls.Add(statusLabel);

                Label orderDateLabel = new Label
                {
                    Text = "Order Date: " + order.OrderDate.ToString("dd/MM/yyyy"),
                    Location = new Point(150, 110),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                cardPanel.Controls.Add(orderDateLabel);

                // Add the card to the panel
                partOrder_panal.Controls.Add(cardPanel);

                // Adjust the position for the next card
                cardsInCurrentRow++;
                if (cardsInCurrentRow < cardsPerRow)
                {
                    x += cardWidth + spacing;
                }
                else
                {
                    x = 10;
                    y += cardHeight + spacing;
                    cardsInCurrentRow = 0;
                }
            }
        }

    }
}
