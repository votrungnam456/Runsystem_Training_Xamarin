using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_Training_Xamarin.Views.BehaviorView
{
    public class ListViewSelectedItemBehavior: Behavior<ListView>
    {
        public ListView AssociatedObject { get; private set; }

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(
                "Command",
                typeof(ICommand),
                typeof(ListViewSelectedItemBehavior),
                null);

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(
                "CommandParameter",
                typeof(object),
                typeof(ListViewSelectedItemBehavior),
                null);

        public static readonly BindableProperty InputConverterProperty =
            BindableProperty.Create(
                "InputConverter",
                typeof(IValueConverter),
                typeof(ListViewSelectedItemBehavior),
                null);

        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }

        public object CommandParameter
        {
            get
            {
                return GetValue(CommandParameterProperty);
            }
            set
            {
                SetValue(CommandParameterProperty, value);
            }
        }


        public IValueConverter Converter
        {
            get
            {
                return (IValueConverter)GetValue(InputConverterProperty);
            }
            set
            {
                SetValue(InputConverterProperty, value);
            }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.ItemSelected += OnListViewItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.ItemSelected -= OnListViewItemSelected;
            AssociatedObject = null;
        }

        void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command == null)
            {
                return;
            }
            // Parameter value of CommandParameterProperty attached in XAML.
            string commandParameter = (string)CommandParameter;
            // Parameter value from vent (ItemSelected).
            object parameter = Converter.Convert(e, typeof(object), commandParameter, System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
            if (Command.CanExecute(parameter))
            {
                Command.Execute(parameter);
            }

            //// Deselected item.
            //ListView listView = sender as ListView;
            //listView.SelectedItem = null;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }


    }
}
