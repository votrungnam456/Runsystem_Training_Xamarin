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
    public partial class NavigationPage1 : ContentPage
    {
        NavigationPage2 navigationPage2 = new NavigationPage2();
        public NavigationPage1()
        {
            InitializeComponent();
        }
        protected override void OnDisappearing()
        {
             navigationPage2.Title = "Navigation from Page 1";
        }

        private async void NextPage_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(navigationPage2);
        }

        private async void PreviousPage_Clicked(object sender, EventArgs e)
        { 
            await Navigation.PopAsync();
        }
        //private void RemovePage_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        //}
    }
}