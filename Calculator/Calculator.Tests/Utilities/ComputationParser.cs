namespace Calculator.Tests.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Calculator.Services;

    public static class ComputationParser
    {
        public static Computation ParseComputation(string computation)
        {
            List<Symbol> symbols = new List<Symbol>();

            foreach (char character in computation.Where(character => character != ' '))
            {
                Symbol symbolValue = (Symbol)character;

                if (Enum.IsDefined(typeof(Symbol), symbolValue))
                {
                    symbols.Add(symbolValue);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(computation), computation, "Invalid non-symbol characters in computation.");
                }
            }

            return new Computation(new SymbolCollection(symbols.ToArray()));
        }
    }
}