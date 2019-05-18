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
	public partial class Start : ContentPage
	{
		public Start ()
		{
			InitializeComponent ();
		}

        private void LoginClicked (object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new LoginPage(),true);
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RegisterPage(),true);
        }
    }
}