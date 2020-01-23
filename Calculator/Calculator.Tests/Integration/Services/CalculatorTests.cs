namespace Calculator.Tests.Integration.Services
{
    using Calculator.Services;

    using Xunit;

    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void CanPerformSimpleComputation_Addition()
        {
            const string computation = "2 + 2";

            double result = _calculator.Calculate(computation);

            Assert.Equal(4, result);
        }
    }
}