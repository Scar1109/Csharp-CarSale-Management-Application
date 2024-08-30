using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ABC_Car_Traders.Data
{
    public class UserData
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public DateTime DateRegister { get; set; }

        private SQLConnection sql = new SQLConnection();

        // Method to retrieve all users
        public List<UserData> GetAllUsers()
        {
            List<UserData> userList = new List<UserData>();

            try
            {
                sql.OpenConnection();
                string query = "SELECT id, username, email, password, userType, date_register FROM users";
                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UserData user = new UserData
                        {
                            Id = (int)reader["id"],
                            Username = reader["username"].ToString(),
                            Email = reader["email"].ToString(),
                            Password = reader["password"].ToString(),
                            UserType = reader["userType"].ToString(),
                            DateRegister = (DateTime)reader["date_register"]
                        };
                        userList.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving users: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }

            return userList;
        }

        // Method to add a new user
        public void AddUser(UserData user)
        {
            try
            {
                sql.OpenConnection();
                string query = "INSERT INTO users (username, email, password, userType, date_register) VALUES (@Username, @Email, @Password, @UserType, @DateRegister)";
                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);
                    cmd.Parameters.AddWithValue("@DateRegister", user.DateRegister);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding user: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }
        }

        // Method to update an existing user
        public void UpdateUser(UserData user)
        {
            try
            {
                sql.OpenConnection();
                string query = "UPDATE users SET username = @Username, email = @Email, password = @Password, userType = @UserType WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@UserType", user.UserType);
                    cmd.Parameters.AddWithValue("@Id", user.Id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }
        }

        // Method to delete a user
        public void DeleteUser(int userId)
        {
            try
            {
                sql.OpenConnection();
                string query = "DELETE FROM users WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, sql.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting user: " + ex.Message);
            }
            finally
            {
                sql.CloseConnection();
            }
        }
    }
}
