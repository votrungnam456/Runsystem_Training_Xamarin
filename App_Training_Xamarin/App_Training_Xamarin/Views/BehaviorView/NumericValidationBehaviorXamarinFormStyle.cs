using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.BehaviorView
{
    public class NumericValidationBehaviorXamarinFormStyle: Behavior<Entry>
    {
        public static readonly BindableProperty AttachBehaviorProperty =
        BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(NumericValidationBehavior), false, propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry;
            if (entry == null)
            {
                return;
            }

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.Behaviors.Add(new NumericValidationBehaviorXamarinFormStyle());
            }
            else
            {
                var toRemove = entry.Behaviors.FirstOrDefault(b => b is NumericValidationBehaviorXamarinFormStyle);
                if (toRemove != null)
                {
                    entry.Behaviors.Remove(toRemove);
                }
            }
        }
        static void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {

            double result;
            bool isValid = double.TryParse(e.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
