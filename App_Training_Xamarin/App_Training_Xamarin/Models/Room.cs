using System;
using System.Collections.Generic;
using System.Text;

namespace App_Training_Xamarin.Models
{
    public class Room
    {
        string _idRoom, _nameRoom;
        double _price;

        public string IdRoom { get => _idRoom; set => _idRoom = value; }
        public string NameRoom { get => _nameRoom; set => _nameRoom = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
