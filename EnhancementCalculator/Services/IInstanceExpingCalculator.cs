using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IInstanceExpingCalculator
    {
        LevelingContainer CalculateExping(int startLevel, int targetLevel, int gainedExpPercentage, bool clanArena = false, bool baium = false, bool antharas = false, int arenaRbCount = 0, int instanceEntranceFee = 0);
    }
}
