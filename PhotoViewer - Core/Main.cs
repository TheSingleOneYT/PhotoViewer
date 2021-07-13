using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace PhotoViewer
{
    public partial class Main : Form
    {
        Image file;

        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        public object prefs = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer/Preferences";

        Bitmap newBitmap;

        public object NewVer;

        public Main()
        {
            Directory.CreateDirectory(LocalAppData + "/PhotoViewer");

            File.Delete(LocalAppData + "/PhotoViewer/%%Temp.png");

            InitializeComponent();

            MainImage.AllowDrop = true;

            this.KeyPreview = true;

            Directory.CreateDirectory(LocalAppData + "/PhotoViewer/Preferences");

            var UserOnWin = SystemInformation.UserName.ToString();
            WelcomeLabel.Text = "PhotoViewer - Welcome " + UserOnWin + "!";

            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");

            ControlBox = false;

            if (File.Exists(prefs + "/CFUOASChkBx.txt"))
            {
                var CFU = File.ReadAllText(prefs + "/CFUOASChkBx.txt");

                if (CFU == "true")
                {
                    var url = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/main/Update/Version.txt";
                    var wc = new System.Net.WebClient();
                    var GithubVer = wc.DownloadString(url).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                    var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                    if (AppVer == GithubVer)
                    {

                    }
                    else
                    {
                        notify.Icon = SystemIcons.Application;
                        notify.BalloonTipText = "A new version of PhotoViewer is available. Click to install new version";
                        notify.ShowBalloonTip(1000);
                        notify.BalloonTipClicked += Notify_BalloonTipClicked;
                        NewVer = GithubVer;
                    }
                }
            }
            else
            {
                var url = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/main/Update/Version.txt";
                var wc = new System.Net.WebClient();
                var GithubVer = wc.DownloadString(url).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                if (AppVer == GithubVer)
                {

                }
                else
                {
                    notify.Icon = SystemIcons.Application;
                    notify.BalloonTipText = "A new version of PhotoViewer is available. Click to install new version";
                    notify.ShowBalloonTip(1000);
                    notify.BalloonTipClicked += Notify_BalloonTipClicked;
                    NewVer = GithubVer;
                }
            }
        }

        private void Notify_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TheSingleOneYT/PhotoViewer/releases/download/" + NewVer + "/Installer.msi");
            var Downloads = @"C:\Users\" + SystemInformation.UserName.ToString() + @"\Downloads";
            Application.Exit();

            while (File.Exists(Downloads + "/Installer.msi") == false)
            {
                this.Cursor = Cursors.WaitCursor;
            }

            notify.Icon = SystemIcons.Application;
            notify.BalloonTipText = "Download Complete!";
            notify.ShowBalloonTip(1000);

            Process.Start(Downloads + "/Installer.msi");
        }

        private void MainImage_Click(object sender, EventArgs e)
        {
            if (MainImage.Image == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "All Supported | *.png; *.JPG; *.JPEG; *.JPE; *.JPX; *.JP2; *.J2C; *.J2K; *.JPC *.GIF; *.ico; *.Tiff; *.Tif *.bmp; *.rle; *.dib" +
                                "|PNG Images |*.png" +
                                "|JPEG Images | *.JPG; *.JPEG: *.JPE; *.JPX; *.JP2; *.J2C; *.J2K; *.JPC" +
                                "|GIF Images | *.GIF" +
                                "|Icons | *.ico" +
                                "|Tiff Images | *.Tiff; *.Tif" +
                                "|Bitmaps | *.bmp; *.rle; *.dib";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    file = Image.FromFile(dialog.FileName);
                    Main.ActiveForm.Text = "Photo Viewer & Editor - " + Path.GetFileName(dialog.FileName);
                    File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt", Path.GetDirectoryName(dialog.FileName));
                    File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt", Path.GetFileNameWithoutExtension(dialog.FileName));
                    File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt", Path.GetExtension(dialog.FileName));

                    MainImage.Image = file;
                }

                openToolStripMenuItem.Enabled = false;
                importImageToolStripMenuItem.Enabled = false;
            }
            else
            {

            }
        }

        private void Rotate90BTN_Click(object sender, EventArgs e)
        {
            MainImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            MainImage.Refresh();
            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "PNG Images |*.png" +
                "|JPEG Images | *.JPG; *.JPEG: *.JPE; *.JPX; *.JP2; *.J2C; *.J2K; *.JPC" +
                "|GIF Images | *.GIF" +
                "|Icons | *.ico" +
                "|Tiff Images | *.Tiff; *.Tif" +
                "|Bitmaps | *.bmp; *.rle; *.dib";

            if (File.Exists(LocalAppData + "/PhotoViewer/CurrentImportName.txt"))
            {
                var CIN = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt");

                if (CIN == "")
                {
                    dialog.FileName = ".png";
                }
                else
                {
                    dialog.FileName = CIN + ".png";
                }
            }
            else
            {
                dialog.FileName = ".png";
            }

            if (File.Exists(LocalAppData + "/PhotoViewer/CurrentImportPath.txt"))
            {
                var CIP = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");

                dialog.InitialDirectory = CIP;
            }

            dialog.Title = "Save image - PhotoViewer";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName.EndsWith(".jpg"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Jpeg);
                }
                else if (dialog.FileName.EndsWith(".GIF"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Gif);
                }
                else if (dialog.FileName.EndsWith(".png"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Png);
                }
                else if (dialog.FileName.EndsWith(".ico"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Icon);
                }
                else if (dialog.FileName.EndsWith(".Tiff"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Tiff);
                }
                else if (dialog.FileName.EndsWith(".bmp"))
                {
                    MainImage.Image.Save(dialog.FileName, ImageFormat.Bmp);
                }
                else
                {
                    MainImage.Image.Save(dialog.FileName + ".png", ImageFormat.Png);
                }

                Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
            }
        }

        private void FlipXBTN_Click(object sender, EventArgs e)
        {
            MainImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            MainImage.Refresh();
            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";
        }

        private void FlipYBTN_Click(object sender, EventArgs e)
        {
            MainImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            MainImage.Refresh();
            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm.Text.EndsWith("*"))
            {
                DialogResult dialog = MessageBox.Show("This image has been modified. Closing would mean losing changes. Should we continue?", "Photo Viewer & Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    File.Delete(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
                    File.Delete(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
                    File.Delete(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
                    Application.Exit();
                }
            }
            else
            {
                File.Delete(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
                File.Delete(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
                File.Delete(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
                Application.Exit();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Minimize", Minimize);
        }

        private void CloseLabel_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Close", CloseLabel);
        }

        private void ProjectInfoBTN_Click(object sender, EventArgs e)
        {
            var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageBox.Show("The Photo Viewer Project\nVersion: " + AppVer + "\nAn Open-source Photo Viewer And Simple Editor Intended For Use With Windows Sandbox\n\nBy TheSingleOne (TS1)\nProject Github - https://www.github.com/TheSingleOneYT/PhotoViewer", "Project Information", MessageBoxButtons.OK);
        }

        private void ProjectInfoBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Displays information about the Photo Viewer & Editor Project.", ProjectInfoBTN);
        }

        private void GreyScaleBTN_Click(object sender, EventArgs e)
        {
            newBitmap = new Bitmap(MainImage.Image);

            this.Cursor = Cursors.WaitCursor;

            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";

            for (int x = 0; x < newBitmap.Width; x++)
            {
                for (int y = 0; y < newBitmap.Height; y++)
                {
                    Color original = newBitmap.GetPixel(x, y);

                    int greyScale = (int)((original.R * .3) + (original.G * .59) + (original.B * .11));

                    Color newcolor = Color.FromArgb(greyScale, greyScale, greyScale);

                    newBitmap.SetPixel(x, y, newcolor);

                    MainImage.Image = newBitmap;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void InvertBTN_Click(object sender, EventArgs e)
        {
            newBitmap = new Bitmap(MainImage.Image);

            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";

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

                    MainImage.Image = newBitmap;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void zoomSlider_Scroll(object sender, EventArgs e)
        {
            var OrgWidth = MainImage.Width;
            var OrgHeight = MainImage.Height;
            var img = MainImage.Image;
            var prevvalue = ZoomText.Text.ToString();
            int value = zoomSlider.Value;
            ZoomText.Text = value.ToString();
            int PV = Int32.Parse(prevvalue);

            if (value < PV)
            {
                MainImage.Width = OrgWidth - 10;
                MainImage.Height = OrgHeight - 10;
                MainImage.Image = img;
            }
            else
            {
                MainImage.Width = OrgWidth + 10;
                MainImage.Height = OrgHeight + 10;
                MainImage.Image = img;
            }
        }

        private void ResetZoomBTN_Click(object sender, EventArgs e)
        {
            //944, 452
            MainImage.Width = 944;
            MainImage.Height = 452;
            ZoomText.Text = 0.ToString();
            zoomSlider.Value = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void importImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "All Supported | *.png; *.JPG; *.GIF; *.ico; *.Tiff; *.bmp |PNG Images |*.png|JPEG Images | *.JPG|GIF Images | *.GIF|Icons | *.ico|Tiff Images | *.Tiff|Bitmaps | *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(dialog.FileName);
                Main.ActiveForm.Text = "Photo Viewer & Editor - " + Path.GetFileName(dialog.FileName);
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt", Path.GetDirectoryName(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt", Path.GetFileNameWithoutExtension(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt", Path.GetExtension(dialog.FileName));

                MainImage.Image = file;
            }
        }


        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.PerformClick();
        }

        private void resetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form.ActiveForm.Text.EndsWith("*"))
            {
                DialogResult dialog = MessageBox.Show("This image has been modified. Resetting would mean losing changes. Should we continue?", "Photo Viewer & Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    MainImage.Image = null;

                    var path = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
                    var name = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
                    var ext = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");

                    MainImage.Image = Image.FromFile(path + "/" + name + ext);

                    Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
                }
            }
            else
            {
                MainImage.Image = null;

                var path = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
                var name = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
                var ext = File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");

                MainImage.Image = Image.FromFile(path + "/" + name + ext);

                Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
            }
        }

        public static Image img;

        public static Image imgnew
        {
            get { return img; }
            set { img = value; }
        }

        private void openInLargeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgnew = MainImage.Image;
            LargeView lv = new LargeView(img);
            lv.Show();
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void SettingsLabel_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Opens the settings app for PhotoViewer.", SettingsLabel);
        }

        private void ResetZoomBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Resets the image zoom.", ResetZoomBTN);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.Shift == false && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(MainImage.Image);
            }
            else if (e.Control == true && e.KeyCode == Keys.I)
            {
                invertToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.G)
            {
                greyScaleToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.S)
            {
                saveToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.V)
            {
                if (MainImage.Image == null)
                {
                    MainImage.Image = Clipboard.GetImage();
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.L)
            {
                openInLargeViewToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.Z)
            {
                ResetZoomBTN.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.R)
            {
                Application.Exit();
                Process.Start(Application.ExecutablePath);
            }
        }

        private void MainImage_DragEnter(object sender, DragEventArgs e)
        {
            if (MainImage.Image == null)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainImage_DragDrop(object sender, DragEventArgs e)
        {
            if (MainImage.Image == null)
            {
                foreach (string dragged in ((string[])e.Data.GetData(DataFormats.FileDrop)))
                {
                    file = Image.FromFile(dragged);
                    MainImage.Image = file;
                }

                importImageToolStripMenuItem.Enabled = false;
                openToolStripMenuItem.Enabled = false;
            }
        }

        private void PaintBTN_Click(object sender, EventArgs e)
        {
            if (File.Exists(prefs + "/ASWOPS.txt"))
            {
                var prefonASWOPSChkBx = File.ReadAllText(prefs + "/ASWOPS.txt");

                if (prefonASWOPSChkBx == "true")
                {
                    DialogResult dr = MessageBox.Show("Painting uses a large amount of memory. Please only use if you have a reasonable amount of RAM installed. Click OK to continue", "PhotoViewer - Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.OK)
                    {
                        imgnew = MainImage.Image;
                        PaintForm paint = new PaintForm(img);
                        paint.Show();
                    }
                }
                else
                {
                    imgnew = MainImage.Image;
                    PaintForm paint = new PaintForm(img);
                    paint.Show();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Painting uses a large amount of memory. Please only use if you have a reasonable amount of RAM installed. Click OK to continue", "PhotoViewer - Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.OK)
                {
                    imgnew = MainImage.Image;
                    PaintForm paint = new PaintForm(img);
                    paint.Show();
                }
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (File.Exists(LocalAppData + "/PhotoViewer/%%Temp.png"))
            {
                MainImage.Image = Image.FromFile(LocalAppData + "/PhotoViewer/%%Temp.png");
                Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";
            }

            if (MainImage.Image == null)
            {
                importImageToolStripMenuItem.Enabled = true;
                openToolStripMenuItem.Enabled = true;
            }
            else
            {
                importImageToolStripMenuItem.Enabled = false;
                openToolStripMenuItem.Enabled = false;
            }
        }

        private void FileLabel_Click(object sender, EventArgs e)
        {
            FileCMS.Show((Control)sender, FileLabel.Location);
        }

        private void EditLabel_Click(object sender, EventArgs e)
        {
            EditCMS.Show((Control)sender, FileLabel.Location);
        }

        private void ViewLabel_Click(object sender, EventArgs e)
        {
            ViewCMS.Show((Control)sender, FileLabel.Location);
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainImage.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            MainImage.Refresh();
            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";

        }

        private void rotate270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainImage.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            MainImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            MainImage.Refresh();
            Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt") + " *";
        }

        private void ConsoleBTN_Click(object sender, EventArgs e)
        {
            console cmd = new console();
            cmd.Show();
        }
    }
}
