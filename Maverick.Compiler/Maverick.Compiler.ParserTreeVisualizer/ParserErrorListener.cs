using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maverick.Compiler.ParserTreeVisualizer
{
    class ParserErrorListener : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            Logs.AddLog("Parser: line " + line + ":" + charPositionInLine + " at " + offendingSymbol + ": " + msg);
        }
    }
}
