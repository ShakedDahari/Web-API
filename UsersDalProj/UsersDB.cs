using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersDalProj
{
    public static class UsersDB
    {
        static string conStr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
        static SqlConnection con = new SqlConnection(conStr);

        public static User[] GetAllUsers()
        {
            string query = $"SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();

            List<User> users = new List<User>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                users.Add(new User()
                { 
                    ID = (int)reader["ID"],
                    Name = (string)reader["Name"],
                    Email = (string)reader["Email"]
                });            
            }
            cmd.Connection.Close();

            return users.ToArray();
        }

        public static User GetUser(int id) 
        {
            string query = $"SELECT * FROM Users WHERE ID=" + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();

            User user = new User();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                user = new User()
                {
                    ID = (int)reader["ID"],
                    Name = (string)reader["Name"],
                    Email = (string)reader["Email"]
                };
            }
            cmd.Connection.Close();

            return user;
        }
    }
}
