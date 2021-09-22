using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace PhotoViewer.Edit_Forms
{
    public partial class resize : Form
    {
        Image image;
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        public resize(Image img)
        {
            InitializeComponent();
            image = img;

            width.Text = img.Width.ToString();
            height.Text = img.Height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w = int.Parse(width.Text);
            int h = int.Parse(height.Text);

            Image result = PhotoViewer.Classes.Resize.resize(image, w, h);

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
                    result.Save(dialog.FileName, ImageFormat.Jpeg);
                }
                else if (dialog.FileName.EndsWith(".GIF"))
                {
                    result.Save(dialog.FileName, ImageFormat.Gif);
                }
                else if (dialog.FileName.EndsWith(".png"))
                {
                    result.Save(dialog.FileName, ImageFormat.Png);
                }
                else if (dialog.FileName.EndsWith(".ico"))
                {
                    result.Save(dialog.FileName, ImageFormat.Icon);
                }
                else if (dialog.FileName.EndsWith(".Tiff"))
                {
                    result.Save(dialog.FileName, ImageFormat.Tiff);
                }
                else if (dialog.FileName.EndsWith(".bmp"))
                {
                    result.Save(dialog.FileName, ImageFormat.Bmp);
                }
                else
                {
                    result.Save(dialog.FileName + ".png", ImageFormat.Png);
                }

                MessageBox.Show("You must restart the program and load this file from the saved location.", "Photo Viewer & Editor", MessageBoxButtons.OK);

                Application.Exit();
                Process.Start(new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true
                });
            }
        }
    }
}
