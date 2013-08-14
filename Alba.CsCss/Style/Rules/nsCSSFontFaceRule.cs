using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@font-face \{ font-family: {mDecl.mFamily}; src: {mDecl.mSrc} \}")]
    internal class nsCSSFontFaceRule : Rule
    {
        public nsCSSFontFaceRule ()
        {}

        public void SetDesc (nsCSSFontDesc aDescId, nsCSSValue aValue)
        {
            mDecl.SetValue(aDescId, aValue);
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.FONT_FACE;
        }

        private readonly nsCSSFontFaceStyleDecl mDecl = new nsCSSFontFaceStyleDecl();
    }
}