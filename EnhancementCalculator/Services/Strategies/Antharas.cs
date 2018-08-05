using EnhancementCalculator.Models;
using EnhancementCalculator.Services.DataProvider;

namespace EnhancementCalculator.Services.Strategies
{
    sealed class Antharas : StrategyBase, IStrategy
    {
        IEpicBossProvider m_EpicBossProvider;
        public Antharas(IEpicBossProvider epicBossProvider = null)
        {
            m_EpicBossProvider = epicBossProvider ?? new EpicBoss();
        }
        public void Apply(ILevelingContainer container)
        {
            if (!LevelUpPossible(container.CurrentLevel)) return;
            if (m_EpicBossProvider.AntharasExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > m_EpicBossProvider.AntharasExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)m_EpicBossProvider.AntharasExpPerLevelTable[container.CurrentLevel];
                ApplyScrolls(container, rewards);
            }
        }
    }
}
