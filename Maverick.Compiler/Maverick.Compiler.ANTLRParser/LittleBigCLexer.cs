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
		Comma=36, Assign=37, Equal=38, NotEqual=39, Dot=40, Identifier=41, IntegerConstant=42, 
		FloatingConstant=43, StringConstant=44, BooleanConstant=45, Whitespace=46, 
		Newline=47, BlockComment=48, LineComment=49;
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
		"IntegerConstant", "FloatingConstant", "DigitSequence", "StringConstant", 
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
		"NotEqual", "Dot", "Identifier", "IntegerConstant", "FloatingConstant", 
		"StringConstant", "BooleanConstant", "Whitespace", "Newline", "BlockComment", 
		"LineComment"
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
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x33\x166\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37"+
		"\t\x37\x4\x38\t\x38\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3"+
		"\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3"+
		"\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3"+
		"\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3"+
		"\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3"+
		"\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1D\x3"+
		"\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3!\x3\"\x3\"\x3\"\x3"+
		"#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3)\x3)\x3*\x3"+
		"*\x3*\a*\x104\n*\f*\xE*\x107\v*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x6.\x110\n"+
		".\r.\xE.\x111\x3/\x5/\x115\n/\x3/\x3/\x3/\x3/\x3/\x5/\x11C\n/\x3\x30\x6"+
		"\x30\x11F\n\x30\r\x30\xE\x30\x120\x3\x31\x3\x31\x5\x31\x125\n\x31\x3\x31"+
		"\x3\x31\x3\x32\x6\x32\x12A\n\x32\r\x32\xE\x32\x12B\x3\x33\x3\x33\x3\x33"+
		"\x5\x33\x131\n\x33\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3\x34\x3"+
		"\x34\x3\x34\x5\x34\x13C\n\x34\x3\x35\x6\x35\x13F\n\x35\r\x35\xE\x35\x140"+
		"\x3\x35\x3\x35\x3\x36\x3\x36\x5\x36\x147\n\x36\x3\x36\x5\x36\x14A\n\x36"+
		"\x3\x36\x3\x36\x3\x37\x3\x37\x3\x37\x3\x37\a\x37\x152\n\x37\f\x37\xE\x37"+
		"\x155\v\x37\x3\x37\x3\x37\x3\x37\x3\x37\x3\x37\x3\x38\x3\x38\x3\x38\x3"+
		"\x38\a\x38\x160\n\x38\f\x38\xE\x38\x163\v\x38\x3\x38\x3\x38\x3\x153\x2"+
		"\x39\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE"+
		"\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18/\x19\x31\x1A"+
		"\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\"\x43#\x45$G%I&K\'M(O)Q"+
		"*S+U\x2W\x2Y\x2[,]-_\x2\x61.\x63\x2\x65\x2g/i\x30k\x31m\x32o\x33\x3\x2"+
		"\b\x5\x2\x43\\\x61\x61\x63|\x3\x2\x32;\x6\x2\f\f\xF\xF$$^^\f\x2$$))\x41"+
		"\x41^^\x63\x64hhppttvvxx\x4\x2\v\v\"\"\x4\x2\f\f\xF\xF\x16E\x2\x3\x3\x2"+
		"\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2"+
		"\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3"+
		"\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2"+
		"\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2"+
		"\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+"+
		"\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2\x61\x3\x2\x2\x2\x2g\x3\x2\x2"+
		"\x2\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2\x2o\x3\x2\x2\x2\x3"+
		"q\x3\x2\x2\x2\x5t\x3\x2\x2\x2\az\x3\x2\x2\x2\t\x7F\x3\x2\x2\x2\v\x88\x3"+
		"\x2\x2\x2\r\x8D\x3\x2\x2\x2\xF\x93\x3\x2\x2\x2\x11\x98\x3\x2\x2\x2\x13"+
		"\x9F\x3\x2\x2\x2\x15\xA9\x3\x2\x2\x2\x17\xAD\x3\x2\x2\x2\x19\xB0\x3\x2"+
		"\x2\x2\x1B\xB4\x3\x2\x2\x2\x1D\xBB\x3\x2\x2\x2\x1F\xC0\x3\x2\x2\x2!\xC6"+
		"\x3\x2\x2\x2#\xCA\x3\x2\x2\x2%\xCC\x3\x2\x2\x2\'\xCE\x3\x2\x2\x2)\xD0"+
		"\x3\x2\x2\x2+\xD2\x3\x2\x2\x2-\xD4\x3\x2\x2\x2/\xD6\x3\x2\x2\x2\x31\xD8"+
		"\x3\x2\x2\x2\x33\xDB\x3\x2\x2\x2\x35\xDD\x3\x2\x2\x2\x37\xE0\x3\x2\x2"+
		"\x2\x39\xE2\x3\x2\x2\x2;\xE4\x3\x2\x2\x2=\xE6\x3\x2\x2\x2?\xE8\x3\x2\x2"+
		"\x2\x41\xEA\x3\x2\x2\x2\x43\xED\x3\x2\x2\x2\x45\xF0\x3\x2\x2\x2G\xF2\x3"+
		"\x2\x2\x2I\xF4\x3\x2\x2\x2K\xF6\x3\x2\x2\x2M\xF8\x3\x2\x2\x2O\xFB\x3\x2"+
		"\x2\x2Q\xFE\x3\x2\x2\x2S\x100\x3\x2\x2\x2U\x108\x3\x2\x2\x2W\x10A\x3\x2"+
		"\x2\x2Y\x10C\x3\x2\x2\x2[\x10F\x3\x2\x2\x2]\x11B\x3\x2\x2\x2_\x11E\x3"+
		"\x2\x2\x2\x61\x122\x3\x2\x2\x2\x63\x129\x3\x2\x2\x2\x65\x130\x3\x2\x2"+
		"\x2g\x13B\x3\x2\x2\x2i\x13E\x3\x2\x2\x2k\x149\x3\x2\x2\x2m\x14D\x3\x2"+
		"\x2\x2o\x15B\x3\x2\x2\x2qr\a]\x2\x2rs\a_\x2\x2s\x4\x3\x2\x2\x2tu\a\x64"+
		"\x2\x2uv\at\x2\x2vw\ag\x2\x2wx\a\x63\x2\x2xy\am\x2\x2y\x6\x3\x2\x2\x2"+
		"z{\a\x65\x2\x2{|\a\x63\x2\x2|}\au\x2\x2}~\ag\x2\x2~\b\x3\x2\x2\x2\x7F"+
		"\x80\a\x65\x2\x2\x80\x81\aq\x2\x2\x81\x82\ap\x2\x2\x82\x83\av\x2\x2\x83"+
		"\x84\ak\x2\x2\x84\x85\ap\x2\x2\x85\x86\aw\x2\x2\x86\x87\ag\x2\x2\x87\n"+
		"\x3\x2\x2\x2\x88\x89\ag\x2\x2\x89\x8A\an\x2\x2\x8A\x8B\au\x2\x2\x8B\x8C"+
		"\ag\x2\x2\x8C\f\x3\x2\x2\x2\x8D\x8E\ah\x2\x2\x8E\x8F\an\x2\x2\x8F\x90"+
		"\aq\x2\x2\x90\x91\a\x63\x2\x2\x91\x92\av\x2\x2\x92\xE\x3\x2\x2\x2\x93"+
		"\x94\a\x64\x2\x2\x94\x95\aq\x2\x2\x95\x96\aq\x2\x2\x96\x97\an\x2\x2\x97"+
		"\x10\x3\x2\x2\x2\x98\x99\au\x2\x2\x99\x9A\av\x2\x2\x9A\x9B\at\x2\x2\x9B"+
		"\x9C\ak\x2\x2\x9C\x9D\ap\x2\x2\x9D\x9E\ai\x2\x2\x9E\x12\x3\x2\x2\x2\x9F"+
		"\xA0\aj\x2\x2\xA0\xA1\a\x63\x2\x2\xA1\xA2\au\x2\x2\xA2\xA3\aj\x2\x2\xA3"+
		"\xA4\av\x2\x2\xA4\xA5\a\x63\x2\x2\xA5\xA6\a\x64\x2\x2\xA6\xA7\an\x2\x2"+
		"\xA7\xA8\ag\x2\x2\xA8\x14\x3\x2\x2\x2\xA9\xAA\ah\x2\x2\xAA\xAB\aq\x2\x2"+
		"\xAB\xAC\at\x2\x2\xAC\x16\x3\x2\x2\x2\xAD\xAE\ak\x2\x2\xAE\xAF\ah\x2\x2"+
		"\xAF\x18\x3\x2\x2\x2\xB0\xB1\ak\x2\x2\xB1\xB2\ap\x2\x2\xB2\xB3\av\x2\x2"+
		"\xB3\x1A\x3\x2\x2\x2\xB4\xB5\at\x2\x2\xB5\xB6\ag\x2\x2\xB6\xB7\av\x2\x2"+
		"\xB7\xB8\aw\x2\x2\xB8\xB9\at\x2\x2\xB9\xBA\ap\x2\x2\xBA\x1C\x3\x2\x2\x2"+
		"\xBB\xBC\ax\x2\x2\xBC\xBD\aq\x2\x2\xBD\xBE\ak\x2\x2\xBE\xBF\a\x66\x2\x2"+
		"\xBF\x1E\x3\x2\x2\x2\xC0\xC1\ay\x2\x2\xC1\xC2\aj\x2\x2\xC2\xC3\ak\x2\x2"+
		"\xC3\xC4\an\x2\x2\xC4\xC5\ag\x2\x2\xC5 \x3\x2\x2\x2\xC6\xC7\ap\x2\x2\xC7"+
		"\xC8\ag\x2\x2\xC8\xC9\ay\x2\x2\xC9\"\x3\x2\x2\x2\xCA\xCB\a*\x2\x2\xCB"+
		"$\x3\x2\x2\x2\xCC\xCD\a+\x2\x2\xCD&\x3\x2\x2\x2\xCE\xCF\a]\x2\x2\xCF("+
		"\x3\x2\x2\x2\xD0\xD1\a_\x2\x2\xD1*\x3\x2\x2\x2\xD2\xD3\a}\x2\x2\xD3,\x3"+
		"\x2\x2\x2\xD4\xD5\a\x7F\x2\x2\xD5.\x3\x2\x2\x2\xD6\xD7\a>\x2\x2\xD7\x30"+
		"\x3\x2\x2\x2\xD8\xD9\a>\x2\x2\xD9\xDA\a?\x2\x2\xDA\x32\x3\x2\x2\x2\xDB"+
		"\xDC\a@\x2\x2\xDC\x34\x3\x2\x2\x2\xDD\xDE\a@\x2\x2\xDE\xDF\a?\x2\x2\xDF"+
		"\x36\x3\x2\x2\x2\xE0\xE1\a-\x2\x2\xE1\x38\x3\x2\x2\x2\xE2\xE3\a/\x2\x2"+
		"\xE3:\x3\x2\x2\x2\xE4\xE5\a,\x2\x2\xE5<\x3\x2\x2\x2\xE6\xE7\a\x31\x2\x2"+
		"\xE7>\x3\x2\x2\x2\xE8\xE9\a\'\x2\x2\xE9@\x3\x2\x2\x2\xEA\xEB\a(\x2\x2"+
		"\xEB\xEC\a(\x2\x2\xEC\x42\x3\x2\x2\x2\xED\xEE\a~\x2\x2\xEE\xEF\a~\x2\x2"+
		"\xEF\x44\x3\x2\x2\x2\xF0\xF1\a#\x2\x2\xF1\x46\x3\x2\x2\x2\xF2\xF3\a=\x2"+
		"\x2\xF3H\x3\x2\x2\x2\xF4\xF5\a.\x2\x2\xF5J\x3\x2\x2\x2\xF6\xF7\a?\x2\x2"+
		"\xF7L\x3\x2\x2\x2\xF8\xF9\a?\x2\x2\xF9\xFA\a?\x2\x2\xFAN\x3\x2\x2\x2\xFB"+
		"\xFC\a#\x2\x2\xFC\xFD\a?\x2\x2\xFDP\x3\x2\x2\x2\xFE\xFF\a\x30\x2\x2\xFF"+
		"R\x3\x2\x2\x2\x100\x105\x5U+\x2\x101\x104\x5U+\x2\x102\x104\x5Y-\x2\x103"+
		"\x101\x3\x2\x2\x2\x103\x102\x3\x2\x2\x2\x104\x107\x3\x2\x2\x2\x105\x103"+
		"\x3\x2\x2\x2\x105\x106\x3\x2\x2\x2\x106T\x3\x2\x2\x2\x107\x105\x3\x2\x2"+
		"\x2\x108\x109\x5W,\x2\x109V\x3\x2\x2\x2\x10A\x10B\t\x2\x2\x2\x10BX\x3"+
		"\x2\x2\x2\x10C\x10D\t\x3\x2\x2\x10DZ\x3\x2\x2\x2\x10E\x110\t\x3\x2\x2"+
		"\x10F\x10E\x3\x2\x2\x2\x110\x111\x3\x2\x2\x2\x111\x10F\x3\x2\x2\x2\x111"+
		"\x112\x3\x2\x2\x2\x112\\\x3\x2\x2\x2\x113\x115\x5_\x30\x2\x114\x113\x3"+
		"\x2\x2\x2\x114\x115\x3\x2\x2\x2\x115\x116\x3\x2\x2\x2\x116\x117\a\x30"+
		"\x2\x2\x117\x11C\x5_\x30\x2\x118\x119\x5_\x30\x2\x119\x11A\a\x30\x2\x2"+
		"\x11A\x11C\x3\x2\x2\x2\x11B\x114\x3\x2\x2\x2\x11B\x118\x3\x2\x2\x2\x11C"+
		"^\x3\x2\x2\x2\x11D\x11F\x5Y-\x2\x11E\x11D\x3\x2\x2\x2\x11F\x120\x3\x2"+
		"\x2\x2\x120\x11E\x3\x2\x2\x2\x120\x121\x3\x2\x2\x2\x121`\x3\x2\x2\x2\x122"+
		"\x124\a$\x2\x2\x123\x125\x5\x63\x32\x2\x124\x123\x3\x2\x2\x2\x124\x125"+
		"\x3\x2\x2\x2\x125\x126\x3\x2\x2\x2\x126\x127\a$\x2\x2\x127\x62\x3\x2\x2"+
		"\x2\x128\x12A\x5\x65\x33\x2\x129\x128\x3\x2\x2\x2\x12A\x12B\x3\x2\x2\x2"+
		"\x12B\x129\x3\x2\x2\x2\x12B\x12C\x3\x2\x2\x2\x12C\x64\x3\x2\x2\x2\x12D"+
		"\x131\n\x4\x2\x2\x12E\x12F\a^\x2\x2\x12F\x131\t\x5\x2\x2\x130\x12D\x3"+
		"\x2\x2\x2\x130\x12E\x3\x2\x2\x2\x131\x66\x3\x2\x2\x2\x132\x133\av\x2\x2"+
		"\x133\x134\at\x2\x2\x134\x135\aw\x2\x2\x135\x13C\ag\x2\x2\x136\x137\a"+
		"h\x2\x2\x137\x138\a\x63\x2\x2\x138\x139\an\x2\x2\x139\x13A\au\x2\x2\x13A"+
		"\x13C\ag\x2\x2\x13B\x132\x3\x2\x2\x2\x13B\x136\x3\x2\x2\x2\x13Ch\x3\x2"+
		"\x2\x2\x13D\x13F\t\x6\x2\x2\x13E\x13D\x3\x2\x2\x2\x13F\x140\x3\x2\x2\x2"+
		"\x140\x13E\x3\x2\x2\x2\x140\x141\x3\x2\x2\x2\x141\x142\x3\x2\x2\x2\x142"+
		"\x143\b\x35\x2\x2\x143j\x3\x2\x2\x2\x144\x146\a\xF\x2\x2\x145\x147\a\f"+
		"\x2\x2\x146\x145\x3\x2\x2\x2\x146\x147\x3\x2\x2\x2\x147\x14A\x3\x2\x2"+
		"\x2\x148\x14A\a\f\x2\x2\x149\x144\x3\x2\x2\x2\x149\x148\x3\x2\x2\x2\x14A"+
		"\x14B\x3\x2\x2\x2\x14B\x14C\b\x36\x2\x2\x14Cl\x3\x2\x2\x2\x14D\x14E\a"+
		"\x31\x2\x2\x14E\x14F\a,\x2\x2\x14F\x153\x3\x2\x2\x2\x150\x152\v\x2\x2"+
		"\x2\x151\x150\x3\x2\x2\x2\x152\x155\x3\x2\x2\x2\x153\x154\x3\x2\x2\x2"+
		"\x153\x151\x3\x2\x2\x2\x154\x156\x3\x2\x2\x2\x155\x153\x3\x2\x2\x2\x156"+
		"\x157\a,\x2\x2\x157\x158\a\x31\x2\x2\x158\x159\x3\x2\x2\x2\x159\x15A\b"+
		"\x37\x2\x2\x15An\x3\x2\x2\x2\x15B\x15C\a\x31\x2\x2\x15C\x15D\a\x31\x2"+
		"\x2\x15D\x161\x3\x2\x2\x2\x15E\x160\n\a\x2\x2\x15F\x15E\x3\x2\x2\x2\x160"+
		"\x163\x3\x2\x2\x2\x161\x15F\x3\x2\x2\x2\x161\x162\x3\x2\x2\x2\x162\x164"+
		"\x3\x2\x2\x2\x163\x161\x3\x2\x2\x2\x164\x165\b\x38\x2\x2\x165p\x3\x2\x2"+
		"\x2\x12\x2\x103\x105\x111\x114\x11B\x120\x124\x12B\x130\x13B\x140\x146"+
		"\x149\x153\x161\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
