namespace Calculator.Services
{
    public readonly struct ComputationResult
    {
        public ComputationResult(double value)
        {
            Value = value;
        }

        public double Value { get; }
    }
}