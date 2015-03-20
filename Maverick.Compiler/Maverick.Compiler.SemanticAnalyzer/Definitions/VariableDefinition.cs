using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer.Definitions
{
    public enum VariableType
    {
        Integer,
        Float,
        Boolean,
        String,
        Hashtable,
        Undefined,
        Void
    }

    public class VariableDefinition
    {
        private static Dictionary<String, VariableType> _variableTypes = new Dictionary<String, VariableType>()
        {
            { "int", VariableType.Integer },
            { "float", VariableType.Float },
            { "bool", VariableType.Boolean },
            { "string", VariableType.String },
            { "hashtable", VariableType.Hashtable },
            { "void", VariableType.Void }
        };

        public static Dictionary<String, VariableType> VariableTypes
        {
            get
            {
                return _variableTypes;
            }
        }

        private LittleBigCParser.VariableDeclarationContext _context;
        private VariableType _variableType;
        private bool _isArray = false;

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

        public bool IsArray
        {
            get
            {
                return _isArray;
            }
        }

        public VariableDefinition(LittleBigCParser.VariableDeclarationContext context)
        {
            _context = context;
            var type = _context.variableType().simpleVariableType().GetText().ToString();
            _variableType = VariableDefinition.VariableTypes[type];
        }
    }
}
