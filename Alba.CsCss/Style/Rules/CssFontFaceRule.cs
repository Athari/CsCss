using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@font-face \{ font-family: {mDecl.mFamily}; src: {mDecl.mSrc} \}")]
    public class CssFontFaceRule : CssRule
    {
        private readonly CssFontFace mDecl = new CssFontFace();

        internal CssFontFaceRule ()
        {}

        internal void SetDesc (nsCSSFontDesc aDescId, CssValue aValue)
        {
            mDecl.SetValue(aDescId, aValue);
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.FontFace;
        }

        // Public interface

        public CssFontFace Font
        {
            get { return mDecl; }
        }
    }
}