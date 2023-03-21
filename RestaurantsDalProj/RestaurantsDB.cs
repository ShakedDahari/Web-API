using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsDalProj
{
    public static class RestaurantsDB
    {
        static string conStr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
        static SqlConnection con = new SqlConnection(conStr);

        public static Restaurant[] GetAllRestaurants()
        {
            string query = $"SELECT * FROM Restaurants";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();

            List<Restaurant> restaurants = new List<Restaurant>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                restaurants.Add(new Restaurant()
                { 
                    ID = (int)reader["ID"],
                    Name = (string)reader["Name"],
                    City = (string)reader["City"],
                    Cuisine = (string)reader["Cuisine"]
                });
            }
            cmd.Connection.Close();

            return restaurants.ToArray();
        }

        public static Restaurant[] GetRestaurantsByCity(string city)
        {
            string query = $"SELECT * FROM Restaurants WHERE City='{city}'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();

            List<Restaurant> restaurants = new List<Restaurant>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                restaurants.Add(new Restaurant()
                {
                    ID = (int)reader["ID"],
                    Name = (string)reader["Name"],
                    City = (string)reader["City"],
                    Cuisine = (string)reader["Cuisine"]
                });
            }
            cmd.Connection.Close();

            return restaurants.ToArray();
        }

        public static Restaurant[] GetRestaurantsByCuisine(string cuisine) 
        {
            string query = $"SELECT * FROM Restaurants WHERE Cuisine='{cuisine}'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection.Open();

            List<Restaurant> restaurants = new List<Restaurant>();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                restaurants.Add(new Restaurant()
                {
                    ID = (int)reader["ID"],
                    Name = (string)reader["Name"],
                    City = (string)reader["City"],
                    Cuisine = (string)reader["Cuisine"]
                });
            }
            cmd.Connection.Close();

            return restaurants.ToArray();
        }
    }
}
