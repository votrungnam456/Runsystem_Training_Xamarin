using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Models;
using System.Threading.Tasks;
namespace App_Training_Xamarin.Services
{
    public class GetDataUsers: IDataStore<User>
    {
        public List<User> listusers;
        public GetDataUsers()
        {
            listusers = new List<User>()
            {
                new User {Username = "Nam",Password="123"},
                new User {Username = "Dai",Password="456"},
            };
        }
        public async Task<List<User>> GetListItemAsync()
        {
            return await Task.FromResult(listusers);
        }
    }
}
