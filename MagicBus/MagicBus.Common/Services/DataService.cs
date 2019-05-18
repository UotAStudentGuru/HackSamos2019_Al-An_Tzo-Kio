using System;
using System.Collections.Generic;
using System.Text;
using MagicBus.Common.Models;

namespace MagicBus.Common.Services
{
   public class DataService
    {
        public List<User> Users { get; set; }
        public List<Route> Routes { get; set; }

        public List<User> GetUsers()
        {
            if (Users != null)
                return Users;
            Users = new List<User>
            {
                new User
                {
                    Name = "Alex",
                    Surname = "Andronis",
                    Username = "Mpuras",
                    Email = "alexandronis@hotmail.com",
                    Password = "1234"
                }
            };
            return Users;
        }

        public List<Route> GetRoutes()
        {
            if(Routes != null)
                return Routes;
            Routes = new List<Route>
            {
                new Route{Destination = "Athens"},
                new Route{Destination = "Thessaloniki"},
                new Route{Destination = "Rodos"},
                new Route{Destination = "Kriti"}
            };
            return Routes;
        }

        public void InsertRoute(Route route)
        {
            Routes.Add(route);
        }

        public void InsertUser(User user)
        {
            Users.Add(user);
        }
    }
}
