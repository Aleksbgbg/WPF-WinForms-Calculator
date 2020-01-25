namespace Calculator.Services
{
    public class SymbolCollection : ISymbolCollection
    {
        private readonly Symbol[] _symbols;

        public SymbolCollection(Symbol[] symbols)
        {
            _symbols = symbols;
        }
    }
}