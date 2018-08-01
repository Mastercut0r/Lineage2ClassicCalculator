using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    public interface IStrategy
    {
        void Apply(IStrategyParameter container);
    }
}
