using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.Models;
namespace App_Training_Xamarin.Views.NavigationView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage3 : ContentPage
    {
        string _title3;
        public NavigationPage3()
        {
            InitializeComponent();
        }

        public string Title1 { get => _title3; set => _title3 = value; }

        protected override void OnAppearing()
        {
            ButtonPreviousPage3.Text = "Previous Page";
            ButtonGoToHomePage3.Text = "Go To Home Page";
            ButtonNextPage3.Text = "Next Page and push Data";
        }
        private async void GoToHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
         
        }

        private async void PreviousPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void NextPage_Clicked(object sender, EventArgs e)
        {
            NavigationPagePassData navigationPagePassData = new NavigationPagePassData();
            var customer = new Customer() { Name = "Võ Trung Nam", Address = "38/3 Nguyễn Trọng Trí, P. An Lạc A, Q. BT", PhoneNumber = "0703197183" };
            navigationPagePassData.BindingContext = customer;
            await Navigation.PushAsync(navigationPagePassData);
        }
    }
}