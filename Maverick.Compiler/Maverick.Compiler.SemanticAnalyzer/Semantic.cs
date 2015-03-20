using Antlr4.Runtime.Tree;
using Maverick.Compiler.SemanticAnalyzer.Definitions;
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
        private List<String> _errors = new List<String>();

        public List<Scope> Scopes
        {
            get
            {
                return _listener.Scopes;
            }
        }

        public Scope GlobalScope
        {
            get
            {
                return _listener.GlobalScope;
            }
        }

        public List<String> Errors
        {
            get
            {
                return _errors;
            }
        }

        public Semantic(IParseTree root)
        {
            _root = root;

            _listener = new DefinitionListener();

            ParseTreeWalker.Default.Walk(_listener, root);

            _errors.AddRange(_listener.Errors);

            var resolvingListener = new ResolvingListener(this);

            ParseTreeWalker.Default.Walk(resolvingListener, root);

            _errors.AddRange(resolvingListener.Errors);
        }

        public Scope GetScope(string name)
        {
            return Scopes.SingleOrDefault(x => x.Name == name);
        }
    }
}
