namespace EnhancementCalculator.Services
{
    class CalculatorFactory : IExpingCalculatorFactory
    {
        public IInstanceExpingCalculator CreateExpingCalculator()
        {
            return new InstanceExpingCalculator();
        }
    }
}
