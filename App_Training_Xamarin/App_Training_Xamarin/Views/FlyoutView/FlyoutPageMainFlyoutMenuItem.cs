using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Training_Xamarin.Views.FlyoutView
{
    public class FlyoutPageMainFlyoutMenuItem
    {
        public FlyoutPageMainFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPageMainFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}