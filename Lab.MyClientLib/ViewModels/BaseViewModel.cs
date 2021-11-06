using System.Threading.Tasks;
using Lab.MyClientLib.Models;
using Lab.MyClientLib.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;

namespace Lab.MyClientLib.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private ApplicationPage _pageToGoTo;
        public ApplicationPage PageToGoTo
        {
            get { return _pageToGoTo; }
            set { SetProperty(ref _pageToGoTo, value); }
        }

        public RelayCommand GoToCommand { get; set; }
        public RelayCommand GoBackCommand { get; set; }

        public BaseViewModel()
        {
            GoBackCommand = new RelayCommand(() => GoBack());
            GoToCommand = new RelayCommand(() => GoTo());
        }

        private async Task GoTo()
        {
            await Ioc.Default.GetRequiredService<IMyNavigationService>().Navigate(PageToGoTo);
        }

        private async Task GoBack()
        {
            await Ioc.Default.GetRequiredService<IMyNavigationService>().GoBack();
        }
    }
}
