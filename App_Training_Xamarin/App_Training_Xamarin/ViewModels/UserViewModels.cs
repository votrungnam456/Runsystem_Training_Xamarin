using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_Training_Xamarin.ViewModels
{
    class UserViewModels : BindableObject, INotifyPropertyChanged
    {
        public string SelectedItemText { get; private set; }
        public ICommand OutputAgeCommand { get; set; }
        public ObservableCollection<UserModel> UserList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public UserViewModels()
        {
            UserList = new ObservableCollection<UserModel>()
            {
                new UserModel("uesr 1", 1),
                new UserModel("uesr 2", 0),
                new UserModel("uesr 3", 0)
            };
            OutputAgeCommand = new Command<UserModel>(HandelOutputAgeCommand);
        }
        void HandelOutputAgeCommand(UserModel obj)
        {
            SelectedItemText = string.Format("{0} is {1} years old.", obj.Name, 11);
            OnPropertyChanged(SelectedItemText);
       
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class UserModel
    {
        public string Name { get; set; }
        public int Sex { get; set; }

        public UserModel(string name, int sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
