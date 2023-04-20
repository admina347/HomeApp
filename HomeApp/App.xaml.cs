using System;
using HomeApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();  //LoadingPage(); //MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
