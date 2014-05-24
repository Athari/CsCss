using System;
using System.Diagnostics;
using Alba.CsCss.Internal.Extensions;
using PRUnichar = System.Char;

namespace Alba.CsCss.Gfx
{
    [DebuggerDisplay ("rgba({R}, {G}, {B}, {A})")]
    public partial struct CssColor : IEquatable<CssColor>
    {
        private readonly UInt32 _rgba;

        private CssColor (uint rgba)
        {
            _rgba = rgba;
        }

        public byte R
        {
            get { return (byte)((_rgba) & 0xff); }
        }

        public byte G
        {
            get { return (byte)((_rgba >> 8) & 0xff); }
        }

        public byte B
        {
            get { return (byte)((_rgba >> 16) & 0xff); }
        }

        public byte A
        {
            get { return (byte)((_rgba >> 24) & 0xff); }
        }

        public static CssColor RGB (byte r, byte g, byte b)
        {
            return new CssColor(((uint)255 << 24) | ((uint)(b) << 16) | ((uint)(g) << 8) | (r));
        }

        public static CssColor RGBA (byte r, byte g, byte b, byte a)
        {
            return new CssColor(((uint)a << 24) | ((uint)(b) << 16) | ((uint)(g) << 8) | (r));
        }

        public static bool HexToRGB (string aColorSpec, ref CssColor aResult)
        {
            string buffer = aColorSpec;

            int nameLen = aColorSpec.Length;
            if ((nameLen == 3) || (nameLen == 6)) {
                // Make sure the digits are legal
                for (int i = 0; i < nameLen; i++) {
                    PRUnichar ch = buffer[i];
                    if (((ch >= '0') && (ch <= '9')) ||
                        ((ch >= 'a') && (ch <= 'f')) ||
                        ((ch >= 'A') && (ch <= 'F'))) {
                        // Legal character
                        continue;
                    }
                    // Whoops. Illegal character.
                    return false;
                }

                // Convert the ascii to binary
                int dpc = ((3 == nameLen) ? 1 : 2);
                // Translate components from hex to binary
                byte r = ComponentValue(buffer, nameLen, 0, dpc);
                byte g = ComponentValue(buffer, nameLen, 1, dpc);
                byte b = ComponentValue(buffer, nameLen, 2, dpc);
                if (dpc == 1) {
                    // Scale single digit component to an 8 bit value. Replicate the
                    // single digit to compute the new value.
                    r = (byte)((r << 4) | r);
                    g = (byte)((g << 4) | g);
                    b = (byte)((b << 4) | b);
                }
                aResult = RGB(r, g, b);
                return true;
            }

            // Improperly formatted color value
            return false;
        }

        public static CssColor? HexToRGB (string aColorSpec)
        {
            var aResult = new CssColor();
            return HexToRGB(aColorSpec, ref aResult) ? aResult : (CssColor?)null;
        }

        public static bool LooseHexToRGB (string aColorSpec, ref CssColor aResult)
        {
            if (aColorSpec.EqualsLiteral("transparent")) {
                return false;
            }

            int nameLen = aColorSpec.Length;
            int idx = 0;
            string colorSpec = aColorSpec;
            if (nameLen > 128) {
                nameLen = 128;
            }

            if ('#' == colorSpec[0]) {
                ++idx;
                --nameLen;
            }

            // digits per component
            int dpc = (nameLen + 2) / 3;
            int newdpc = dpc;

            // Use only the rightmost 8 characters of each component.
            if (newdpc > 8) {
                nameLen -= newdpc - 8;
                idx += newdpc - 8;
                newdpc = 8;
            }

            // And then keep trimming characters at the left until we'd trim one
            // that would leave a nonzero value, but not past 2 characters per
            // component.
            while (newdpc > 2) {
                bool haveNonzero = false;
                for (int c = 0; c < 3; ++c) {
                    PRUnichar ch = colorSpec[idx + c * dpc];
                    if (('1' <= ch && ch <= '9') ||
                        ('A' <= ch && ch <= 'F') ||
                        ('a' <= ch && ch <= 'f')) {
                        haveNonzero = true;
                        break;
                    }
                }
                if (haveNonzero) {
                    break;
                }
                --newdpc;
                --nameLen;
                ++idx;
            }

            // Translate components from hex to binary
            colorSpec = colorSpec.Substring(idx);
            byte r = ComponentValue(colorSpec, nameLen, 0, dpc);
            byte g = ComponentValue(colorSpec, nameLen, 1, dpc);
            byte b = ComponentValue(colorSpec, nameLen, 2, dpc);

            aResult = RGB(r, g, b);
            return true;
        }

