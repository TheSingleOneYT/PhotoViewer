using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class console : Form
    {
        public console()
        {
            InitializeComponent();

            KeyPreview = true;

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
        private object NewVer;

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
                    "EDIT - edits an image (REQUIRES FILE LOC). Extensions: invert, gs, fx, fy, 90, 180, 270. Requires file path: TRUE\n" +
                    "OUTPUT - controls the output feed. Extensions: clear, copy\n" +
                    "INPUT - controls the input feed. Extensions: clear, copy\n" +
                    "INFO - displays information about Photo Viewer. Extensions: ver, projectinfo, github, website\n" +
                    "CONSOLE - controls the console form. Extensions: hide\n" +
                    "RUN - runs extension. Extension: website, github\n" +
                    "APPLICATION - controls the application. Extensions: show (REQUIRES A PARAMETER), kill, restart\n" +
                    "UPDATE - update the application. Extensions: do\n" +
                    "RESIZE - resize an image at a specified location. Extensions: show. Requires file path: TRUE\n" +
                    "MEDFI - use medfi files via the console. Extensions: create, filter, resize, convert.\n" +
                    "ERRORC - provides info about console errors. Extensions: 1, 2.\n" +
                    "MAINERRORS - provides info about Photo Viewer errors. Extensions: 001, 002, 003, 004, 005, 006." +
                    "\n\nPARAMETERS:\n" +
                    "APPLICATION PARAMETERS: \"s, \"h\n" +
                    "GENERAL PARAMETERS: \"c";
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
            else if (In.StartsWith("application-show \"s"))
            {
                Settings settings = new Settings();
                settings.Show();
            }
            else if (In.StartsWith("application-show \"h"))
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
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true
                });
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
            else if (In.StartsWith("update-do"))
            {
                if (internetTest() == true)
                {
                    var url = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/main/Update/Version.txt";
                    var prURL = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/pre-release/Update/Version.txt";
                    var wc = new System.Net.WebClient();
                    var GithubVer = wc.DownloadString(url).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                    var PreRelease = wc.DownloadString(prURL).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                    var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                    if (AppVer == GithubVer)
                    {
                        MessageBox.Show("Could not find a newer version of PhotoViewer", "PhotoViewer", icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.OK);
                    }
                    else if (AppVer != GithubVer && PreRelease != AppVer)
                    {
                        DialogResult dr = MessageBox.Show("Newer version found, press OK to continue updating...", "PhotoViewer", icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.OKCancel);

                        if (dr == DialogResult.OK)
                        {
                            NewVer = GithubVer;

                            File.WriteAllText(LocalAppData + "/NewVer.txt", NewVer.ToString());

                            Application.Exit();

                            Process.Start(new ProcessStartInfo
                            {
                                FileName = Directory.GetCurrentDirectory() + "/Updater.exe",
                                Verb = "runas",
                                UseShellExecute = true
                            });
                        }
                    }
                    else if (AppVer != GithubVer && PreRelease == AppVer)
                    {
                        DialogResult dr = MessageBox.Show("You are testing a Pre-Release. Downgrade to a release?", "PhotoViewer", icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            NewVer = GithubVer;

                            File.WriteAllText(LocalAppData + "/NewVer.txt", NewVer.ToString());

                            Application.Exit();

                            Process.Start(new ProcessStartInfo
                            {
                                FileName = Directory.GetCurrentDirectory() + "/Updater.exe",
                                Verb = "runas",
                                UseShellExecute = true
                            });
                        }
                    }
                }
            }
            else if (In.StartsWith("resize-show"))
            {
                Edit_Forms.resize r = new Edit_Forms.resize(Image.FromFile(In.Remove(0, 12)));
                r.Show();
            }
            else if (In.StartsWith("errorc-1"))
            {
                OutputFeed.Text = "Error 1 describes an issue where a COMMAND DOES NOT EXIST.\n\n" +
                    "For example, abc-xyz is not a command. The output will state: abc-xyz is not recognised.\nERROR: 1";
            }
            else if (In.StartsWith("errorc-2"))
            {
                OutputFeed.Text = "Error 2 describes an issue where a parameter is used in the WRONG CONTEXT or AS A COMMAND.\n\n" +
                    "For example, \"h is a parameter but requires application-show to function. The output will state: \"h is parameter and requires more context.\nERROR: 2";
            }
            else if (In.StartsWith("mainerror-001"))
            {
                OutputFeed.Text = "Error PV001 describes an issue where more than 1 Photo Viewer app is attempted to be ran at the SAME TIME as another.";
            }
            else if (In.StartsWith("mainerror-002"))
            {
                OutputFeed.Text = "Error PV002 describes an issue where an image cannot be reset as the files containing the name, path and extension cannot be found. A likely cause of this is if the image wants to be reset but the image was pasted into Photo Viewer or dragged and dropped into Photo Viewer.";
            }
            else if (In.StartsWith("mainerror-003"))
            {
                OutputFeed.Text = "Error PV003 describes an issue where the updater is lacking administrative permissions.";
            }
            else if (In.StartsWith("mainerror-004"))
            {
                OutputFeed.Text = "Error PV004 describes an issue where the updater cannot find NewVer.txt. This file tells the updater what version of Photo Viewer it should download and install.";
            }
            else if (In.StartsWith("mainerror-005"))
            {
                OutputFeed.Text = "Error PV005 describes an issue where an unrecognised filter is selected in the mass filter form.";
            }
            else if (In.StartsWith("mainerror-006"))
            {
                OutputFeed.Text = "Error PV006 describes an issue where the settings form attempts to Check For Updates but there is no internet connection.";
            }
            else if (In.StartsWith("medfi-create"))
            {
                medfi.medfi_creator mc = new medfi.medfi_creator();
                mc.Show();
            }
            else if (In.StartsWith("medfi-convert"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TEXT FILES | *.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "MEDFI | *.medfi";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, File.ReadAllText(ofd.FileName));
                    }
                }
            }
            else if (In.StartsWith("medfi-resize"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MEDFI | *.medfi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Edit_Forms.mass_resize mr = new Edit_Forms.mass_resize(ofd.FileName);
                    mr.Show();
                }
            }
            else if (In.StartsWith("medfi-filter"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MEDFI | *.medfi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Edit_Forms.mass_filter mr = new Edit_Forms.mass_filter(ofd.FileName);
                    mr.Show();
                }
            }
            else
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is not recognised.\nERROR: 1";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }

            if (In == ("\"c"))
            {
                OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                player.Play();
            }
            else if (In.Contains("\"c"))
            {
                InputFeed.Text = "";
            }

            if (In.Contains("\"h"))
            {
                if (!In.StartsWith("application-show"))
                {
                    OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                    player.Play();
                }
            }

            if (In.Contains("\"s"))
            {
                if (!In.StartsWith("application-show"))
                {
                    OutputFeed.Text = InputFeed.Text.ToString() + " is a parameter and requires more context.\nERROR: 2";
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                    player.Play();
                }
            }
        }

        public static bool internetTest(int timeoutMs = 10000, string url = "https://www.google.com")
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OutputFeed.Text != "")
            {
                Clipboard.SetText(OutputFeed.Text);
                label1.Text = "Output Feed copied.";
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputFeed.Text = "";
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (InputFeed.Text != "")
                Clipboard.SetText(InputFeed.Text);
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputFeed.Text = "";
        }
    }
}
