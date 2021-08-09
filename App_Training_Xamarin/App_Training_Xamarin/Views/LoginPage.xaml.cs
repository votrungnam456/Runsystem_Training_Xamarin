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
        LoginPageViewModels loginViewModels;
        
        public LoginPage()
        {
            loginViewModels = new LoginPageViewModels(Navigation);
            InitializeComponent();
            BindingContext = loginViewModels;
            
        }
    }
}