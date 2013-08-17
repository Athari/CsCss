using System;
using System.Diagnostics;
using System.Text;
using Alba.CsCss.Globalization;
using Alba.CsCss.Style;

namespace Alba.CsCss
{
    internal class ErrorReporter
    {
        private readonly nsCSSScanner mScanner;
        private readonly CssStyleSheet mSheet;
        private readonly CssLoader mLoader;
        private readonly Uri mUri;
        private readonly StringBuilder mError = new StringBuilder();
        private string mFileName, mErrorLine;
        private int mErrorLineNumber, mPrevErrorLineNumber, mErrorColumnNumber;

        internal ErrorReporter (nsCSSScanner aScanner, CssStyleSheet aSheet, CssLoader aLoader, Uri aUri)
        {
            mScanner = aScanner;
            mSheet = aSheet;
            mLoader = aLoader;
            mUri = aUri;
        }

        internal void OutputError ()
        {
            if (mError.Length == 0)
                return;
            if (mFileName == null)
                mFileName = mUri != null ? mUri.AbsoluteUri : "dynamic";
            AlbaCsCssTraceSources.CssParser.TraceEvent(TraceEventType.Warning, 0,
                "{0} at {1}:{2}({3})",
                mError, mFileName, mErrorLineNumber, mErrorColumnNumber);
            ClearError();
        }

        internal void ClearError ()
        {
            mError.Length = 0;
        }

        private void AddToError (string aErrorText)
        {
            if (mError.Length == 0) {
                mError.Append(aErrorText);
                mErrorLineNumber = mScanner.GetLineNumber();
                mErrorColumnNumber = mScanner.GetColumnLineNumber();
                if (mErrorLine == null || mErrorLineNumber != mPrevErrorLineNumber) {
                    mErrorLine = mScanner.GetCurrentLine();
                    mPrevErrorLineNumber = mErrorLineNumber;
                }
            }
            else {
                mError.Append("  ");
                mError.Append(aErrorText);
            }
        }

        internal void ReportUnexpected (string aMessage)
        {
            AddToError(CssResources.GetString(aMessage));
        }

        internal void ReportUnexpected (string aMessage, string aParam)
        {
            AddToError(CssResources.FormatString(aMessage, aParam));
        }

        internal void ReportUnexpected (string aMessage, nsCSSToken aToken)
        {
            var sbToken = new StringBuilder();
            aToken.AppendToString(sbToken);
            AddToError(CssResources.FormatString(aMessage, sbToken.ToString()));
        }

        internal void ReportUnexpected (string aMessage, nsCSSToken aToken, char aChar)
        {
            AddToError(CssResources.FormatString(aMessage, aToken, aChar));
        }

        internal void ReportUnexpectedEOF (string aMessage)
        {
            AddToError(CssResources.FormatString("PEUnexpEOF2", CssResources.GetString(aMessage)));
        }

        internal void ReportUnexpected (char aExpected)
        {
            AddToError(CssResources.FormatString("PEUnexpEOF2", string.Format("'{0}'", aExpected)));
        }
    }
}