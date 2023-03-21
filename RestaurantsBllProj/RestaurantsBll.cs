using RestaurantsDalProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsBllProj
{
    public static class RestaurantsBll
    {
        public static Restaurant[] GetRestaurants()
        {
            Restaurant[] restaurants = null;
            restaurants = RestaurantsDB.GetAllRestaurants();
            return restaurants;
        }

        public static Restaurant[] GetRestaurantsByCity(string city)
        {
            Restaurant[] restaurants = null;
            restaurants = RestaurantsDB.GetRestaurantsByCity(city);
            return restaurants;
        }

        public static Restaurant[] GetRestaurantsByCuisine(string cuisine) 
        {
            Restaurant[] restaurants = null;
            restaurants = RestaurantsDB.GetRestaurantsByCuisine(cuisine);
            return restaurants;
        }
    }
}
