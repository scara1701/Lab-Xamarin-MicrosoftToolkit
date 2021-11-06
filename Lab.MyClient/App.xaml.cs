using Lab.MyClient.Services;
using Lab.MyClient.Views;
using Lab.MyClientLib.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Xamarin.Forms;

namespace Lab.MyClient
{
    public partial class App : Application
    {
        public static MyNavigationService MyNavigationService { get; set; }
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
        }

        private void ConfigureServices()
        {
            Ioc.Default.ConfigureServices(new ServiceCollection()
            .AddSingleton<IMyNavigationService>(MyNavigationService)
            .BuildServiceProvider()
            );
        }


        protected override void OnStart()
        {
            MainPage = new NavigationPage(new MainPage());
            MyNavigationService = new MyNavigationService();
            //MyNavigationService.XFNavigation = MainPage.Navigation;
            ConfigureServices();
            //register viewmodels

            MainPage = new NavigationPage(new FirstPage());
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
