using Lab.MyClientLib.Models;

namespace Lab.MyClientLib.ViewModels
{
    public class FirstPageViewModel : BaseViewModel
    {
        public FirstPageViewModel()
        {
            Title = "This is the mainpage";
            PageToGoTo = ApplicationPage.SecondPage;
        }
    }
}
