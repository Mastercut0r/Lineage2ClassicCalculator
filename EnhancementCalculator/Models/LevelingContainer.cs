namespace EnhancementCalculator.Models
{
    public class LevelingContainer
    {
        public ulong TotalExperience { get; set; }
        public ulong RemainingExperience { get; private set; }
        public int WeeklyCyclesNeeded { get; private set; }
        public int ArenaRbKillCount { get; private set; }
        public int HundertKkScrollNeeded { get; private set; }
        public int FiftyKkScrollNeeded { get; private set; }
        public int TenKkScrollNeeded { get; private set; }
        public ulong MoneyTotal { get; private set; }
        public LevelingContainer(ulong totalExperience, ulong remainingExperience, int weeklyCyclesNeeded, int arenaRbKillCount, int hundertKkScrollNeeded, int fiftyKkScrollNeeded, int tenKkScrollNeeded, ulong moneyTotal)
        {
            TotalExperience = totalExperience;
            RemainingExperience = remainingExperience;
            WeeklyCyclesNeeded = weeklyCyclesNeeded;
            ArenaRbKillCount = arenaRbKillCount;
            HundertKkScrollNeeded = hundertKkScrollNeeded;
            FiftyKkScrollNeeded = fiftyKkScrollNeeded;
            TenKkScrollNeeded = tenKkScrollNeeded;
            MoneyTotal = moneyTotal;
        }
        public static LevelingContainer CreateExpContainer(ulong totalExperience)
        {
            return new LevelingContainer(totalExperience, totalExperience, 0, 0, 0, 0, 0, 0);
        }
    }
}
