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
    public partial class ImplicitStyleControllLevelPage : ContentPage
    {
        public ImplicitStyleControllLevelPage()
        {
            InitializeComponent();
            var entryCodeStyle = new Style(typeof(Entry))
            {
                Setters = {
                new Setter { Property = Entry.TextColorProperty, Value = Color.Blue },
                new Setter { Property = Entry.TextProperty, Value = "This entry was created and set style in the code behind" }
            }
            };
            Resources = new ResourceDictionary();
            Resources.Add(entryCodeStyle);
            Entry entry = new Entry();
            stackLayoutImplicitStyleControlLevel.Children.Add(entry);
        }
    }
}