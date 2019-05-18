using MagicBus.Views;
using System;
using MagicBus.Common.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MagicBus
{
    public partial class App : Application
    {
        public DataService DataService { get; set; }
        public App()
        {
            InitializeComponent();
           
            MainPage = new NavigationPage(new Start());
        }

        protected override void OnStart()
        {
            DataService = new DataService();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
