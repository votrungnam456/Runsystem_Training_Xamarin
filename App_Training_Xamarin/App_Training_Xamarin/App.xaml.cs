using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.Views.TabbedView;
using App_Training_Xamarin.Views.FlyoutView;
using App_Training_Xamarin.Views.UsingStyle;
using App_Training_Xamarin.Views.Themes;
using App_Training_Xamarin.Views.TriggerView;
namespace App_Training_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var buttonStyle2 = new Style(typeof(Button))
            {
                Setters = {
                new Setter { Property = Button.TextColorProperty, Value = Color.Tomato },
                new Setter { Property = Button.FontSizeProperty, Value = "30" }
            }
            };
            Resources.Add("buttonStyle2", buttonStyle2);
            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            Application.Current.UserAppTheme = OSAppTheme.Dark;
            MainPage = new TriggerPage();
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
