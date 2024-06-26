﻿namespace DevToys.Tools.Helpers.SqlFormatter.Core;

internal enum TokenType
{
    Word,
    String,
    Reserved,
    ReservedTopLevel,
    ReservedTopLevelNoIndent,
    ReservedNewLine,
    Operator,
    OpenParen,
    CloseParen,
    LineComment,
    BlockComment,
    Number,
    PlaceHolder
}
