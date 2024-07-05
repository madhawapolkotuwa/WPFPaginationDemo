using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace PaginationControl.Converters
{
    public class StyleNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string styleName && Application.Current.TryFindResource(styleName) is Style style)
            {
                return style;
            }

            return DependencyProperty.UnsetValue; // Return an unset value if the style is not found.
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
