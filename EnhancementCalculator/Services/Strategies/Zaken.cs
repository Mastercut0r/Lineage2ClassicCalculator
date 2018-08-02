using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    class Zaken : StrategyBase, IStrategy
    {
        public void Apply(IStrategyParameter container)
        {
            if (LevelUpPossible(container.CurrentLevel)) return;
            if (InstanceExpPerLevelTable.ZakenExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > InstanceExpPerLevelTable.ZakenExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)InstanceExpPerLevelTable.ZakenExpPerLevelTable[container.CurrentLevel];
                CalculateScrolls(container, rewards);
            }
        }
    }
}
