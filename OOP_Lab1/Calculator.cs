using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace OOP_lab1
{
    public static class Calculator
    {
        public static double Evaluate(string expression)
        {
            var lexer = new OOP_lab1Lexer(new AntlrInputStream(expression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());

            var token = new CommonTokenStream(lexer);
            var parser = new OOP_lab1Parser(token);
            var tree = parser.compileUnit();
            var visitor = new OOP_lab1Visitor();
            return visitor.Visit(tree);
        }
    }
}