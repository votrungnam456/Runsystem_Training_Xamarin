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
        
        public ListRoomPage()
        {
            InitializeComponent();
            listRoomsModel = new ListRoomPageModels(Navigation);
            BindingContext = listRoomsModel;
        }

    }
}