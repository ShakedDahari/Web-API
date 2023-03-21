using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersDalProj;

namespace UsersBllProj
{
    public static class UsersBll
    {
        public static User[] GetUsers() 
        {
            User[] users = null;
            users = UsersDB.GetAllUsers();
            return users;
        }

        public static User GetUser(int id) 
        { 
            User user = UsersDB.GetUser(id);
            return user;
        }
    }
}
