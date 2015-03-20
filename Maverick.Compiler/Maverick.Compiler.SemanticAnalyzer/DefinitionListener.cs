using Maverick.Compiler.SemanticAnalyzer.Definitions;
using Maverick.Compiler.SemanticAnalyzer.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer
{
    class DefinitionListener : LittleBigCBaseListener
    {
        private Scope _globalScope = new Scope();
        private List<Scope> _scopes = new List<Scope>();
        private Scope _currentScope;
        private List<String> _errors = new List<String>();

        public List<Scope> Scopes
        {
            get
            {
                return _scopes;
            }
        }

        public Scope GlobalScope
        {
            get
            {
                return _globalScope;
            }
        }

        public List<String> Errors
        {
            get
            {
                return _errors;
            }
        }

        public DefinitionListener(): base()
        {
            _scopes.Add(_globalScope);
            _currentScope = _globalScope;
        }

        public override void EnterFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            var function = new FunctionDefinition(context);
            var scope = new Scope(function);

            if (_scopes.Any(x => x.Name == scope.Name))
            {
                var node = context.Identifier();

                _errors.Add(String.Format("[{0}:{1}] Semantic error: Function {2} already defined.", node.Symbol.Line, node.Symbol.StartIndex, scope.Name));
            }
            else
            {
                _scopes.Add(scope);
                _currentScope = scope;
            }
        }

        public override void EnterFormalParameter(LittleBigCParser.FormalParameterContext context)
        {
            var parameter = new ParameterDefinition(context);

            if (_currentScope.ParameterDefinitions.ContainsKey(parameter.Name))
            {
                var node = context.Identifier();
                _errors.Add(String.Format("[{0}:{1}] Semantic error: Parameter {2} already defined.", node.Symbol.Line, node.Symbol.StartIndex, parameter.Name));
            }
            else
            {
                _currentScope.AddParameterDefinition(parameter);
            }
        }

        public override void ExitFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            _currentScope = _globalScope;
        }

        public override void EnterVariableDeclaration(LittleBigCParser.VariableDeclarationContext context)
        {
            var variable = new VariableDefinition(context);

            if (_currentScope.VariableDefinitions.ContainsKey(variable.Name))
            {
                var node = context.Identifier();
                _errors.Add(String.Format("[{0}:{1}] Semantic error: Variable {2} already defined.", node.Symbol.Line, node.Symbol.StartIndex, variable.Name));
            }
            else
            {
                _currentScope.AddVariableDefinition(variable);
            }
        }
    }
}
