using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoViewer
{
    public class MovablePB : PictureBox
    {
        public MovablePB(IContainer container)
        {
            container.Add(this);
        }

        Point point;

        public bool md = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            md = true;
            point = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            md = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (md == true)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}
