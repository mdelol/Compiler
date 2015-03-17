using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.SemanticAnalyzer
{
    public class Semantic
    {
        private IParseTree _root;
        private TreeListener _listener;
        public List<String> Result
        {
            get
            {
                return _listener.Results;
            }
        }

        public Semantic(IParseTree root)
        {
            _root = root;

            _listener = new TreeListener();

            ParseTreeWalker.Default.Walk(_listener, root);
        }
    }
}
