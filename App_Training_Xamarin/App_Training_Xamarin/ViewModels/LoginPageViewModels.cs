using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Services;
using App_Training_Xamarin.Models;
using App_Training_Xamarin.Views;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace App_Training_Xamarin.ViewModels
{
    public class LoginPageViewModels
    {
        private INavigation _navigation;
        private Command _loginCommand;
        private Command _registerCommand;
        private List<User> _listUser;
        private string username, password;
        private string _usernameRegister, _passwordRegister, __introduceRegister, _nameRegister;
        private DateTime _birthdayRegister;
        private bool _genderRegister;
        public LoginPageViewModels(INavigation navigation)
        {
            ListUser = dataUsers.listusers;
            Navigation = navigation;
            //foreach(User user in dataUsers.listusers)
            //{
            //    ListUser.Add(user);
            //}    
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(async () => await Register());
        }

        GetDataUsers dataUsers = new GetDataUsers();
        public async Task Login()
        {
            User userCheck = ListUser.FirstOrDefault(user => user.Username.Equals(Username));
            if (userCheck.Password.Equals(Password))
            {
                var homePage = new HomePage();
                homePage.BindingContext = userCheck;
                await Navigation.PushModalAsync(homePage);
            }

        }

        public async Task Register()
        {
            User newUser = new User() { Name = NameRegister, Username = UsernameRegister, Password = PasswordRegister, BirthDay = BirthdayRegister, Gender = GenderRegister, Introduce = IntroduceRegister };
            ListUser.Add(newUser);
            LoginPage loginPage = new LoginPage();
            loginPage.BindingContext = this;
            await Navigation.PushModalAsync(loginPage);
        }
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
        public List<User> ListUser { get => _listUser; set => _listUser = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Command LoginCommand { get => _loginCommand; set => _loginCommand = value; }
        public string UsernameRegister { get => _usernameRegister; set => _usernameRegister = value; }
        public string PasswordRegister { get => _passwordRegister; set => _passwordRegister = value; }
        public DateTime BirthdayRegister { get => _birthdayRegister; set => _birthdayRegister = value; }
        public string IntroduceRegister { get => __introduceRegister; set => __introduceRegister = value; }
        public bool GenderRegister { get => _genderRegister; set => _genderRegister = value; }
        public string NameRegister { get => _nameRegister; set => _nameRegister = value; }
        public Command RegisterCommand { get => _registerCommand; set => _registerCommand = value; }

        //GetDataUsers dataUsers = new GetDataUsers();
        //public bool checkLogin(string username, string password)
        //{
        //    for(int i = 0; i < dataUsers.listusers.Count; i++)
        //    {
        //        if(username.Equals(dataUsers.listusers[i].Username) && password.Equals(dataUsers.listusers[i].Password))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool addUserModel(string name, string username, string password, string birthDay, bool gender, string introduce)
        //{
        //    dataUsers.addUser(name, username, password, birthDay, gender, introduce);
        //    return true;
        //}
    }
}
