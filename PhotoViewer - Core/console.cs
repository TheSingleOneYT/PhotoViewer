using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class console : Form
    {
        public console()
        {
            InitializeComponent();
        }

        public Bitmap newBitmap;
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        private void Submit_Click(object sender, EventArgs e)
        {
            string In = InputFeed.Text;

            if (In.Contains("edit-invert"))
            {
                string file = In.Remove(0, 12);
                newBitmap = new Bitmap(file);

                this.Cursor = Cursors.WaitCursor;

                for (int x = 0; x < newBitmap.Width; x++)
                {
                    for (int y = 0; y < newBitmap.Height; y++)
                    {
                        Color pixel = newBitmap.GetPixel(x, y);

                        int red = pixel.R;
                        int green = pixel.G;
                        int blue = pixel.B;

                        newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                    }
                }

                this.Cursor = Cursors.Default;

                SaveFileDialog dialog = new SaveFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".jpg"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Jpeg);
                    }
                    else if (dialog.FileName.EndsWith(".GIF"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Gif);
                    }
                    else if (dialog.FileName.EndsWith(".png"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Png);
                    }
                    else if (dialog.FileName.EndsWith(".ico"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Icon);
                    }
                    else if (dialog.FileName.EndsWith(".Tiff"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Tiff);
                    }
                    else if (dialog.FileName.EndsWith(".bmp"))
                    {
                        newBitmap.Save(dialog.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        newBitmap.Save(dialog.FileName + ".png", ImageFormat.Png);
                    }

                    OutputFeed.Text = DateTime.Now.ToString() + " - Inverted image " + file + " to " + dialog.FileName.ToString() + " successfully.";
                }
            }
            else if (In.Contains("edit-gs"))
            {
                string f = In.Remove(0, 8);
                newBitmap = new Bitmap(f);

                this.Cursor = Cursors.WaitCursor;

                for (int x = 0; x < newBitmap.Width; x++)
                {
                    for (int y = 0; y < newBitmap.Height; y++)
                    {
                        Color original = newBitmap.GetPixel(x, y);

                        int greyScale = (int)((original.R * .3) + (original.G * .59) + (original.B * .11));

                        Color newcolor = Color.FromArgb(greyScale, greyScale, greyScale);

                        newBitmap.SetPixel(x, y, newcolor);
                    }
                }

                this.Cursor = Cursors.Default;

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        newBitmap.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        newBitmap.Save(d.FileName + ".png", ImageFormat.Png);
                    }

                    OutputFeed.Text = DateTime.Now.ToString() + " - GreyScaled image " + f + " to " + d.FileName.ToString() + " successfully.";
                }
            }
            else if (In.Contains("help-show"))
            {
                OutputFeed.Text = "Help:\n" +
                    "All commands structured as command-extension\n\n" +
                    "All commands:\n" +
                    "HELP - shows help. Extensions: show\n" +
                    "EDIT - edits an image. Extensions: invert, gs\n" +
                    "OUTPUT - controls the output feed. Extensions: clear\n" +
                    "INPUT - controls the input feed. Extensions: clear\n" +
                    "INFO - displays information about Photo Viewer. Extensions: ver, projectinfo, github" + 
                    "\n\nPARAMETERS:\n" +
                    "COMING SOON";
            }
            else if (In.Contains("output-clear"))
            {
                OutputFeed.Text = "";
            }
            else if (In.Contains("input-clear"))
            {
                InputFeed.Text = "";
            }
            else if (In.Contains("info-ver"))
            {
                OutputFeed.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            else if (In.Contains("info-projectinfo"))
            {
                MessageBox.Show("The Photo Viewer Project\nVersion:\nAn Open-source Photo Viewer And Simple Editor Intended For Use With Windows Sandbox\n\nBy TheSingleOne (TS1)", "Project Information", MessageBoxButtons.OK);
            }
            else if (In.Contains("info-github"))
            {
                OutputFeed.Text = "Project Github - https://www.github.com/TheSingleOneYT/PhotoViewer";
            }
            else
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is not recognised.\nERROR: 1";
            }
        }
    }
}
