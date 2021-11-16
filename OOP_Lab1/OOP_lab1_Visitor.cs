using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using OOP_lab1;
using Antlr4.Runtime.Misc;

namespace OOP_lab1
{
    class OOP_lab1Visitor : OOP_lab1BaseVisitor<double>
    {
        Dictionary<string, double> tableIdentifier = new Dictionary<string, double>();

        public override double VisitCompileUnit(OOP_lab1Parser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitNumberExpr(OOP_lab1Parser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            Debug.WriteLine(result);
            return result;
        }
        public override double VisitIdentifierExpr([NotNull] OOP_lab1Parser.IdentifierExprContext context)
        {
            var result = context.GetText();
            double value;
            if (tableIdentifier.TryGetValue(result.ToString(), out value))
                return value;
            else
                return 0.0;
        }
        public override double VisitParenthesizedExpr([NotNull] OOP_lab1Parser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitExponentialExpr([NotNull] OOP_lab1Parser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("{0}^{1}", left, right);
            return System.Math.Pow(left, right);

        }
        public override double VisitAdditiveExpr([NotNull] OOP_lab1Parser.AdditiveExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.ADD)
            {
                Debug.WriteLine("{0}+{1}", left, right);
                return left + right;
            }
            else
            {
                Debug.WriteLine("{0}-{1}", left, right);
                return left - right;
            }
        }
        public override double VisitMultiplicativeExpr([NotNull] OOP_lab1Parser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.MULTIPLY)
            {
                Debug.WriteLine("{0}*{1}", left, right);
                return left * right;
            }
            else
            {
                Debug.WriteLine("{0}/{1}", left, right);
                return left / right;
            }
        }
        public override double VisitModDivExpr([NotNull] OOP_lab1Parser.ModDivExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.MOD)
            {
                Debug.WriteLine("{0}mod{1}", left, right);
                return left % right;
            }
            else
            {
                Debug.WriteLine("{0}div{1}", left, right);
                return (left - left % right) / right;
            }
        }
        public override double VisitMaxMinExpr([NotNull] OOP_lab1Parser.MaxMinExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.MAX)
            {
                Debug.WriteLine("max({0},{1})", left, right);
                return Math.Max(left, right);
            }
            else
            {
                Debug.WriteLine("min({0},{1})", left, right);
                return Math.Min(left, right);
            }
        }
        public override double VisitIncDecExpr([NotNull] OOP_lab1Parser.IncDecExprContext context)
        {
            var number = WalkLeft(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.INC)
            {
                Debug.WriteLine("inc ({0})", number);
                return number + 1;
            }
            else
            {
                Debug.WriteLine("dec ({0})", number);
                return number - 1;
            }
        }
        public override double VisitComparsionExpr([NotNull] OOP_lab1Parser.ComparsionExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == OOP_lab1Lexer.LESS)
            {
                Debug.WriteLine("{0}<{1}", left, right);
                return Convert.ToDouble(left < right);
            }
            else if (context.operatorToken.Type == OOP_lab1Lexer.GREATER)
            {
                Debug.WriteLine("{0}>{1}", left, right);
                return Convert.ToDouble(left > right);
            }
            else if (context.operatorToken.Type == OOP_lab1Lexer.LESSEQUAL)
            {
                Debug.WriteLine("{0}<={1}", left, right);
                return Convert.ToDouble(left <= right);
            }
            else if (context.operatorToken.Type == OOP_lab1Lexer.GREATEREQUAL)
            {
                Debug.WriteLine("{0}>={1}", left, right);
                return Convert.ToDouble(left >= right);
            }
            else if (context.operatorToken.Type == OOP_lab1Lexer.EQUAL)
            {
                Debug.WriteLine("{0}={1}", left, right);
                return Convert.ToDouble(left == right);
            }
            else
            {
                Debug.WriteLine("{0}<>{1}", left, right);
                return Convert.ToDouble(left != right);
            }
        }
        private double WalkLeft(OOP_lab1Parser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<OOP_lab1Parser.ExpressionContext>(0));
        }
        private double WalkRight(OOP_lab1Parser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<OOP_lab1Parser.ExpressionContext>(1));
        }
    }
}