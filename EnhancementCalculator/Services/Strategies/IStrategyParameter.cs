using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    public interface IStrategyParameter
    {
        int CurrentLevel { get; set; }
        ulong ExperienceGainedOnLevel { get; set; }
        ulong RemainingExperience { get; set; }
        Scrolls CollectedScrolls { get; set; }
    }
}
