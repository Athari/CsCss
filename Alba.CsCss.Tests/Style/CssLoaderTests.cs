using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public void ParseSheet_Simple_ColorHex ()
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
            Assert.AreEqual(CssProperty.Color, h1color.Property);
            Assert.AreEqual(CssColor.RGB(0x11, 0x22, 0x33), h1color.Value.Color);
            Assert.AreEqual(CssColor.RGB(0x11, 0x22, 0x33), css.StyleRules.Single().Declaration.Color.Color);
        }

        [TestMethod]
        public void ParseSheet_Simple_ColorName ()
        {
            var loader = new CssLoader();
            var css = loader.ParseSheet("h1 { color: red; }", SheetUri, BaseUri);

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
            Assert.AreEqual(CssProperty.Color, h1color.Property);
            Assert.AreEqual(CssColor.RGB(0xFF, 0x00, 0x00), CssColor.ColorNameToRGB(h1color.Value.String));
            Assert.AreEqual(CssColor.RGB(0xFF, 0x00, 0x00), CssColor.ColorNameToRGB(css.StyleRules.Single().Declaration.Color.String));
            Assert.AreEqual(CssColor.RGB(0xFF, 0x00, 0x00), h1color.Value.CalculatedColor);
            Assert.AreEqual(CssColor.RGB(0xFF, 0x00, 0x00), css.StyleRules.Single().Declaration.Color.CalculatedColor);
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
            var css = loader.ParseSheet(CssTwitterBootstrap, SheetUri, SheetUri);
            //var q = css.AllStyleRules.Where(r => r.Declaration.BackgroundImage.GetUnit() != CssUnit.Null).Select(r => r.Declaration.BackgroundImage);
        }

        [TestMethod]
        public void GetUris_TwitterBootstrap ()
        {
            var loader = new CssLoader();
            int nUris = 0;
            foreach (string uri in loader.GetUris(CssTwitterBootstrap)) {
                Trace.WriteLine(string.Format("Uri: {0}", uri));
                nUris++;
            }
            Assert.AreEqual(2, nUris);
        }

        [TestMethod]
        public void ParseSheet_GetUris_StackOverflow18262390 ()
        {
            var loader = new CssLoader();
            var css = loader.ParseSheet(CssStackOverflow18262390, SheetUri, BaseUri);
            List<string> uris = css.AllStyleRules
                .SelectMany(styleRule => styleRule.Declaration.AllData)
                .SelectMany(prop => prop.Value.Unit == CssUnit.List ? prop.Value.List : new[] { prop.Value })
                .Where(value => value.Unit == CssUnit.Url)
                .Select(value => value.OriginalUri)
                .ToList();
            CollectionAssert.AreEqual(
                new[] { "img0", "img1", "img2", "img3", "img4", "img5", "img6", "img7" },
                uris);
        }

        [TestMethod]
        public void GetUris_StackOverflow18262390 ()
        {
            List<string> uris = new CssLoader().GetUris(CssStackOverflow18262390).ToList();
            CollectionAssert.AreEqual(
                new[] { "img0", "img1", "img2", "img3", "img4", "img5", "noimg4", "img6", "img7" },
                uris);
        }

        private string CssTwitterBootstrap
        {
            get { return GetResourceFile("bootstrap.css"); }
        }

        private string CssStackOverflow18262390
        {
            get { return GetResourceFile("StackOverflow18262390.css"); }
        }

        private string GetResourceFile (string filename)
        {
            using (var stream = GetType().Assembly.GetManifestResourceStream("Alba.CsCss.Tests.Files." + filename))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }
    }
}