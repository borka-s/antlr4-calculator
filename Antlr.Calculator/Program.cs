using System;
using Antlr.Calculator.Antlr;
using Antlr4.Runtime;

namespace Antlr.Calculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string exp = "5 + -5";
            var inputStream = new AntlrInputStream(exp);
            var lexer = new CalculatorLexer(inputStream);

            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new CalculatorParser(commonTokenStream);

            var visitor = new CalculatorVisitor();

            var resut = visitor.Visit(parser.expr());

            Console.WriteLine(resut);
        }
    }
}