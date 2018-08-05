using System.Collections.Generic;

namespace EnhancementCalculator.Services
{
    interface IExperienceProvider
    {
        IEnumerable<int> LevelRanges { get; }
        IReadOnlyDictionary<int, ulong> ExperienceForLevel { get; }
        bool IsLevelUpPossible(int currentLevel);
    }
}
