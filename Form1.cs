using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Form1 : Form
    {
        SQLConnection sql = new SQLConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }

        private void signin_username_TextChanged(object sender, EventArgs e)
        {
            // Handle username text changes if needed
        }

        private void signin_password_TextChanged(object sender, EventArgs e)
        {
            // Handle password text changes if needed
        }

        private void signin_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            signin_password.UseSystemPasswordChar = !signin_showPass.Checked;
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            // Get user input from text fields
            string username = signin_username.Text.Trim();
            string password = signin_password.Text.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            try
            {
                // Open the SQL connection
                sql.OpenConnection();

                // SQL query to check if the user exists
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and get the result
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // Proceed to the next form (e.g., Admin or Customer dashboard)
                        //DashboardForm dashboard = new DashboardForm();
                        //dashboard.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                sql.CloseConnection();
            }
        }
    }
}
