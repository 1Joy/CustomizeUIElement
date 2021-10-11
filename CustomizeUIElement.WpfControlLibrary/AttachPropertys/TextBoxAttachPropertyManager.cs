using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public static class TextBoxAttachPropertyManager
    {
        #region icon
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
            DependencyProperty.RegisterAttached("TextBoxIcon", typeof(string), typeof(TextBoxAttachPropertyManager), new PropertyMetadata(string.Empty));
        #endregion

        #region placeholder
        public static string GetPlaceHolder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceHolderProperty);
        }

        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(TextBoxAttachPropertyManager), new PropertyMetadata(string.Empty));
        #endregion

        #region cornerRadius
        public static CornerRadius GetTextBoxCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(TextBoxCornerRadiusProperty);
        }

        public static void SetTextBoxCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(TextBoxCornerRadiusProperty, value);
        }

        // Using a DependencyProperty as the backing store for TextBoxCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxCornerRadiusProperty =
            DependencyProperty.RegisterAttached("TextBoxCornerRadius", typeof(CornerRadius), typeof(TextBoxAttachPropertyManager), new PropertyMetadata(default(CornerRadius)));

        #endregion

        #region 清空按钮


        public static bool GetHasClearBtn(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasClearBtnProperty);
        }

        public static void SetHasClearBtn(DependencyObject obj, bool value)
        {
            obj.SetValue(HasClearBtnProperty, value);
        }

        // Using a DependencyProperty as the backing store for HasClearBtn.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasClearBtnProperty =
            DependencyProperty.RegisterAttached("HasClearBtn", typeof(bool), typeof(TextBoxAttachPropertyManager), new PropertyMetadata(false));


        #endregion
    }
}
