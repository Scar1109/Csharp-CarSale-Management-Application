using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.FormClosing += Custom_FormClosing; // Attach the event handler
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();

                // Remove Current user data
                CurrentUser.Id = 0;
                CurrentUser.Username = " ";
                CurrentUser.Email = " ";
                CurrentUser.UserType = " ";
                CurrentUser.DateRegister = DateTime.Now;

                this.Hide();
            }

            
        }

        private void Custom_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the entire application if the RegisterForm is closed
            Application.Exit();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            carManagement1.Visible = false;
            partManagement1.Visible = false;
            orderManagement1.Visible = false;
            userManagement1.Visible = false;
        }

        private void manageCar_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            carManagement1.Visible = true;
            partManagement1.Visible = false;
            orderManagement1.Visible = false;
            userManagement1.Visible = false;
        }

        private void partDetails_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            carManagement1.Visible = false;
            partManagement1.Visible = true;
            orderManagement1.Visible = false;
            userManagement1.Visible = false;
        }

        private void orderDetails_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            carManagement1.Visible = false;
            partManagement1.Visible = false;
            orderManagement1.Visible = true;
            userManagement1.Visible = false;
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            carManagement1.Visible = false;
            partManagement1.Visible = false;
            orderManagement1.Visible = false;
            userManagement1.Visible = true;
        }
    }
}
