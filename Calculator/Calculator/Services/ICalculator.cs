namespace Calculator.Services
{
    public interface ICalculator
    {
        ComputationResult Calculate(Computation computation);
    }
}