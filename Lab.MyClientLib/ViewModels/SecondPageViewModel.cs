using Lab.MyClientLib.Models;

namespace Lab.MyClientLib.ViewModels
{
    public class SecondPageViewModel : BaseViewModel
    {
        public SecondPageViewModel()
        {
            Title = "This is the second page";
            PageToGoTo = ApplicationPage.ThirdPage;
        }
    }
}
