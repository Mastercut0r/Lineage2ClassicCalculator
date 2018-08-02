using System.Collections.Generic;

namespace EnhancementCalculator.Services.Strategies
{
    public interface IStrategyFactory
    {
        IReadOnlyCollection<IStrategy> CreateStrategies(
            bool arena, 
            bool baium,
            bool antharas,
            bool zaken,
            bool dailyQuests,
            int startBossStage,
            int endBossStage);
    }
}
