using App_Training_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views.TabbedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
            NavigationPage navigation = new NavigationPage(new TabbedChild2());
            navigation.Title = "Navigation Tab";
            navigation.IconImageSource = "https://image.flaticon.com/icons/png/512/69/69524.png";
            Children.Add(navigation);

        }

        
    }
}