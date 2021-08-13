using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.Views.TabbedView;
using App_Training_Xamarin.Views.FlyoutView;
using App_Training_Xamarin.Views.UsingStyle;
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
                new Setter { Property = Button.TextColorProperty,    Value = Color.Tomato },
                new Setter { Property = Button.FontSizeProperty,    Value = "30" }
            }
            };

            Resources = new ResourceDictionary();
            Resources.Add("buttonStyle2", buttonStyle2);
            MainPage = new PageUsingCss();
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
