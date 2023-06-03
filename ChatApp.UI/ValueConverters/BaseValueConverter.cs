using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace ChatApp.UI.ValueConverters
{
    /// <summary>
    /// A base value convertor that allows direct XAML usage
    /// </summary>
    /// <typeparam name="T">The type of this value convertor</typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : class, new()
    {
        #region Private Members
        /// <summary>
        /// A single static instance of this value convertor
        /// </summary>
        private static T _convertor = null;
        #endregion

        #region Markup Extension Method

        /// <summary>
        /// Provides a static instance of the value convertor
        /// </summary>
        /// <param name="serviceProvider">The service Provider</param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _convertor ?? (_convertor = new T());
        }

        #endregion

        #region Value Convertor Methods

        /// <summary>
        /// The method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// The method to convert a value back to it's source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
