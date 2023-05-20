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

            // Инициализация главного экрана и стека навигации
            MainPage = new NavigationPage(new LoginPage());


            //MainPage = new DeviceListPage();    //BindingModePage();  //NewDevicePage(); // DeviceContolPage();   //WebPage();   //ProfilePage();   
            //NewDevicePage(); //DeviceContolPage();  //DevicesPage(); //CsharpPaddingPage(); //PaddingPage();   //MergeGridPage(); 
            //GridPage();  //AboutPage(); //ClimatePage();   //DevicesPage();   //LoginPage();  //LoadingPage(); //MainPage();
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
