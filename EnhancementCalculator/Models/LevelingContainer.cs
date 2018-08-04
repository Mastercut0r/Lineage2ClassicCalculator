namespace EnhancementCalculator.Models
{
    public class LevelingContainer : ILevelingContainer
    {
        public ulong TotalExperience { get; set; }
        public ulong RemainingExperience { get; set; }
        public int WeeklyCyclesNeeded { get; set; }
        public int ArenaRbKillCount { get; set; }
        public IScrolls CollectedScrolls { get; set; }
        public ulong ExperienceOnLevel { get; set; }
        public int ResultLevel { get; set; }

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
        public LevelingContainer() { };
        public static LevelingContainer CreateExpContainer(ulong totalExperience)
        {
            return new LevelingContainer(totalExperience, totalExperience, 0, 0, Scrolls.CreateEmptyContainer());
        }
    }
}
