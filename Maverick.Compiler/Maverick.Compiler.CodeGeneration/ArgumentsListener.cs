using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.CodeGeneration
{
    class ArgumentsListener : LittleBigCBaseListener
    {
        public String StringConstant { get; set; }

        public override void EnterConstant(LittleBigCParser.ConstantContext context)
        {
            var stringConstant = context.StringConstant();

            if (stringConstant != null)
            {
                StringConstant = stringConstant.GetText().Replace("\"", String.Empty);
            }
        }
    }
}
