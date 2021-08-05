using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace App_Training_Xamarin.Services
{
    public interface IDataStore<T>
    {
        Task<List<T>> GetListItemAsync();
    }
}
