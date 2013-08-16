using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@font-face \{ font-family: {mDecl.mFamily}; src: {mDecl.mSrc} \}")]
    public class CssFontFaceRule : CssRule
    {
        private readonly nsCSSFontFaceStyleDecl mDecl = new nsCSSFontFaceStyleDecl();

        internal CssFontFaceRule ()
        {}

        internal void SetDesc (nsCSSFontDesc aDescId, CssValue aValue)
        {
            mDecl.SetValue(aDescId, aValue);
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.FONT_FACE;
        }

        // Public interface

        public nsCSSFontFaceStyleDecl Font
        {
            get { return mDecl; }
        }
    }
}