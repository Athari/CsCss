using System;
using System.Linq;
using Alba.CsCss.Gfx;
using Alba.CsCss.Style;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests.Style
{
    [TestClass]
    public class CssLoaderTests
    {
        private static readonly Uri SheetUri = new Uri("http://example.com/sheet.css");

        [TestMethod]
        public void ParseSheet_Simple ()
        {
            var loader = new CssLoader();
            var css = loader.ParseSheet("h1 { color: #123; }", SheetUri, SheetUri);

            Assert.AreEqual(SheetUri, css.SheetUri);
            Assert.AreEqual(SheetUri, css.BaseUri);
            var h1 = css.GetRules<StyleRule>().Single();
            var h1sel = h1.SelectorGroups.Single().Selectors.Single();
            Assert.AreEqual("h1", h1sel.Tag);
            var h1color = h1.Declaration.Data.Single();
            Assert.AreEqual(nsCSSProperty.color, h1color.Property);
            Assert.AreEqual(nscolor.RGB(0x11, 0x22, 0x33), h1color.Value.Color);
            //var h1colorval = css.GetRules<StyleRule>().Single().Declaration.Data.Single().Value.Color;
        }
    }
}