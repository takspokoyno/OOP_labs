grammar OOP_lab1; 

/*
* Parser Rules
*/

compileUnit : expression EOF;

expression :
LPAREN expression RPAREN #ParenthesizedExpr
	| expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
	| expression operatorToken=(MOD | DIV) expression #ModDivExpr
	| operatorToken=(MAX| MIN) LPAREN expression DESP expression RPAREN #MaxMinExpr
	| expression operatorToken=(ADD | SUBSTRACT) expression #AdditiveExpr
	| operatorToken=(INC| DEC) LPAREN expression RPAREN #IncDecExpr
	| expression EXPONENT expression #ExponentialExpr
	| expression operatorToken=(LESS | GREATER | LESSEQUAL | GREATEREQUAL | EQUAL | INEQUAL) expression #ComparsionExpr
	| NUMBER #NumberExpr
	| IDENTIFIER #IdentifierExpr
	;

/*
* Lexer Rules
*/

NUMBER : INT ('.'INT)?;
IDENTIFIER : [a-zA-Z]+[1-9][0-9]+;
INT : ('0'..'9')+;
INC: 'inc';
DEC: 'dec';
MAX: 'max';
MIN: 'min';
MOD: 'mod';
DIV: 'div';
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBSTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';
LESS : '<';
GREATER : '>';
LESSEQUAL : '<=';
GREATEREQUAL : '>=';
EQUAL : '=';
INEQUAL : '<>';
DESP: ',' | ';';
WS : [ \t\r\n] -> channel(HIDDEN);