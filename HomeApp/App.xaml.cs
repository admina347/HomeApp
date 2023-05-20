using System;
using System.IO;
using AutoMapper;
using HomeApp.Data;
using HomeApp.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public partial class App : Application
    {
        // Инициализация репозитория
        public static HomeDeviceRepository HomeDevices = new HomeDeviceRepository(
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                $"homedevices.db")
            );

        public static IMapper Mapper { get; set; }


        public App()
        {
            Mapper = CreateMapper();

            InitializeComponent();

            // Инициализация главного экрана и стека навигации
            MainPage = new NavigationPage(new LoginPage());


            //MainPage = new DeviceListPage();    //BindingModePage();  //NewDevicePage(); // DeviceContolPage();   //WebPage();   //ProfilePage();   
            //NewDevicePage(); //DeviceContolPage();  //DevicesPage(); //CsharpPaddingPage(); //PaddingPage();   //MergeGridPage(); 
            //GridPage();  //AboutPage(); //ClimatePage();   //DevicesPage();   //LoginPage();  //LoadingPage(); //MainPage();
        }

        /// <summary>
        /// Создание Автомаппера для преобразования сущностей
        /// </summary>
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Tables.HomeDevice, Models.HomeDevice>();
                cfg.CreateMap<Models.HomeDevice, Data.Tables.HomeDevice>();
            });

            return config.CreateMapper();
        }


        protected async override void OnStart()
        {
            await HomeDevices.InitDatabase();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
