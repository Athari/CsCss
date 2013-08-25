// TODO Implement other CssLoader methods, support @charset etc.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Style
{
    public class CssLoader
    {
        public BrowserCompatibility Compatibility { get; set; }
        public event EventHandler<CssParserErrorEventArgs> ParseError;

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
            sheet.Fix(); // My
            return sheet;
        }

        public IEnumerable<string> GetUris (string aInput)
        {
            var lexer = new CssScanner(aInput, 1);
            lexer.SetErrorReporter(new ErrorReporter(lexer, null, this, null));
            var token = new CssToken();
            while (lexer.Next(token, true))
                if (token.mType == CssTokenType.URL)
                    yield return token.mIdentStr;
        }

        public IEnumerable<Uri> GetUris (string aInput, Uri baseUri)
        {
            return GetUris(aInput).Select(s => new Uri(baseUri, s));
        }

        internal void LoadChildSheet (CssStyleSheet aParentSheet, Uri aUrl, nsMediaList aMedia, CssImportRule aRule)
        {}

        internal void FireParseError (ErrorReporter aErrorReporter)
        {
            var handler = ParseError;
            if (handler != null)
                handler(this, new CssParserErrorEventArgs(aErrorReporter));
        }
    }
}