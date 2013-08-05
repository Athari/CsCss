namespace Alba.CsCss.Style
{
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