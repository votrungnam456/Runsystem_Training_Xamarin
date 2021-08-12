using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_Training_Xamarin.Views.NavigationView;
namespace App_Training_Xamarin
{
    public partial class MainPage : ContentPage
    {
        NavigationPage1 navigationPage1 = new NavigationPage1();
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Main Page";
        }
        protected override void OnDisappearing()
        {
            //ButtonPreviousPage3.Text = "Previous Page";
            navigationPage1.Title = "Navigation from MainPage";
        }
        private async void Next_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(navigationPage1);
        }
    }
}
