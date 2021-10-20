
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ColourBTN = new System.Windows.Forms.Button();
            this.CurrentC = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentC)).BeginInit();
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
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveLabel.Location = new System.Drawing.Point(12, 2);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(56, 30);
            this.SaveLabel.TabIndex = 22;
            this.SaveLabel.Text = "Save";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(861, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // ColourBTN
            // 
            this.ColourBTN.Location = new System.Drawing.Point(863, 103);
            this.ColourBTN.Name = "ColourBTN";
            this.ColourBTN.Size = new System.Drawing.Size(62, 27);
            this.ColourBTN.TabIndex = 24;
            this.ColourBTN.Text = "Colour";
            this.ColourBTN.UseVisualStyleBackColor = true;
            this.ColourBTN.Click += new System.EventHandler(this.ColourBTN_Click);
            // 
            // CurrentC
            // 
            this.CurrentC.BackColor = System.Drawing.Color.White;
            this.CurrentC.Location = new System.Drawing.Point(863, 132);
            this.CurrentC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurrentC.Name = "CurrentC";
            this.CurrentC.Size = new System.Drawing.Size(62, 22);
            this.CurrentC.TabIndex = 25;
            this.CurrentC.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Open";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentC);
            this.Controls.Add(this.ColourBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SaveLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ColourBTN;
        private System.Windows.Forms.PictureBox CurrentC;
        private System.Windows.Forms.Label label1;
    }
}