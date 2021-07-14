using System;
using System.Diagnostics;
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

            if (File.Exists(prefs + "/ColourMode.txt"))
            {
                var CM = File.ReadAllText(prefs + "/ColourMode.txt");

                if (CM == "l")
                {
                    this.BackColor = Color.White;
                    InputFeed.BackColor = Color.White;
                    OutputFeed.BackColor = Color.White;
                    label1.ForeColor = Color.Black;
                    label1.BackColor = Color.White;
                }
                else
                {
                    this.BackColor = Color.Gray;
                    InputFeed.BackColor = Color.Gray;
                    OutputFeed.BackColor = Color.Gray;
                    label1.ForeColor = Color.Black;
                    label1.BackColor = Color.Gray;
                }
            }
            else
            {
                this.BackColor = Color.White;
                InputFeed.BackColor = Color.White;
                OutputFeed.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.White;
            }
        }

        public Bitmap newBitmap;

        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        public object prefs = Environment.GetEnvironmentVariable("LocalAppData").ToString() + "/PhotoViewer/Preferences";

        private void Submit_Click(object sender, EventArgs e)
        {
            label1.Text = "Output Feed:";
            string In = InputFeed.Text;

            if (In.StartsWith("edit-invert"))
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
            else if (In.StartsWith("edit-gs"))
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
            else if (In.StartsWith("help-show"))
            {
                OutputFeed.Text = "Help:\n" +
                    "All commands structured as command-extension\n\n" +
                    "All commands:\n" +
                    "HELP - shows help. Extensions: show\n" +
                    "EDIT - edits an image (REQUIRES FILE LOC). Extensions: invert, gs, fx, fy, 90, 180, 270\n" +
                    "OUTPUT - controls the output feed. Extensions: clear, copy\n" +
                    "INPUT - controls the input feed. Extensions: clear, copy\n" +
                    "INFO - displays information about Photo Viewer. Extensions: ver, projectinfo, github, website\n" +
                    "CONSOLE - controls the console form. Extensions: hide\n" +
                    "RUN - runs extension. Extension: website, github\n" +
                    "APPLICATION - controls the application. Extensions: show (REQUIRES A PARAMETER), kill, restart" +
                    "\n\nPARAMETERS:\n" +
                    "APPLICATION PARAMETERS: /s, /h\n" +
                    "GENERAL PARAMETERS: /c";
            }
            else if (In.StartsWith("output-clear"))
            {
                OutputFeed.Text = "";
            }
            else if (In.StartsWith("input-clear"))
            {
                InputFeed.Text = "";
            }
            else if (In.StartsWith("info-ver"))
            {
                OutputFeed.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            else if (In.StartsWith("info-projectinfo"))
            {
                MessageBox.Show("The Photo Viewer Project\nVersion:\nAn Open-source Photo Viewer And Simple Editor Intended For Use With Windows Sandbox\n\nBy TheSingleOne (TS1)", "Project Information", MessageBoxButtons.OK);
            }
            else if (In.StartsWith("info-github"))
            {
                OutputFeed.Text = "Project Github - https://www.github.com/TheSingleOneYT/PhotoViewer";
            }
            else if (In.StartsWith("edit-90"))
            {
                string file = In.Remove(0, 8);
                Image imported = Image.FromFile(file);
                imported.RotateFlip(RotateFlipType.Rotate90FlipNone);

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        imported.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        imported.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        imported.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        imported.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        imported.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        imported.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        imported.Save(d.FileName + ".png", ImageFormat.Png);
                    }
                }
                OutputFeed.Text = DateTime.Now.ToString() + " - Rotated image " + file + " by 90⁰ and saved to " + d.FileName.ToString() + " successfully.";
            }
            else if (In.StartsWith("edit-180"))
            {
                string file = In.Remove(0, 9);
                Image imported = Image.FromFile(file);
                imported.RotateFlip(RotateFlipType.Rotate180FlipNone);

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        imported.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        imported.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        imported.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        imported.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        imported.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        imported.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        imported.Save(d.FileName + ".png", ImageFormat.Png);
                    }
                }
                OutputFeed.Text = DateTime.Now.ToString() + " - Rotated image " + file + " by 180⁰ and saved to " + d.FileName.ToString() + " successfully.";
            }
            else if (In.StartsWith("edit-270"))
            {
                string file = In.Remove(0, 9);
                Image imported = Image.FromFile(file);
                imported.RotateFlip(RotateFlipType.Rotate180FlipNone);
                imported.RotateFlip(RotateFlipType.Rotate90FlipNone);

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        imported.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        imported.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        imported.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        imported.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        imported.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        imported.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        imported.Save(d.FileName + ".png", ImageFormat.Png);
                    }
                }
                OutputFeed.Text = DateTime.Now.ToString() + " - Rotated image " + file + " by 270⁰ and saved to " + d.FileName.ToString() + " successfully.";
            }
            else if (In.StartsWith("edit-fx"))
            {
                string file = In.Remove(0, 8);
                Image imported = Image.FromFile(file);
                imported.RotateFlip(RotateFlipType.RotateNoneFlipX);

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        imported.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        imported.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        imported.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        imported.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        imported.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        imported.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        imported.Save(d.FileName + ".png", ImageFormat.Png);
                    }
                }
                OutputFeed.Text = DateTime.Now.ToString() + " - Flipped image " + file + " on X axis and saved to " + d.FileName.ToString() + " successfully.";
            }
            else if (In.StartsWith("edit-fy"))
            {
                string file = In.Remove(0, 8);
                Image imported = Image.FromFile(file);
                imported.RotateFlip(RotateFlipType.RotateNoneFlipY);

                SaveFileDialog d = new SaveFileDialog();

                if (d.ShowDialog() == DialogResult.OK)
                {
                    if (d.FileName.EndsWith(".jpg"))
                    {
                        imported.Save(d.FileName, ImageFormat.Jpeg);
                    }
                    else if (d.FileName.EndsWith(".GIF"))
                    {
                        imported.Save(d.FileName, ImageFormat.Gif);
                    }
                    else if (d.FileName.EndsWith(".png"))
                    {
                        imported.Save(d.FileName, ImageFormat.Png);
                    }
                    else if (d.FileName.EndsWith(".ico"))
                    {
                        imported.Save(d.FileName, ImageFormat.Icon);
                    }
                    else if (d.FileName.EndsWith(".Tiff"))
                    {
                        imported.Save(d.FileName, ImageFormat.Tiff);
                    }
                    else if (d.FileName.EndsWith(".bmp"))
                    {
                        imported.Save(d.FileName, ImageFormat.Bmp);
                    }
                    else
                    {
                        imported.Save(d.FileName + ".png", ImageFormat.Png);
                    }
                }
                OutputFeed.Text = DateTime.Now.ToString() + " - Flipped image " + file + " on Y axis and saved to " + d.FileName.ToString() + " successfully.";
            }
            else if (In.StartsWith("console-hide"))
            {
                Form.ActiveForm.Hide();
            }
            else if (In.StartsWith("application-show /s"))
            {
                Settings settings = new Settings();
                settings.Show();
            }
            else if (In.StartsWith("application-show /h"))
            {
                Help help = new Help();
                help.Show();
            }
            else if (In.StartsWith("application-kill"))
            {
                var processes = Process.GetProcessesByName("PhotoViewer");

                foreach (var process in processes)
                {
                    process.Kill();
                }
            }
            else if (In.StartsWith("application-restart"))
            {
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }
            else if (In.StartsWith("info-website"))
            {
                OutputFeed.Text = "Website - https://TheSingleOneYT.github.io/PhotoViewer";
            }
            else if (In.StartsWith("output-copy"))
            {
                Clipboard.SetText(OutputFeed.Text);
                label1.Text = "Output Feed copied.";
            }
            else if (In.StartsWith("input-copy"))
            {
                Clipboard.SetText(InputFeed.Text);
                label1.Text = "Input Feed copied.";
            }
            else if (In.StartsWith("run-github"))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.github.com/TheSingleOneYT/PhotoViewer",
                    UseShellExecute = true
                });
            }
            else if (In.StartsWith("run-website"))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://TheSingleOneYT.github.io/PhotoViewer",
                    UseShellExecute = true
                });
            }
            else
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is not recognised.\nERROR: 1";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }

            if (In == ("/c"))
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }
            else if (In.Contains("/c"))
            {
                InputFeed.Text = "";
            }

            if (In == ("/h"))
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }

            if (In == ("/s"))
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }
        }
    }
}
