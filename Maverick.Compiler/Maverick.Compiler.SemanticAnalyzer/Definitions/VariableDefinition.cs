using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer.Definitions
{
    public class VariableDefinition
    {
        private LittleBigCParser.VariableDeclarationContext _context;

        public String Name
        {
            get
            {
                return _context.Identifier().GetText();
            }
        }

        public VariableDefinition(LittleBigCParser.VariableDeclarationContext context)
        {
            _context = context;
        }
    }
}
