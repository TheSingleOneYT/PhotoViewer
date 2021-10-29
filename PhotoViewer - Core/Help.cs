using System.Windows.Forms;
using System.IO;
using System;
using System.Drawing;

namespace PhotoViewer
{
    public partial class Help : Form
    {
        public object prefs = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer/Preferences";

        public Help()
        {
            InitializeComponent();

            if (File.Exists(prefs + "/ColourMode.txt"))
            {
                var CM = File.ReadAllText(prefs + "/ColourMode.txt");

                if (CM == "l")
                {
                    this.BackColor = Color.White;
                }
                else
                {
                    this.BackColor = Color.Gray;
                }
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
