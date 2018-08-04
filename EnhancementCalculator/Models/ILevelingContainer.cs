namespace EnhancementCalculator.Models
{
    public interface ILevelingContainer
    {
        ulong TotalExperience { get; set; }
        ulong RemainingExperience { get; set; }
        ulong ExperienceOnLevel { get; set; }
        int WeeklyCyclesNeeded { get; set; }
        int CurrentLevel { get; set; }
        int ArenaRbKillCount { get; set; }
        IScrolls CollectedScrolls { get; set; }
    }
}
