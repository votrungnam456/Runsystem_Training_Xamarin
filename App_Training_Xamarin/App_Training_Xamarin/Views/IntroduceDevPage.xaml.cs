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
    public partial class IntroduceDevPage : ContentPage
    {
        public IntroduceDevPage()
        {
            InitializeComponent();
            devPage.Source = new UrlWebViewSource() { Url = "https://votrungnam456.github.io/"};
        }
        
    }
}