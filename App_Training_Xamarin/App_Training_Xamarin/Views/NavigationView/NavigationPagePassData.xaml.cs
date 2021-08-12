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
    public partial class NavigationPagePassData : ContentPage
    {
        public NavigationPagePassData()
        {
            InitializeComponent();
        }

        private async void NextPage_Clicked(object sender, EventArgs e)
        {
            NavigationPage4 navigationPage4 = new NavigationPage4();
            await Navigation.PushAsync(navigationPage4);
        }
        private async void PreviousPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void AddPageBefore_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new NavigationPageBeingInsertBefore(), this);
        }
        private void RemovePage_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count -2]);
        }
    }
}