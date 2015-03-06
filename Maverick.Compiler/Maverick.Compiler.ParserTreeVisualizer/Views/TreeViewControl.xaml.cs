using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Maverick.Compiler.ParserTreeVisualizer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maverick.Compiler.ParserTreeVisualizer.Views
{
    /// <summary>
    /// Interaction logic for TreeViewControl.xaml
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        private readonly TreeViewModel _treeViewModel;

        public TreeViewControl(ParserRuleContext root, LittleBigCParser parser)
        {
            InitializeComponent();

            var rootViewModel = new NodeViewModel(root, null, parser);

            _treeViewModel = new TreeViewModel(rootViewModel);

            base.DataContext = _treeViewModel;
        }

        public TreeViewModel TreeViewModel
        {
            get { return _treeViewModel; }
        }
    }
}