        public static CssColor? LooseHexToRGB (string aColorSpec)
        {
            var aResult = new CssColor();
            return LooseHexToRGB(aColorSpec, ref aResult) ? aResult : (CssColor?)null;
        }

        public static bool ColorNameToRGB (string aColorName, ref CssColor aResult)
        {
            if (gColorTable == null)
                return false;

            int id;
            if (gColorTable.TryGetValue(aColorName, out id)) {
                aResult = kColors[id];
                return true;
            }
            return false;
        }

        public static CssColor? ColorNameToRGB (string aColorName)
        {
            var aResult = new CssColor();
            return ColorNameToRGB(aColorName, ref aResult) ? aResult : (CssColor?)null;
        }

        public static CssColor HSL2RGB (float h, float s, float l)
        {
            float m2 = l <= 0.5f ? (l * (s + 1)) : (l + s - l * s);
            float m1 = l * 2 - m2;
            byte r = (byte)(255 * HSL_HueToRGB(m1, m2, h + 1.0f / 3.0f));
            byte g = (byte)(255 * HSL_HueToRGB(m1, m2, h));
            byte b = (byte)(255 * HSL_HueToRGB(m1, m2, h - 1.0f / 3.0f));
            return RGB(r, g, b);
        }

        private static float HSL_HueToRGB (float m1, float m2, float h)
        {
            if (h < 0.0f)
                h += 1.0f;
            if (h > 1.0f)
                h -= 1.0f;
            if (h < (float)(1.0 / 6.0))
                return m1 + (m2 - m1) * h * 6.0f;
            if (h < (float)(1.0 / 2.0))
                return m2;
            if (h < (float)(2.0 / 3.0))
                return m1 + (m2 - m1) * ((float)(2.0 / 3.0) - h) * 6.0f;
            return m1;
        }

        public static string RGBToColorName (CssColor aColor)
        {
            for (int idx = 0; idx < kColors.Length; ++idx) {
                if (kColors[idx] == aColor) {
                    return kColorNames[idx];
                }
            }
            return null;
        }

        private static byte ComponentValue (string aColorSpec, int aLen, int color, int dpc)
        {
            int component = 0;
            int index = (color * dpc);
            if (2 < dpc) {
                dpc = 2;
            }
            while (--dpc >= 0) {
                PRUnichar ch = ((index < aLen) ? aColorSpec[index++] : '0');
                if (('0' <= ch) && (ch <= '9')) {
                    component = (component * 16) + (ch - '0');
                }
                else if ((('a' <= ch) && (ch <= 'f')) ||
                    (('A' <= ch) && (ch <= 'F'))) {
                    // "ch&7" handles lower and uppercase hex alphabetics
                    component = (component * 16) + (ch & 7) + 9;
                }
                else { // not a hex digit, treat it like 0
                    component = (component * 16);
                }
            }
            return (byte)component;
        }

        public bool Equals (CssColor other)
        {
            return _rgba == other._rgba;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(null, obj) && (obj is CssColor && Equals((CssColor)obj));
        }

        public override int GetHashCode ()
        {
            return (int)_rgba;
        }

        public static bool operator == (CssColor left, CssColor right)
        {
            return left.Equals(right);
        }

        public static bool operator != (CssColor left, CssColor right)
        {
            return !left.Equals(right);
        }
    }
}