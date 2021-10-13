using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CustomizeUIElement.WpfControlLibrary.AttachPropertys
{
    public static class InputBoxAttachPropertyManager
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
            DependencyProperty.RegisterAttached("TextBoxIcon", typeof(string), typeof(InputBoxAttachPropertyManager), new PropertyMetadata(string.Empty));
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
            DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(InputBoxAttachPropertyManager), new PropertyMetadata(string.Empty));
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
            DependencyProperty.RegisterAttached("TextBoxCornerRadius", typeof(CornerRadius), typeof(InputBoxAttachPropertyManager), new PropertyMetadata(default(CornerRadius)));

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
            DependencyProperty.RegisterAttached("HasClearBtn", typeof(bool), typeof(InputBoxAttachPropertyManager), new PropertyMetadata(false, HasClearButtonChanged));

        /// <summary>
        /// 属性变化时触发
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void HasClearButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = d as Control;
            if (sender is null)
                return;
            if (sender.IsLoaded)
                SetClearHandler(sender);
            else
                sender.Loaded += (s, e) => SetClearHandler(sender);
        }


        private static void SetClearHandler(Control box)
        {
            var hasClearBtn = GetHasClearBtn(box);
            var clearButton = box.Template.FindName("_clearBtn", box) as Button;
            if (clearButton != null)
            {
                RoutedEventHandler handler = (sender, args) =>
                {
                    (box as TextBox)?.SetCurrentValue(TextBox.TextProperty, null);

                };
                if (hasClearBtn)
                    clearButton.Click += handler;
                else
                    clearButton.Click -= handler;
            }
        }
        #endregion

        #region 密码
        public static readonly DependencyProperty PasswordProperty =DependencyProperty.RegisterAttached("Password",typeof(string), typeof(InputBoxAttachPropertyManager),new FrameworkPropertyMetadata(string.Empty, OnPasswordPropertyChanged));
        public static readonly DependencyProperty AttachProperty =DependencyProperty.RegisterAttached("Attach",typeof(bool), typeof(InputBoxAttachPropertyManager), new PropertyMetadata(false, Attach));
        private static readonly DependencyProperty IsUpdatingProperty =DependencyProperty.RegisterAttached("IsUpdating", typeof(bool),
           typeof(InputBoxAttachPropertyManager));

        public static void SetAttach(DependencyObject dp, bool value)
        {
            dp.SetValue(AttachProperty, value);
        }
        public static bool GetAttach(DependencyObject dp)
        {
            return (bool)dp.GetValue(AttachProperty);
        }
        public static string GetPassword(DependencyObject dp)
        {
            return (string)dp.GetValue(PasswordProperty);
        }
        public static void SetPassword(DependencyObject dp, string value)
        {
            dp.SetValue(PasswordProperty, value);
        }
        private static bool GetIsUpdating(DependencyObject dp)
        {
            return (bool)dp.GetValue(IsUpdatingProperty);
        }
        private static void SetIsUpdating(DependencyObject dp, bool value)
        {
            dp.SetValue(IsUpdatingProperty, value);
        }
        private static void OnPasswordPropertyChanged(DependencyObject sender,
            DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            passwordBox.PasswordChanged -= PasswordChanged;
            if (!(bool)GetIsUpdating(passwordBox))
            {
                passwordBox.Password = (string)e.NewValue;
            }
            passwordBox.PasswordChanged += PasswordChanged;
        }
        private static void Attach(DependencyObject sender,
            DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox == null)
                return;
            if ((bool)e.OldValue)
            {
                passwordBox.PasswordChanged -= PasswordChanged;
            }
            if ((bool)e.NewValue)
            {
                passwordBox.PasswordChanged += PasswordChanged;
            }
        }
        private static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            SetIsUpdating(passwordBox, true);
            SetPassword(passwordBox, passwordBox.Password);
            SetIsUpdating(passwordBox, false);
        }

        #endregion
    }
}
