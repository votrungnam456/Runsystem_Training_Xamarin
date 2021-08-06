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
        LoginPageViewModels userViewModel;
        public bool gender = true;
        public RegisterPage()
        {
            InitializeComponent();
            BirthdayPicker.MaximumDate = new DateTime(DateTime.Now.Year+10,DateTime.Now.Month,DateTime.Now.Day);
            BirthdayPicker.Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        public RegisterPage(LoginPageViewModels loginPageViewModels)
        {
            userViewModel = loginPageViewModels;
            InitializeComponent();
            BirthdayPicker.MaximumDate = new DateTime(DateTime.Now.Year + 10, DateTime.Now.Month, DateTime.Now.Day);
            BirthdayPicker.Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        private async void Register_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(NameEntry.Text) || String.IsNullOrWhiteSpace(IdEntry.Text)|| String.IsNullOrWhiteSpace(PasswordEntry.Text) )
            {
                await DisplayAlert("Failed", "Register failed", "OK");
            }
            else
            {
                string name = NameEntry.Text.Trim();
                string username = IdEntry.Text.Trim();
                string password = PasswordEntry.Text.Trim();
                string introduce;
                if (String.IsNullOrWhiteSpace(IntroduceEditor.Text))
                {
                    introduce = "Hello everyone";
                }
                else
                {
                    introduce = IntroduceEditor.Text.Trim();
                }              
                string birthDay = BirthdayPicker.Date.ToString("MM/dd/yyyy");
                userViewModel.addUserModel(name, username, password, birthDay, gender, introduce);
                await DisplayAlert("Successed", "Register successed", "OK");
                await Navigation.PushModalAsync(new LoginPage(userViewModel));
            }
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