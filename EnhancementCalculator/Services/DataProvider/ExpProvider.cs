using EnhancementCalculator.Constants;
using System.Collections.Generic;

namespace EnhancementCalculator.Services.DataProvider
{
    class ExpProvider : IExperienceProvider
    {
        public IEnumerable<int> LevelRanges => ExperienceForLevel.Keys;

        public IReadOnlyDictionary<int, ulong> ExperienceForLevel => ExperienceForLevelTable.ExperienceForLevel;

        public bool IsLevelUpPossible(int currentLevel)
        {
            return ExperienceForLevelTable.IsLevelUpPossible(currentLevel);
        }
    }
}
