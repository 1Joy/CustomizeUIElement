using System.Drawing;
using System.Windows;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public static class ButtonAttachPropertyManager
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

        #region 按钮类型 Primary Default Error Warn Success       



        public static string GetBottonType(DependencyObject obj)
        {
            return (string)obj.GetValue(BottonTypeProperty);
        }

        public static void SetBottonType(DependencyObject obj, string value)
        {
            obj.SetValue(BottonTypeProperty, value);
        }

        // Using a DependencyProperty as the backing store for BottonType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottonTypeProperty =
            DependencyProperty.RegisterAttached("BottonType", typeof(string), typeof(ButtonAttachPropertyManager), new PropertyMetadata("default"));



        #endregion



    }
}
