using System;

namespace theme_color
{
    public class Color
    {
        public double R { get; internal set; }
        public double G { get; internal set; }
        public double B { get; internal set; }
        public object A { get; internal set; }

        internal static Color FromArgb(object a, byte red, byte green, byte blue)
        {
            throw new NotImplementedException();
        }
    }
}