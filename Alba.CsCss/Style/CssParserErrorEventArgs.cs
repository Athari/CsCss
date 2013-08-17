using System;

namespace Alba.CsCss.Style
{
    public class CssParserErrorEventArgs : EventArgs
    {
        private readonly ErrorReporter mReporter;

        internal CssParserErrorEventArgs (ErrorReporter aReporter)
        {
            mReporter = aReporter;
        }

        public string Message
        {
            get { return mReporter.mError.ToString(); }
        }

        public Uri Uri
        {
            get { return mReporter.mUri; }
        }

        public string Line
        {
            get { return mReporter.mErrorLine; }
        }

        public int LineNumber
        {
            get { return mReporter.mErrorLineNumber - 1; }
        }

        public int ColumnNumber
        {
            get { return mReporter.mErrorColumnNumber; }
        }
    }
}