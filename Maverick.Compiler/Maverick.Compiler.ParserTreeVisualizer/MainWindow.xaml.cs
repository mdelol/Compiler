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
using Antlr4.Runtime;
using System.IO;
using System.Threading;
using Antlr4.Runtime.Tree;
using Microsoft.Win32;
using Maverick.Compiler.ParserTreeVisualizer.Views;

namespace Maverick.Compiler.ParserTreeVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String _sourceCode = "";
        private AntlrInputStream _inputStream;
        private LittleBigCLexer _lexer;
        private LittleBigCParser _parser;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = new FileStream(@"Assets/test.lbc", FileMode.Open);
            var reader = new StreamReader(input);


        }


        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.DefaultExt = ".lbc";
            fileDialog.Filter = "LittleBigC source code  (*.lbc)|*.lbc|Text file (*.txt)|*.txt";


            if (fileDialog.ShowDialog() == true)
            {
                String fileName = fileDialog.FileName;

                var input = new FileStream(fileName, FileMode.Open);
                var reader = new StreamReader(input);

                _sourceCode = reader.ReadToEnd();

                SourceCodeTextEditor.Text = _sourceCode;
            }
        }


        private void ParseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Clear logs
            var logs = Logs.GetInstance();
            logs.Clear();
            LogsListBox.Items.Clear();
            TokensListBox.Items.Clear();

            // Get source code
            _sourceCode = SourceCodeTextEditor.Text;


            _inputStream = new AntlrInputStream(_sourceCode);
            _lexer = new LittleBigCLexer(_inputStream);


            // Lexer error listener
            var lexerErrorListener = new LexerErrorListener();

            _lexer.RemoveErrorListeners();
            _lexer.AddErrorListener(lexerErrorListener);


            // Recognize tokens
            IToken token = _lexer.NextToken();

            while (token.Type != LittleBigCLexer.Eof)
            {
                var vocubalary = LittleBigCLexer.DefaultVocabulary;

                TokensListBox.Items.Add(String.Format("{0} : {1}", token.Text, vocubalary.GetSymbolicName(token.Type)));

                token = _lexer.NextToken();
            }

            _lexer.Reset();

            var tokenStream = new CommonTokenStream(_lexer);
            _parser = new LittleBigCParser(tokenStream);


            // Parser error listener
            var parserErrorListener = new ParserErrorListener();

            _parser.RemoveErrorListeners();
            _parser.AddErrorListener(parserErrorListener);



            // Parser init
            var root = _parser.compilationUnit();

            var treeView = new TreeViewControl(root, _parser);

            TreePanel.Children.Add(treeView);


            // Logs 
            foreach (var log in logs.LogsCollection)
            {
                LogsListBox.Items.Add(log);
            }
        }
    }
}
