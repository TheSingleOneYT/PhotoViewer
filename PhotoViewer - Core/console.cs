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
                    "EDIT - edits an image (REQUIRES FILE LOC). Extensions: invert, gs, fx, fy, 90, 180, 270\n" +
                    "OUTPUT - controls the output feed. Extensions: clear, copy\n" +
                    "INPUT - controls the input feed. Extensions: clear, copy\n" +
                    "INFO - displays information about Photo Viewer. Extensions: ver, projectinfo, github, website\n" +
                    "CONSOLE - controls the console form. Extensions: hide\n" +
                    "RUN - runs extension. Extension: website, github\n" +
                    "APPLICATION - controls the application. Extensions: show (REQUIRES A PARAMETER), kill, restart\n" +
                    "UPDATE - update the application. Extensions: do\n" +
                    "RESIZE - resize an image at a specified location. Extensions: show" +
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

        private void InputFeed_TextChanged(object sender, EventArgs e)
        {
            if (InputFeed.Text.StartsWith("e") && !InputFeed.Text.StartsWith("edit")) //commands-start
            {
                DYMText.Text = "Did you mean 'edit'?";
            }
            else if (InputFeed.Text.StartsWith("h") && !InputFeed.Text.StartsWith("help"))
            {
                DYMText.Text = "Did you mean 'help'?";
            }
            else if (InputFeed.Text.StartsWith("o") && !InputFeed.Text.StartsWith("output"))
            {
                DYMText.Text = "Did you mean 'output'?";
            }
            else if (InputFeed.Text.StartsWith("inp") && !InputFeed.Text.StartsWith("input"))
            {
                DYMText.Text = "Did you mean 'input'?";
            }
            else if (InputFeed.Text.StartsWith("inf") && !InputFeed.Text.StartsWith("info"))
            {
                DYMText.Text = "Did you mean 'info'?";
            }
            else if (InputFeed.Text.StartsWith("c") && !InputFeed.Text.StartsWith("console"))
            {
                DYMText.Text = "Did you mean 'console'?";
            }
            else if (InputFeed.Text.StartsWith("ru") && !InputFeed.Text.StartsWith("run"))
            {
                DYMText.Text = "Did you mean 'run'?";
            }
            else if (InputFeed.Text.StartsWith("a") && !InputFeed.Text.StartsWith("application"))
            {
                DYMText.Text = "Did you mean 'application'?";
            }
            else if (InputFeed.Text.StartsWith("u") && !InputFeed.Text.StartsWith("update"))
            {
                DYMText.Text = "Did you mean 'update'?";
            }
            else if (InputFeed.Text.StartsWith("re") && !InputFeed.Text.StartsWith("resize"))
            {
                DYMText.Text = "Did you mean 'resize'?";
            }
            else if (InputFeed.Text.StartsWith("edit-i") && !InputFeed.Text.StartsWith("edit-invert")) //edit //extensions-start
            {
                DYMText.Text = "Did you mean 'edit-invert'?";
            }
            else if (InputFeed.Text.StartsWith("edit-g") && !InputFeed.Text.StartsWith("edit-gs"))
            {
                DYMText.Text = "Did you mean 'edit-gs'?";
            }
            else if (InputFeed.Text.StartsWith("edit-9") && !InputFeed.Text.StartsWith("edit-90"))
            {
                DYMText.Text = "Did you mean 'edit-90'?";
            }
            else if (InputFeed.Text.StartsWith("edit-1") && !InputFeed.Text.StartsWith("edit-180"))
            {
                DYMText.Text = "Did you mean 'edit-180'?";
            }
            else if (InputFeed.Text.StartsWith("edit-2") && !InputFeed.Text.StartsWith("edit-270"))
            {
                DYMText.Text = "Did you mean 'edit-270'?";
            }
            else if (InputFeed.Text.StartsWith("help-s") && !InputFeed.Text.StartsWith("help-show")) //help
            {
                DYMText.Text = "Did you mean 'help-show'?";
            }
            else if (InputFeed.Text.StartsWith("output-cl") && !InputFeed.Text.StartsWith("output-clear")) //output
            {
                DYMText.Text = "Did you mean 'output-clear'?";
            }
            else if (InputFeed.Text.StartsWith("output-co") && !InputFeed.Text.StartsWith("output-copy"))
            {
                DYMText.Text = "Did you mean 'output-copy'?";
            }
            else if (InputFeed.Text.StartsWith("input-cl") && !InputFeed.Text.StartsWith("input-clear")) //input
            {
                DYMText.Text = "Did you mean 'input-clear'?";
            }
            else if (InputFeed.Text.StartsWith("input-co") && !InputFeed.Text.StartsWith("input-copy"))
            {
                DYMText.Text = "Did you mean 'input-copy'?";
            }
            else if (InputFeed.Text.StartsWith("info-v") && !InputFeed.Text.StartsWith("info-ver")) //info
            {
                DYMText.Text = "Did you mean 'info-ver'?";
            }
            else if (InputFeed.Text.StartsWith("info-p") && !InputFeed.Text.StartsWith("info-projectinfo"))
            {
                DYMText.Text = "Did you mean 'info-projectinfo'?";
            }
            else if (InputFeed.Text.StartsWith("info-g") && !InputFeed.Text.StartsWith("info-github"))
            {
                DYMText.Text = "Did you mean 'info-github'?";
            }
            else if (InputFeed.Text.StartsWith("info-w") && !InputFeed.Text.StartsWith("info-website"))
            {
                DYMText.Text = "Did you mean 'info-website'?";
            }
            else if (InputFeed.Text.StartsWith("console-h") && !InputFeed.Text.StartsWith("console-hide")) //console
            {
                DYMText.Text = "Did you mean 'console-hide'?";
            }
            else if (InputFeed.Text.StartsWith("run-w") && !InputFeed.Text.StartsWith("run-website")) //run
            {
                DYMText.Text = "Did you mean 'run-website'?";
            }
            else if (InputFeed.Text.StartsWith("run-g") && !InputFeed.Text.StartsWith("run-github"))
            {
                DYMText.Text = "Did you mean 'run-github'?";
            }
            else if (InputFeed.Text.StartsWith("application-k") && !InputFeed.Text.StartsWith("application-kill")) //application
            {
                DYMText.Text = "Did you mean 'application-kill'?";
            }
            else if (InputFeed.Text.StartsWith("application-r") && !InputFeed.Text.StartsWith("application-restart"))
            {
                DYMText.Text = "Did you mean 'application-restart'?";
            }
            else if (InputFeed.Text.StartsWith("update-d") && !InputFeed.Text.StartsWith("update-do")) //update
            {
                DYMText.Text = "Did you mean 'update-do'?";
            }
            else if (InputFeed.Text.StartsWith("resize-s") && !InputFeed.Text.StartsWith("resize-show")) //resize
            {
                DYMText.Text = "Did you mean 'resize-show'?";
            }
            else
            {
                DYMText.Text = "No Predictions.";
            }
        }

        private void DYMText_Click(object sender, EventArgs e)
        {
            if (DYMText.Text != "No Predictions.")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Print Complete.wav");
                player.Play();

                string i = DYMText.Text.Remove(0, 14);
                int length = i.Length;
                int lt2 = length - 2;
                string ii = i.Remove(lt2, 2);

                if (InputFeed.Text.Contains("-"))
                {
                    InputFeed.Text = ii;
                    InputFeed.Select(lt2, lt2);
                }
                else
                {
                    string iii = ii + "-";
                    InputFeed.Text = iii;
                    InputFeed.Select(lt2 + 1, lt2 + 1);
                }
            }
        }

        private void console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control == false)
            {
                DYMText_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                Submit.PerformClick();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void InputFeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control == false)
            {
                DYMText_Click(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                Submit.PerformClick();
                e.Handled = e.SuppressKeyPress = true;
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
    }
}
