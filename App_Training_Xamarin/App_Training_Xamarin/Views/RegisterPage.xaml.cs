using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Training_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public bool gender = true;
        public RegisterPage()
        {
            InitializeComponent();
            BirthdayPicker.MaximumDate = new DateTime(DateTime.Now.Year+10,DateTime.Now.Month,DateTime.Now.Day);
            BirthdayPicker.Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private async void GoToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.IsChecked)
            {
                gender = bool.Parse(radioButton.Value.ToString());
            }
        }
    }
}
    