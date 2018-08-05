using EnhancementCalculator.Models;
using EnhancementCalculator.Services.DataProvider;

namespace EnhancementCalculator.Services.Strategies
{
    sealed class Baium : StrategyBase, IStrategy
    {
        IEpicBossProvider m_EpicBossProvider;
        public Baium(IEpicBossProvider epicBossProvider = null)
        {
            m_EpicBossProvider = epicBossProvider ?? new EpicBoss();
        }
        public void Apply(ILevelingContainer container)
        {
            if (!LevelUpPossible(container.CurrentLevel)) return;
            if (m_EpicBossProvider.BaiumExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > m_EpicBossProvider.BaiumExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)m_EpicBossProvider.BaiumExpPerLevelTable[container.CurrentLevel];
                ApplyScrolls(container, rewards);
            }
        }
    }
}
