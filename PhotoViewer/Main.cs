using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PhotoViewer
{
    public partial class Main : Form
    {
        Image file;

        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        Bitmap newBitmap;

        public Main()
        {
            InitializeComponent();

            Directory.CreateDirectory(LocalAppData + "/PhotoViewer");

            var UserOnWin = SystemInformation.UserName.ToString();
            WelcomeLabel.Text = "PhotoViewer - Welcome " + UserOnWin + "!";

            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportPath.txt");
            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportName.txt");
            File.Delete(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");

            ControlBox = false;
        }

        private void MainImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Images|*.png; *.JPG; *.GIF";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(dialog.FileName);
                Main.ActiveForm.Text = "Photo Viewer & Editor - " + Path.GetFileName(dialog.FileName);
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt", Path.GetDirectoryName(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt", Path.GetFileNameWithoutExtension(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt", Path.GetExtension(dialog.FileName));

                MainImage.Image = file;

                if (EditBTN.Text == "Stop Editing")
                {
                    EditBTN.PerformClick();
                }
            }
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (EditBar.Visible == true)
            {
                EditBar.Hide();
                Rotate90BTN.Hide();
                SaveBTN.Hide();
                FlipXBTN.Hide();
                FlipYBTN.Hide();
                FiltersBar.Hide();
                FiltersText.Hide();
                InvertBTN.Hide();
                GreyScaleBTN.Hide();
                EditBTN.Text = "Edit";
            }
            else
            {
                EditBar.Show();
                Rotate90BTN.Show();
                Rotate90BTN.BringToFront();
                SaveBTN.Show();
                SaveBTN.BringToFront();
                FlipXBTN.Show();
                FlipXBTN.BringToFront();
                FlipYBTN.Show();
                FlipYBTN.BringToFront();
                InvertBTN.Show();
                InvertBTN.BringToFront();
                FiltersBar.Show();
                FiltersText.Show();
                FiltersText.BringToFront();
                GreyScaleBTN.Show();
                GreyScaleBTN.BringToFront();
                EditBTN.Text = "Stop Editing";
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

            dialog.Filter = "Images|*.png; *.jpg; *.GIF";

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
                else
                {
                    MainImage.Image.Save(dialog.FileName + ".png", ImageFormat.Png);
                }

                Main.ActiveForm.Text = "Photo Viewer & Editor - " + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt") + File.ReadAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt");
            }
        }

        private void EditBTN_MouseHover(object sender, EventArgs e)
        {
            if (EditBTN.Text == "Stop Editing")
            {
                tooltip.Show("Stop editing", EditBTN);
            }
            else
            {
                tooltip.Show("Displays image editing tools", EditBTN);
            }
        }

        private void Rotate90BTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Rotates the image 90 degrees.", Rotate90BTN);
        }

        private void SaveBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Saves the image displayed.", SaveBTN);
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
            MessageBox.Show("The Photo Viewer Project\nAn Open-source Photo Viewer And Simple Editor Intended For Use With Windows Sandbox\n\nBy TheSingleOne (TS1)\nGithub - https://www.github.com/TheSingleOneYT", "Project Information", MessageBoxButtons.OK);
        }

        private void FlipXBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Flips the image along the X axis", FlipXBTN);
        }

        private void FlipYBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Flips the image along the Y axis", FlipYBTN);
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

        private void InvertBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Inverts the image.", InvertBTN);
        }

        private void GreyScaleBTN_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("Makes the image go GreyScale.", GreyScaleBTN);
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
                MainImage.Width = OrgWidth - 5;
                MainImage.Height = OrgHeight - 5;
                MainImage.Image = img;
            }
            else
            {
                MainImage.Width = OrgWidth + 5;
                MainImage.Height = OrgHeight + 5;
                MainImage.Image = img;
            }
        }

        private void ResetZoomBTN_Click(object sender, EventArgs e)
        {
            MainImage.Width = 809;
            MainImage.Height = 391;
            ZoomText.Text = 0.ToString();
            zoomSlider.Value = 0;
        }
    }
}
