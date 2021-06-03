
namespace PhotoViewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.ColourBar = new System.Windows.Forms.PictureBox();
            this.EditBTN = new System.Windows.Forms.Button();
            this.EditBar = new System.Windows.Forms.PictureBox();
            this.Rotate90BTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.FlipXBTN = new System.Windows.Forms.Button();
            this.FlipYBTN = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjectInfoBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainImage.Location = new System.Drawing.Point(-6, 33);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(809, 391);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            this.MainImage.Click += new System.EventHandler(this.MainImage_Click);
            // 
            // ColourBar
            // 
            this.ColourBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColourBar.Location = new System.Drawing.Point(-10, 419);
            this.ColourBar.Name = "ColourBar";
            this.ColourBar.Size = new System.Drawing.Size(813, 36);
            this.ColourBar.TabIndex = 1;
            this.ColourBar.TabStop = false;
            // 
            // EditBTN
            // 
            this.EditBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBTN.Location = new System.Drawing.Point(3, 423);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(103, 23);
            this.EditBTN.TabIndex = 2;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            this.EditBTN.MouseHover += new System.EventHandler(this.EditBTN_MouseHover);
            // 
            // EditBar
            // 
            this.EditBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBar.Location = new System.Drawing.Point(379, -10);
            this.EditBar.Name = "EditBar";
            this.EditBar.Size = new System.Drawing.Size(336, 42);
            this.EditBar.TabIndex = 3;
            this.EditBar.TabStop = false;
            this.EditBar.Visible = false;
            // 
            // Rotate90BTN
            // 
            this.Rotate90BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rotate90BTN.Location = new System.Drawing.Point(387, 4);
            this.Rotate90BTN.Name = "Rotate90BTN";
            this.Rotate90BTN.Size = new System.Drawing.Size(75, 23);
            this.Rotate90BTN.TabIndex = 4;
            this.Rotate90BTN.Text = "Rotate 90";
            this.Rotate90BTN.UseVisualStyleBackColor = true;
            this.Rotate90BTN.Visible = false;
            this.Rotate90BTN.Click += new System.EventHandler(this.Rotate90BTN_Click);
            this.Rotate90BTN.MouseHover += new System.EventHandler(this.Rotate90BTN_MouseHover);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.Location = new System.Drawing.Point(630, 4);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Visible = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            this.SaveBTN.MouseHover += new System.EventHandler(this.SaveBTN_MouseHover);
            // 
            // FlipXBTN
            // 
            this.FlipXBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlipXBTN.Location = new System.Drawing.Point(468, 4);
            this.FlipXBTN.Name = "FlipXBTN";
            this.FlipXBTN.Size = new System.Drawing.Size(75, 23);
            this.FlipXBTN.TabIndex = 6;
            this.FlipXBTN.Text = "Flip X";
            this.FlipXBTN.UseVisualStyleBackColor = true;
            this.FlipXBTN.Visible = false;
            this.FlipXBTN.Click += new System.EventHandler(this.FlipXBTN_Click);
            this.FlipXBTN.MouseHover += new System.EventHandler(this.FlipXBTN_MouseHover);
            // 
            // FlipYBTN
            // 
            this.FlipYBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlipYBTN.Location = new System.Drawing.Point(549, 4);
            this.FlipYBTN.Name = "FlipYBTN";
            this.FlipYBTN.Size = new System.Drawing.Size(75, 23);
            this.FlipYBTN.TabIndex = 7;
            this.FlipYBTN.Text = "Flip Y";
            this.FlipYBTN.UseVisualStyleBackColor = true;
            this.FlipYBTN.Visible = false;
            this.FlipYBTN.Click += new System.EventHandler(this.FlipYBTN_Click);
            this.FlipYBTN.MouseHover += new System.EventHandler(this.FlipYBTN_MouseHover);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(103, 13);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "PhotoViewer - Hello!";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.Location = new System.Drawing.Point(768, -1);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(28, 29);
            this.CloseLabel.TabIndex = 9;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseHover += new System.EventHandler(this.CloseLabel_MouseHover);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold);
            this.Minimize.Location = new System.Drawing.Point(735, -4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 29);
            this.Minimize.TabIndex = 10;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(721, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 42);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ProjectInfoBTN
            // 
            this.ProjectInfoBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectInfoBTN.Location = new System.Drawing.Point(692, 423);
            this.ProjectInfoBTN.Name = "ProjectInfoBTN";
            this.ProjectInfoBTN.Size = new System.Drawing.Size(104, 23);
            this.ProjectInfoBTN.TabIndex = 12;
            this.ProjectInfoBTN.Text = "Project Info";
            this.ProjectInfoBTN.UseVisualStyleBackColor = true;
            this.ProjectInfoBTN.Click += new System.EventHandler(this.ProjectInfoBTN_Click);
            this.ProjectInfoBTN.MouseHover += new System.EventHandler(this.ProjectInfoBTN_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(112, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Press the centre of the screen to import an image.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectInfoBTN);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.FlipYBTN);
            this.Controls.Add(this.FlipXBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.Rotate90BTN);
            this.Controls.Add(this.EditBar);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.ColourBar);
            this.Controls.Add(this.MainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Viewer & Editor";
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox ColourBar;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.PictureBox EditBar;
        private System.Windows.Forms.Button Rotate90BTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button FlipXBTN;
        private System.Windows.Forms.Button FlipYBTN;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ProjectInfoBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

