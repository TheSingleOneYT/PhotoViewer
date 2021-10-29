
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
            this.components = new System.ComponentModel.Container();
            this.Minimize = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MiniControl = new System.Windows.Forms.PictureBox();
            this.LargeImage = new PhotoViewer.MovablePB(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minimize.Location = new System.Drawing.Point(1289, -6);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(1328, -2);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 29);
            this.CloseLabel.TabIndex = 12;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // MiniControl
            // 
            this.MiniControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniControl.Location = new System.Drawing.Point(1273, -13);
            this.MiniControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MiniControl.Name = "MiniControl";
            this.MiniControl.Size = new System.Drawing.Size(99, 48);
            this.MiniControl.TabIndex = 14;
            this.MiniControl.TabStop = false;
            // 
            // LargeImage
            // 
            this.LargeImage.Location = new System.Drawing.Point(-6, 30);
            this.LargeImage.Name = "LargeImage";
            this.LargeImage.Size = new System.Drawing.Size(1386, 695);
            this.LargeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LargeImage.TabIndex = 15;
            this.LargeImage.TabStop = false;
            // 
            // LargeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 732);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MiniControl);
            this.Controls.Add(this.LargeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "LargeView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LargeView - Image From Main";
            this.Load += new System.EventHandler(this.LargeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.PictureBox MiniControl;
        private MovablePB LargeImage;
    }
}