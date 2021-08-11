using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageFlyout : ContentPage
    {
        public ListView ListView;

        public HomePageFlyout()
        {
            InitializeComponent();

            BindingContext = new HomePageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class HomePageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageFlyoutMenuItem> MenuItems { get; set; }

            public HomePageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomePageFlyoutMenuItem>(new[]
                {
                    new HomePageFlyoutMenuItem { Id = 0, Title = "Home" , TargetType=typeof(WelcomePage), UrlIcon="https://image.flaticon.com/icons/png/512/2/2144.png"},
                    new HomePageFlyoutMenuItem { Id = 1, Title = "Introduce",TargetType=typeof(InfomationPage), UrlIcon="https://static.thenounproject.com/png/2043850-200.png"},
                    new HomePageFlyoutMenuItem { Id = 2, Title = "About PG",TargetType=typeof(IntroduceDevPage), UrlIcon="https://i.pinimg.com/474x/53/fa/bf/53fabf5ac9ed557319a2a0fa5ae535d8.jpg" },
                    new HomePageFlyoutMenuItem { Id = 3, Title = "List room",TargetType=typeof(ListRoomPage), UrlIcon="https://image.flaticon.com/icons/png/512/1950/1950715.png"},
                    new HomePageFlyoutMenuItem { Id = 4, Title = "Personal infomation",TargetType=typeof(PersonalInfomationPage), UrlIcon="https://cdn.iconscout.com/icon/premium/png-512-thumb/personal-information-2240981-1897728.png" },
                    new HomePageFlyoutMenuItem { Id = 5, Title = "Setup",TargetType=typeof(SetupPage), UrlIcon="https://icon-library.com/images/set-up-icon/set-up-icon-24.jpg" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}