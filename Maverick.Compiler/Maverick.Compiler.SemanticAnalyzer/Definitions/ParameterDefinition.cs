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

        public String Name
        {
            get
            {
                return _context.Identifier().GetText();
            }
        }

        public ParameterDefinition(LittleBigCParser.FormalParameterContext context)
        {
            _context = context;
        }
    }
}
