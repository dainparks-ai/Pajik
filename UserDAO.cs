using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserDAO
    {
        private string connectionString = "server=localhost;port=3306;database=userdb;uid=root;pwd=;";

        // REGISTER
        public bool Register(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username=@username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", user.Username);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    return false;
                }

                // Insert new user
                string query = @"INSERT INTO users 
                (username, password, first_name, last_name, address, city, barangay, contact_number)
                VALUES (@username, @password, @fname, @lname, @address, @city, @barangay, @contact)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@fname", user.FirstName);
                cmd.Parameters.AddWithValue("@lname", user.LastName);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@city", user.City);
                cmd.Parameters.AddWithValue("@barangay", user.Barangay);
                cmd.Parameters.AddWithValue("@contact", user.ContactNumber);

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // LOGIN
        public User Login(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User(
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["first_name"].ToString(),
                        reader["last_name"].ToString(),
                        reader["address"].ToString(),
                        reader["city"].ToString(),
                        reader["barangay"].ToString(),
                        reader["contact_number"].ToString()
                    );
                }

                return null;
            }
        }
    }
}