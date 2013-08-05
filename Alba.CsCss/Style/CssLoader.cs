using System;

namespace Alba.CsCss.Style
{
    internal class CssLoader
    {
        public nsCompatibility CompatibilityMode { get; set; }

        public CssLoader ()
        {
            CompatibilityMode = nsCompatibility.FullStandards;
        }

        public nsCSSStyleSheet ParseSheet (string aInput, Uri sheetUrl, Uri baseUrl)
        {
            var sheet = new nsCSSStyleSheet();
            var parser = new nsCSSParser();
            parser.SetChildLoader(this);
            parser.SetQuirkMode(CompatibilityMode == nsCompatibility.NavQuirks);
            parser.SetStyleSheet(sheet);
            parser.ParseSheet(aInput, sheetUrl, baseUrl, nsIPrincipal.Default, 1, false);
            return sheet;
        }

        public void LoadChildSheet (nsCSSStyleSheet aParentSheet, Uri aUrl, nsMediaList aMedia, ImportRule aRule)
        {}
    }
}