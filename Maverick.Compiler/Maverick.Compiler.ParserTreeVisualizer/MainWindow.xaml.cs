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

namespace Maverick.Compiler.ParserTreeVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var input = new FileStream(@"Assets/test.lbc", FileMode.Open);
            var reader = new StreamReader(input);
            var stream = new AntlrInputStream(reader.ReadToEnd());

            var lexer = new LittleBigCLexer(stream);

            IToken token = lexer.NextToken();

            while (token.Type != LittleBigCLexer.Eof)
            {
                var vocubalary = LittleBigCLexer.DefaultVocabulary;

                TokensListBox.Items.Add(
                    String.Format("[{0}, {1}:{2}] {3} : {4}", 
                    token.Line, token.StartIndex, token.StopIndex, token.Text, vocubalary.GetSymbolicName(token.Type)));


                token = lexer.NextToken();
            }
        }
    }
}
