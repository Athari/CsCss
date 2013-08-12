// ReSharper disable RedundantCast

// Too much hassle to convert the whole ErrorList.h (included from nsError.h) with hundreds of codes, considering we need only a few.
// Besides, exact codes don't really matter; only 0x80000000 failure bit matters.

namespace Alba.CsCss
{
    internal enum nsresult
    {
        OK = unchecked ((int)0x00000000),
        ERROR_UNEXPECTED = unchecked ((int)0x8000ffff),
        ERROR_DOM_SYNTAX_ERR = unchecked ((int)0x8053000c),
        ERROR_MALFORMED_URI = unchecked((int)0x804b000a),
        ERROR_ILLEGAL_VALUE = unchecked((int)0x80070057),
    }
}