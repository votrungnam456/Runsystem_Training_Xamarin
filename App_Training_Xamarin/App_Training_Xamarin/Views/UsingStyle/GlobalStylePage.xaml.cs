using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views.UsingStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalStylePage : ContentPage
    {
        public GlobalStylePage()
        {
            InitializeComponent();
            Button button = new Button();
            button.Text = "This button created in code behind and set global style";
            button.Style = (Style)Application.Current.Resources["buttonStyle2"];
            stackLayouyGlobalStyle.Children.Add(button);
        }
    }
}