using System;

// TODO Implement other CssLoader methods, support @charset etc.
namespace Alba.CsCss.Style
{
    internal class CssLoader
    {
        public BrowserCompatibility Compatibility { get; set; }

        public CssLoader ()
        {
            Compatibility = BrowserCompatibility.FullStandards;
        }

        public CssStyleSheet ParseSheet (string aInput, Uri sheetUrl, Uri baseUrl)
        {
            var sheet = new CssStyleSheet();
            sheet.SetURIs(sheetUrl, baseUrl);
            var parser = new CssParser();
            parser.SetChildLoader(this);
            parser.SetQuirkMode(Compatibility == BrowserCompatibility.Quirks);
            parser.SetStyleSheet(sheet);
            parser.ParseSheet(aInput, sheetUrl, baseUrl, nsIPrincipal.Default, 1, false);
            return sheet;
        }

        public void LoadChildSheet (CssStyleSheet aParentSheet, Uri aUrl, nsMediaList aMedia, CssImportRule aRule)
        {}
    }
}