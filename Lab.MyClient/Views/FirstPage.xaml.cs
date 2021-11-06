using System;
using System.Collections.Generic;
using Lab.MyClientLib.ViewModels;
using Xamarin.Forms;

namespace Lab.MyClient.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new FirstPageViewModel();
        }
    }
}
