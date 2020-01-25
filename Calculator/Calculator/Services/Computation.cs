namespace Calculator.Services
{
    public class Computation
    {
        public Computation(ISymbolCollection symbols)
        {
            Symbols = symbols;
        }

        public ISymbolCollection Symbols { get; }
    }
}