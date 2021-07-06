using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class LargeView : Form
    {
        public LargeView(Image picture)
        {
            InitializeComponent();
            LargeImage.Image = Main.img;
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
