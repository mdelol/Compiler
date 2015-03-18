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

        public List<Scope> Scopes
        {
            get
            {
                return _scopes;
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

            _scopes.Add(scope);
            _currentScope = scope;
        }

        public override void EnterFormalParameter(LittleBigCParser.FormalParameterContext context)
        {
            var parameter = new ParameterDefinition(context);
            _currentScope.AddParameterDefinition(parameter);
        }

        public override void ExitFunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            _currentScope = _globalScope;
        }

        public override void EnterVariableDeclaration(LittleBigCParser.VariableDeclarationContext context)
        {
            var variable = new VariableDefinition(context);
            _currentScope.AddVariableDefinition(variable);
        }
    }
}
