using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageDetail : ContentPage
    {
        public HomePageDetail()
        {
            InitializeComponent();
            //string nameuser = "ABC";
            if (App.Current.Properties.ContainsKey("username"))
            {
                HomePageDetailTitle.Title = "True";
            }
            else
            {
                HomePageDetailTitle.Title = "False";
                //"Xin chào " + Convert.ToString(Application.Current.Properties["username"]);
            }
        }
    }
}