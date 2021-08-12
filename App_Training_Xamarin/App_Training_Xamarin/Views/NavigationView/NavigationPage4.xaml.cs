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
    public partial class NavigationPage4 : ContentPage
    {
        public NavigationPage4()
        {
            InitializeComponent();
        }
        private async void NextPage_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NavigatiionPageDisplayView());
        }

        private async void PreviousPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}