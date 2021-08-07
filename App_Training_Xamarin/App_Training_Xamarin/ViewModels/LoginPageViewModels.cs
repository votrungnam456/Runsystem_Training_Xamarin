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
        private List<User> _listUser;
        public LoginPageViewModels(INavigation navigation)
        {
            Navigation = navigation;
            ListUser = dataUsers.listusers;
            LoginCommand = new Command(async () => await Login());
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
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
        public List<User> ListUser { get => _listUser; set => _listUser = value; }
        string username, password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Command LoginCommand { get => _loginCommand; set => _loginCommand = value; }

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
