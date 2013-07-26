using uint32_t = System.Int32;

namespace Alba.CsCss
{
    internal partial class nsCSSScanner
    {
        private string mBuffer;
        private uint32_t mOffset;
        private uint32_t mCount;

        private uint32_t mLineNumber;
        private uint32_t mLineOffset;

        private uint32_t mTokenLineNumber;
        private uint32_t mTokenLineOffset;
        private uint32_t mTokenOffset;

        private uint32_t mRecordStartOffset;

        private ErrorReporter mReporter;

        private bool mSVGMode;
        private bool mRecording;
    }
}