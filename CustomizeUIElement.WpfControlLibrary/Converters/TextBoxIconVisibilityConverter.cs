using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CustomizeUIElement.WpfControlLibrary.Converters
{
    /// <summary>
    /// 是否显示Icon的转换器
    /// </summary>
    public class TextBoxIconVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = value.ToString();
            return valueStr.Equals(string.Empty) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 是否有清空按钮的转换器
    /// </summary>
    public class TextBoxClearBtnVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 是否显示水印的转换器
    /// </summary>
    public class TextBoxPlaceHolderVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //下标0表示的是水印内容
            //下标1表示的是textbox的内容
            string content = values[1].ToString();
            string placeHolder = values[0].ToString();
            if (content != string.Empty)
                return Visibility.Collapsed;
            return placeHolder.Equals(string.Empty) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
