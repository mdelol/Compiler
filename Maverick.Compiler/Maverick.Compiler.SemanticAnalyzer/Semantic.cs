using Antlr4.Runtime.Tree;
using Maverick.Compiler.SemanticAnalyzer.Scopes;
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
        private DefinitionListener _listener;

        public List<Scope> Scopes
        {
            get
            {
                return _listener.Scopes;
            }
        }

        public Semantic(IParseTree root)
        {
            _root = root;

            _listener = new DefinitionListener();

            ParseTreeWalker.Default.Walk(_listener, root);
        }
    }
}
