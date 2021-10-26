using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CustomizeUIElement.WpfControlLibrary.Converters
{
    /// <summary>
    /// 颜色转换
    /// </summary>
    public class ColorConverter : IValueConverter
    {
        public static Color CustomizeForeground = Color.FromRgb(255, 255, 255);
        public static Color CustomizeForeground1 = Color.FromRgb(0, 0, 0);
        public static Color DefaultWhiteColor = Color.FromRgb(255, 255, 255);
        public static Color DefaultBlackColor = Color.FromRgb(0, 0, 0);

        public static Color PrimaryColor = Color.FromRgb(24, 144, 255);
        public static Color PrimaryHoverColor = Color.FromRgb( 64, 169, 255);

        public static Color ErrorColor = Color.FromRgb(255, 77, 79);
        public static Color ErrorHoverColor = Color.FromRgb( 255, 120, 117);

        public static Color SuccessColor = Color.FromRgb(82, 196, 26);
        public static Color SuccessHoverColor = Color.FromRgb(133, 206, 97);

        public static Color WarnColor = Color.FromRgb(250, 173, 20);
        public static Color WarnHoverColor = Color.FromRgb(235, 181, 99);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueStr = value.ToString();
            var paramStr = parameter.ToString();
            Color targetColor;
            switch (valueStr)
            {
                case "primary": targetColor = PrimaryColor; break;
                case "error": targetColor = ErrorColor; break;
                case "success": targetColor = SuccessColor; break;
                case "warn": targetColor = WarnColor; break;
                default: targetColor = paramStr== "defaultWhite"? DefaultWhiteColor:DefaultBlackColor; break;
            }
            return  new SolidColorBrush(targetColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ColorHoverConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueStr = value.ToString();
            Color targetColor;
            switch (valueStr)
            {
                case "primary": targetColor = ColorConverter.PrimaryHoverColor; break;
                case "error": targetColor = ColorConverter.ErrorHoverColor; break;
                case "success": targetColor = ColorConverter.SuccessHoverColor; break;
                case "warn": targetColor = ColorConverter.WarnHoverColor; break;
                default: targetColor = ColorConverter.DefaultWhiteColor; break;
            }
            return new SolidColorBrush(targetColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ForegroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueStr = value.ToString();
            Color color =ColorConverter.CustomizeForeground;
            if (valueStr == "default")
            {
                color = ColorConverter.CustomizeForeground1;
            }
            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
