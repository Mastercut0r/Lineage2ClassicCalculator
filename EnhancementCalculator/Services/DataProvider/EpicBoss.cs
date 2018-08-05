using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Services.DataProvider
{
    class EpicBoss : IEpicBossProvider
    {
        public IReadOnlyDictionary<int, IScrolls> BaiumExpPerLevelTable => InstanceExpPerLevelTable.BaiumExpPerLevelTable;

        public IReadOnlyDictionary<int, IScrolls> AntharasExpPerLevelTable => InstanceExpPerLevelTable.AntharasExpPerLevelTable;

        public IReadOnlyDictionary<int, IScrolls> ZakenExpPerLevelTable => InstanceExpPerLevelTable.ZakenExpPerLevelTable;
    }
}
