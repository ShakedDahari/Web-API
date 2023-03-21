using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UsersBllProj;
using UsersDalProj;

namespace _3TL.Controllers
{
    public class UsersController : ApiController
    {
        public IHttpActionResult Get()
        {
			try
			{
				User[] users = UsersBll.GetUsers();
				return Ok(users);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
        }

		public IHttpActionResult Get(int id) 
		{
			try
			{
				User user = UsersBll.GetUser(id);
				if (user.Name == null) 
				{
					return NotFound();
				}
				return Ok(user);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
    }
}
