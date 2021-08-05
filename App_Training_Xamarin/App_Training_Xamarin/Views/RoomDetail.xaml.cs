using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomDetail : ContentPage
    {
        public RoomDetail()
        {
            Room room = new Room() { IdRoom = "R001", NameRoom = "Room 001", Price = 200000 };
            InitializeComponent();
            BindingContext = room;
        }
        public RoomDetail(string idRoom, string nameRoom, double priceRoom)
        {
            Room room = new Room() { IdRoom = idRoom, NameRoom = nameRoom, Price = priceRoom };
            InitializeComponent();
            BindingContext = room;
        }
        public class Room
        {
            string idRoom, nameRoom;
            double price;

            public string IdRoom { get => idRoom; set => idRoom = value; }
            public string NameRoom { get => nameRoom; set => nameRoom = value; }
            public double Price { get => price; set => price = value; }
        }
    }
}