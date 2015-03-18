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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="LittleBigCParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public interface ILittleBigCVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] LittleBigCParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTranslationUnit([NotNull] LittleBigCParser.TranslationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExternalDeclaration([NotNull] LittleBigCParser.ExternalDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.variableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableType([NotNull] LittleBigCParser.VariableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.simpleVariableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleVariableType([NotNull] LittleBigCParser.SimpleVariableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] LittleBigCParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.initExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitExpression([NotNull] LittleBigCParser.InitExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.arrayInitExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayInitExpression([NotNull] LittleBigCParser.ArrayInitExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDefinition([NotNull] LittleBigCParser.FunctionDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameters([NotNull] LittleBigCParser.FormalParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameter([NotNull] LittleBigCParser.FormalParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockItemList([NotNull] LittleBigCParser.BlockItemListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockItem([NotNull] LittleBigCParser.BlockItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] LittleBigCParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundStatement([NotNull] LittleBigCParser.CompoundStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionStatement([NotNull] LittleBigCParser.ExpressionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelectionStatement([NotNull] LittleBigCParser.SelectionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIterationStatement([NotNull] LittleBigCParser.IterationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJumpStatement([NotNull] LittleBigCParser.JumpStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryExpression([NotNull] LittleBigCParser.PrimaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostfixExpression([NotNull] LittleBigCParser.PostfixExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentExpressionList([NotNull] LittleBigCParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] LittleBigCParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] LittleBigCParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] LittleBigCParser.RelationalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] LittleBigCParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalAndExpression([NotNull] LittleBigCParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOrExpression([NotNull] LittleBigCParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpression([NotNull] LittleBigCParser.AssignmentExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] LittleBigCParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="LittleBigCParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] LittleBigCParser.ConstantContext context);
}
