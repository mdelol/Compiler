using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.ParserTreeVisualizer
{
    class LexerErrorListener : IAntlrErrorListener<int>
    {
        public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            Logs.AddLog("Lexer: line " + line + ":" + charPositionInLine + " at " + offendingSymbol + ": " + msg);
        }
    }
}
