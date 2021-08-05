using System;
using System.Collections.Generic;
using System.Text;

namespace App_Training_Xamarin.Models
{
    public class Room
    {
        string idRoom, nameRoom;
        double price;

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string NameRoom { get => nameRoom; set => nameRoom = value; }
        public double Price { get => price; set => price = value; }
    }
}
