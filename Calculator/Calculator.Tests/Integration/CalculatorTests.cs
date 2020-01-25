namespace Calculator.Tests.Integration
{
    using Calculator.Services;
    using Calculator.Tests.Utilities;

    using Xunit;

    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void CanPerform_Addition_TwoPlusTwo()
        {
            Computation computation = ComputationParser.ParseComputation("2 + 2");

            ComputationResult result = _calculator.Calculate(computation);

            Assert.Equal(4, result.Value);
        }
    }
}