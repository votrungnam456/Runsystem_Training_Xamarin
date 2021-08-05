using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Models;
namespace App_Training_Xamarin.Services
{
    public class GetDataRooms
    {
        public List<Room> listRoom;
        public GetDataRooms()
        {
            listRoom = new List<Room>()
            {
                new Room{IdRoom="R001", NameRoom = "Room 001", Price = 200000},
                new Room{IdRoom="R002", NameRoom = "Room 002", Price = 300000},
                new Room{IdRoom="R003", NameRoom = "Room 003", Price = 400000},
                new Room{IdRoom="R004", NameRoom = "Room 004", Price = 500000},
                new Room{IdRoom="R005", NameRoom = "Room 005", Price = 600000},
                new Room{IdRoom="R006", NameRoom = "Room 006", Price = 700000},
                new Room{IdRoom="R007", NameRoom = "Room 007", Price = 800000},
                new Room{IdRoom="R008", NameRoom = "Room 008", Price = 900000},
                new Room{IdRoom="R009", NameRoom = "Room 009", Price = 120000},
                new Room{IdRoom="R010", NameRoom = "Room 010", Price = 130000},
                new Room{IdRoom="R011", NameRoom = "Room 011", Price = 140000},
                new Room{IdRoom="R012", NameRoom = "Room 012", Price = 150000},
                new Room{IdRoom="R013", NameRoom = "Room 013", Price = 200000},
                new Room{IdRoom="R014", NameRoom = "Room 014", Price = 200000},
                new Room{IdRoom="R015", NameRoom = "Room 015", Price = 200000},
                new Room{IdRoom="R016", NameRoom = "Room 016", Price = 200000},
                new Room{IdRoom="R017", NameRoom = "Room 017", Price = 200000},
            };
        }
    }
}
