using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    sealed class DailyQuests : StrategyBase, IStrategy
    {
        private readonly IDailyQuestsProvider m_DailyQuests;
        private readonly int m_Days;
        public DailyQuests(IDailyQuestsProvider dailyQuests = null, int days = 7)
        {
            m_DailyQuests = dailyQuests ?? new DailyQuestsProvider();
            m_Days = days;
        }

        public void Apply(ILevelingContainer container)
        {
            if (!LevelUpPossible(container.CurrentLevel)) return;
            for (int day = 0; day < m_Days; day++)
            {
                var rewards = (Scrolls)m_DailyQuests.DailyReward(container.CurrentLevel);
                if (container.RemainingExperience > rewards.TotalExp)
                {
                    ApplyScrolls(container, rewards);
                }
            }
        }
    }
}
