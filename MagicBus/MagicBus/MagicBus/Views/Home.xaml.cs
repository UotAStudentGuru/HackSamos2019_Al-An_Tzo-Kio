using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicBus.Common.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home ()
        {
            InitializeComponent();
        }

        private void Quit_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopToRootAsync();
        }

        private void youroute_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NewRoutePage(),true);
        }

        private void RouteListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            RouteListView.SelectedItem = null;
        }
        private void SavedRoutesListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            SavedRoutesListView.SelectedItem = null;
        }
    }
}