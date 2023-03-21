using RestaurantsBllProj;
using RestaurantsDalProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _3TL.Controllers
{
    public class RestaurantsController : ApiController
    {
        public IHttpActionResult Get()
        {
			try
			{
                Restaurant[] restaurant = RestaurantsBll.GetRestaurants();
                return Ok(restaurant);
			}
			catch (Exception ex)
			{
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Get(string city)
        {
            try
            {
                Restaurant[] restaurant = RestaurantsBll.GetRestaurantsByCity(city);
                if (restaurant.Length == 0)
                {
                    return NotFound();
                }
                return Ok(restaurant);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Post(string cuisine) 
        {
            try
            {
                Restaurant[] restaurant = RestaurantsBll.GetRestaurantsByCuisine(cuisine);
                if (restaurant.Length == 0)
                {
                    return NotFound();
                }
                return Ok(restaurant);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.Conflict, ex.Message);
            }
        }
    }
}
