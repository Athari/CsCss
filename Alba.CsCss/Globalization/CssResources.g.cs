using System.Globalization;
using System.Resources;

namespace Alba.CsCss.Globalization
{
    internal static class CssResources
    {
        private static ResourceManager _manager;

        public static CultureInfo Culture { get; set; }

        public static ResourceManager ResourceManager
        {
            get { return _manager ?? (_manager = new ResourceManager("Alba.CsCss.Globalization.CssResources", typeof(CssResources).Assembly)); }
        }

        public static string GetString (string name)
        {
            return ResourceManager.GetString(name, Culture);
        }

        public static string FormatString (string name, params object[] args)
        {
            return string.Format(Culture, GetString(name), args);
        }

    }
}
