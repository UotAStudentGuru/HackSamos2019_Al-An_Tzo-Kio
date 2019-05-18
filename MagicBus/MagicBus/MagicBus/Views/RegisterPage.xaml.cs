using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicBus.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Home(), true);
        }
    }
}