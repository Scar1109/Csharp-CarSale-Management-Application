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

                // SQL query to check if the user exists and retrieve user details
                string query = "SELECT id, username, email, userType, date_register FROM users WHERE username = @Username AND password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and read the result
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Store user details in the CurrentUser class
                            CurrentUser.Id = reader.GetInt32(0);
                            CurrentUser.Username = reader.GetString(1);
                            CurrentUser.Email = reader.GetString(2);
                            CurrentUser.UserType = reader.GetString(3);
                            CurrentUser.DateRegister = reader.GetDateTime(4);

                            MessageBox.Show("Login successful as " + CurrentUser.UserType);

                            // Redirect based on user type
                            if (CurrentUser.UserType == "Admin")
                            {
                                //AdminDashboard adminDashboard = new AdminDashboard();
                                //adminDashboard.Show();
                            }
                            else if (CurrentUser.UserType == "Customer")
                            {
                                //Home home = new Home();
                                //home.Show();
                            }

                            this.Hide(); // Hide the login form
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
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
