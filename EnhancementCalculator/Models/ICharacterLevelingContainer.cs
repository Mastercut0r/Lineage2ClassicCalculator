using System;

namespace EnhancementCalculator.Models
{
    internal interface ICharacterLevelingContainer
    {
        int CurrentLevel { get; } 
        UInt16 StartLevel { get; } 
        UInt16 TargetLevel { get; } 
        ulong GainedExperiencePercentage { get; }
        ulong TotalExperience { get; }
        ulong RemainingExperience { get; }
        ulong WeeklyCyclesNeeded { get; }
        ulong MoneyTotal { get; }
        UInt16 ArenaRbKillCount { get; }
        int HundertKkScrollNeeded { get; }
        int FiftyKkScrollNeeded { get; }
        int TenKkScrollNeeded { get; }
        //ulong CalculateExpNeeded();
        //UInt16 CalculateInstancesNeeded();
        //UInt16 CalcScrollsNeeded();
        bool ApplyInstanceSettings(UInt16 startLevel, UInt16 targetLevel, UInt16 gainedExpPercentage, bool clanArena = false, bool bauim = false, bool antharas = false, int arenaRbCount = 0, ushort instanceEntranceFee = 0);
    }
}
