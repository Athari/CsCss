using System;
using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Style;
using Alba.Framework.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alba.CsCss.Tests
{
    [TestClass]
    public class PublicInterface
    {
        [TestMethod]
        public void ClassNamesTest ()
        {
            bool success = true;
            foreach (Type type in typeof(CssLoader).Assembly.GetExportedTypes().OrderBy(t => t.FullName)) {
                int nCaps = 0;
                bool isuccess = true;

                if (char.IsLower(type.Name, 0)) {
                    isuccess = false;
                    Trace.WriteLine("{0} - failed: class name is not in PascalCase".Fmt(type.FullName));
                }

                if (isuccess) {
                    foreach (char c in type.Name) {
                        if (char.IsUpper(c))
                            nCaps++;
                        else
                            nCaps = 0;
                        if (nCaps > 2) {
                            isuccess = false;
                            Trace.WriteLine("{0} - failed: SCREAMING_CAPS in class name".Fmt(type.FullName));
                            break;
                        }
                    }
                }

                if (isuccess)
                    Trace.WriteLine("{0} - no issues found".Fmt(type.FullName));
                success &= isuccess;
            }
            Assert.IsTrue(success, "One or more public classes failed name check.");
        }
    }
}