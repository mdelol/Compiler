//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Dev/GitHub/Compiler/Grammar\LittleBigC.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="LittleBigCParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface ILittleBigCListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] LittleBigCParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] LittleBigCParser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTranslationUnit([NotNull] LittleBigCParser.TranslationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTranslationUnit([NotNull] LittleBigCParser.TranslationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternalDeclaration([NotNull] LittleBigCParser.ExternalDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternalDeclaration([NotNull] LittleBigCParser.ExternalDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.variableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableType([NotNull] LittleBigCParser.VariableTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.variableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableType([NotNull] LittleBigCParser.VariableTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.simpleVariableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleVariableType([NotNull] LittleBigCParser.SimpleVariableTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.simpleVariableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleVariableType([NotNull] LittleBigCParser.SimpleVariableTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaration([NotNull] LittleBigCParser.VariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaration([NotNull] LittleBigCParser.VariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.initExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitExpression([NotNull] LittleBigCParser.InitExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.initExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitExpression([NotNull] LittleBigCParser.InitExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.arrayInitExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayInitExpression([NotNull] LittleBigCParser.ArrayInitExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.arrayInitExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayInitExpression([NotNull] LittleBigCParser.ArrayInitExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDefinition([NotNull] LittleBigCParser.FunctionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDefinition([NotNull] LittleBigCParser.FunctionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameters([NotNull] LittleBigCParser.FormalParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameters([NotNull] LittleBigCParser.FormalParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameter([NotNull] LittleBigCParser.FormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameter([NotNull] LittleBigCParser.FormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockItemList([NotNull] LittleBigCParser.BlockItemListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockItemList([NotNull] LittleBigCParser.BlockItemListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockItem([NotNull] LittleBigCParser.BlockItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockItem([NotNull] LittleBigCParser.BlockItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] LittleBigCParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] LittleBigCParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundStatement([NotNull] LittleBigCParser.CompoundStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundStatement([NotNull] LittleBigCParser.CompoundStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] LittleBigCParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] LittleBigCParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectionStatement([NotNull] LittleBigCParser.SelectionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectionStatement([NotNull] LittleBigCParser.SelectionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterationStatement([NotNull] LittleBigCParser.IterationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterationStatement([NotNull] LittleBigCParser.IterationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJumpStatement([NotNull] LittleBigCParser.JumpStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJumpStatement([NotNull] LittleBigCParser.JumpStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] LittleBigCParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] LittleBigCParser.PrimaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixExpression([NotNull] LittleBigCParser.PostfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixExpression([NotNull] LittleBigCParser.PostfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentExpressionList([NotNull] LittleBigCParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentExpressionList([NotNull] LittleBigCParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] LittleBigCParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] LittleBigCParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] LittleBigCParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] LittleBigCParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] LittleBigCParser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] LittleBigCParser.RelationalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] LittleBigCParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] LittleBigCParser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalAndExpression([NotNull] LittleBigCParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalAndExpression([NotNull] LittleBigCParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOrExpression([NotNull] LittleBigCParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOrExpression([NotNull] LittleBigCParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] LittleBigCParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] LittleBigCParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LittleBigCParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] LittleBigCParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LittleBigCParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] LittleBigCParser.ExpressionContext context);
}