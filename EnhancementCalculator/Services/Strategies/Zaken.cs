using EnhancementCalculator.Models;
using EnhancementCalculator.Services.DataProvider;

namespace EnhancementCalculator.Services.Strategies
{
    sealed class Zaken : StrategyBase, IStrategy
    {
        IEpicBossProvider m_EpicBossProvider;
        public Zaken(IEpicBossProvider epicBossProvider = null)
        {
            m_EpicBossProvider = epicBossProvider ?? new EpicBoss();
        }

        public void Apply(ILevelingContainer container)
        {
            if (!LevelUpPossible(container.CurrentLevel)) return;
            if (m_EpicBossProvider.ZakenExpPerLevelTable.ContainsKey(container.CurrentLevel)
                && container.RemainingExperience > m_EpicBossProvider.ZakenExpPerLevelTable[container.CurrentLevel].TotalExp)
            {
                var rewards = (Scrolls)m_EpicBossProvider.ZakenExpPerLevelTable[container.CurrentLevel];
                ApplyScrolls(container, rewards);
            }
        }
    }
}
