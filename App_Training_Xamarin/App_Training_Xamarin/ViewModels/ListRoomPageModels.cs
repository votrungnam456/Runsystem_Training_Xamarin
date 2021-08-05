using System;
using System.Collections.Generic;
using System.Text;
using App_Training_Xamarin.Services;
namespace App_Training_Xamarin.ViewModels
{
    public class ListRoomPageModels
    {
      
        public GetDataRooms dataRooms;
        public ListRoomPageModels()
        {
            dataRooms = new GetDataRooms();
        }
    }
}
