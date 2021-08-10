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
            //var Images = new List<string>
            //{
            //    "https://image.shutterstock.com/image-photo/beautiful-abstract-grunge-decorative-navy-260nw-539880832.jpg","http://localhost:62212/Uploads/back2.png","http://localhost:62212/Uploads/heart.png"
            //};

            //mainCarousel.ItemsSource = Images;
            //imgWelcomes.Source = ImageSource.FromUri(new Uri("https://pix10.agoda.net/hotelImages/124/1246280/1246280_16061017110043391702.jpg?s=1024x768"));
        }

        private async void Info_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfomationPage());
        }
    }
}