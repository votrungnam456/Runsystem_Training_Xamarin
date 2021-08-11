﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Training_Xamarin.Views
{
    public class HomePageFlyoutMenuItem
    {
        public HomePageFlyoutMenuItem()
        {
            TargetType = typeof(HomePageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string UrlIcon { get; set; }
    }
}