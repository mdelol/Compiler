grammar LittleBigC;

compilationUnit
    :   translationUnit? EOF
    ;

translationUnit
    :   externalDeclaration
    |   translationUnit externalDeclaration
    ;

externalDeclaration
    :   functionDefinition
    |   variableDeclaration
    |   ';'
    ;

/* Reserved words */
Break : 'break';
Case : 'case';
Continue : 'continue';
Else : 'else';
Float : 'float';
Bool : 'bool';
String: 'string';
Hashtable: 'hashtable';
For : 'for';
If : 'if';
Int : 'int';
Return : 'return';
Void : 'void';
While : 'while';
New: 'new';

LeftParen : '(';
RightParen : ')';
LeftBracket : '[';
RightBracket : ']';
LeftBrace : '{';
RightBrace : '}';

Less : '<';
LessEqual : '<=';
Greater : '>';
GreaterEqual : '>=';

Plus : '+';
Minus : '-';
Star : '*';
Div : '/';
Mod : '%';

AndAnd : '&&';
OrOr : '||';
Not : '!';

Semi : ';';
Comma : ',';

Assign : '=';

Equal : '==';
NotEqual : '!=';

Dot : '.';

/* Variable declaration */
variableType
    : simpleVariableType
    | simpleVariableType '[]'
    | 'void'
    ;

simpleVariableType
    : 'float'
    | 'bool'
    | 'int'
    | 'string'
    | 'hashtable'
    ;

variableDeclaration
    :   variableType Identifier ('=' initExpression)? ';'
    ;

initExpression
    : expression
    | constant
    | arrayInitExpression
    ;

arrayInitExpression
    : 'new' simpleVariableType '[' expression ']'
    ;

/* Function declaration */
functionDefinition
    :   variableType Identifier '(' formalParameters? ')' compoundStatement
    ;

formalParameters
    :   formalParameter
    |   formalParameters ',' formalParameter
    ;

formalParameter
    :   variableType Identifier
    ;

/* Code blocks */
blockItemList
    :   blockItem
    |   blockItemList blockItem
    ;

blockItem
    :   variableDeclaration
    |   statement
    ;

/* Statements */
statement
    :   compoundStatement
    |   expressionStatement
    |   selectionStatement
    |   iterationStatement
    |   jumpStatement
    ;

compoundStatement
    :   '{' blockItemList? '}'
    ;

expressionStatement
    :   expression? ';'
    ;

selectionStatement
    :   'if' '(' expression ')' statement ('else' statement)?
    ;

iterationStatement
    :   'while' '(' expression ')' statement
    |   'for' '(' expression? ';' expression? ';' expression? ')' statement
    ;

jumpStatement
    :   'continue' ';'
    |   'break' ';'
    |   'return' expression? ';'
    ;

/* Expressions */
primaryExpression
    :   Identifier
    |   constant
    |   '(' expression ')'
    ;

postfixExpression
    :   primaryExpression
    |   postfixExpression '[' expression ']' // Array index (hashtable index)
    |   postfixExpression '(' argumentExpressionList? ')' // Function call
    ;

argumentExpressionList
    :   assignmentExpression
    |   argumentExpressionList ',' assignmentExpression
    ;

multiplicativeExpression
    :   postfixExpression
    |   multiplicativeExpression '*' postfixExpression
    |   multiplicativeExpression '/' postfixExpression
    |   multiplicativeExpression '%' postfixExpression
    ;

additiveExpression
    :   multiplicativeExpression
    |   additiveExpression '+' multiplicativeExpression
    |   additiveExpression '-' multiplicativeExpression
    ;

relationalExpression
    :   additiveExpression
    |   relationalExpression '<' additiveExpression
    |   relationalExpression '>' additiveExpression
    |   relationalExpression '<=' additiveExpression
    |   relationalExpression '>=' additiveExpression
    ;

equalityExpression
    :   relationalExpression
    |   equalityExpression '==' relationalExpression
    |   equalityExpression '!=' relationalExpression
    ;

logicalAndExpression
    :   equalityExpression
    |   logicalAndExpression '&&' equalityExpression
    ;

logicalOrExpression
    :   logicalAndExpression
    |   logicalOrExpression '||' logicalAndExpression
    ;

assignmentExpression
    :   logicalOrExpression
    |   postfixExpression '=' logicalOrExpression
    ;

expression
    :   assignmentExpression
    ;

/* Identifier */
Identifier
    :   IdentifierNondigit
        (   IdentifierNondigit
        |   Digit
        )*
    ;

fragment
IdentifierNondigit
    :   Nondigit
    ;

fragment
Nondigit
    :   [a-zA-Z_]
    ;
fragment
Digit
    :   [0-9]
    ;

/* Constants (inline numbers, strings) */
constant
    :   IntegerConstant
    |   FloatingConstant
    |   StringConstant
    |   BooleanConstant
    ;

IntegerConstant
    :   [0-9]+
    ;


FloatingConstant
    :   DigitSequence? '.' DigitSequence
    |   DigitSequence '.'
    ;

fragment
DigitSequence
    :   Digit+
    ;


StringConstant
    :   '"' SCharSequence? '"'
    ;

fragment
SCharSequence
    :   SChar+
    ;

fragment
SChar
    :   ~["\\\r\n]
    |   '\\' ['"?abfnrtv\\]
    ;

BooleanConstant
    : 'true'
    | 'false'
    ;

/* Symbols */
Whitespace
    :   [ \t]+
        -> skip
    ;

Newline
    :   (   '\r' '\n'?
        |   '\n'
        )
        -> skip
    ;

BlockComment
    :   '/*' .*? '*/'
        -> skip
    ;

LineComment
    :   '//' ~[\r\n]*
        -> skip
    ;