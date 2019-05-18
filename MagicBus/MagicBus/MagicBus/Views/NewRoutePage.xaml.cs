using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewRoutePage : ContentPage
	{
		public NewRoutePage()
        {
            InitializeComponent();

        }

        private void Submit_OnClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as NewRouteViewModel;
            vm.AddRoute();
            this.Navigation.PushAsync(new Home(), true);
        }
    }
}