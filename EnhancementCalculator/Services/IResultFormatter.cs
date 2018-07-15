using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IResultFormatter
    {
        string ScrollsCount(LevelingContainer result);
        string ScrollPrices(LevelingContainer result);
        string TotalExperience(LevelingContainer result);
        string WeeksCount(LevelingContainer result);
        string RemainingExperience(LevelingContainer result);
        string MoneyTotal(LevelingContainer result);
        string Experience(ulong result);
    }
}
