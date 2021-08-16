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
using App_Training_Xamarin.Views.UsingStyle;
using App_Training_Xamarin.Views.Themes;
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
                    new FlyoutPageMainFlyoutMenuItem { Id = 2, Title = "Explicit style page level",TargetType=typeof(ExplicitStylePage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 3, Title = "Explicit style control level",TargetType=typeof(ExplicitStyleControlLevelPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 4, Title = "Impolicit style page level",TargetType=typeof(ImplicitStylePageLevelPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 5, Title = "Impolicit style control level",TargetType=typeof(ImplicitStyleControllLevelPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 6,Title = "Global style",TargetType=typeof(GlobalStylePage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 7,Title = "Dynamic style",TargetType=typeof(DynamicStylePage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 8,Title = "Class style",TargetType=typeof(StyleClassPage) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 9,Title = "Style using css",TargetType=typeof(PageUsingCss) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 10,Title = "Light Theme",TargetType=typeof(UsingLightTheme) },
                    new FlyoutPageMainFlyoutMenuItem { Id = 11,Title = "App theme binding",TargetType=typeof(AppThemeBindingPage) },
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