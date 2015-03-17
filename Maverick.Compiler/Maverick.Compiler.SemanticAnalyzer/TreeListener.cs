using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer
{
    class TreeListener : LittleBigCBaseListener
    {
        private List<String> _results = new List<String>();

        public List<String> Results
        {
            get
            {
                return _results;
            }
        }
        
        public override void EnterVariableDeclaration(LittleBigCParser.VariableDeclarationContext context)
        {
            var type = context.variableType().GetText();
            var name = context.Identifier().GetText();
            var value = context.initExpression().GetText();

            _results.Add(String.Format("{0} {1} = {2}", type, name, value));
        }
    }
}
