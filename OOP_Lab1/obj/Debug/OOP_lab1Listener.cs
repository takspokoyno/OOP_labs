﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Приложения\GitHub\OOP_labs\OOP_Lab1\OOP_lab1.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OOP_lab1 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OOP_lab1Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IOOP_lab1Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpr([NotNull] OOP_lab1Parser.ParenthesizedExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpr([NotNull] OOP_lab1Parser.ParenthesizedExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpr([NotNull] OOP_lab1Parser.MultiplicativeExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpr([NotNull] OOP_lab1Parser.MultiplicativeExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModDivExpr([NotNull] OOP_lab1Parser.ModDivExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ModDivExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModDivExpr([NotNull] OOP_lab1Parser.ModDivExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MaxMinExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxMinExpr([NotNull] OOP_lab1Parser.MaxMinExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MaxMinExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxMinExpr([NotNull] OOP_lab1Parser.MaxMinExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpr([NotNull] OOP_lab1Parser.AdditiveExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpr([NotNull] OOP_lab1Parser.AdditiveExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>IncDecExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncDecExpr([NotNull] OOP_lab1Parser.IncDecExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IncDecExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncDecExpr([NotNull] OOP_lab1Parser.IncDecExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExponentialExpr([NotNull] OOP_lab1Parser.ExponentialExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExponentialExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExponentialExpr([NotNull] OOP_lab1Parser.ExponentialExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ComparsionExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparsionExpr([NotNull] OOP_lab1Parser.ComparsionExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparsionExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparsionExpr([NotNull] OOP_lab1Parser.ComparsionExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpr([NotNull] OOP_lab1Parser.NumberExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpr([NotNull] OOP_lab1Parser.NumberExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpr([NotNull] OOP_lab1Parser.IdentifierExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpr([NotNull] OOP_lab1Parser.IdentifierExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OOP_lab1Parser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] OOP_lab1Parser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OOP_lab1Parser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] OOP_lab1Parser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] OOP_lab1Parser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OOP_lab1Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] OOP_lab1Parser.ExpressionContext context);
}
} // namespace OOP_lab1