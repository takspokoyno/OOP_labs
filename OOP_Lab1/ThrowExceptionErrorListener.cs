﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace OOP_lab1
{
    class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<int>
    {
        public override void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine,
            [NotNull] string msg, [Nullable] RecognitionException e)
        {
            throw new ArgumentException("Invalid expression: {0}", msg, e);
        }
        public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionLine, string msg, RecognitionException e)
        {
            throw new ArgumentException("Invalid expression: {0}", msg, e);
        }
    }
}
