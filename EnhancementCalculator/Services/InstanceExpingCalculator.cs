using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    class InstanceExpingCalculator : IInstanceExpingCalculator
    {
        private int ArenaRbKillCount { get; set; }
        private int WeeklyCyclesNeeded { get; set; }
        private ulong RemainingExperience { get; set; }
        private ulong ExperienceGainedOnLevel { get; set; }
        private int CurrentLevel { get; set; }

        /// <summary>
        /// Calculates all relevant data and puts them in a container
        /// </summary>
        /// <param name="startLevel"></param>
        /// <param name="targetLevel"></param>
        /// <param name="gainedExpPercentage"></param>
        /// <param name="clanArena"></param>
        /// <param name="baium"></param>
        /// <param name="antharas"></param>
        /// <param name="arenaRbCount"></param>
        /// <param name="instanceEntranceFee"></param>
        /// <returns>returns data container if arguments are valid. Otherwise returns light weight container with total experience only</returns>
        public LevelingContainer CalculateExping(ushort startLevel, ushort targetLevel, ushort gainedExpPercentage, bool clanArena = false, bool baium = false, bool antharas = false, int arenaRbCount = 0, ushort instanceEntranceFee = 0)
        {
            if (startLevel > targetLevel) return null;
            ulong totalExperience = CalculateTotalExp(startLevel, targetLevel, gainedExpPercentage);
            if (!clanArena && !baium && !antharas) return LevelingContainer.CreateExpContainer(totalExperience);

            var scrollContainer = CalculateExpScrollsNeeded(totalExperience, startLevel, clanArena, baium, antharas, (ushort)arenaRbCount);
            var moneyTotal = CaclulateMoneyTotal(scrollContainer);
            return new LevelingContainer(totalExperience, RemainingExperience, WeeklyCyclesNeeded, ArenaRbKillCount, scrollContainer.hundertKkScrollNeeded, scrollContainer.fiftyKkScrollNeeded, scrollContainer.tenKkScrollNeeded, moneyTotal);
        }
        private ulong CalculateTotalExp(ushort startLevel, ushort targetLevel, ushort gainedExpPercentage)
        {
            if (startLevel >= targetLevel)
                return 0;

            ulong expNeeded = 0;
            if (startLevel < targetLevel)
            {
                for (ushort lvl = (ushort)(startLevel + 1); lvl <= targetLevel; lvl++)
                {
                    expNeeded += ExperienceForLevelTable.ExperienceForLevel[lvl];
                }
            }
            expNeeded -= (ulong)(ExperienceForLevelTable.ExperienceForLevel[(ushort)(startLevel + 1)] * ((double)gainedExpPercentage / 100));
            return expNeeded;
        }
        private (int tenKkScrollNeeded, int fiftyKkScrollNeeded, int hundertKkScrollNeeded) CalculateExpScrollsNeeded(ulong totalExp, ushort startLevel, bool arena, bool baium, bool antharas, ushort arenaRbCount)
        {
            if (!antharas && !arena && !baium)
                return (0, 0, 0);
            CurrentLevel = startLevel;
            int hundertKkScrollNeeded = 0;
            int fiftyKkScrollNeeded = 0;
            int tenKkScrollNeeded = 0;
            var scrollsContainer = (tenKkScrollNeeded, fiftyKkScrollNeeded, hundertKkScrollNeeded);
            RemainingExperience = totalExp;
            WeeklyCyclesNeeded = 0;
            bool calculationNeeded = true;
            while (calculationNeeded)
            {
                if (!ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                    calculationNeeded = false;//ToDo check if correct!!
                var tempExpMark = RemainingExperience;
                WeeklyCyclesNeeded += 1;
                if (arena && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                {
                    if (RemainingExperience > InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] * arenaRbCount)
                    {
                        ArenaRbKillCount += arenaRbCount;
                        scrollsContainer = CalculatePricesPerScrollType(InstanceTypes.ClanArena, scrollsContainer, arenaRbCount);
                        RemainingExperience -= InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] * arenaRbCount;
                        LevelUp(InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] * arenaRbCount);
                    }
                }
                if (baium && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                {
                    if (InstanceExpPerLevelTable.BaiumExpPerLevelTable.ContainsKey(CurrentLevel)
                        && RemainingExperience > InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel])
                    {
                        scrollsContainer = CalculatePricesPerScrollType(InstanceTypes.Baium, scrollsContainer);
                        RemainingExperience -= InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel];
                        LevelUp(InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel]);
                    }
                }
                if (antharas && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                {
                    if (InstanceExpPerLevelTable.AntharasExpPerLevelTable.ContainsKey(CurrentLevel)
                        && RemainingExperience > InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel])
                    {
                        scrollsContainer = CalculatePricesPerScrollType(InstanceTypes.Antharas, scrollsContainer);
                        RemainingExperience -= InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel];
                        LevelUp(InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel]);
                    }
                }
                if (tempExpMark - RemainingExperience == 0)
                {
                    calculationNeeded = false;
                    WeeklyCyclesNeeded -= 1;
                }
            }
            return scrollsContainer;
        }
        private bool LevelUp(ulong expIncrease)
        {
            ExperienceGainedOnLevel += expIncrease;
            if (ExperienceGainedOnLevel >= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel + 1])
            {
                CurrentLevel += 1;
                ExperienceGainedOnLevel -= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel];
                return true;
            }
            return false;
        }
        private (int tenKkScrollNeeded, int fiftyKkScrollNeeded, int hundertKkScrollNeeded) CalculatePricesPerScrollType(InstanceTypes instanceType, (int tenKkScrollNeeded, int fiftyKkScrollNeeded, int hundertKkScrollNeeded) scrollContainer, ushort arenaRbCount = 0)
        {
            switch (instanceType)
            {
                case InstanceTypes.ClanArena:
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 10000000)
                    {
                        scrollContainer.tenKkScrollNeeded += 1 * arenaRbCount;
                    }
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 30000000)
                    {
                        scrollContainer.tenKkScrollNeeded += 3 * arenaRbCount;
                    }
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 50000000)
                    {
                        scrollContainer.fiftyKkScrollNeeded += 1 * arenaRbCount;
                    }
                    break;
                case InstanceTypes.Baium:
                    scrollContainer.hundertKkScrollNeeded += (InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel] == 100000000) ? 1 : 2;
                    break;
                case InstanceTypes.Antharas:
                    scrollContainer.hundertKkScrollNeeded += (InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel] == 100000000) ? 1 : 2;
                    break;
                default:
                    break;
            }
            return scrollContainer;
        }
        private ulong CaclulateMoneyTotal((int tenKkScrollNeeded, int fiftyKkScrollNeeded, int hundertKkScrollNeeded) scrollContainer)
        {
            //ToDo calculate arena fee too
           return (ulong)scrollContainer.tenKkScrollNeeded * (ulong)ExpScrollPrices.tenKkExpScrollPrice + (ulong)scrollContainer.fiftyKkScrollNeeded * (ulong)ExpScrollPrices.fiftyKkExpScrollPrice + (ulong)scrollContainer.hundertKkScrollNeeded * (ulong)ExpScrollPrices.hundertKkExpScrollPrice;
        }

    }
}
