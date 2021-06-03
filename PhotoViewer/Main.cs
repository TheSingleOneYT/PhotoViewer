using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Main : Form
    {
        Image file;

        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

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

            dialog.Filter = "Images|*.png; *.JPG; *.GIF; *.JPEG";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(dialog.FileName);
                MainImage.Image = file;
                Main.ActiveForm.Text = "Photo Viewer & Editor - " + Path.GetFileName(dialog.FileName);
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportPath.txt", Path.GetDirectoryName(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportName.txt", Path.GetFileNameWithoutExtension(dialog.FileName));
                File.WriteAllText(LocalAppData + "/PhotoViewer/CurrentImportExt.txt", Path.GetExtension(dialog.FileName));
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
            else
            {

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
                else if(dialog.FileName.EndsWith(".png"))
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
    }
}
