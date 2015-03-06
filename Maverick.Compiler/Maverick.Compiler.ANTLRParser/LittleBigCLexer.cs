//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Dev/GitHub/Compiler/Grammar\LittleBigC.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class LittleBigCLexer : Lexer {
	public const int
		T__0=1, Break=2, Case=3, Continue=4, Else=5, Float=6, Bool=7, String=8, 
		Hashtable=9, For=10, If=11, Int=12, Return=13, Void=14, While=15, New=16, 
		LeftParen=17, RightParen=18, LeftBracket=19, RightBracket=20, LeftBrace=21, 
		RightBrace=22, Less=23, LessEqual=24, Greater=25, GreaterEqual=26, Plus=27, 
		Minus=28, Star=29, Div=30, Mod=31, AndAnd=32, OrOr=33, Not=34, Semi=35, 
		Comma=36, Assign=37, Equal=38, NotEqual=39, Dot=40, Identifier=41, Constant=42, 
		IntegerConstant=43, BooleanConstant=44, Whitespace=45, Newline=46, BlockComment=47, 
		LineComment=48;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "Break", "Case", "Continue", "Else", "Float", "Bool", "String", 
		"Hashtable", "For", "If", "Int", "Return", "Void", "While", "New", "LeftParen", 
		"RightParen", "LeftBracket", "RightBracket", "LeftBrace", "RightBrace", 
		"Less", "LessEqual", "Greater", "GreaterEqual", "Plus", "Minus", "Star", 
		"Div", "Mod", "AndAnd", "OrOr", "Not", "Semi", "Comma", "Assign", "Equal", 
		"NotEqual", "Dot", "Identifier", "IdentifierNondigit", "Nondigit", "Digit", 
		"Constant", "IntegerConstant", "FloatingConstant", "DigitSequence", "StringConstant", 
		"SCharSequence", "SChar", "BooleanConstant", "Whitespace", "Newline", 
		"BlockComment", "LineComment"
	};


	public LittleBigCLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'[]'", "'break'", "'case'", "'continue'", "'else'", "'float'", 
		"'bool'", "'string'", "'hashtable'", "'for'", "'if'", "'int'", "'return'", 
		"'void'", "'while'", "'new'", "'('", "')'", "'['", "']'", "'{'", "'}'", 
		"'<'", "'<='", "'>'", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'&&'", 
		"'||'", "'!'", "';'", "','", "'='", "'=='", "'!='", "'.'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "Break", "Case", "Continue", "Else", "Float", "Bool", "String", 
		"Hashtable", "For", "If", "Int", "Return", "Void", "While", "New", "LeftParen", 
		"RightParen", "LeftBracket", "RightBracket", "LeftBrace", "RightBrace", 
		"Less", "LessEqual", "Greater", "GreaterEqual", "Plus", "Minus", "Star", 
		"Div", "Mod", "AndAnd", "OrOr", "Not", "Semi", "Comma", "Assign", "Equal", 
		"NotEqual", "Dot", "Identifier", "Constant", "IntegerConstant", "BooleanConstant", 
		"Whitespace", "Newline", "BlockComment", "LineComment"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "LittleBigC.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x32\x16E\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37"+
		"\t\x37\x4\x38\t\x38\x4\x39\t\x39\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v"+
		"\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE"+
		"\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13"+
		"\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C"+
		"\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3!"+
		"\x3\"\x3\"\x3\"\x3#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3\'\x3(\x3"+
		"(\x3(\x3)\x3)\x3*\x3*\x3*\a*\x106\n*\f*\xE*\x109\v*\x3+\x3+\x3,\x3,\x3"+
		"-\x3-\x3.\x3.\x3.\x3.\x5.\x115\n.\x3/\x6/\x118\n/\r/\xE/\x119\x3\x30\x5"+
		"\x30\x11D\n\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x5\x30\x124\n\x30\x3"+
		"\x31\x6\x31\x127\n\x31\r\x31\xE\x31\x128\x3\x32\x3\x32\x5\x32\x12D\n\x32"+
		"\x3\x32\x3\x32\x3\x33\x6\x33\x132\n\x33\r\x33\xE\x33\x133\x3\x34\x3\x34"+
		"\x3\x34\x5\x34\x139\n\x34\x3\x35\x3\x35\x3\x35\x3\x35\x3\x35\x3\x35\x3"+
		"\x35\x3\x35\x3\x35\x5\x35\x144\n\x35\x3\x36\x6\x36\x147\n\x36\r\x36\xE"+
		"\x36\x148\x3\x36\x3\x36\x3\x37\x3\x37\x5\x37\x14F\n\x37\x3\x37\x5\x37"+
		"\x152\n\x37\x3\x37\x3\x37\x3\x38\x3\x38\x3\x38\x3\x38\a\x38\x15A\n\x38"+
		"\f\x38\xE\x38\x15D\v\x38\x3\x38\x3\x38\x3\x38\x3\x38\x3\x38\x3\x39\x3"+
		"\x39\x3\x39\x3\x39\a\x39\x168\n\x39\f\x39\xE\x39\x16B\v\x39\x3\x39\x3"+
		"\x39\x3\x15B\x2:\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f"+
		"\x17\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18"+
		"/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\"\x43#\x45"+
		"$G%I&K\'M(O)Q*S+U\x2W\x2Y\x2[,]-_\x2\x61\x2\x63\x2\x65\x2g\x2i.k/m\x30"+
		"o\x31q\x32\x3\x2\b\x5\x2\x43\\\x61\x61\x63|\x3\x2\x32;\x6\x2\f\f\xF\xF"+
		"$$^^\f\x2$$))\x41\x41^^\x63\x64hhppttvvxx\x4\x2\v\v\"\"\x4\x2\f\f\xF\xF"+
		"\x177\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)"+
		"\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2"+
		"I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2"+
		"\x2\x2\x2S\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2i\x3\x2\x2\x2"+
		"\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x2q\x3\x2\x2\x2\x3s\x3"+
		"\x2\x2\x2\x5v\x3\x2\x2\x2\a|\x3\x2\x2\x2\t\x81\x3\x2\x2\x2\v\x8A\x3\x2"+
		"\x2\x2\r\x8F\x3\x2\x2\x2\xF\x95\x3\x2\x2\x2\x11\x9A\x3\x2\x2\x2\x13\xA1"+
		"\x3\x2\x2\x2\x15\xAB\x3\x2\x2\x2\x17\xAF\x3\x2\x2\x2\x19\xB2\x3\x2\x2"+
		"\x2\x1B\xB6\x3\x2\x2\x2\x1D\xBD\x3\x2\x2\x2\x1F\xC2\x3\x2\x2\x2!\xC8\x3"+
		"\x2\x2\x2#\xCC\x3\x2\x2\x2%\xCE\x3\x2\x2\x2\'\xD0\x3\x2\x2\x2)\xD2\x3"+
		"\x2\x2\x2+\xD4\x3\x2\x2\x2-\xD6\x3\x2\x2\x2/\xD8\x3\x2\x2\x2\x31\xDA\x3"+
		"\x2\x2\x2\x33\xDD\x3\x2\x2\x2\x35\xDF\x3\x2\x2\x2\x37\xE2\x3\x2\x2\x2"+
		"\x39\xE4\x3\x2\x2\x2;\xE6\x3\x2\x2\x2=\xE8\x3\x2\x2\x2?\xEA\x3\x2\x2\x2"+
		"\x41\xEC\x3\x2\x2\x2\x43\xEF\x3\x2\x2\x2\x45\xF2\x3\x2\x2\x2G\xF4\x3\x2"+
		"\x2\x2I\xF6\x3\x2\x2\x2K\xF8\x3\x2\x2\x2M\xFA\x3\x2\x2\x2O\xFD\x3\x2\x2"+
		"\x2Q\x100\x3\x2\x2\x2S\x102\x3\x2\x2\x2U\x10A\x3\x2\x2\x2W\x10C\x3\x2"+
		"\x2\x2Y\x10E\x3\x2\x2\x2[\x114\x3\x2\x2\x2]\x117\x3\x2\x2\x2_\x123\x3"+
		"\x2\x2\x2\x61\x126\x3\x2\x2\x2\x63\x12A\x3\x2\x2\x2\x65\x131\x3\x2\x2"+
		"\x2g\x138\x3\x2\x2\x2i\x143\x3\x2\x2\x2k\x146\x3\x2\x2\x2m\x151\x3\x2"+
		"\x2\x2o\x155\x3\x2\x2\x2q\x163\x3\x2\x2\x2st\a]\x2\x2tu\a_\x2\x2u\x4\x3"+
		"\x2\x2\x2vw\a\x64\x2\x2wx\at\x2\x2xy\ag\x2\x2yz\a\x63\x2\x2z{\am\x2\x2"+
		"{\x6\x3\x2\x2\x2|}\a\x65\x2\x2}~\a\x63\x2\x2~\x7F\au\x2\x2\x7F\x80\ag"+
		"\x2\x2\x80\b\x3\x2\x2\x2\x81\x82\a\x65\x2\x2\x82\x83\aq\x2\x2\x83\x84"+
		"\ap\x2\x2\x84\x85\av\x2\x2\x85\x86\ak\x2\x2\x86\x87\ap\x2\x2\x87\x88\a"+
		"w\x2\x2\x88\x89\ag\x2\x2\x89\n\x3\x2\x2\x2\x8A\x8B\ag\x2\x2\x8B\x8C\a"+
		"n\x2\x2\x8C\x8D\au\x2\x2\x8D\x8E\ag\x2\x2\x8E\f\x3\x2\x2\x2\x8F\x90\a"+
		"h\x2\x2\x90\x91\an\x2\x2\x91\x92\aq\x2\x2\x92\x93\a\x63\x2\x2\x93\x94"+
		"\av\x2\x2\x94\xE\x3\x2\x2\x2\x95\x96\a\x64\x2\x2\x96\x97\aq\x2\x2\x97"+
		"\x98\aq\x2\x2\x98\x99\an\x2\x2\x99\x10\x3\x2\x2\x2\x9A\x9B\au\x2\x2\x9B"+
		"\x9C\av\x2\x2\x9C\x9D\at\x2\x2\x9D\x9E\ak\x2\x2\x9E\x9F\ap\x2\x2\x9F\xA0"+
		"\ai\x2\x2\xA0\x12\x3\x2\x2\x2\xA1\xA2\aj\x2\x2\xA2\xA3\a\x63\x2\x2\xA3"+
		"\xA4\au\x2\x2\xA4\xA5\aj\x2\x2\xA5\xA6\av\x2\x2\xA6\xA7\a\x63\x2\x2\xA7"+
		"\xA8\a\x64\x2\x2\xA8\xA9\an\x2\x2\xA9\xAA\ag\x2\x2\xAA\x14\x3\x2\x2\x2"+
		"\xAB\xAC\ah\x2\x2\xAC\xAD\aq\x2\x2\xAD\xAE\at\x2\x2\xAE\x16\x3\x2\x2\x2"+
		"\xAF\xB0\ak\x2\x2\xB0\xB1\ah\x2\x2\xB1\x18\x3\x2\x2\x2\xB2\xB3\ak\x2\x2"+
		"\xB3\xB4\ap\x2\x2\xB4\xB5\av\x2\x2\xB5\x1A\x3\x2\x2\x2\xB6\xB7\at\x2\x2"+
		"\xB7\xB8\ag\x2\x2\xB8\xB9\av\x2\x2\xB9\xBA\aw\x2\x2\xBA\xBB\at\x2\x2\xBB"+
		"\xBC\ap\x2\x2\xBC\x1C\x3\x2\x2\x2\xBD\xBE\ax\x2\x2\xBE\xBF\aq\x2\x2\xBF"+
		"\xC0\ak\x2\x2\xC0\xC1\a\x66\x2\x2\xC1\x1E\x3\x2\x2\x2\xC2\xC3\ay\x2\x2"+
		"\xC3\xC4\aj\x2\x2\xC4\xC5\ak\x2\x2\xC5\xC6\an\x2\x2\xC6\xC7\ag\x2\x2\xC7"+
		" \x3\x2\x2\x2\xC8\xC9\ap\x2\x2\xC9\xCA\ag\x2\x2\xCA\xCB\ay\x2\x2\xCB\""+
		"\x3\x2\x2\x2\xCC\xCD\a*\x2\x2\xCD$\x3\x2\x2\x2\xCE\xCF\a+\x2\x2\xCF&\x3"+
		"\x2\x2\x2\xD0\xD1\a]\x2\x2\xD1(\x3\x2\x2\x2\xD2\xD3\a_\x2\x2\xD3*\x3\x2"+
		"\x2\x2\xD4\xD5\a}\x2\x2\xD5,\x3\x2\x2\x2\xD6\xD7\a\x7F\x2\x2\xD7.\x3\x2"+
		"\x2\x2\xD8\xD9\a>\x2\x2\xD9\x30\x3\x2\x2\x2\xDA\xDB\a>\x2\x2\xDB\xDC\a"+
		"?\x2\x2\xDC\x32\x3\x2\x2\x2\xDD\xDE\a@\x2\x2\xDE\x34\x3\x2\x2\x2\xDF\xE0"+
		"\a@\x2\x2\xE0\xE1\a?\x2\x2\xE1\x36\x3\x2\x2\x2\xE2\xE3\a-\x2\x2\xE3\x38"+
		"\x3\x2\x2\x2\xE4\xE5\a/\x2\x2\xE5:\x3\x2\x2\x2\xE6\xE7\a,\x2\x2\xE7<\x3"+
		"\x2\x2\x2\xE8\xE9\a\x31\x2\x2\xE9>\x3\x2\x2\x2\xEA\xEB\a\'\x2\x2\xEB@"+
		"\x3\x2\x2\x2\xEC\xED\a(\x2\x2\xED\xEE\a(\x2\x2\xEE\x42\x3\x2\x2\x2\xEF"+
		"\xF0\a~\x2\x2\xF0\xF1\a~\x2\x2\xF1\x44\x3\x2\x2\x2\xF2\xF3\a#\x2\x2\xF3"+
		"\x46\x3\x2\x2\x2\xF4\xF5\a=\x2\x2\xF5H\x3\x2\x2\x2\xF6\xF7\a.\x2\x2\xF7"+
		"J\x3\x2\x2\x2\xF8\xF9\a?\x2\x2\xF9L\x3\x2\x2\x2\xFA\xFB\a?\x2\x2\xFB\xFC"+
		"\a?\x2\x2\xFCN\x3\x2\x2\x2\xFD\xFE\a#\x2\x2\xFE\xFF\a?\x2\x2\xFFP\x3\x2"+
		"\x2\x2\x100\x101\a\x30\x2\x2\x101R\x3\x2\x2\x2\x102\x107\x5U+\x2\x103"+
		"\x106\x5U+\x2\x104\x106\x5Y-\x2\x105\x103\x3\x2\x2\x2\x105\x104\x3\x2"+
		"\x2\x2\x106\x109\x3\x2\x2\x2\x107\x105\x3\x2\x2\x2\x107\x108\x3\x2\x2"+
		"\x2\x108T\x3\x2\x2\x2\x109\x107\x3\x2\x2\x2\x10A\x10B\x5W,\x2\x10BV\x3"+
		"\x2\x2\x2\x10C\x10D\t\x2\x2\x2\x10DX\x3\x2\x2\x2\x10E\x10F\t\x3\x2\x2"+
		"\x10FZ\x3\x2\x2\x2\x110\x115\x5]/\x2\x111\x115\x5_\x30\x2\x112\x115\x5"+
		"\x63\x32\x2\x113\x115\x5i\x35\x2\x114\x110\x3\x2\x2\x2\x114\x111\x3\x2"+
		"\x2\x2\x114\x112\x3\x2\x2\x2\x114\x113\x3\x2\x2\x2\x115\\\x3\x2\x2\x2"+
		"\x116\x118\x5Y-\x2\x117\x116\x3\x2\x2\x2\x118\x119\x3\x2\x2\x2\x119\x117"+
		"\x3\x2\x2\x2\x119\x11A\x3\x2\x2\x2\x11A^\x3\x2\x2\x2\x11B\x11D\x5\x61"+
		"\x31\x2\x11C\x11B\x3\x2\x2\x2\x11C\x11D\x3\x2\x2\x2\x11D\x11E\x3\x2\x2"+
		"\x2\x11E\x11F\a\x30\x2\x2\x11F\x124\x5\x61\x31\x2\x120\x121\x5\x61\x31"+
		"\x2\x121\x122\a\x30\x2\x2\x122\x124\x3\x2\x2\x2\x123\x11C\x3\x2\x2\x2"+
		"\x123\x120\x3\x2\x2\x2\x124`\x3\x2\x2\x2\x125\x127\x5Y-\x2\x126\x125\x3"+
		"\x2\x2\x2\x127\x128\x3\x2\x2\x2\x128\x126\x3\x2\x2\x2\x128\x129\x3\x2"+
		"\x2\x2\x129\x62\x3\x2\x2\x2\x12A\x12C\a$\x2\x2\x12B\x12D\x5\x65\x33\x2"+
		"\x12C\x12B\x3\x2\x2\x2\x12C\x12D\x3\x2\x2\x2\x12D\x12E\x3\x2\x2\x2\x12E"+
		"\x12F\a$\x2\x2\x12F\x64\x3\x2\x2\x2\x130\x132\x5g\x34\x2\x131\x130\x3"+
		"\x2\x2\x2\x132\x133\x3\x2\x2\x2\x133\x131\x3\x2\x2\x2\x133\x134\x3\x2"+
		"\x2\x2\x134\x66\x3\x2\x2\x2\x135\x139\n\x4\x2\x2\x136\x137\a^\x2\x2\x137"+
		"\x139\t\x5\x2\x2\x138\x135\x3\x2\x2\x2\x138\x136\x3\x2\x2\x2\x139h\x3"+
		"\x2\x2\x2\x13A\x13B\av\x2\x2\x13B\x13C\at\x2\x2\x13C\x13D\aw\x2\x2\x13D"+
		"\x144\ag\x2\x2\x13E\x13F\ah\x2\x2\x13F\x140\a\x63\x2\x2\x140\x141\an\x2"+
		"\x2\x141\x142\au\x2\x2\x142\x144\ag\x2\x2\x143\x13A\x3\x2\x2\x2\x143\x13E"+
		"\x3\x2\x2\x2\x144j\x3\x2\x2\x2\x145\x147\t\x6\x2\x2\x146\x145\x3\x2\x2"+
		"\x2\x147\x148\x3\x2\x2\x2\x148\x146\x3\x2\x2\x2\x148\x149\x3\x2\x2\x2"+
		"\x149\x14A\x3\x2\x2\x2\x14A\x14B\b\x36\x2\x2\x14Bl\x3\x2\x2\x2\x14C\x14E"+
		"\a\xF\x2\x2\x14D\x14F\a\f\x2\x2\x14E\x14D\x3\x2\x2\x2\x14E\x14F\x3\x2"+
		"\x2\x2\x14F\x152\x3\x2\x2\x2\x150\x152\a\f\x2\x2\x151\x14C\x3\x2\x2\x2"+
		"\x151\x150\x3\x2\x2\x2\x152\x153\x3\x2\x2\x2\x153\x154\b\x37\x2\x2\x154"+
		"n\x3\x2\x2\x2\x155\x156\a\x31\x2\x2\x156\x157\a,\x2\x2\x157\x15B\x3\x2"+
		"\x2\x2\x158\x15A\v\x2\x2\x2\x159\x158\x3\x2\x2\x2\x15A\x15D\x3\x2\x2\x2"+
		"\x15B\x15C\x3\x2\x2\x2\x15B\x159\x3\x2\x2\x2\x15C\x15E\x3\x2\x2\x2\x15D"+
		"\x15B\x3\x2\x2\x2\x15E\x15F\a,\x2\x2\x15F\x160\a\x31\x2\x2\x160\x161\x3"+
		"\x2\x2\x2\x161\x162\b\x38\x2\x2\x162p\x3\x2\x2\x2\x163\x164\a\x31\x2\x2"+
		"\x164\x165\a\x31\x2\x2\x165\x169\x3\x2\x2\x2\x166\x168\n\a\x2\x2\x167"+
		"\x166\x3\x2\x2\x2\x168\x16B\x3\x2\x2\x2\x169\x167\x3\x2\x2\x2\x169\x16A"+
		"\x3\x2\x2\x2\x16A\x16C\x3\x2\x2\x2\x16B\x169\x3\x2\x2\x2\x16C\x16D\b\x39"+
		"\x2\x2\x16Dr\x3\x2\x2\x2\x13\x2\x105\x107\x114\x119\x11C\x123\x128\x12C"+
		"\x133\x138\x143\x148\x14E\x151\x15B\x169\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
