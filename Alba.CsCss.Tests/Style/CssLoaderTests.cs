using System;
using System.IO;
using System.Linq;
using Alba.CsCss.Gfx;
using Alba.CsCss.Style;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests.Style
{
    [TestClass]
    public class CssLoaderTests
    {
        private static readonly Uri SheetUri = new Uri("http://example.com/sheet.css"), BaseUri = new Uri("http://example.com/");

        [TestMethod]
        public void ParseSheet_Simple ()
        {
            var loader = new CssLoader();
            var css = loader.ParseSheet("h1 { color: #123; }", SheetUri, BaseUri);

            Assert.AreEqual(SheetUri, css.SheetUri);
            Assert.AreEqual(BaseUri, css.BaseUri);
            Assert.AreEqual(1, css.Rules.Count());
            Assert.AreEqual(1, css.AllRules.Count());
            Assert.AreEqual(1, css.StyleRules.Count());
            Assert.AreEqual(1, css.AllStyleRules.Count());
            var h1 = css.StyleRules.Single();
            var h1sel = h1.SelectorGroups.Single().Selectors.Single();
            Assert.AreEqual("h1", h1sel.Tag);
            var h1color = h1.Declaration.Data.Single();
            Assert.AreEqual(CssProperty.color, h1color.Property);
            Assert.AreEqual(CssColor.RGB(0x11, 0x22, 0x33), h1color.Value.Color);
            //var h1colorval = css.StyleRules.Single().Declaration.GetValue(CssProperty.color).Color;
        }

        [TestMethod]
        public void ParseSheet_ParseErrorEvent ()
        {
            int nErrors = 0;
            var loader = new CssLoader();
            loader.ParseError += (o, a) => {
                Assert.AreEqual(SheetUri, a.Uri);
                Assert.AreEqual("b {*}", a.Line);
                Assert.AreEqual(1, a.LineNumber);
                Assert.AreEqual(3, a.ColumnNumber);
                Assert.IsTrue(a.Message.Contains("found '*'"));
                Assert.IsTrue(a.Message.Contains("Skipped to next"));
                nErrors++;
            };
            loader.ParseSheet("a {}\nb {*}\nc {}", SheetUri, BaseUri);
            Assert.AreEqual(1, nErrors);
        }

        [TestMethod]
        public void ParseSheet_TwitterBootstrap ()
        {
            var loader = new CssLoader();
            loader.ParseSheet(GetResourceFile("bootstrap.css"), SheetUri, SheetUri);
        }

        private string GetResourceFile (string filename)
        {
            using (var stream = GetType().Assembly.GetManifestResourceStream("Alba.CsCss.Tests.Files." + filename))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }
    }
}