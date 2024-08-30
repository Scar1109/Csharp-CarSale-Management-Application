using ABC_Car_Traders.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABC_Car_Traders.AdminPanels
{
    public partial class UserManagement : UserControl
    {
        private UserData selectedUser; // To store the selected user

        public UserManagement()
        {
            InitializeComponent();
            LoadUsers(); // Load users when the UserControl is initialized
            TogglePasswordVisibility();
        }

        // Method to load users into the DataGridView
        private void LoadUsers()
        {
            UserData userData = new UserData();
            List<UserData> userList = userData.GetAllUsers();
            dataGridView1.DataSource = userList;

            // Set DataGridView properties
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Event handler to clear input fields
        private void input_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Event handler to delete a user
        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete user {selectedUser.Username}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    UserData userData = new UserData();
                    userData.DeleteUser(selectedUser.Id);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers(); // Refresh the user list
                    ClearFields();
                }
            }
        }

        // Event handler to add a new user
        private void addNew_userBtn_Click(object sender, EventArgs e)
        {
            UserData newUser = new UserData
            {
                Username = username_input.Text.Trim(),
                Email = emailInput.Text.Trim(),
                Password = password_inputBox.Text.Trim(),
                UserType = "Customer", // Default user type, can be changed based on requirements
                DateRegister = DateTime.Now
            };

            UserData userData = new UserData();
            userData.AddUser(newUser);
            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers(); // Refresh the user list
            ClearFields();
        }

        // Event handler to handle DataGridView cell click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedUser = new UserData
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Username = row.Cells["Username"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Password = row.Cells["Password"].Value.ToString(),
                    UserType = row.Cells["UserType"].Value.ToString(),
                    DateRegister = Convert.ToDateTime(row.Cells["DateRegister"].Value)
                };

                // Fill input fields with selected user details
                username_input.Text = selectedUser.Username;
                emailInput.Text = selectedUser.Email;
                password_inputBox.Text = selectedUser.Password;
            }
            TogglePasswordVisibility();
        }

        // Method to clear input fields
        private void ClearFields()
        {
            username_input.Text = "";
            emailInput.Text = "";
            password_inputBox.Text = "";
            selectedUser = null;
        }

        private void showPwd_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            TogglePasswordVisibility();
        }

        // Method to toggle password visibility
        private void TogglePasswordVisibility()
        {
            password_inputBox.UseSystemPasswordChar = showPwd_checkBox.Checked;
        }
    }
}
