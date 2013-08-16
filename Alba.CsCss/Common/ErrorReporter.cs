using System;
using Alba.CsCss.Style;

namespace Alba.CsCss
{
    internal class ErrorReporter
    {
        public ErrorReporter (nsCSSScanner scanner, CssStyleSheet mSheet, CssLoader mChildLoader, Uri aUri)
        {
            // TODO
        }

        public void ReportUnexpected (string str)
        {
            // TODO
        }

        public void ReportUnexpected (char str)
        {
            // TODO
        }

        public void ReportUnexpected (string str, nsCSSToken token)
        {
            // TODO
        }

        public void ReportUnexpected (string str, string name)
        {
            // TODO
        }

        public void ReportUnexpectedEOF (string str)
        {
            // TODO
        }

        public void OutputError ()
        {
            // TODO
        }

        public void ClearError ()
        {
            // TODO
        }

        public void ReportUnexpected (string pecolorcomponentbadterm, nsCSSToken mToken, char aStop)
        {
            // TODO
        }
    }
}