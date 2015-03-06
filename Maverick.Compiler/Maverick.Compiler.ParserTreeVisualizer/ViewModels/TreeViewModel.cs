using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.ParserTreeVisualizer.ViewModels
{
    public class TreeViewModel
    {
        private readonly ReadOnlyCollection<NodeViewModel> _rootChildren;
        private readonly NodeViewModel _root;

        public ReadOnlyCollection<NodeViewModel> RootChildren
        {
            get { return _rootChildren; }
        }

        public NodeViewModel Root
        {
            get { return _root; }
        }
        
        public TreeViewModel(NodeViewModel root)
        {
            _root = root;
            _rootChildren = new ReadOnlyCollection<NodeViewModel>(new List<NodeViewModel> { _root });
        }
    }
}
