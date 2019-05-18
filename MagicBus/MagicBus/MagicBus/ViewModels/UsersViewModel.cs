using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MagicBus.Common.Models;
using MagicBus.Common.Services;
using Xamarin.Forms;

namespace MagicBus.ViewModels
{
    public class UsersViewModel
    {
        private List<User> _users;

        public List<User> Users
        {
            get => _users;
            set => _users = value;
        }

        public DataService DataService { get; set; }

        public UsersViewModel()
        {
            DataService = (Application.Current as App).DataService;
            Users = new List<User>(GetUsers());
        }

        public List<User> GetUsers()
        {
            return DataService.GetUsers();
        }

        public void InsertUser(User user)
        {
            DataService.InsertUser(user);
        }
    }
}
