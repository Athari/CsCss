using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests
{
    [TestClass]
    public class nsCSSScannerTests
    {
        [TestMethod]
        public void Create ()
        {
            var lex = new nsCSSScanner("", 0);
        }

        [TestMethod]
        public void ParseSimple ()
        {
            var lex = new nsCSSScanner("a { color: red; }", 0);
            //lex.Next();
        }
    }
}