using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using EnhancementCalculator.Services.Strategies;
using System;
using System.Collections.Generic;

namespace EnhancementCalculator.Services
{
    class InstanceExpingCalculator : IInstanceExpingCalculator
    {
        //private int ArenaRbKillCount { get; set; }
        //private int WeeklyCyclesNeeded { get; set; }
        //private ulong RemainingExperience { get; set; }
        //private ulong ExperienceGainedOnLevel { get; set; }
        //private int CurrentLevel { get; set; }

        /// <summary>
        /// Calculates all relevant data and puts them in a container
        /// </summary>
        /// <param name="startLevel">The start level.</param>
        /// <param name="targetLevel">The target level.</param>
        /// <param name="gainedExpPercentage">The gained exp percentage.</param>
        /// <param name="startBossStage">The start boss stage.</param>
        /// <param name="endBossStage">The end boss stage.</param>
        /// <param name="isClanArena">if set to <c>true</c> [is clan arena].</param>
        /// <param name="isBaium">if set to <c>true</c> [is baium].</param>
        /// <param name="isZaken">if set to <c>true</c> [is zaken].</param>
        /// <param name="isAntharas">if set to <c>true</c> [is antharas].</param>
        /// <param name="isDailyQuest">if set to <c>true</c> [is DailyQuest].</param>
        /// <param name="instanceEntranceFee">The instance entrance fee.</param>
        /// <param name="strategyFactory">The strategyFactory. For unit testing purposes</param>
        /// <returns>returns data container if arguments are valid. Otherwise returns light weight container with total experience only</returns>
        public ILevelingContainer CalculateExping(
            int startLevel,
            int targetLevel,
            int gainedExpPercentage,
            int startBossStage,
            int endBossStage,
            bool isClanArena = false,
            bool isBaium = false,
            bool isZaken = false,
            bool isAntharas = false,
            bool isDailyQuest = false,
            int instanceEntranceFee = 0,
            IStrategyFactory strategyFactory = null)
        {
            if (startLevel > targetLevel) return null;
            var factory = strategyFactory ?? new StrategyFactory();
            IReadOnlyCollection<IStrategy> strategies = factory.CreateStrategies(
                isClanArena,
                isBaium,
                isAntharas,
                isZaken,
                isDailyQuest,
                startBossStage,
                endBossStage);
            ulong totalExperience = CalculateTotalExp(startLevel, targetLevel, gainedExpPercentage);
            if (strategies.Count == 0) return new LevelingContainer(totalExperience, startLevel);
            var container = new LevelingContainer(totalExperience, startLevel);
            return ApplyStrategies(
                strategies, 
                container);
        }

        private ILevelingContainer ApplyStrategies(IReadOnlyCollection<IStrategy> strategies, ILevelingContainer container)
        { 
            bool calculationNeeded = true;
            while (calculationNeeded)
            {
                var tempExpMark = container.RemainingExperience;
                foreach (var strategy in strategies)
                {
                    strategy.Apply(container);
                }
                container.WeeklyCyclesNeeded++;
                if (tempExpMark - container.RemainingExperience == 0)
                {
                    calculationNeeded = false;
                    container.WeeklyCyclesNeeded -= 1;
                }
            }
            return container;
        }

