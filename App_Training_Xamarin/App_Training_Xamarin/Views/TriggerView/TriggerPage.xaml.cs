using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views.TriggerView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TriggerPage : ContentPage
    {
        bool check = true;
        public TriggerPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (check)
            {
                lableUsingPropertyTrigger.Text = "AAAAA";
                check = false;
            }
            else
            {
                lableUsingPropertyTrigger.Text = "Property Trigger !";
                check = true;
            }
        }
    }
}