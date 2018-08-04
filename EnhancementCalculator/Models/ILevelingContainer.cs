using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementCalculator.Models
{
    public interface ILevelingContainer
    {
        ulong TotalExperience { get; set; }
        ulong RemainingExperience { get; set; }
        ulong ExperienceOnLevel { get; set; }
        int WeeklyCyclesNeeded { get; set; }
        int ResultLevel { get; set; }
        int ArenaRbKillCount { get; set; }
        IScrolls CollectedScrolls { get; set; }
    }
}
