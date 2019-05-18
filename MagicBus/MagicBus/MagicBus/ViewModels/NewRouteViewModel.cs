using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using MagicBus.Annotations;
using MagicBus.Common.Models;
using MagicBus.Common.Services;
using Xamarin.Forms;

namespace MagicBus.ViewModels
{
    public class NewRouteViewModel : INotifyPropertyChanged
    {
        private Route _newRoute;
        private DateTime _departureDate;
        private DateTime _departureTime;

        public Route NewRoute
        {
            get => _newRoute;
            set
            {
                _newRoute = value;
                OnPropertyChanged(nameof(NewRoute));
            }
        }

        public DateTime DepartureDate
        {
            get => _departureDate;
            set
            {
                _departureDate = value;
                OnPropertyChanged(nameof(DepartureDate));
            }
        }

        public DateTime DepartureTime
        {
            get => _departureTime;
            set
            {
                _departureTime = value;
                OnPropertyChanged(nameof(DepartureTime));
            }
        }

        public DataService DataService { get; set; }

        public NewRouteViewModel()
        {
            DataService = (Application.Current as App).DataService;
            NewRoute = new Route();
            DepartureDate = DateTime.Now;
            DepartureTime = DateTime.Now;
        }

        public void AddRoute()
        {
            NewRoute.Departure = new DateTime(DepartureDate.Year,DepartureDate.Month,DepartureDate.Day,DepartureTime.Hour,DepartureTime.Minute,DepartureTime.Second);
            DataService.InsertRoute(NewRoute);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
