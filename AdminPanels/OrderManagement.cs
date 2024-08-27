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

        public OrderManagement()
        {
            InitializeComponent();
            LoadCarOrders(); // Load car orders when the UserControl is initialized
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

        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = carOrdersDataGrid.Rows[e.RowIndex];
                selectedOrderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                selectedOrderStatus = row.Cells["Status"].Value.ToString();

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
                CarOrderData carOrderData = new CarOrderData();
                carOrderData.UpdateOrderStatus(selectedOrderId, "Completed");

                MessageBox.Show("Order status updated to Completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCarOrders(); // Refresh the order list

                order_id.Text = "--select--";
                order_status.Text = "--select--";
                conformDilivary_btn.Enabled = false;
            }
        }
    }
}
