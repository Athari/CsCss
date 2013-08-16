namespace Alba.CsCss.Style
{
    public class CssValueGradientStop
    {
        internal CssValue mColor;
        internal CssValue mLocation;

        // public interface

        public CssValue Color
        {
            get { return mColor; }
        }

        public CssValue Location
        {
            get { return mLocation; }
        }
    }
}