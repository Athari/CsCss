using System;
using System.Globalization;
using System.Text;

namespace Alba.CsCss.Extensions
{
    internal static class StringBuilderExts
    {
        private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

        internal static void AppendLiteral (this StringBuilder @this, string value)
        {
            @this.Append(value);
        }

        internal static void AppendInt (this StringBuilder @this, int value, int toBase)
        {
            @this.Append(Convert.ToString(value, toBase));
        }

        internal static void AppendFloat (this StringBuilder @this, float value)
        {
            @this.Append(Convert.ToString(value, Culture));
        }

        internal static int Length (this StringBuilder @this)
        {
            return @this.Length;
        }

        internal static void SetLength (this StringBuilder @this, int value)
        {
            @this.Length = value;
        }

        internal static void Truncate (this StringBuilder @this, int length = 0)
        {
            @this.Length = length;
        }

        internal static bool LowerCaseEqualsLiteral (this StringBuilder @this, string value)
        {
            return @this.ToString().ToLowerInvariant() == value;
        }

        internal static void AssignLiteral (this StringBuilder @this, string value)
        {
            @this.Clear();
            @this.Append(value);
        }
    }
}