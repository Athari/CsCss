using System;
using System.Globalization;
using System.Text;

namespace Alba.CsCss.Internal.Extensions
{
    internal static class StringBuilderExts
    {
        private static readonly CultureInfo Culture = CultureInfo.InvariantCulture;

        internal static bool IsEmpty (this StringBuilder @this)
        {
            return @this.Length == 0;
        }

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

        internal static void Trim (this StringBuilder @this, string aSet, bool aLeading, bool aTrailing, bool unused)
        {
            if (!aLeading && !aTrailing)
                return;
            string val = @this.ToString();
            if (aLeading && aTrailing)
                val = val.Trim(aSet.ToCharArray());
            else if (aLeading)
                val = val.TrimStart(aSet.ToCharArray());
            else if (aTrailing)
                val = val.TrimEnd(aSet.ToCharArray());
            @this.Clear();
            @this.Append(val);
        }

        internal static void Clear (this StringBuilder @this) // missing in .NET 3.5
        {
            @this.Length = 0;
        }
    }
}