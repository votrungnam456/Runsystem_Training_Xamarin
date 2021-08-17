using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.BehaviorView
{
    public class NumericValidationBehaviorXamarinForm : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            entry.Focused += OnEntryForcused;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            entry.Focused -= OnEntryForcused;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
        void OnEntryForcused(object sender, FocusEventArgs args)
        {

            ((Entry)sender).BackgroundColor = args.IsFocused ? Color.Gray : Color.Default;
        }
    }
}
