using System;
using System.Text;

namespace Alba.CsCss.Style
{
    internal partial class CssScanner
    {
        private readonly string mBuffer;
        private Int32 mOffset;
        private readonly Int32 mCount;

        private Int32 mLineNumber;
        private Int32 mLineOffset;

        private Int32 mTokenLineNumber;
        private Int32 mTokenLineOffset;
        private Int32 mTokenOffset;

        private Int32 mRecordStartOffset;

        private ErrorReporter mReporter;

        private bool mSVGMode;
        private bool mRecording;

        internal CssScanner (string aBuffer, Int32 aLineNumber)
        {
            mBuffer = aBuffer;
            mCount = aBuffer.Length;
            mLineNumber = aLineNumber;
            mTokenLineNumber = aLineNumber;
        }

        internal void SetErrorReporter (ErrorReporter aReporter)
        {
            mReporter = aReporter;
        }

        internal bool IsSVGMode ()
        {
            return mSVGMode;
        }

        internal void SetSVGMode (bool aSVGMode)
        {
            mSVGMode = aSVGMode;
        }

        internal Int32 GetLineNumber ()
        {
            return mTokenLineNumber;
        }

        internal Int32 GetColumnLineNumber ()
        {
            return mTokenOffset - mTokenLineOffset;
        }

        internal void StopRecording (StringBuilder aBuffer)
        {
            mRecording = false;
            aBuffer.Append(mBuffer, mRecordStartOffset, mOffset - mRecordStartOffset);
        }

        internal string GetCurrentLine ()
        {
            Int32 end = mTokenOffset;
            while (end < mCount && !IsVertSpace(mBuffer[end])) {
                end++;
            }
            return mBuffer.Substring(mTokenLineOffset, end - mTokenLineOffset);
        }
    }
}