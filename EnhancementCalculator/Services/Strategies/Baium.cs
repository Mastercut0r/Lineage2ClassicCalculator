using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    class Baium : StrategyBase, IStrategy
    {
        public void Apply(IStrategyParameter container)
        {
            if (LevelUpPossible(container.CurrentLevel)) return;
            if (InstanceExpPerLevelTable.BaiumExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > InstanceExpPerLevelTable.BaiumExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)InstanceExpPerLevelTable.BaiumExpPerLevelTable[container.CurrentLevel];
                CalculateScrolls(container, rewards);
            }
        }
    }
}
