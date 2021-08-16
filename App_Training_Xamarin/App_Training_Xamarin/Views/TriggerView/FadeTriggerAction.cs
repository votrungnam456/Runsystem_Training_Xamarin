using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.TriggerView
{
    public class FadeTriggerAction : TriggerAction<VisualElement>
    {
        public int StartsFrom { set; get; }
        protected override void Invoke(VisualElement sender)
        {
            sender.Animate("FadeTriggerAction", new Animation((d) =>
            {
                var val = StartsFrom == 1 ? d : 1 - d;
                sender.BackgroundColor = Color.FromRgb(1, val, 1);
            }),
        length: 1000,
        easing: Easing.Linear);
        }
    }
}
