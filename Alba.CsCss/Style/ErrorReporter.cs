using System;

namespace Alba.CsCss.Style
{
    internal class ErrorReporter
    {
        public ErrorReporter (nsCSSScanner scanner, nsCSSStyleSheet mSheet, CssLoader mChildLoader, Uri aUri)
        {
            // TODO
        }

        internal void ReportUnexpectedEOF (string str)
        {
            // TODO
        }

        internal void ReportUnexpected (string str, nsCSSToken token)
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
    }
}