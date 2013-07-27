using System.Text;
using uint32_t = System.Int32;

namespace Alba.CsCss
{
    internal partial class nsCSSScanner
    {
        private readonly string mBuffer;
        private uint32_t mOffset;
        private readonly uint32_t mCount;

        private uint32_t mLineNumber;
        private uint32_t mLineOffset;

        private uint32_t mTokenLineNumber;
        private uint32_t mTokenLineOffset;
        private uint32_t mTokenOffset;

        private uint32_t mRecordStartOffset;

        private ErrorReporter mReporter;

        private bool mSVGMode;
        private bool mRecording;

        internal nsCSSScanner (string aBuffer, uint32_t aLineNumber)
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

        internal uint32_t GetLineNumber ()
        {
            return mTokenLineNumber;
        }

        internal uint32_t GetColumnLineNumber ()
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
            uint32_t end = mTokenOffset;
            while (end < mCount && !IsVertSpace(mBuffer[end])) {
                end++;
            }
            return mBuffer.Substring(mTokenLineOffset, end);
        }
    }
}