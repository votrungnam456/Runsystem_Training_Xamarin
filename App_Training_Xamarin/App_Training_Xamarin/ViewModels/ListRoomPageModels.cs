using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Services;
using App_Training_Xamarin.Models;
using App_Training_Xamarin.Views;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Training_Xamarin.ViewModels
{
    public class ListRoomPageModels
    {
        private ICommand detailCommand;
        private List<Room> rooms;
        private GetDataRooms dataRooms;
        private INavigation _navigation;
        public ListRoomPageModels(INavigation navigation)
        {
            DataRooms = new GetDataRooms();
            Rooms = DataRooms.listRoom;
            DetailCommand = new Command(async (obj)=> await LoadDetailPage(obj));
            Navigation = navigation;
        }

        public async Task LoadDetailPage(object obj)
        {
            var a = new RoomDetail();
            a.BindingContext = obj;
            await Navigation.PushAsync(a);
        }
        public GetDataRooms DataRooms { get => dataRooms; set => dataRooms = value; }
        public List<Room> Rooms { get => rooms; set => rooms = value; }
        public ICommand DetailCommand { get => detailCommand; set => detailCommand = value; }
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
    }
}
