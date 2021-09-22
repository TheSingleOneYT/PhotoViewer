using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace PhotoViewer.Edit_Forms
{
    public partial class mass_resize : Form
    {
        string path;
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        public mass_resize(string filePath)
        {
            InitializeComponent();
            path = filePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w = int.Parse(width.Text);
            int h = int.Parse(height.Text);

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                Image export = PhotoViewer.Classes.Resize.resize(Image.FromFile(line), w, h);
                export.Save(line + ".png", ImageFormat.Png);
            }

            MessageBox.Show("Operation Complete!", "PhotoViewer - Mass Resize", MessageBoxButtons.OK);
            Form.ActiveForm.Hide();
        }
    }
}
