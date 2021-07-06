
namespace PhotoViewer
{
    partial class PaintForm
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
            this.Minimize = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MiniControl = new System.Windows.Forms.PictureBox();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.BlackSelector = new System.Windows.Forms.PictureBox();
            this.RedSelector = new System.Windows.Forms.PictureBox();
            this.WhiteSelector = new System.Windows.Forms.PictureBox();
            this.GreenSelector = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold);
            this.Minimize.Location = new System.Drawing.Point(738, -5);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 29);
            this.Minimize.TabIndex = 14;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(771, -2);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 29);
            this.CloseLabel.TabIndex = 13;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // MiniControl
            // 
            this.MiniControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniControl.Location = new System.Drawing.Point(726, -11);
            this.MiniControl.Name = "MiniControl";
            this.MiniControl.Size = new System.Drawing.Size(83, 42);
            this.MiniControl.TabIndex = 15;
            this.MiniControl.TabStop = false;
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainImage.Location = new System.Drawing.Point(-3, 32);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(809, 391);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 12;
            this.MainImage.TabStop = false;
            this.MainImage.Click += new System.EventHandler(this.MainImage_Click);
            this.MainImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseDown);
            this.MainImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainImage_MouseMove);
            this.MainImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseUp);
            // 
            // BlackSelector
            // 
            this.BlackSelector.BackColor = System.Drawing.Color.Black;
            this.BlackSelector.Location = new System.Drawing.Point(7, 6);
            this.BlackSelector.Name = "BlackSelector";
            this.BlackSelector.Size = new System.Drawing.Size(20, 20);
            this.BlackSelector.TabIndex = 16;
            this.BlackSelector.TabStop = false;
            this.BlackSelector.Click += new System.EventHandler(this.BlackSelector_Click);
            // 
            // RedSelector
            // 
            this.RedSelector.BackColor = System.Drawing.Color.Red;
            this.RedSelector.Location = new System.Drawing.Point(33, 6);
            this.RedSelector.Name = "RedSelector";
            this.RedSelector.Size = new System.Drawing.Size(20, 20);
            this.RedSelector.TabIndex = 17;
            this.RedSelector.TabStop = false;
            this.RedSelector.Click += new System.EventHandler(this.RedSelector_Click);
            // 
            // WhiteSelector
            // 
            this.WhiteSelector.BackColor = System.Drawing.Color.White;
            this.WhiteSelector.Location = new System.Drawing.Point(59, 6);
            this.WhiteSelector.Name = "WhiteSelector";
            this.WhiteSelector.Size = new System.Drawing.Size(20, 20);
            this.WhiteSelector.TabIndex = 18;
            this.WhiteSelector.TabStop = false;
            this.WhiteSelector.Click += new System.EventHandler(this.WhiteSelector_Click);
            // 
            // GreenSelector
            // 
            this.GreenSelector.BackColor = System.Drawing.Color.Lime;
            this.GreenSelector.Location = new System.Drawing.Point(85, 6);
            this.GreenSelector.Name = "GreenSelector";
            this.GreenSelector.Size = new System.Drawing.Size(20, 20);
            this.GreenSelector.TabIndex = 19;
            this.GreenSelector.TabStop = false;
            this.GreenSelector.Click += new System.EventHandler(this.GreenSelector_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 420);
            this.Controls.Add(this.GreenSelector);
            this.Controls.Add(this.WhiteSelector);
            this.Controls.Add(this.RedSelector);
            this.Controls.Add(this.BlackSelector);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MiniControl);
            this.Controls.Add(this.MainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox MiniControl;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox BlackSelector;
        private System.Windows.Forms.PictureBox RedSelector;
        private System.Windows.Forms.PictureBox WhiteSelector;
        private System.Windows.Forms.PictureBox GreenSelector;
    }
}