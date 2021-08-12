using App_Training_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Training_Xamarin.Views.TabbedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageUsingTemplate : TabbedPage
    {
        List<Customer> listCustomer;
        public TabbedPageUsingTemplate()
        {
            InitializeComponent();
            listCustomer = new List<Customer>()
            {
                new Customer(){Name="Võ Trung Nam",Address="Tp.HCM",PhoneNumber="0703197183"},
                new Customer(){Name="Dương Văn Đại",Address="Phú Yên",PhoneNumber="0123456789"},

            };
            BindingContext = listCustomer;
        }
    }
}