using Antlr4.Runtime;
using Maverick.Compiler.SemanticAnalyzer.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer.Scopes
{
    public enum ScopeType
    {
        Global,
        Function
    }

    public class Scope
    {
        private ScopeType _scopeType;
        private FunctionDefinition _functionDefinition;
        private Dictionary<String, VariableDefinition> _variableDefinitions = new Dictionary<String, VariableDefinition>();
        private Dictionary<String, ParameterDefinition> _parameterDefinitions = new Dictionary<String, ParameterDefinition>();


        public ScopeType ScopeType
        {
            get
            {
                return _functionDefinition == null ? ScopeType.Global : ScopeType.Function;
            }
        }

        public String Name
        {
            get
            {
                return _functionDefinition == null ? "Global" : _functionDefinition.Name;
            }
        }

        public Dictionary<String, VariableDefinition> VariableDefinitions
        {
            get
            {
                return _variableDefinitions;
            }
        }

        public Dictionary<String, ParameterDefinition> ParameterDefinitions
        {
            get
            {
                return _parameterDefinitions;
            }
        }

        public Scope()
        {
            _functionDefinition = null;
        }

        public Scope(FunctionDefinition functionDefinition)
        {
            _functionDefinition = functionDefinition;
        }

        public void AddVariableDefinition(VariableDefinition variableDefinition) 
        {
            _variableDefinitions.Add(variableDefinition.Name, variableDefinition);
        }

        public void AddParameterDefinition(ParameterDefinition parameterDefinition)
        {
            _parameterDefinitions.Add(parameterDefinition.Name, parameterDefinition);
        }
    }
}
