using System;
using System.Globalization;
using System.Text;

namespace Alba.CsCss.Extensions
{
    internal static class StringBuilderExts
    {
        private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

        public static void AppendLiteral (this StringBuilder @this, string value)
        {
            @this.Append(value);
        }

        public static void AppendInt (this StringBuilder @this, int value, int toBase)
        {
            @this.Append(Convert.ToString(value, toBase));
        }

        public static void AppendFloat (this StringBuilder @this, float value)
        {
            @this.Append(Convert.ToString(value, Culture));
        }

        public static int Length (this StringBuilder @this)
        {
            return @this.Length;
        }

        public static void SetLength (this StringBuilder @this, int value)
        {
            @this.Length = value;
        }

        public static void Truncate (this StringBuilder @this, int length = 0)
        {
            @this.Length = length;
        }

        public static bool LowerCaseEqualsLiteral (this StringBuilder @this, string value)
        {
            return @this.ToString().ToLowerInvariant() == value;
        }

        public static void AssignLiteral (this StringBuilder @this, string value)
        {
            @this.Clear();
            @this.Append(value);
        }
    }
}