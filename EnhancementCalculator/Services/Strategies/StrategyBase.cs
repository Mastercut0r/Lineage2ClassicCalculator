using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    abstract class StrategyBase
    {
        public void ApplyScrolls(ILevelingContainer container, Scrolls rewards)
        {
            container.CollectedScrolls = (Scrolls)container.CollectedScrolls + rewards;
            container.RemainingExperience -= rewards.TotalExp;
            LevelUp(container, rewards.TotalExp);
        }

        public bool LevelUpPossible(int currentLevel)
        {
            return ExperienceForLevelTable.IsLevelUpPossible(currentLevel);
        }

        private bool LevelUp(ILevelingContainer container, ulong expIncrease)
        {
            container.ExperienceOnLevel += expIncrease;
            if (container.ExperienceOnLevel >= ExperienceForLevelTable.ExperienceForLevel[container.CurrentLevel + 1])
            {
                container.CurrentLevel += 1;
                container.ExperienceOnLevel -= ExperienceForLevelTable.ExperienceForLevel[container.CurrentLevel];
                return true;
            }
            return false;
        }
    }
}
