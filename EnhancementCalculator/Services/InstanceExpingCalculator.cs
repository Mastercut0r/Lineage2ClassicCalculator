using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using EnhancementCalculator.Services.Strategies;
using System;
using System.Collections.Generic;

namespace EnhancementCalculator.Services
{
    class InstanceExpingCalculator : IInstanceExpingCalculator
    {
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
