using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    abstract class StrategyBase
    {
        public void CalculateScrolls(IStrategyParameter container, Scrolls rewards)
        {
            container.CollectedScrolls = container.CollectedScrolls + rewards;
            container.RemainingExperience -= rewards.TotalExp;
            LevelUp(container, rewards.TotalExp);
        }

        public bool LevelUpPossible(int currentLevel)
        {
            return ExperienceForLevelTable.IsLevelUpPossible(currentLevel);
        }

        private bool LevelUp(IStrategyParameter container, ulong expIncrease)
        {
            container.ExperienceGainedOnLevel += expIncrease;
            if (container.ExperienceGainedOnLevel >= ExperienceForLevelTable.ExperienceForLevel[container.CurrentLevel + 1])
            {
                container.CurrentLevel += 1;
                container.ExperienceGainedOnLevel -= ExperienceForLevelTable.ExperienceForLevel[container.CurrentLevel];
                return true;
            }
            return false;
        }
    }
}
