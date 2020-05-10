using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AttachedProperties
{
    public class MyControl : System.Windows.Controls.Control
    {
        public DependencyObject MyProperty
        {
            get { return (DependencyObject)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(DependencyObject), typeof(CustomMouseNavigation), new UIPropertyMetadata(null));

    }

    public class CustomMouseNavigation : UIElement
    {
        protected override void OnMouseWheel(System.Windows.Input.MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
            Mouse.AddMouseWheelHandler(this, this.OnMouseWheel);
        }

        private void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
        }
    }
}
