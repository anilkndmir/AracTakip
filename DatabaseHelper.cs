using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCareProApp
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }

        public bool RegisterUser(string mail, string password, string number, string name, string surname)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Mail, Password, Number, Name, Surname) VALUES (@Mail, @Password, @Number, @Name, @Surname)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Number", number);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool LoginUser(string mail, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Mail=@Mail AND Password=@Password";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
