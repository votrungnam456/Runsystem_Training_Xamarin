using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Training_Xamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;
namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListRoomPage : ContentPage
    {
        ListRoomPageModels listRoomsModel;
        //public List<Room> listRoom;
        public ListRoomPage()
        {
            InitializeComponent();
            //listRoom = new List<Room>();
            //listRoom.Add(new Room() { IdRoom = "R001", NameRoom = "Room 001", Price = 200000 });
            //listRoom.Add(new Room() { IdRoom = "R002", NameRoom = "Room 002", Price = 300000 });
            //listRoom.Add(new Room() { IdRoom = "R003", NameRoom = "Room 003", Price = 400000 });
            //BindingContext = listRoom;
            listRoomsModel = new ListRoomPageModels();
            BindingContext = listRoomsModel.dataRooms.listRoom;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button theButton = (Button)sender;
            int row = Grid.GetRow(theButton);
            string getIdRoom = listRoomsModel.dataRooms.listRoom[row].IdRoom;
            string getNameRoom = listRoomsModel.dataRooms.listRoom[row].NameRoom;
            double getPriceRoom = listRoomsModel.dataRooms.listRoom[row].Price;


            await Navigation.PushAsync(new RoomDetail(getIdRoom,getNameRoom,getPriceRoom));
        }
        //public class Room
        //{
        //    string idRoom, nameRoom;
        //    double price;

        //    public string IdRoom { get => idRoom; set => idRoom = value; }
        //    public string NameRoom { get => nameRoom; set => nameRoom = value; }
        //    public double Price { get => price; set => price = value; }
        //}
    }
}