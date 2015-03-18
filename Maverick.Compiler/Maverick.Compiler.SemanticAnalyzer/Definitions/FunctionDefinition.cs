using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer.Definitions
{
    public class FunctionDefinition
    {
        private LittleBigCParser.FunctionDefinitionContext _context;

        public String Name
        {
            get
            {
                return _context.Identifier().GetText();
            }
        }

        public FunctionDefinition(LittleBigCParser.FunctionDefinitionContext context)
        {
            _context = context;
        }
    }
}
