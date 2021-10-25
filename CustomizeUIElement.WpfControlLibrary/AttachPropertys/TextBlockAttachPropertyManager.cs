using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public static class TextBlockAttachPropertyManager
    {
        #region 标题鼠标移入是否变色


        public static bool GetHeaderCanChangeColor(DependencyObject obj)
        {
            return (bool)obj.GetValue(HeaderCanChangeColorProperty);
        }

        public static void SetHeaderCanChangeColor(DependencyObject obj, bool value)
        {
            obj.SetValue(HeaderCanChangeColorProperty, value);
        }

        // Using a DependencyProperty as the backing store for HeaderCanChangeColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderCanChangeColorProperty =
            DependencyProperty.RegisterAttached("HeaderCanChangeColor", typeof(bool), typeof(TextBlockAttachPropertyManager), new PropertyMetadata(false));


        #endregion



    }
}
