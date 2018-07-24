using EnhancementCalculator.Constants;
using System;

namespace EnhancementCalculator.Models
{
    class ResultMinimal : ICalculationResultMinimal
    {
        public ResultMinimal(int resultLevel, ulong gainedExpOnLevel)
        {
            ResultLevel = resultLevel;
            GainedExpOnLevel = gainedExpOnLevel;
            SetExpPercentage();
        }

        public int ResultLevel { get; private set; }

        public double GainedExpPercentageOnLevel { get; private set; }

        public ulong GainedExpOnLevel { get; private set; }

        /// <summary>
        /// Sets the exp percentage and rounds it to two digits
        /// </summary>
        private void SetExpPercentage()
        {
            if (ExperienceForLevelTable.IsLevelUpPossible(ResultLevel))
            {
                GainedExpPercentageOnLevel = (double)GainedExpOnLevel * 100.00 / ExperienceForLevelTable.ExperienceForLevel[ResultLevel + 1];
                GainedExpPercentageOnLevel = Math.Round(GainedExpPercentageOnLevel, 2);
            }
            else
            {
                GainedExpPercentageOnLevel = 0;
            }
        }
    }
}
