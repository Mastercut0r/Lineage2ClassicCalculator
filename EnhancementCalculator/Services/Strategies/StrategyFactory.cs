using System.Collections.Generic;

namespace EnhancementCalculator.Services.Strategies
{
    class StrategyFactory : IStrategyFactory
    {
        public IReadOnlyCollection<IStrategy> CreateStrategies(
            bool arena, 
            bool baium, 
            bool antharas, 
            bool zaken, 
            bool dailyQuests, 
            int startBossStage, 
            int endBossStage)
        {
            var strategies = new List<IStrategy>();
            if (arena)
            {
                strategies.Add(new Arena(startBossStage, endBossStage));
            }
            else if (baium)
            {
                strategies.Add(new Baium());
            }
            else if (antharas)
            {
                strategies.Add(new Antharas());
            }
            else if (zaken)
            {
                strategies.Add(new Zaken());
            }
            else if (dailyQuests)
            {
                strategies.Add(new DailyQuests());
            }
            return strategies;
        }
    }
}
