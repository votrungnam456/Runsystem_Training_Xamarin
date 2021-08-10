using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Services;
using App_Training_Xamarin.Models;
using App_Training_Xamarin.Views;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App_Training_Xamarin.ViewModels
{
    public class ListRoomPageModels : INotifyPropertyChanged
    {
        private ICommand detailCommand;
        private List<Room> rooms;
        private GetDataRooms dataRooms;
        private INavigation _navigation;
        private Command<string> _filterCommand;
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Room> searchResults;
        public ListRoomPageModels(INavigation navigation)
        {
            DataRooms = new GetDataRooms();
            Rooms = DataRooms.listRoom;
            DetailCommand = new Command(async (obj)=> await LoadDetailPage(obj));
            Navigation = navigation;
            FilterCommand = new Command<string>((query) => Search(query));
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Search(string query)
        {
           Rooms = DataRooms.listRoom;
            if (!query.Trim().Equals(""))
            {
                SearchResults = new List<Room>();
                foreach (Room room in Rooms)
                {
                    if (room.NameRoom.Contains(query.Trim()))
                    {
                        SearchResults.Add(room);
                    }
                }
                Rooms = SearchResults;
            }
        }
        
        public List<Room> SearchResults
        {
            get
            {
                return searchResults;
            }
            set
            {
                searchResults = value;
                NotifyPropertyChanged();
            }
        }
        public async Task LoadDetailPage(object obj)
        {
            var a = new RoomDetail();
            a.BindingContext = obj;
            await Navigation.PushAsync(a);
        }
        public GetDataRooms DataRooms { get => dataRooms; set => dataRooms = value; }
        public List<Room> Rooms {
            get {
                return rooms;
            }
            set { 
                rooms = value;
                NotifyPropertyChanged();
            } 
        }
        public ICommand DetailCommand { get => detailCommand; set => detailCommand = value; }
        public INavigation Navigation { get => _navigation; set => _navigation = value; }
        public Command<string> FilterCommand { get => _filterCommand; set => _filterCommand = value; }
    }
}
