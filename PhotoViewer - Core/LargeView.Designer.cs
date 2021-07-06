
namespace PhotoViewer
{
    partial class LargeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LargeImage = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MiniControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).BeginInit();
            this.SuspendLayout();
            // 
            // LargeImage
            // 
            this.LargeImage.Location = new System.Drawing.Point(-5, 37);
            this.LargeImage.Name = "LargeImage";
            this.LargeImage.Size = new System.Drawing.Size(1188, 602);
            this.LargeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeImage.TabIndex = 0;
            this.LargeImage.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold);
            this.Minimize.Location = new System.Drawing.Point(1105, -5);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 29);
            this.Minimize.TabIndex = 13;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(1138, -2);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 29);
            this.CloseLabel.TabIndex = 12;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // MiniControl
            // 
            this.MiniControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniControl.Location = new System.Drawing.Point(1091, -11);
            this.MiniControl.Name = "MiniControl";
            this.MiniControl.Size = new System.Drawing.Size(85, 42);
            this.MiniControl.TabIndex = 14;
            this.MiniControl.TabStop = false;
            // 
            // LargeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 634);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MiniControl);
            this.Controls.Add(this.LargeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LargeView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LargeView - Image From Main";
            this.Load += new System.EventHandler(this.LargeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LargeImage;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox MiniControl;
    }
}