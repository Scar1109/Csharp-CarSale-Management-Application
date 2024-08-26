using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class RegisterForm : Form
    {
        SQLConnection sql = new SQLConnection();

        public RegisterForm()
        {
            InitializeComponent();
            this.FormClosing += RegisterForm_FormClosing; // Attach the event handler
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            // Get user input from text fields
            string username = signup_username.Text.Trim();
            string email = signup_email.Text.Trim();
            string password = signup_password.Text.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("A valid email is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Password is required and must be at least 6 characters long.");
                return;
            }

            string userType = "Customer"; // Default userType as Customer
            DateTime dateRegister = DateTime.Now; // Current date as registration date

            try
            {
                // Open the SQL connection
                sql.OpenConnection();

                // SQL query to insert a new user
                string query = "INSERT INTO users (username, password, email, userType, date_register) " +
                               "VALUES (@Username, @Password, @Email, @UserType, @DateRegister)";

                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@DateRegister", dateRegister);

                    // Execute the query
                    int result = cmd.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (result > 0)
                    {
                        MessageBox.Show("User registered successfully!");
                        ClearInputFields(); // Clear the fields after successful registration
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
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

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the login form
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void signup_email_TextChanged(object sender, EventArgs e)
        {
            // Handle email text changes if needed
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {
            // Handle username text changes if needed
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            // Handle password text changes if needed
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            signup_password.UseSystemPasswordChar = !signup_showPass.Checked;
        }

        // Helper method to validate email using regex
        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                return emailRegex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        // Helper method to clear input fields
        private void ClearInputFields()
        {
            signup_username.Text = string.Empty;
            signup_email.Text = string.Empty;
            signup_password.Text = string.Empty;
            signup_showPass.Checked = false;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the entire application if the RegisterForm is closed
            Application.Exit();
        }
    }
}
