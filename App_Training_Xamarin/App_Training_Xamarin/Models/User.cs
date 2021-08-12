using System;
using System.Collections.Generic;
using System.Text;

namespace App_Training_Xamarin.Models
{
    public class User
    {
        private string _username;
        private string _password;
        private string _name,_introduce;
        private DateTime _birthDay;
        private bool _gender;
        public string Password { get => _password; set => _password = value; }
        public string Username { get => _username; set => _username = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime BirthDay { get => _birthDay; set => _birthDay = value; }
        public string Introduce { get => _introduce; set => _introduce = value; }
        public bool Gender { get => _gender; set => _gender = value; }
    }
}