        private ulong CalculateTotalExp(int startLevel, int targetLevel, int gainedExpPercentage)
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
        //private IScrolls CalculateExpScrollsNeeded(
        //    ulong totalExp,
        //    int startLevel,
        //    bool arena,
        //    bool baium,
        //    bool zaken,
        //    bool antharas,
        //    bool dailyQuest,
        //    int startBossStage,
        //    int endBossStage)
        //{
        //    CurrentLevel = startLevel;
        //    Scrolls collectedScrolls = (Scrolls)Scrolls.CreateEmptyContainer();
        //    RemainingExperience = totalExp;
        //    WeeklyCyclesNeeded = 0;
        //    bool calculationNeeded = true;
        //    while (calculationNeeded)
        //    {
        //        if (!ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel))
        //            calculationNeeded = false;//ToDo check if correct!!
        //        var tempExpMark = RemainingExperience;
        //        WeeklyCyclesNeeded += 1;
        //        if (Verify(dailyQuest))
        //        {
        //            for (int day = 0; day < 7; day++)
        //            {
        //                Scrolls rewards = (Scrolls)m_DailyQuests.DailyReward(CurrentLevel);
        //                if (RemainingExperience > rewards.TotalExp)
        //                {
        //                    collectedScrolls = ApplyScrolls(collectedScrolls, rewards);
        //                }
        //            }
        //        }
        //        if (Verify(antharas))
        //        {
        //            if (InstanceExpPerLevelTable.AntharasExpPerLevelTable.ContainsKey(CurrentLevel)
        //                && RemainingExperience > InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel].TotalExp)
        //            {
        //                Scrolls rewards = (Scrolls)InstanceExpPerLevelTable.AntharasExpPerLevelTable[CurrentLevel];
        //                collectedScrolls = ApplyScrolls(collectedScrolls, rewards);
        //            }
        //        }
        //        if (Verify(arena))
        //        {
        //            Scrolls rewards = (Scrolls)m_ClanArena.Reward(CurrentLevel, startBossStage, endBossStage);
        //            if (RemainingExperience > rewards.TotalExp)
        //            {
        //                ArenaRbKillCount += endBossStage - startBossStage;
        //                collectedScrolls = ApplyScrolls(collectedScrolls, rewards);
        //            }
        //        }
        //        if (Verify(baium))
        //        {
        //            if (InstanceExpPerLevelTable.BaiumExpPerLevelTable.ContainsKey(CurrentLevel)
        //                && RemainingExperience > InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel].TotalExp)
        //            {
        //                Scrolls rewards = (Scrolls)InstanceExpPerLevelTable.BaiumExpPerLevelTable[CurrentLevel];
        //                collectedScrolls = ApplyScrolls(collectedScrolls, rewards);
        //            }
        //        }
        //        if (Verify(zaken))
        //        {
        //            if (InstanceExpPerLevelTable.ZakenExpPerLevelTable.ContainsKey(CurrentLevel)
        //                && RemainingExperience > InstanceExpPerLevelTable.ZakenExpPerLevelTable[CurrentLevel].TotalExp)
        //            {
        //                Scrolls rewards = (Scrolls)InstanceExpPerLevelTable.ZakenExpPerLevelTable[CurrentLevel];
        //                collectedScrolls = ApplyScrolls(collectedScrolls, rewards);
        //            }
        //        }
        //        if (tempExpMark - RemainingExperience == 0)
        //        {
        //            calculationNeeded = false;
        //            WeeklyCyclesNeeded -= 1;
        //        }
        //    }
        //    return collectedScrolls;
        //}

        //private bool Verify(bool instance)
        //{
        //    return instance && ExperienceForLevelTable.IsLevelUpPossible(CurrentLevel);
        //}

        //private Scrolls ApplyScrolls(Scrolls collectedScrolls, Scrolls rewards)
        //{
        //    collectedScrolls = collectedScrolls + rewards;
        //    RemainingExperience -= rewards.TotalExp;
        //    LevelUp(rewards.TotalExp);
        //    return collectedScrolls;
        //}

        //private bool LevelUp(ulong expIncrease)
        //{
        //    ExperienceGainedOnLevel += expIncrease;
        //    if (ExperienceGainedOnLevel >= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel + 1])
        //    {
        //        CurrentLevel += 1;
        //        ExperienceGainedOnLevel -= ExperienceForLevelTable.ExperienceForLevel[CurrentLevel];
        //        return true;
        //    }
        //    return false;
        //}

        public ICalculationResultMinimal ConvertScrollsToLevel(
            int startLevel,
            int gainedExpPercentage,
            IScrolls scrolls)
        {
            if (!ExperienceForLevelTable.IsLevelUpPossible(startLevel)) return new ResultMinimal(startLevel, 0);
            int currentLevel = startLevel;
            ulong expToConvert = scrolls.TotalExp;
            ulong expOnLevel = CalculateGainedExpOnLevel(startLevel, gainedExpPercentage);
            if (expToConvert==0)
            {
                return new ResultMinimal(startLevel, expOnLevel);
            }
            expToConvert += expOnLevel;
            while(ExperienceForLevelTable.IsLevelUpPossible(currentLevel) && expToConvert >= ExperienceForLevelTable.ExperienceForLevel[currentLevel + 1])
            {
                currentLevel++;
                expToConvert -= ExperienceForLevelTable.ExperienceForLevel[currentLevel];
            };
            return new ResultMinimal(currentLevel, expToConvert);
        }

        private ulong CalculateGainedExpOnLevel(int level, int gainedExpPercentage)
        {
            return (ulong)(ExperienceForLevelTable.ExperienceForLevel[(ushort)(level + 1)] * ((double)gainedExpPercentage / 100));
        }
    }
}
