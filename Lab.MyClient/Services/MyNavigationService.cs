using System.Threading.Tasks;
using Lab.MyClientLib.Models;
using Lab.MyClientLib.Services;
using Xamarin.Forms;
using Lab.MyClient.Views;

namespace Lab.MyClient.Services
{
    public class MyNavigationService : IMyNavigationService
    {
        //public INavigation XFNavigation { get; set; }

        public async Task GoBack()
        {
            //await XFNavigation.PopAsync();
            await ((NavigationPage)Application.Current.MainPage).PopAsync();
        }

        public async Task Navigate(ApplicationPage sourcePage)
        {
            switch (sourcePage)
            {
                case ApplicationPage.FirstPage:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new FirstPage(), true);
                    //await XFNavigation.PushAsync(new FirstPage(),true);
                    break;
                case ApplicationPage.SecondPage:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new SecondPage(), true);
                    //await XFNavigation.PushAsync(new SecondPage(),true);
                    break;
                    
                case ApplicationPage.ThirdPage:
                    await ((NavigationPage)Application.Current.MainPage).PushAsync(new ThirdPage(), true);
                    //await XFNavigation.PushAsync(new ThirdPage(),true);
                    break;
            }
            //await XFNavigation.PushAsync(new FirstPage());
        }
    }
}
