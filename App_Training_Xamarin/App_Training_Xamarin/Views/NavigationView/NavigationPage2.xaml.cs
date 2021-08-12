using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views.NavigationView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage2 : ContentPage
    {
        NavigationPage3 navigationPage3 = new NavigationPage3();
        public NavigationPage2()
        {
            InitializeComponent();
        }
        protected override void OnDisappearing()
        {
            navigationPage3.Title = "Navigation from Page 2";
        }

        private async void NextPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(navigationPage3, false);
        }

        private async void PreviousPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(false);
        }
    }
}