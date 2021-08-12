using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Training_Xamarin.Views.NavigationView;
namespace App_Training_Xamarin.Views.TabbedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedChild2 : ContentPage
    {
        public TabbedChild2()
        {
            InitializeComponent();
        }

        private async void Navigation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage1());
        }
    }
}