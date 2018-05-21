using EnhancementCalculator.Constants;

namespace EnhancementCalculator.Models
{
    class CharacterLevelingContainer : ICharacterLevelingContainer
    {
        public int CurrentLevel { get; private set; }
        public ushort StartLevel { get; private set; }
        public ushort TargetLevel { get; private set; }
        public ulong TotalExperience { get; set; }
        public ulong GainedExperiencePercentage { get; private set; }
        public ulong RemainingExperience { get; private set; }
        public ulong WeeklyCyclesNeeded { get; private set; }
        public ushort ArenaRbKillCount { get; private set; }
        public int HundertKkScrollNeeded { get; private set; }
        public int FiftyKkScrollNeeded { get; private set; }
        public int TenKkScrollNeeded { get; private set; }
        public ulong ExperienceGainedOnLevel { get; private set; }
        public ulong MoneyTotal { get; private set; }

        //private bool ClanArena { get; set; }
        //private ushort ArenaScrollsCount { get; set; }
        //private bool Baium { get; set; }
        //private ushort BaiumScroll { get; set; }
        //private bool Antharas { get; set; }

        public bool ApplyInstanceSettings(ushort startLevel, ushort targetLevel, ushort gainedExpPercentage, bool clanArena = false, bool baium = false, bool antharas = false, int arenaRbCount = 0, ushort instanceEntranceFee = 0)
        {
            if (startLevel > targetLevel) return false;
            GainedExperiencePercentage = gainedExpPercentage;
            TotalExperience = CalculateTotalExp(startLevel, targetLevel, gainedExpPercentage);

            StartLevel = startLevel;
            CurrentLevel = startLevel;
            TargetLevel = targetLevel;
            //ClanArena = clanArena;
            //Baium = baium;
            //Antharas = antharas;

            if (!clanArena && !baium && !antharas) return false;
            CalculateExpScrollsNeeded(TotalExperience, startLevel, clanArena, baium, antharas, (ushort)arenaRbCount);
            CaclulateMoneyTotal();
            return true;
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
        private ulong CalculateExpScrollsNeeded(ulong totalExp, ushort startLevel, bool arena, bool baium, bool antharas, ushort arenaRbCount)
        {
            if (!antharas && !arena && !baium)
                return 0;

            HundertKkScrollNeeded = 0;
            FiftyKkScrollNeeded = 0;
            TenKkScrollNeeded = 0;
            //uint instacesNeeded = 0;
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
                        CalculatePricesPerScrollType(InstanceTypes.ClanArena, arenaRbCount);
                        RemainingExperience -= InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] * arenaRbCount;
                        LevelUp(InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] * arenaRbCount);
                    }
                }
                if (baium && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                {
                    if (InstanceExpPerLevelTable.BaiumExpPerLevelTable.ContainsKey(CurrentLevel)
                        && RemainingExperience > InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel])
                    {
                        CalculatePricesPerScrollType(InstanceTypes.Baium, 0);
                        RemainingExperience -= InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel];
                        LevelUp(InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel]);
                    }
                }
                if (antharas && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
                {
                    if (InstanceExpPerLevelTable.AntharasExpPerLevelTable.ContainsKey(CurrentLevel) 
                        && RemainingExperience > InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel])
                    {
                        CalculatePricesPerScrollType(InstanceTypes.Antharas, 0);
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
            return RemainingExperience;
        }
        private bool LevelUp(ulong expIncrease)
        {
            ExperienceGainedOnLevel += expIncrease;
            if (ExperienceGainedOnLevel >= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel+1])
            {
                CurrentLevel += 1;
                ExperienceGainedOnLevel -= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel];
                return true;
            }
            return false;
        }
        private void CalculatePricesPerScrollType(InstanceTypes instanceType, ushort arenaRbCount)
        {
            switch (instanceType)
            {
                case InstanceTypes.ClanArena:
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 10000000)
                    {
                        TenKkScrollNeeded += 1 * arenaRbCount;
                    }
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 30000000)
                    {
                        TenKkScrollNeeded += 3 * arenaRbCount;
                    }
                    if (InstanceExpPerLevelTable.ArenaRbExpPerLevelTable[CurrentLevel] == 50000000)
                    {
                        FiftyKkScrollNeeded += 1 * arenaRbCount;
                    }
                    break;
                case InstanceTypes.Baium:
                    HundertKkScrollNeeded += (InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel] == 100000000) ? 1 : 2;
                    break;
                case InstanceTypes.Antharas:
                    HundertKkScrollNeeded += (InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel] == 100000000) ? 1 : 2;
                    break;
                default:
                    break;
            }
        }
        private void CaclulateMoneyTotal()
        {
            //ToDo calculate arena fee too
            MoneyTotal = (ulong)TenKkScrollNeeded * (ulong)ExpScrollPrices.tenKkExpScrollPrice + (ulong)FiftyKkScrollNeeded * (ulong)ExpScrollPrices.fiftyKkExpScrollPrice + (ulong)HundertKkScrollNeeded * (ulong)ExpScrollPrices.hundertKkExpScrollPrice;
        }
    }
}
