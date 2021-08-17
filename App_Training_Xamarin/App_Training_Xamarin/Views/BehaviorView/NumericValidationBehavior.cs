using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
namespace App_Training_Xamarin.Views.BehaviorView
{
    public static class NumericValidationBehavior 
    {
        static bool check = true;
        public static readonly BindableProperty AttachBehaviorProperty = BindableProperty.CreateAttached("AttachBehavior", typeof(bool),typeof(NumericValidationBehavior) ,false, propertyChanged: OnAttachBehaviorChanged);
        static void OnAttachBehaviorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Entry entry = bindable as Entry;
            if (entry == null)
            {
                return;
            }

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {

            //double result;
            //bool isValid = double.TryParse(e.NewTextValue, out result);
            //((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;

            //if (isValid && check)
            //{
            //    ((Entry)sender).Text = (result * 2).ToString();
            //    check = false;
            //}
            //else
            //{
            //    ((Entry)sender).Text = e.NewTextValue;
            //    check = true;
            //}
            if(e.NewTextValue.Contains("@") && e.NewTextValue.Contains("."))
            {
                ((Entry)sender).TextColor = Color.Green;
            }
            else
            {
                ((Entry)sender).TextColor = Color.Red;
            }
        }

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

    }
}
