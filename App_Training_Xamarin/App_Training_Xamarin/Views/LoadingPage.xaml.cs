using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            InitializeComponent();
            WaitingAndLoading();
        }
        public async void WaitingAndLoading()
        {
            await progressBar.ProgressTo(0.25, 1000, Easing.Linear);
            await progressBar.ProgressTo(0.5, 2000, Easing.Linear);
            await progressBar.ProgressTo(0.75, 3000, Easing.Linear);
            await progressBar.ProgressTo(1, 4000, Easing.Linear);
            var homePage = new HomePage();
            homePage.BindingContext = this.BindingContext;
            await Navigation.PushModalAsync(homePage);
        }
    }
}