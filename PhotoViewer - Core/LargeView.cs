using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class LargeView : Form
    {
        public object prefs = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer/Preferences";

        public LargeView(Image picture)
        {
            InitializeComponent();
            LargeImage.Image = Main.img;

            if (File.Exists(prefs + "/ColourMode.txt"))
            {
                var CM = File.ReadAllText(prefs + "/ColourMode.txt");

                if (CM == "l")
                {
                    LargeImage.BackColor = Color.White;
                    this.BackColor = Color.White;
                }
                else
                {
                    LargeImage.BackColor = Color.Gray;
                    this.BackColor = Color.Gray;
                }
            }
            else
            {
                LargeImage.BackColor = Color.White;
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

        private void LargeView_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
