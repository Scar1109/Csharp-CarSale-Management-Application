using ABC_Car_Traders.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders.AdminPanels
{
    public partial class OrderManagement : UserControl
    {
        private int selectedOrderId;
        private string selectedOrderStatus;
        private string selectedOrderType; // To differentiate between car orders and part orders

        public OrderManagement()
        {
            InitializeComponent();
            LoadCarOrders(); // Load car orders when the UserControl is initialized
            LoadPartOrders(); // Load part orders when the UserControl is initialized
        }

        private void LoadCarOrders()
        {
            CarOrderData carOrderData = new CarOrderData();
            List<CarOrderData> carOrders = carOrderData.GetAllCarOrders();

            carOrdersDataGrid.DataSource = carOrders;

            carOrdersDataGrid.Columns["ImageUrl"].Visible = false;
            carOrdersDataGrid.Columns["Model"].Visible = false;
            carOrdersDataGrid.Columns["Make"].Visible = false;
            carOrdersDataGrid.Columns["OrderDate"].Visible = false;

            // Set DataGridView properties
            carOrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            carOrdersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadPartOrders()
        {
            PartOrderData partOrderData = new PartOrderData();
            List<PartOrderData> partOrders = partOrderData.GetAllPartOrders();



            partOrdersDataGrid.DataSource = partOrders;

            partOrdersDataGrid.Columns["ImageUrl"].Visible = false;
            partOrdersDataGrid.Columns["Manufacturer"].Visible = false;
            partOrdersDataGrid.Columns["OrderDate"].Visible = false;



            // Set DataGridView properties
            partOrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partOrdersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void carOrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carOrdersDataGrid.Rows[e.RowIndex];
                selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                selectedOrderStatus = row.Cells["Status"].Value.ToString();
                selectedOrderType = "Car"; // Mark that the selected order is a car order

                order_id.Text = selectedOrderId.ToString();
                order_status.Text = selectedOrderStatus;

                if (selectedOrderStatus == "Completed")
                {
                    conformDilivary_btn.Enabled = false;
                }
                else
                {
                    conformDilivary_btn.Enabled = true;
                }
            }
        }

        private void partOrdersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = partOrdersDataGrid.Rows[e.RowIndex];
                selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                selectedOrderStatus = row.Cells["Status"].Value.ToString();
                selectedOrderType = "Part"; // Mark that the selected order is a part order

                order_id.Text = selectedOrderId.ToString();
                order_status.Text = selectedOrderStatus;

                if (selectedOrderStatus == "Completed")
                {
                    conformDilivary_btn.Enabled = false;
                }
                else
                {
                    conformDilivary_btn.Enabled = true;
                }
            }
        }

        private void conformDilivary_btn_Click(object sender, EventArgs e)
        {
            if (selectedOrderId > 0)
            {
                if (selectedOrderType == "Car")
                {
                    CarOrderData carOrderData = new CarOrderData();
                    carOrderData.UpdateOrderStatus(selectedOrderId, "Completed");
                    MessageBox.Show("Car order status updated to Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCarOrders(); // Refresh the car order list
                }
                else if (selectedOrderType == "Part")
                {
                    PartOrderData partOrderData = new PartOrderData();
                    partOrderData.UpdateOrderStatus(selectedOrderId, "Completed");
                    MessageBox.Show("Part order status updated to Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPartOrders(); // Refresh the part order list
                }

                order_id.Text = "--select--";
                order_status.Text = "--select--";
                conformDilivary_btn.Enabled = false;
            }
        }
    }
}
