using System;
using System.Text;
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using int16_t = System.Int16;

namespace Alba.CsCss.Gfx
{
    internal partial class nsFont
    {
        // IDs for generic fonts
        // NOTE: 0, 1 are reserved for the special IDs of the default variable
        // and fixed fonts in the presentation context, see nsPresContext.h
        public const uint8_t GenericFont_NONE = 0x00;
        // Special
        public const uint8_t GenericFont_moz_variable = 0x00; // for the default variable width font
        public const uint8_t GenericFont_moz_fixed = 0x01; // our special "use the user's fixed font"
        // CSS
        public const uint8_t GenericFont_serif = 0x02;
        public const uint8_t GenericFont_sans_serif = 0x04;
        public const uint8_t GenericFont_monospace = 0x08;
        public const uint8_t GenericFont_cursive = 0x10;
        public const uint8_t GenericFont_fantasy = 0x20;

        // The family name of the font
        public string name;

        // The style of font (normal, italic, oblique; see gfxFontConstants.h)
        public uint8_t style;

        // Force this font to not be considered a 'generic' font, even if
        // the name is the same as a CSS generic font family.
        public uint8_t systemFont;

        // The variant of the font (normal, small-caps)
        public uint8_t variant;

        // The decorations on the font (underline, overline,
        // line-through). The decorations can be binary or'd together.
        public uint8_t decorations;

        // The weight of the font; see gfxFontConstants.h.
        public uint16_t weight;

        // The stretch of the font (the sum of various NS_FONT_STRETCH_*
        // constants; see gfxFontConstants.h).
        public int16_t stretch;

        // The logical size of the font, in nscoord units
        public nscoord size;

        // The aspect-value (ie., the ratio actualsize:actualxheight) that any
        // actual physical font created from this font structure must have when
        // rendering or measuring a string. A value of 0 means no adjustment
        // needs to be done.
        public float sizeAdjust;

        // Font features from CSS font-feature-settings
        // (see http://www.microsoft.com/typography/otspec/featuretags.htm)
        public gfxFontFeature[] fontFeatureSettings;

        // Language system tag, to override document language;
        // this is an OpenType "language system" tag represented as a 32-bit integer
        // (see http://www.microsoft.com/typography/otspec/languagetags.htm).
        public string languageOverride;

        public nsFont (string name, uint8_t style, uint8_t systemFont, uint8_t variant, uint8_t decorations, uint16_t weight, int16_t stretch,
            nscoord size, float sizeAdjust = 0, string languageOverride = null)
        {
            this.name = name;
            this.style = style;
            this.systemFont = systemFont;
            this.variant = variant;
            this.decorations = decorations;
            this.weight = weight;
            this.stretch = stretch;
            this.size = size;
            this.sizeAdjust = sizeAdjust;
            this.languageOverride = languageOverride;
        }

        public nsFont (StringBuilder name, int style, int systemFont, int variant, int decorations, int weight, int stretch,
            nscoord size = default(nscoord), float sizeAdjust = 0, string languageOverride = null)
            : this(name.ToString(), (byte)style, (byte)systemFont, (byte)variant, (byte)decorations, (ushort)weight, (short)stretch, size, sizeAdjust, languageOverride)
        {}

        public void EnumerateFamilies (Func<StringBuilder, bool, object, bool> extractFirstFamily, object dat)
        {
            throw new NotImplementedException();
        }
    }
}