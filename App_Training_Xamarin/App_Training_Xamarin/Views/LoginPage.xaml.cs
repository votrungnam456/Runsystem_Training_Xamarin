using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Training_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginPageViewModels loginViewModels = new LoginPageViewModels();
        
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string username = IdEntry.Text;
            string password = PasswordEntry.Text;
            if (loginViewModels.checkLogin(username, password))
            {
                Preferences.Set("username", username);
                await Navigation.PushModalAsync(new HomePage());
            }
        }
    }
}