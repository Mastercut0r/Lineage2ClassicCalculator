using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    class Antharas : StrategyBase, IStrategy
    {
        public void Apply(IStrategyParameter container)
        {
            if (LevelUpPossible(container.CurrentLevel)) return;
            if (InstanceExpPerLevelTable.AntharasExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > InstanceExpPerLevelTable.AntharasExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)InstanceExpPerLevelTable.AntharasExpPerLevelTable[container.CurrentLevel];
                CalculateScrolls(container, rewards);
            }
        }
    }
}
