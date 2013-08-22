using System;
using Alba.CsCss.Style;
using Alba.Framework.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests.Style
{
    [TestClass]
    public class CssScannerTests
    {
        [TestMethod]
        public void Create ()
        {
            // ReSharper disable once UnusedVariable
            var lex = new CssScanner("", 0);
        }

        [TestMethod]
        public void ParseSimple ()
        {
            var lex = new CssScanner("h1 { color: #123; }", 0);
            AssertNextToken(lex, CssTokenType.Ident, t => t.mIdent.ToString() == "h1");
            AssertNextToken(lex, CssTokenType.Symbol, t => t.mSymbol == '{');
            AssertNextToken(lex, CssTokenType.Ident, t => t.mIdent.ToString() == "color");
            AssertNextToken(lex, CssTokenType.Symbol, t => t.mSymbol == ':');
            AssertNextToken(lex, CssTokenType.Hash, t => t.mIdent.ToString() == "123");
            AssertNextToken(lex, CssTokenType.Symbol, t => t.mSymbol == ';');
            AssertNextToken(lex, CssTokenType.Symbol, t => t.mSymbol == '}');
            AssertNextTokenEnd(lex);
        }

        private static void AssertNextToken (CssScanner lex, CssTokenType type, Func<CssToken, bool> condition)
        {
            var token = new CssToken();
            Assert.IsTrue(lex.Next(token, true), "Unexpected EOF");
            Assert.AreEqual(type, token.mType);
            Assert.IsTrue(condition(token), "Condition for token {0} failed".Fmt(token.mType));
        }

        private static void AssertNextTokenEnd (CssScanner lex)
        {
            var token = new CssToken();
            Assert.IsFalse(lex.Next(token, true), "Expected EOF");
        }
    }
}