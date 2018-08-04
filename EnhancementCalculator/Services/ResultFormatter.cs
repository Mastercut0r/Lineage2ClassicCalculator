using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using System;
using System.Text;

namespace EnhancementCalculator.Services
{
    public class ResultFormatter : IResultFormatter
    {
        public string MoneyTotal(ILevelingContainer result)
        {
            return $"{string.Format("{0,9:N0}", result?.CollectedScrolls.TotalMoney)} Aden";
        }

        public string RemainingExperience(ILevelingContainer result)
        {
            return string.Format("{0,9:N0}", result?.RemainingExperience);        
        }

        public string ScrollPrices(ILevelingContainer result)
        {
            StringBuilder scrollPrices = new StringBuilder();
            string delimeter = ", ";
            if (result.CollectedScrolls.HundredKkScrollCount > 0)
                scrollPrices.Append($"{result.CollectedScrolls.HundredKkScrollCount} scrolls x 500k = [{string.Format("{0,9:N0}", (uint)result.CollectedScrolls.HundredKkScrollCount * ScrollConstants.hundredMilScrollPrice)} Aden]");
            if (result.CollectedScrolls.FiftyKkScrollCount > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"{result.CollectedScrolls.FiftyKkScrollCount} scrolls x 400k = [{string.Format("{0,9:N0}", (uint)result.CollectedScrolls.FiftyKkScrollCount * ScrollConstants.fiftyMilScrollPrice)} Aden]");
            }
            if (result.CollectedScrolls.TenKkScrollCount > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"{result.CollectedScrolls.TenKkScrollCount} scrolls x 100k = [{string.Format("{0,9:N0}", (uint)result.CollectedScrolls.TenKkScrollCount * ScrollConstants.tenMilScrollPrice)} Aden]");
            }
            return scrollPrices.ToString();
        }

        public string ScrollsCount(ILevelingContainer result)
        {
            StringBuilder scrollPrices = new StringBuilder();
            string delimeter = ", ";
            if (result.CollectedScrolls.HundredKkScrollCount > 0)
            {
                scrollPrices.Append($"100kk exp scrolls: [{result.CollectedScrolls.HundredKkScrollCount}]");
            }
            if (result.CollectedScrolls.FiftyKkScrollCount > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"50kk exp scrolls: [{result.CollectedScrolls.FiftyKkScrollCount}]");
            }
            if (result.CollectedScrolls.TenKkScrollCount > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"10kk exp scrolls: [{result.CollectedScrolls.TenKkScrollCount}]");
            }
            return scrollPrices.ToString();
        }

        public string Experience(ulong result)
        {
            return string.Format("{0,9:N0}", result);
        }

        public string TotalExperience(ILevelingContainer result)
        {
            return string.Format("{0,9:N0}", result?.TotalExperience);
        }

        public string WeeksCount(ILevelingContainer result)
        {
            return string.Format("{0,9:N0}", result?.WeeklyCyclesNeeded);
        }
    }
}
