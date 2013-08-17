using System.Diagnostics;
using Alba.Framework.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests
{
    [TestClass]
    public class AssemblySetup
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize (TestContext context)
        {
            AlbaCsCssTraceSources.CssParser.Switch.Level = SourceLevels.All;
            AlbaCsCssTraceSources.CssParser.Listeners.Add(new TraceRedirectTraceListener());
        }
    }
}