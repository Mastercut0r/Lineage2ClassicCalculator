using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IInstanceExpingCalculator
    {
        /// <summary>
        /// Calculates the exping.
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
        /// <param name="instanceEntranceFee">The instance entrance fee.</param>
        /// <param name="clanArena">The clan arena. For unit testing purposes</param>
        /// <returns>LevelingContainer.</returns>
        LevelingContainer CalculateExping(
            int startLevel,
            int targetLevel,
            int gainedExpPercentage,
            int startBossStage,
            int endBossStage,
            bool isClanArena = false,
            bool isBaium = false,
            bool isZaken = false,
            bool isAntharas = false,
            int instanceEntranceFee = 0,
            IClanArena clanArena = null);

        /// <summary>
        /// Converts the scrolls to level.
        /// </summary>
        /// <param name="startLevel">The start level.</param>
        /// <param name="gainedExpPercentage">The gained exp percentage.</param>
        /// <param name="scrolls">The scrolls.</param>
        /// <returns>ICalculationResultMinimal.</returns>
        ICalculationResultMinimal ConvertScrollsToLevel(
            int startLevel,
            int gainedExpPercentage,
            IScrolls scrolls);
    }
}
