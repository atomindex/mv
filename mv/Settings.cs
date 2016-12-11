using System.Drawing;

namespace mv {
    public static class Settings {

        public static Pen SourceLinePen = new Pen(Color.OrangeRed, 2);
        public static Pen SplineLinePen = new Pen(Color.Green, 2);

        public static Pen NetPen = Pens.Silver;
        public static Pen AxisPen = new Pen(Color.FromArgb(128, 128, 128), 2);

        public static Color ErrorColor = Color.FromArgb(251, 168, 171);
        public static int ViewPadding = 10;

    }
}
