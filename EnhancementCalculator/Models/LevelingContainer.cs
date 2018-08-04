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
        public int CurrentLevel { get; set; }

        public LevelingContainer(ulong totalExperience, int startLevel)
        {
            CurrentLevel = startLevel;
            TotalExperience = totalExperience;
            RemainingExperience = totalExperience;
            CollectedScrolls = Scrolls.CreateEmptyContainer();
        }
    }
}
