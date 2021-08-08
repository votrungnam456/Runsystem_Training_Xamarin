using System;
using System.Collections.Generic;
using System.Text;

namespace App_Training_Xamarin.Models
{
    public class User
    {
        private string username;
        private string password;
        private string name,introduce;
        private DateTime birthDay;
        private bool gender;
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Introduce { get => introduce; set => introduce = value; }
        public bool Gender { get => gender; set => gender = value; }
    }
}
