using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace EnhancementCalculator.Converter
{
    class PercentageSign : IValueConverter
    {
        //00.00% | 00,00% | 00.00 % | 00,00 % | 00.00 | 00,00
        private const string s_PercentageNumbersWithSignPattern = @"^[0-9]+((\.|\,)[0-9]+)?\s?%?$";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"{value:N2} %";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double numericValue = 0.00;
            string number = value.ToString();
            if (!Regex.IsMatch(value.ToString(), s_PercentageNumbersWithSignPattern))
            {
                return numericValue;
            }
            if (number.Contains("%"))
            {
                number = value.ToString().Remove(value.ToString().Length - 1);
            }
            number = number.Trim();
            if (number.Contains(","))
            {
                number = number.Replace(",", ".");
            }
            double.TryParse(number, NumberStyles.AllowDecimalPoint, culture, out numericValue);
            return numericValue;
        }
    }
}
