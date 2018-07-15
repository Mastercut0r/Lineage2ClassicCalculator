namespace EnhancementCalculator.Models
{
    public interface ICalculationResultMinimal
    {
        int ResultLevel { get; }
        double GainedExpPercentageOnLevel { get; }
        ulong GainedExpOnLevel { get; }
    }
}
