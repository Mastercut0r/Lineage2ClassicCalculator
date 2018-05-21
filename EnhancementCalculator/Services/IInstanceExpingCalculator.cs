using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IInstanceExpingCalculator
    {
        LevelingContainer CalculateExping(ushort startLevel, ushort targetLevel, ushort gainedExpPercentage, bool clanArena = false, bool baium = false, bool antharas = false, int arenaRbCount = 0, ushort instanceEntranceFee = 0);
    }
}
