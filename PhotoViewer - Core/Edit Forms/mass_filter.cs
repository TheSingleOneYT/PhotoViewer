using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace PhotoViewer.Edit_Forms
{
    public partial class mass_filter : Form
    {
        string path;

        Bitmap newBitmap;
        Image export;

        public mass_filter(string filePath)
        {
            InitializeComponent();
            path = filePath;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(path);

            if (comboBox1.SelectedItem.ToString() == "Greyscale")
            {
                foreach (var line in lines)
                {
                    newBitmap = (Bitmap)Image.FromFile(line);

                    for (int x = 0; x < newBitmap.Width; x++)
                    {
                        for (int y = 0; y < newBitmap.Height; y++)
                        {
                            Color original = newBitmap.GetPixel(x, y);

                            int greyScale = (int)((original.R * .3) + (original.G * .59) + (original.B * .11));

                            Color newcolor = Color.FromArgb(greyScale, greyScale, greyScale);

                            newBitmap.SetPixel(x, y, newcolor);

                            export = newBitmap;
                        }
                    }

                    export.Save(line + ".png", ImageFormat.Png);
                }

                MessageBox.Show("Operation complete.", "Photo Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form.ActiveForm.Hide();
            }
            else if (comboBox1.SelectedItem.ToString() == "Invert")
            {
                foreach (var line in lines)
                {
                    newBitmap = (Bitmap)Image.FromFile(line);

                    for (int x = 0; x < newBitmap.Width; x++)
                    {
                        for (int y = 0; y < newBitmap.Height; y++)
                        {
                            Color pixel = newBitmap.GetPixel(x, y);

                            int red = pixel.R;
                            int green = pixel.G;
                            int blue = pixel.B;

                            newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));

                            export = newBitmap;
                        }
                    }

                    export.Save(line + ".png", ImageFormat.Png);
                }

                MessageBox.Show("Operation complete.", "Photo Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form.ActiveForm.Hide();
            }
            else
            {
                MessageBox.Show("FAILED. Invalid selection.", "Photo Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
