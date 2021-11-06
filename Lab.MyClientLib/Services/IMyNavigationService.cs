using System;
using System.Threading.Tasks;
using Lab.MyClientLib.Models;

namespace Lab.MyClientLib.Services
{
    public interface IMyNavigationService
    {
        Task GoBack();
        Task Navigate(ApplicationPage sourcePage);
    }
}