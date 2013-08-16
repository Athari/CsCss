using System;

// TODO Implement other CssLoader methods, support @charset etc.
namespace Alba.CsCss.Style
{
    internal class CssLoader
    {
        public BrowserCompatibility CompatibilityMode { get; set; }

        public CssLoader ()
        {
            CompatibilityMode = BrowserCompatibility.FullStandards;
        }

        public nsCSSStyleSheet ParseSheet (string aInput, Uri sheetUrl, Uri baseUrl)
        {
            var sheet = new nsCSSStyleSheet();
            sheet.SetURIs(sheetUrl, baseUrl);
            var parser = new nsCSSParser();
            parser.SetChildLoader(this);
            parser.SetQuirkMode(CompatibilityMode == BrowserCompatibility.NavQuirks);
            parser.SetStyleSheet(sheet);
            parser.ParseSheet(aInput, sheetUrl, baseUrl, nsIPrincipal.Default, 1, false);
            return sheet;
        }

        public void LoadChildSheet (nsCSSStyleSheet aParentSheet, Uri aUrl, nsMediaList aMedia, CssImportRule aRule)
        {}
    }
}