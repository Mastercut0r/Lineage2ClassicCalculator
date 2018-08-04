using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    sealed class Arena : StrategyBase, IStrategy
    {
        private readonly IClanArena m_ClanArena;
        private readonly int m_StartBossStage;
        private readonly int m_EndBossStage;

        public Arena(int startBossStage, int endBossStage, IClanArena clanArena = null)
        {
            m_ClanArena = clanArena ?? new ClanArena();
            m_StartBossStage = startBossStage;
            m_EndBossStage = endBossStage;
        }

        public void Apply(IStrategyParameter container)
        {
            if (LevelUpPossible(container.CurrentLevel)) return;
            var rewards = (Scrolls)m_ClanArena.Reward(container.CurrentLevel, m_StartBossStage, m_EndBossStage);
            if (container.RemainingExperience > rewards.TotalExp)
            {
                //ArenaRbKillCount += endBossStage - startBossStage;
                CalculateScrolls(container, rewards);
            }
        }
    }
}
