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
	public partial class LoginPage : ContentPage
	{
        public UsersViewModel ViewModel { get; set; }

        public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this,false);
			InitializeComponent ();

            ViewModel = (UsersViewModel) BindingContext;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var username = UserName.Text;

            foreach (var user in ViewModel.Users)
                if (username == user.Username)
                {
                    await Navigation.PushAsync(new Home(), true);
                    break;
                }

            await DisplayAlert(null, "Error!", "OK");
        }
    }
}