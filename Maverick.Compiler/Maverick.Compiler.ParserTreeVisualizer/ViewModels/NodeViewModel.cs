using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Compiler.ParserTreeVisualizer.ViewModels
{
    public class NodeViewModel
    {
        private readonly ReadOnlyCollection<NodeViewModel> _children;
        private readonly String _text;
        private readonly NodeViewModel _parent;

        private bool _isExpanded;
        private bool _isSelected;

        public NodeViewModel(String text, NodeViewModel parent)
        {
            _text = text;
            _parent = parent;
        }

        public NodeViewModel(ParserRuleContext node, NodeViewModel parent, LittleBigCParser parser)
        {
            _parent = parent;
            _text = parser.RuleNames[node.RuleIndex];

            var children = new List<NodeViewModel>();

            for (int i = 0; i < node.ChildCount; i++)
            {
                if (node.GetChild<ParserRuleContext>(i) != null)
                {
                    var child = new NodeViewModel(node.GetChild<ParserRuleContext>(i), this, parser);

                    children.Add(child);
                }
                else
                {
                    /*
                    var child = new NodeViewModel(node.GetChild(i).ToStringTree(parser), this);

                    children.Add(child);*/
                }
            }

            _children = new ReadOnlyCollection<NodeViewModel>(children);
        }

        public ReadOnlyCollection<NodeViewModel> Children
        {
            get { return _children; }
        }

        public string Text
        {
            get
            {
                return _text;
            }
        }

        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }
            set
            {
                if (value != _isExpanded)
                {
                    _isExpanded = value;
                }

                if (_isExpanded && _parent != null)
                    _parent.IsExpanded = true;
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (value != _isSelected)
                {
                    _isSelected = value;
                }
            }
        }

        public NodeViewModel Parent
        {
            get { return _parent; }
        }

    }
}
