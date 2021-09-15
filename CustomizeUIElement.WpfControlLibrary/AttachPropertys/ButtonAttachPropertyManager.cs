using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public class ButtonAttachPropertyManager: DependencyObject
    {
        #region CornerRadius
        private static readonly CornerRadius DefaultCornerRadius = new CornerRadius(2);
        public static readonly DependencyProperty CornerRadiusProperty
           = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ButtonAttachPropertyManager), new PropertyMetadata(DefaultCornerRadius));

        private static void OnCornerRadius(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            SetCornerRadius(obj, new CornerRadius(10));
        }

        public static CornerRadius GetCornerRadius(DependencyObject element) => (CornerRadius)element.GetValue(CornerRadiusProperty);
        public static void SetCornerRadius(DependencyObject element, CornerRadius value) => element.SetValue(CornerRadiusProperty, value);
        #endregion



    }
}
