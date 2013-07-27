using uint32_t = System.UInt32;

namespace Alba.CsCss.Gfx
{
    internal struct gfxFontFeature
    {
        // see http://www.microsoft.com/typography/otspec/featuretags.htm
        public uint32_t mTag;
        // 0 = off, 1 = on, larger values may be used as parameters
        // to features that select among multiple alternatives
        public uint32_t mValue;
    }
}