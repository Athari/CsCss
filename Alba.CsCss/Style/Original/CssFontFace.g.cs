//
// Generated file. Do not edit manually.
//

using System;

namespace Alba.CsCss.Style
{
    public class CssFontFace
    {
        private CssValue mFamily;
        private CssValue mStyle;
        private CssValue mWeight;
        private CssValue mStretch;
        private CssValue mSrc;
        private CssValue mUnicodeRange;
        private CssValue mFontFeatureSettings;
        private CssValue mFontLanguageOverride;

        internal CssValue GetValue (nsCSSFontDesc aDescID)
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

        internal void SetValue (nsCSSFontDesc aDescID, CssValue value)
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

        public CssValue Family
        {
            get { return mFamily; }
        }

        public CssValue Style
        {
            get { return mStyle; }
        }

        public CssValue Weight
        {
            get { return mWeight; }
        }

        public CssValue Stretch
        {
            get { return mStretch; }
        }

        public CssValue Src
        {
            get { return mSrc; }
        }

        public CssValue UnicodeRange
        {
            get { return mUnicodeRange; }
        }

        public CssValue FontFeatureSettings
        {
            get { return mFontFeatureSettings; }
        }

        public CssValue FontLanguageOverride
        {
            get { return mFontLanguageOverride; }
        }

    }
}
