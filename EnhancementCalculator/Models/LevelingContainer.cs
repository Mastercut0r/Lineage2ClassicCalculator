namespace EnhancementCalculator.Models
{
    public class LevelingContainer
    {
        public ulong TotalExperience { get; set; }
        public ulong RemainingExperience { get; private set; }
        public int WeeklyCyclesNeeded { get; private set; }
        public int ArenaRbKillCount { get; private set; }
        public IScrolls CollectedScrolls { get; private set; }

        public LevelingContainer(
            ulong totalExperience, 
            ulong remainingExperience, 
            int weeklyCyclesNeeded, 
            int arenaRbKillCount,
            IScrolls collectedScrolls
            )
        {
            TotalExperience = totalExperience;
            RemainingExperience = remainingExperience;
            WeeklyCyclesNeeded = weeklyCyclesNeeded;
            ArenaRbKillCount = arenaRbKillCount;
            CollectedScrolls = collectedScrolls;
        }
        public static LevelingContainer CreateExpContainer(ulong totalExperience)
        {
            return new LevelingContainer(totalExperience, totalExperience, 0, 0, Scrolls.CreateEmptyContainer());
        }
    }
}
