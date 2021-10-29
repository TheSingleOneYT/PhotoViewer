using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace PhotoViewer
{
    public partial class PaintForm : Form
    {
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");
        public object prefs = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer/Preferences";
        public int paint = 0;

        Bitmap btm;
        Color c = Color.White;
        Graphics im;

        // This video helped me improve painting a lot: https://youtu.be/UWUzfO3EqBY

        public PaintForm(Image picture = null)
        {
            InitializeComponent();

            if (picture == null)
            {
                var b = new Bitmap(1, 1);
                b.SetPixel(0, 0, Color.Black);

                var result = new Bitmap(b, 256, 256);
                MainImage.Image = result;
            }
            else
            {
                MainImage.Image = picture;
            }

            btm = new Bitmap(MainImage.Image.Width, MainImage.Image.Height);
            im = Graphics.FromImage(btm);

            if (File.Exists(prefs + "/ColourMode.txt"))
            {
                var CM = File.ReadAllText(prefs + "/ColourMode.txt");

                if (CM == "l")
                {
                    MainImage.BackColor = Color.White;
                    this.BackColor = Color.White;
                }
                else
                {
                    MainImage.BackColor = Color.Gray;
                    this.BackColor = Color.Gray;
                }
            }
            else
            {
                MainImage.BackColor = Color.White;
                this.BackColor = Color.White;
            }
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainImage_Click(object sender, EventArgs e)
        {
            
        }

        private void MainImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == 1)
            {
                Bitmap b1 = new Bitmap(MainImage.Image);

                Graphics g1 = Graphics.FromImage(b1);


                Rectangle mouseRect = new Rectangle((e.X - 1), (e.Y - 1), 2, 2);
                im.FillRectangle(new SolidBrush(c), mouseRect);
                
                g1.DrawImage(btm, Point.Empty);

                MainImage.Image = b1;
            }
        }

        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            paint = 1;
        }

        private void PaintForm_MouseUp(object sender, MouseEventArgs e)
        {
            paint = 0;
        }

        private void ColourBTN_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                CurrentC.BackColor = cd.Color;
                c = cd.Color;
            }
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files |*.png";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (!sfd.FileName.ToLower().EndsWith(".png"))
                {
                    MainImage.Image.Save(sfd.FileName + ".png", ImageFormat.Png);
                }
                else
                {
                    MainImage.Image.Save(sfd.FileName, ImageFormat.Png);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
                MainImage.Image = Image.FromFile(ofd.FileName);
        }
    }
}