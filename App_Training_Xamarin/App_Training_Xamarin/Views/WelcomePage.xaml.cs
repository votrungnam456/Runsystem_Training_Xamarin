using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.ViewModels;
namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        LoginPageViewModels loginViewModel;
        public WelcomePage()
        {
            InitializeComponent();
            AutoSlide();
        }
        private void AutoSlide()
        {
            loginViewModel = new LoginPageViewModels(Navigation);
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {

                mainCarousel.Position = (mainCarousel.Position + 1)%loginViewModel.ListImage.Count;

                return true;
            }));
        }
        private async void Info_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfomationPage());
        }
    }
}