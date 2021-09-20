
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
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.BlackSelector = new System.Windows.Forms.PictureBox();
            this.RedSelector = new System.Windows.Forms.PictureBox();
            this.WhiteSelector = new System.Windows.Forms.PictureBox();
            this.GreenSelector = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlueSelector = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minimize.Location = new System.Drawing.Point(861, -6);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(899, -2);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 29);
            this.CloseLabel.TabIndex = 13;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.White;
            this.MainImage.Location = new System.Drawing.Point(-4, 30);
            this.MainImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(944, 458);
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
            this.BlackSelector.Location = new System.Drawing.Point(8, 7);
            this.BlackSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BlackSelector.Name = "BlackSelector";
            this.BlackSelector.Size = new System.Drawing.Size(23, 23);
            this.BlackSelector.TabIndex = 16;
            this.BlackSelector.TabStop = false;
            this.BlackSelector.Click += new System.EventHandler(this.BlackSelector_Click);
            // 
            // RedSelector
            // 
            this.RedSelector.BackColor = System.Drawing.Color.Red;
            this.RedSelector.Location = new System.Drawing.Point(38, 7);
            this.RedSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RedSelector.Name = "RedSelector";
            this.RedSelector.Size = new System.Drawing.Size(23, 23);
            this.RedSelector.TabIndex = 17;
            this.RedSelector.TabStop = false;
            this.RedSelector.Click += new System.EventHandler(this.RedSelector_Click);
            // 
            // WhiteSelector
            // 
            this.WhiteSelector.BackColor = System.Drawing.Color.White;
            this.WhiteSelector.Location = new System.Drawing.Point(69, 7);
            this.WhiteSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WhiteSelector.Name = "WhiteSelector";
            this.WhiteSelector.Size = new System.Drawing.Size(23, 23);
            this.WhiteSelector.TabIndex = 18;
            this.WhiteSelector.TabStop = false;
            this.WhiteSelector.Click += new System.EventHandler(this.WhiteSelector_Click);
            // 
            // GreenSelector
            // 
            this.GreenSelector.BackColor = System.Drawing.Color.Lime;
            this.GreenSelector.Location = new System.Drawing.Point(99, 7);
            this.GreenSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GreenSelector.Name = "GreenSelector";
            this.GreenSelector.Size = new System.Drawing.Size(23, 23);
            this.GreenSelector.TabIndex = 19;
            this.GreenSelector.TabStop = false;
            this.GreenSelector.Click += new System.EventHandler(this.GreenSelector_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 48);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // BlueSelector
            // 
            this.BlueSelector.BackColor = System.Drawing.Color.Blue;
            this.BlueSelector.Location = new System.Drawing.Point(130, 7);
            this.BlueSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BlueSelector.Name = "BlueSelector";
            this.BlueSelector.Size = new System.Drawing.Size(23, 23);
            this.BlueSelector.TabIndex = 21;
            this.BlueSelector.TabStop = false;
            this.BlueSelector.Click += new System.EventHandler(this.BlueSelector_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 485);
            this.Controls.Add(this.BlueSelector);
            this.Controls.Add(this.GreenSelector);
            this.Controls.Add(this.WhiteSelector);
            this.Controls.Add(this.RedSelector);
            this.Controls.Add(this.BlackSelector);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaintForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox BlackSelector;
        private System.Windows.Forms.PictureBox RedSelector;
        private System.Windows.Forms.PictureBox WhiteSelector;
        private System.Windows.Forms.PictureBox GreenSelector;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BlueSelector;
    }
}