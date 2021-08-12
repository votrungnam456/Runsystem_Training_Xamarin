﻿using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Models;
using System.Threading.Tasks;
namespace App_Training_Xamarin.Services
{
    public class GetDataUsers
    {
        public List<User> listusers;
        public GetDataUsers()
        {
            listusers = new List<User>()
            {
                new User {Username = "Nam",Password="123", Name="Vo Trung Nam",BirthDay=new DateTime(2000,04,12),Gender=true,Introduce="Hello everyone, I'm 21 years old"},
                new User {Username = "Dai",Password="456", Name="Duong Van Dai",BirthDay=new DateTime(2000,01,01),Gender=true,Introduce="Hello everyone, I'm living in Phu Yen, Viet Nam"},
            };
        }
        public async Task<List<User>> GetListItemAsync()
        {
            return await Task.FromResult(listusers);
        }
        public bool addUser(string name, string username, string password, DateTime birthDay, bool gender, string introduce)
        {
            User newUser = new User() { Name = name, Username = username, Password = password, BirthDay = birthDay, Gender = gender, Introduce = introduce };
            listusers.Add(newUser);
            return true;
        }
    }
}
