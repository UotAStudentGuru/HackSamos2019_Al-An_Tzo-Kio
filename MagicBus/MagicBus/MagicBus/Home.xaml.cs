using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home ()
        {
            InitializeComponent();

            var routes = new List<Route>();
            var route = new Route { Name="Dromologio E1" };
            routes.Add(route);
            route = new Route { Name = "Dromologio E2" };
            routes.Add(route);
            route = new Route { Name = "Dromologio E3" };
            routes.Add(route);

            RouteListView.ItemsSource = routes;
        }

        private void Quit_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopToRootAsync();
        }
    }
}