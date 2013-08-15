//
// Generated file. Do not edit manually.
//

using System;

namespace Alba.CsCss.Style
{
    public class nsCSSFontFaceStyleDecl
    {
        private nsCSSValue mFamily;
        private nsCSSValue mStyle;
        private nsCSSValue mWeight;
        private nsCSSValue mStretch;
        private nsCSSValue mSrc;
        private nsCSSValue mUnicodeRange;
        private nsCSSValue mFontFeatureSettings;
        private nsCSSValue mFontLanguageOverride;

        internal nsCSSValue GetValue (nsCSSFontDesc aDescID)
        {
            switch (aDescID) {
                case nsCSSFontDesc.Family: return mFamily;
                case nsCSSFontDesc.Style: return mStyle;
                case nsCSSFontDesc.Weight: return mWeight;
                case nsCSSFontDesc.Stretch: return mStretch;
                case nsCSSFontDesc.Src: return mSrc;
                case nsCSSFontDesc.UnicodeRange: return mUnicodeRange;
                case nsCSSFontDesc.FontFeatureSettings: return mFontFeatureSettings;
                case nsCSSFontDesc.FontLanguageOverride: return mFontLanguageOverride;
                default: throw new ArgumentOutOfRangeException("aDescID");
            }
        }

        internal void SetValue (nsCSSFontDesc aDescID, nsCSSValue value)
        {
            switch (aDescID) {
                case nsCSSFontDesc.Family: mFamily = value; break;
                case nsCSSFontDesc.Style: mStyle = value; break;
                case nsCSSFontDesc.Weight: mWeight = value; break;
                case nsCSSFontDesc.Stretch: mStretch = value; break;
                case nsCSSFontDesc.Src: mSrc = value; break;
                case nsCSSFontDesc.UnicodeRange: mUnicodeRange = value; break;
                case nsCSSFontDesc.FontFeatureSettings: mFontFeatureSettings = value; break;
                case nsCSSFontDesc.FontLanguageOverride: mFontLanguageOverride = value; break;
                default: throw new ArgumentOutOfRangeException("aDescID");
            }
        }

        // Public interface

        public nsCSSValue Family
        {
            get { return mFamily; }
        }

        public nsCSSValue Style
        {
            get { return mStyle; }
        }

        public nsCSSValue Weight
        {
            get { return mWeight; }
        }

        public nsCSSValue Stretch
        {
            get { return mStretch; }
        }

        public nsCSSValue Src
        {
            get { return mSrc; }
        }

        public nsCSSValue UnicodeRange
        {
            get { return mUnicodeRange; }
        }

        public nsCSSValue FontFeatureSettings
        {
            get { return mFontFeatureSettings; }
        }

        public nsCSSValue FontLanguageOverride
        {
            get { return mFontLanguageOverride; }
        }

    }
}
