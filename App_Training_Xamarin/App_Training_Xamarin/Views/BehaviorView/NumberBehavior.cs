using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.BehaviorView
{
    public class NumberBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {

            entry.TextChanged += onEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= onEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void onEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = sender as Entry;
            int result;
            bool check = int.TryParse(entry.Text, out result);
            entry.TextColor = (check && result > 0) ? Color.Green : (check && result < 0) ? Color.Red : Color.Black;
        }
    }
}
