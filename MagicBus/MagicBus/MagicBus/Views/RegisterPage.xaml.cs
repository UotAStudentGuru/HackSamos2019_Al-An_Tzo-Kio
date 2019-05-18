using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicBus.Common.Models;
using MagicBus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
        public UsersViewModel ViewModel { get; set; }

		public RegisterPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();

            ViewModel = (UsersViewModel) BindingContext;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User
            {
                Email = Mail.Text,
                Username = UserName.Text,
                Password = Pass.Text
            };

            ViewModel.InsertUser(user);

            Navigation.PushAsync(new Home(), true);
        }
    }
}