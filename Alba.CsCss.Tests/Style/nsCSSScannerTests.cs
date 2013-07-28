using System;
using Alba.CsCss.Style;
using Alba.Framework.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests.Style
{
    [TestClass]
    public class nsCSSScannerTests
    {
        [TestMethod]
        public void Create ()
        {
            // ReSharper disable once UnusedVariable
            var lex = new nsCSSScanner("", 0);
        }

        [TestMethod]
        public void ParseSimple ()
        {
            var lex = new nsCSSScanner("h1 { color: #123; }", 0);
            AssertNextToken(lex, nsCSSTokenType.Ident, t => t.mIdent.ToString() == "h1");
            AssertNextToken(lex, nsCSSTokenType.Symbol, t => t.mSymbol == '{');
            AssertNextToken(lex, nsCSSTokenType.Ident, t => t.mIdent.ToString() == "color");
            AssertNextToken(lex, nsCSSTokenType.Symbol, t => t.mSymbol == ':');
            AssertNextToken(lex, nsCSSTokenType.Hash, t => t.mIdent.ToString() == "123");
            AssertNextToken(lex, nsCSSTokenType.Symbol, t => t.mSymbol == ';');
            AssertNextToken(lex, nsCSSTokenType.Symbol, t => t.mSymbol == '}');
            AssertNextTokenEnd(lex);
        }

        private static void AssertNextToken (nsCSSScanner lex, nsCSSTokenType type, Func<nsCSSToken, bool> condition)
        {
            var token = new nsCSSToken();
            Assert.IsTrue(lex.Next(token, true), "Unexpected EOF");
            Assert.AreEqual(type, token.mType);
            Assert.IsTrue(condition(token), "Condition for token {0} failed".Fmt(token.mType));
        }

        private static void AssertNextTokenEnd (nsCSSScanner lex)
        {
            var token = new nsCSSToken();
            Assert.IsFalse(lex.Next(token, true), "Expected EOF");
        }
    }
}