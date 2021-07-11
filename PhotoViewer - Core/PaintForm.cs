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
        public int paint = 0;
        Pen pen;

        public PaintForm(Image picture)
        {
            InitializeComponent();
            MainImage.Image = Main.img;
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
            var CS = File.ReadAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt");

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            if (CS.ToString() == "black")
            {
                pen = new Pen(Color.Black, 1);
            }
            else if (CS.ToString() == "red")
            {
                pen = new Pen(Color.Red, 1);
            }
            else if (CS.ToString() == "green")
            {
                pen = new Pen(Color.Green, 1);
            }
            else if (CS.ToString() == "white")
            {
                pen = new Pen(Color.White, 1);
            }

            Bitmap b1 = new Bitmap(MainImage.Image);

            Graphics g1 = Graphics.FromImage(b1);

            g1.DrawRectangle(pen, x, y, 2, 2);

            MainImage.Image = b1;

            MainImage.Image.Save(LocalAppData + "/PhotoViewer/%%Temp.png", ImageFormat.Png);
        }

        private void MainImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == 1)
            {
                var CS = File.ReadAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt");

                int x = e.X;
                int y = e.Y + x;
                x = e.X + y;

                if (CS.ToString() == "black")
                {
                    pen = new Pen(Color.Black, 1);
                }
                else if (CS.ToString() == "red")
                {
                    pen = new Pen(Color.Red, 1);
                }
                else if (CS.ToString() == "green")
                {
                    pen = new Pen(Color.Green, 1);
                }
                else if (CS.ToString() == "white")
                {
                    pen = new Pen(Color.White, 1);
                }

                Bitmap b1 = new Bitmap(MainImage.Image);

                Graphics g1 = Graphics.FromImage(b1);

                g1.DrawRectangle(pen, x, y, 2, 2);

                MainImage.Image = b1;

                MainImage.Image.Save(LocalAppData + "/PhotoViewer/%%Temp.png", ImageFormat.Png);
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

        // COLOURS

        private void RedSelector_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt", "red");
        }

        private void BlackSelector_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt", "black");
        }

        private void GreenSelector_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt", "green");
        }

        private void WhiteSelector_Click(object sender, EventArgs e)
        {
            File.WriteAllText(LocalAppData + "/PhotoViewer/ColourSelected.txt", "white");
        }
    }
}
