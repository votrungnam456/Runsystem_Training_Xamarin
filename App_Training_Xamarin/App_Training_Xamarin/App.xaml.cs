using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.Views;
namespace App_Training_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
