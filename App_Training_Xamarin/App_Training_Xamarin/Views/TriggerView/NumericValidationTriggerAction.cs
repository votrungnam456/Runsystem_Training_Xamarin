using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.TriggerView
{
    public class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            double result;
            bool isNumber = double.TryParse(sender.Text, out result);

            sender.TextColor = (isNumber || result >= 18 || result <= 27) ? Color.Green : Color.Red;
        }
    }
}
