using ABC_Car_Traders.HomePanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += Custom_FormClosing; // Attach the event handler

            LoadCarView();
            partsView1.Visible = false;
            carView1.Visible = true;
            ordersView1.Visible = false;

            profile_text.Text = "Hi, " + CurrentUser.Username;
        }

        private void Custom_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the entire application if the RegisterForm is closed
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            partsView1.Visible = false;
            carView1.Visible = true;
            ordersView1.Visible = false;

            LoadCarView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            partsView1.Visible = true;
            carView1.Visible = false;
            ordersView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partsView1.Visible = false;
            carView1.Visible = false;
            ordersView1.Visible = true;
        }

        private void LoadCarView()
        {
            Debug.WriteLine($"LoadCarView called. carView1.Visible: {carView1.Visible}");

            if (carView1.Visible)
            {
                carView1.LoadCars();
                Debug.WriteLine("carView1.LoadCars() executed.");
            }
            else
            {
                Debug.WriteLine("carView1.Visible was false, LoadCars() not called.");
            }
        }

    }
}
