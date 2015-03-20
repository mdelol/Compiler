using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer.Definitions
{
    public class ParameterDefinition
    {
        private LittleBigCParser.FormalParameterContext _context;
        private VariableType _variableType;

        public String Name
        {
            get
            {
                return _context.Identifier().GetText();
            }
        }

        public VariableType VariableType
        {
            get
            {
                return _variableType;
            }
        }

        public ParameterDefinition(LittleBigCParser.FormalParameterContext context)
        {
            _context = context;

            var type = _context.variableType().simpleVariableType().GetText().ToString();

            _variableType = VariableDefinition.VariableTypes[type];
        }
    }
}
