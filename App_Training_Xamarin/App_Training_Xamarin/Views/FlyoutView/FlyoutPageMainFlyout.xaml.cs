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
using App_Training_Xamarin.Views.TabbedView;
namespace App_Training_Xamarin.Views.FlyoutView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPageMainFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPageMainFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPageMainFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPageMainFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPageMainFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPageMainFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPageMainFlyoutMenuItem>(new[]
                {
                    new FlyoutPageMainFlyoutMenuItem { Id = 0, Title = "Home - Navigation" ,TargetType=typeof(MainPage)},
                    new FlyoutPageMainFlyoutMenuItem { Id = 1, Title = "Tabbed",TargetType=typeof(MainTabbedPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 2, Title = "Page 3",TargetType=typeof(MainPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 3, Title = "Page 4",TargetType=typeof(MainPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 4, Title = "Page 5",TargetType=typeof(MainPage) },
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