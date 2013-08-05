namespace Alba.CsCss.Style
{
    public class nsCSSValueGradientStop
    {
        internal nsCSSValue mColor;
        internal nsCSSValue mLocation;

        // public interface

        public nsCSSValue Color
        {
            get { return mColor; }
        }

        public nsCSSValue Location
        {
            get { return mLocation; }
        }
    }
}