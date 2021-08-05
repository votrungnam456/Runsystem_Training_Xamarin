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
                    new HomePageFlyoutMenuItem { Id = 0, Title = "Home" , TargetType=typeof(WelcomePage)},
                    new HomePageFlyoutMenuItem { Id = 1, Title = "Introduce",TargetType=typeof(InfomationPage) },
                    new HomePageFlyoutMenuItem { Id = 2, Title = "About PG",TargetType=typeof(WelcomePage) },
                    new HomePageFlyoutMenuItem { Id = 3, Title = "List room",TargetType=typeof(ListRoomPage)},
                    new HomePageFlyoutMenuItem { Id = 4, Title = "Exit",TargetType=typeof(LoginPage) },
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