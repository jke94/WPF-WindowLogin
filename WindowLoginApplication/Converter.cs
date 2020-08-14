namespace WindowLoginApplication
{

    #region using

    using System;
    using System.Globalization;
    using System.Windows.Data;

    #endregion


    #region class

    /// <summary>
    /// Converter class
    /// </summary>
    public class Converter : IMultiValueConverter
    {
        /// <summary>
        /// Converter method
        /// </summary>
        /// <param name="values">Array of elements to convert</param>
        /// <param name="targetType">A target type parameter</param>
        /// <param name="parameter">A object parameter</param>
        /// <param name="culture">A culture parameter</param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Tuple<object, object> tuple = new Tuple<object, object>(values[0], values[1]);
            return tuple;
        }

        /// <summary>
        /// Converter back method (implementation not necessary)
        /// </summary>
        /// <param name="values">Array of elements to convert</param>
        /// <param name="targetType">A target type parameter</param>
        /// <param name="parameter">A object parameter</param>
        /// <param name="culture">A culture parameter</param>
        /// <returns></returns>
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

}
