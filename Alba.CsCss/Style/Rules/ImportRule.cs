namespace Alba.CsCss.Style
{
    internal class ImportRule : Rule
    {
        private nsMediaList mMedia;
        private string mUrlSpec;

        public ImportRule (nsMediaList aMedia, string aUrlSpec)
        {
            mMedia = aMedia;
            mUrlSpec = aUrlSpec;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.IMPORT;
        }
    }
}