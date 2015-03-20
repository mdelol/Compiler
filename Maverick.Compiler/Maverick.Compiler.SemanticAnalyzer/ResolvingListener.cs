using Antlr4.Runtime.Tree;
using Maverick.Compiler.SemanticAnalyzer.Definitions;
using Maverick.Compiler.SemanticAnalyzer.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer
{
    public class ResolvingListener : LittleBigCBaseListener
    {
        private List<String> _errors = new List<String>();
        private Semantic _semantic;
        private Scope _currentScope;

        public List<String> Errors
        {
            get
            {
                return _errors;
            }
        }

        public ResolvingListener(Semantic semantic)
        {
            _semantic = semantic;

            _currentScope = _semantic.GlobalScope;
        }

        public override void EnterFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            var functionName = context.Identifier().GetText();

            _currentScope = _semantic.GetScope(functionName);
        }

        public override void ExitFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            _currentScope = _semantic.GlobalScope;
        }

        public override void EnterVariableDeclaration(LittleBigCParser.VariableDeclarationContext context)
        {
            var listener = new TypeCheckListener(_semantic, _currentScope);

            ParseTreeWalker.Default.Walk(listener, context);

            _errors.AddRange(listener.Errors);
        }

        public override void EnterAssignmentExpression(LittleBigCParser.AssignmentExpressionContext context)
        {
            if (context.postfixExpression() != null)
            {
                var ident = context.postfixExpression().primaryExpression().Identifier();
                var variableName = ident.GetText();
                VariableDefinition variableDef;

                var error = new StringBuilder();

                variableDef = _currentScope.GetVariableDefinition(variableName);

                if (variableDef == null)
                {
                    variableDef = _semantic.GlobalScope.GetVariableDefinition(variableName);
                }

                if (variableDef == null)
                {
                    var parameterDef = _currentScope.GetParameterDefinition(variableName);

                    if (parameterDef == null)
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: ", ident.Symbol.Line, ident.Symbol.StartIndex));
                        error.Append(String.Format("Variable {0} undefined.", variableName));

                        Errors.Add(error.ToString());
                    }
                    else
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: ", ident.Symbol.Line, ident.Symbol.StartIndex));
                        error.Append(String.Format("Value can't be assigned to parameter {0}.", variableName));

                        Errors.Add(error.ToString());
                    }
                }
                else
                {
                    var listener = new TypeCheckListener(_semantic, _currentScope);

                    ParseTreeWalker.Default.Walk(listener, context);

                    _errors.AddRange(listener.Errors);
                }
            }
        }
    }
}
