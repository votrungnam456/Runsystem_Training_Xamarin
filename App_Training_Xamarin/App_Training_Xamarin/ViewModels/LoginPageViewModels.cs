using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Services;
namespace App_Training_Xamarin.ViewModels
{
    public class LoginPageViewModels
    {
        //string username, password;

        //public string Username { get => username; set => username = value; }
        //public string Password { get => password; set => password = value; }

        GetDataUsers dataUsers = new GetDataUsers();
        public bool checkLogin(string username, string password)
        {
            for(int i = 0; i < dataUsers.listusers.Count; i++)
            {
                if(username.Equals(dataUsers.listusers[i].Username) && password.Equals(dataUsers.listusers[i].Password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
