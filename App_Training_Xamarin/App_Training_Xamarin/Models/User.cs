using System;
using System.Collections.Generic;
using System.Text;

namespace App_Training_Xamarin.Models
{
    public class User
    {
        private string username;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
