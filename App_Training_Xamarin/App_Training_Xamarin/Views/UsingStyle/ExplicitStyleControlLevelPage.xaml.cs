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
    public partial class ExplicitStyleControlLevelPage : ContentPage
    {
        public ExplicitStyleControlLevelPage()
        {
            InitializeComponent();

            var boxViewRedStyle = new Style(typeof(BoxView))
            {
                Setters = {
                new Setter { Property = BoxView.ColorProperty, Value = Color.Red },
                new Setter {Property = BoxView.WidthRequestProperty, Value = "30"},
                new Setter {Property = BoxView.HeightRequestProperty, Value = "50"}
                }
            };
            Resources = new ResourceDictionary();
            Resources.Add("boxViewRedStyle", boxViewRedStyle);
            BoxView boxView = new BoxView();
            boxView.Style = (Style)Resources["boxViewRedStyle"];
            stackLayoutMain.Children.Add(boxView);
        }
    }
}