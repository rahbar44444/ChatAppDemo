using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.UI.ValueConverters
{
    /// <summary>
    /// Percentage converter
    /// </summary>
    public class PercentageConverter : BaseValueConverter<PercentageConverter>
    {
        public override object Convert(object value,
                   Type targetType,
                   object parameter,
                   System.Globalization.CultureInfo culture)
        {
            return System.Convert.ToDouble(value) *
                   System.Convert.ToDouble(parameter);
        }

        public override object ConvertBack(object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (null != value)
            {

                return value;
            }

            return null;
        }
    }
}
