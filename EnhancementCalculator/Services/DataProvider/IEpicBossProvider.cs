using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Services
{
    interface IEpicBossProvider
    {
        IReadOnlyDictionary<int, IScrolls> BaiumExpPerLevelTable { get; }
        IReadOnlyDictionary<int, IScrolls> AntharasExpPerLevelTable { get; }
        IReadOnlyDictionary<int, IScrolls> ZakenExpPerLevelTable { get; }
    }
}
