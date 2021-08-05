using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            string username = Preferences.Get("username","");
            mainPage.Title = "Welcome " + username;
        }

        private async void Info_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfomationPage());
        }
    }
}