using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public class TextBoxAttachPropertyManager: DependencyObject
    {
        public static string GetTextBoxIcon(DependencyObject obj)
        {
            return (string)obj.GetValue(TextBoxIconProperty);
        }

        public static void SetTextBoxIcon(DependencyObject obj, string value)
        {
            obj.SetValue(TextBoxIconProperty, value);
        }

        // Using a DependencyProperty as the backing store for TextBoxIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxIconProperty =
            DependencyProperty.RegisterAttached("TextBoxIcon", typeof(string), typeof(TextBoxAttachPropertyManager), new PropertyMetadata());


    }
}
