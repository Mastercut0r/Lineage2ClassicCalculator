using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IResultFormatter
    {
        string ScrollsCount(ILevelingContainer result);
        string ScrollPrices(ILevelingContainer result);
        string TotalExperience(ILevelingContainer result);
        string WeeksCount(ILevelingContainer result);
        string RemainingExperience(ILevelingContainer result);
        string MoneyTotal(IScrolls result);
        string Experience(ulong result);
    }
}
