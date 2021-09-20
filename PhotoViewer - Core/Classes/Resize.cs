using System.Drawing;

namespace PhotoViewer.Classes
{
    public class Resize
    {
        public static Image resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);

            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, width, height);
            graphic.Dispose();

            return bmp;
        }
    }
}
