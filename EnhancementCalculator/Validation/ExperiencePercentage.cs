using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace EnhancementCalculator.Validation
{
    public class ExperiencePercentage : ValidationRule
    {
        //00.00% | 00,00% | 00.00 % | 00,00 % | 00.00 | 00,00
        private const string s_PercentagePattern = @"^[0-9]+((\.|\,)[0-9]+)?\s?%?$";
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double percentage = 0.00;
            string formatedValue = value?.ToString();
            if (!Regex.IsMatch(value.ToString(), s_PercentagePattern))
            {
                return new ValidationResult(false, $"Invalid value: {(string)value}");
            }
            if (formatedValue.Contains("%"))
            {
                formatedValue = value.ToString().Remove(value.ToString().Length - 1);
            }
            formatedValue = formatedValue.Trim();
            if (formatedValue.Contains(","))
            {
               formatedValue = formatedValue.Replace(",", ".");
            }
            if(!double.TryParse(formatedValue, NumberStyles.AllowDecimalPoint, cultureInfo, out percentage))
            {
                return new ValidationResult(false, $"Invalid value: {(string)value}");
            }
            if (percentage > 100
                || percentage < 0)
            {
                return new ValidationResult(false, "value out of range");
            }
            return ValidationResult.ValidResult;
        }
    }
}
