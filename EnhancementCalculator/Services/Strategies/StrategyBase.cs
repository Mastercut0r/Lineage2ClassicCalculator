using EnhancementCalculator.Models;
using EnhancementCalculator.Services.DataProvider;

namespace EnhancementCalculator.Services.Strategies
{
    abstract class StrategyBase
    {
        private readonly IExperienceProvider m_ExperienceProvidere;
        public StrategyBase(IExperienceProvider provider = null)
        {
            m_ExperienceProvidere = provider ?? new ExpProvider();
        }
        public void ApplyScrolls(ILevelingContainer container, Scrolls rewards)
        {
            container.CollectedScrolls = (Scrolls)container.CollectedScrolls + rewards;
            container.RemainingExperience -= rewards.TotalExp;
            LevelUp(container, rewards.TotalExp);
        }

        public bool LevelUpPossible(int currentLevel)
        {
            return m_ExperienceProvidere.IsLevelUpPossible(currentLevel);
        }

        private bool LevelUp(ILevelingContainer container, ulong expIncrease)
        {
            container.ExperienceOnLevel += expIncrease;
            if (container.ExperienceOnLevel >= m_ExperienceProvidere.ExperienceForLevel[container.CurrentLevel + 1])
            {
                container.CurrentLevel += 1;
                container.ExperienceOnLevel -= m_ExperienceProvidere.ExperienceForLevel[container.CurrentLevel];
                return true;
            }
            return false;
        }
    }
}
