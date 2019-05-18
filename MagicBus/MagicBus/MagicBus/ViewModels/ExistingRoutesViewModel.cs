using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MagicBus.Common.Models;
using MagicBus.Common.Services;
using Xamarin.Forms;

namespace MagicBus.ViewModels
{
    public class ExistingRoutesViewModel
    {
        private ObservableCollection<Route> _routes;

        public ObservableCollection<Route> Routes
        {
            get => _routes;
            set => _routes = value;
        }

        public DataService DataService { get; set; }

        public ExistingRoutesViewModel()
        {
            DataService = (Application.Current as App).DataService;
            Routes = new ObservableCollection<Route>(GetRoutes());
        }

        public List<Route> GetRoutes()
        {
            return DataService.GetRoutes();
        }
    }
}
