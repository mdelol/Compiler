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
    public class TypeCheckListener : LittleBigCBaseListener
    {
        private List<String> _errors = new List<String>();
        private Scope _scope;
        private Semantic _semantic;
        private VariableType _targetType;

        public List<String> Errors
        {
            get
            {
                return _errors;
            }
        }

        public TypeCheckListener(Semantic semantic, Scope scope)
        {
            _semantic = semantic;
            _scope = scope;
        }


        public override void EnterVariableDeclaration(LittleBigCParser.VariableDeclarationContext context)
        {
            var variable = _scope.GetVariableDefinition(context.Identifier().GetText());
            _targetType = variable.VariableType;
        }

        public override void EnterAssignmentExpression(LittleBigCParser.AssignmentExpressionContext context)
        {
            if (context.postfixExpression() != null)
            {
                var ident = context.postfixExpression().primaryExpression().Identifier();
                var variableName = ident.GetText();

                VariableDefinition variable;

                var error = new StringBuilder();

                variable = _scope.GetVariableDefinition(variableName);

                if (variable == null)
                {
                    variable = _semantic.GlobalScope.GetVariableDefinition(variableName);
                }

                if (variable == null)
                {
                    var parameterDef = _scope.GetParameterDefinition(variableName);

                    if (parameterDef == null)
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: ", ident.Symbol.Line, ident.Symbol.StartIndex));
                        error.Append(String.Format("Variable {0} undefinded.", variableName));

                        Errors.Add(error.ToString());
                    }
                    else
                    {
                        if (parameterDef.VariableType != _targetType)
                        {
                            error.Append(String.Format("[{0}:{1}] Semantic error: Type mismatch. ", ident.Symbol.Line, ident.Symbol.StartIndex));
                            error.Append(String.Format("{0} expected, but {1} found.", _targetType.ToString(), parameterDef.VariableType.ToString()));

                            Errors.Add(error.ToString());
                        }
                    }
                }
                else
                {
                    if (variable.VariableType != _targetType)
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: Type mismatch. ", ident.Symbol.Line, ident.Symbol.StartIndex));
                        error.Append(String.Format("{0} expected, but {1} found.", _targetType.ToString(), variable.VariableType.ToString()));

                        Errors.Add(error.ToString());
                    }
                }

                _targetType = variable.VariableType;
            }
        }

        public override void EnterConstant(LittleBigCParser.ConstantContext context)
        {
            var constantType = GetConstantType(context);

            if (constantType != _targetType)
            {
                var error = new StringBuilder();

                ITerminalNode node = (ITerminalNode)context.GetChild(0);

                error.Append(String.Format("[{0}:{1}] Semantic error: Type mismatch. ", node.Symbol.Line, node.Symbol.StartIndex));
                error.Append(String.Format("{0} expected, but {1} found.", _targetType.ToString(), constantType.ToString()));

                Errors.Add(error.ToString());
            }
        }

        public override void EnterPrimaryExpression(LittleBigCParser.PrimaryExpressionContext context)
        {
            if (context.Identifier() != null)
            {
                var variableName = context.Identifier().GetText();
                VariableDefinition variableDef;

                var error = new StringBuilder();

                variableDef = _scope.GetVariableDefinition(variableName);

                if (variableDef == null)
                {
                    variableDef = _semantic.GlobalScope.GetVariableDefinition(variableName);
                }

                if (variableDef == null)
                {
                    var parameterDef = _scope.GetParameterDefinition(variableName);

                    if (parameterDef == null)
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: ", context.Identifier().Symbol.Line, context.Identifier().Symbol.StartIndex));
                        error.Append(String.Format("Variable {0} undefined.", variableName));

                        Errors.Add(error.ToString());
                    }
                    else
                    {
                        if (parameterDef.VariableType != _targetType)
                        {
                            error.Append(String.Format("[{0}:{1}] Semantic error: Type mismatch. ", context.Identifier().Symbol.Line, context.Identifier().Symbol.StartIndex));
                            error.Append(String.Format("{0} expected, but {1} found.", _targetType.ToString(), parameterDef.VariableType.ToString()));

                            Errors.Add(error.ToString());
                        }
                    }
                }
                else
                {
                    if (variableDef.VariableType != _targetType)
                    {
                        error.Append(String.Format("[{0}:{1}] Semantic error: Type mismatch. ", context.Identifier().Symbol.Line, context.Identifier().Symbol.StartIndex));
                        error.Append(String.Format("{0} expected, but {1} found.", _targetType.ToString(), variableDef.VariableType.ToString()));

                        Errors.Add(error.ToString());
                    }
                }

            }
        }

        private VariableType GetConstantType(LittleBigCParser.ConstantContext context)
        {
            if (context.BooleanConstant() != null)
            {
                return VariableType.Boolean;
            }

            if (context.IntegerConstant() != null)
            {
                return VariableType.Integer;
            }

            if (context.StringConstant() != null)
            {
                return VariableType.String;
            }

            if (context.FloatingConstant() != null)
            {
                return VariableType.Float;
            }

            return VariableType.Undefined;
        }
    }
}
