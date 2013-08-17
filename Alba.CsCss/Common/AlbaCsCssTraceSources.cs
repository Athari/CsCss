using System.Diagnostics;

namespace Alba.CsCss
{
    public static class AlbaCsCssTraceSources
    {
        public const string BaseTraceSourceName = "Alba.CsCss.";
        public const string CssParserTraceSourceName = BaseTraceSourceName + "CssParser";

        private static TraceSource _cssParser;

        public static TraceSource CssParser
        {
            get { return _cssParser ?? (_cssParser = new TraceSource(CssParserTraceSourceName)); }
        }
    }
}