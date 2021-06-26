
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
            this.MainImageContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInLargeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MiniControl = new System.Windows.Forms.PictureBox();
            this.ProjectInfoBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.FiltersBar = new System.Windows.Forms.PictureBox();
            this.GreyScaleBTN = new System.Windows.Forms.Button();
            this.InvertBTN = new System.Windows.Forms.Button();
            this.FiltersText = new System.Windows.Forms.Label();
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.ZoomText = new System.Windows.Forms.Label();
            this.ResetZoomBTN = new System.Windows.Forms.Button();
            this.EditBarSection2 = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SettingsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.MainImageContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltersBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBarSection2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImage
            // 
            this.MainImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainImage.ContextMenuStrip = this.MainImageContextStrip;
            this.MainImage.Location = new System.Drawing.Point(-6, 33);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(809, 391);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            this.MainImage.Click += new System.EventHandler(this.MainImage_Click);
            this.MainImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainImage_DragDrop);
            this.MainImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainImage_DragEnter);
            // 
            // MainImageContextStrip
            // 
            this.MainImageContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.resetImageToolStripMenuItem,
            this.clearItemsToolStripMenuItem,
            this.openInLargeViewToolStripMenuItem});
            this.MainImageContextStrip.Name = "MainImageContextStrip";
            this.MainImageContextStrip.Size = new System.Drawing.Size(173, 114);
            // 
            // importImageToolStripMenuItem
            // 
            this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
            this.importImageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.importImageToolStripMenuItem.Text = "Import Image";
            this.importImageToolStripMenuItem.Click += new System.EventHandler(this.importImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // resetImageToolStripMenuItem
            // 
            this.resetImageToolStripMenuItem.Name = "resetImageToolStripMenuItem";
            this.resetImageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.resetImageToolStripMenuItem.Text = "Reset Image";
            this.resetImageToolStripMenuItem.Click += new System.EventHandler(this.resetImageToolStripMenuItem_Click);
            // 
            // clearItemsToolStripMenuItem
            // 
            this.clearItemsToolStripMenuItem.Name = "clearItemsToolStripMenuItem";
            this.clearItemsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clearItemsToolStripMenuItem.Text = "Clear Items";
            this.clearItemsToolStripMenuItem.Click += new System.EventHandler(this.clearItemsToolStripMenuItem_Click);
            // 
            // openInLargeViewToolStripMenuItem
            // 
            this.openInLargeViewToolStripMenuItem.Name = "openInLargeViewToolStripMenuItem";
            this.openInLargeViewToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openInLargeViewToolStripMenuItem.Text = "Open in large view";
            this.openInLargeViewToolStripMenuItem.Click += new System.EventHandler(this.openInLargeViewToolStripMenuItem_Click);
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
            this.EditBar.Location = new System.Drawing.Point(575, -10);
            this.EditBar.Name = "EditBar";
            this.EditBar.Size = new System.Drawing.Size(93, 42);
            this.EditBar.TabIndex = 3;
            this.EditBar.TabStop = false;
            // 
            // Rotate90BTN
            // 
            this.Rotate90BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rotate90BTN.Location = new System.Drawing.Point(341, 4);
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
            this.SaveBTN.Location = new System.Drawing.Point(584, 4);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 23);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            this.SaveBTN.MouseHover += new System.EventHandler(this.SaveBTN_MouseHover);
            // 
            // FlipXBTN
            // 
            this.FlipXBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlipXBTN.Location = new System.Drawing.Point(422, 4);
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
            this.FlipYBTN.Location = new System.Drawing.Point(503, 4);
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
            // MiniControl
            // 
            this.MiniControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MiniControl.Location = new System.Drawing.Point(684, -10);
            this.MiniControl.Name = "MiniControl";
            this.MiniControl.Size = new System.Drawing.Size(122, 42);
            this.MiniControl.TabIndex = 11;
            this.MiniControl.TabStop = false;
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
            // FiltersBar
            // 
            this.FiltersBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FiltersBar.Location = new System.Drawing.Point(584, 389);
            this.FiltersBar.Name = "FiltersBar";
            this.FiltersBar.Size = new System.Drawing.Size(220, 32);
            this.FiltersBar.TabIndex = 14;
            this.FiltersBar.TabStop = false;
            this.FiltersBar.Visible = false;
            // 
            // GreyScaleBTN
            // 
            this.GreyScaleBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreyScaleBTN.Location = new System.Drawing.Point(721, 393);
            this.GreyScaleBTN.Name = "GreyScaleBTN";
            this.GreyScaleBTN.Size = new System.Drawing.Size(75, 23);
            this.GreyScaleBTN.TabIndex = 15;
            this.GreyScaleBTN.Text = "GreyScale";
            this.GreyScaleBTN.UseVisualStyleBackColor = true;
            this.GreyScaleBTN.Visible = false;
            this.GreyScaleBTN.Click += new System.EventHandler(this.GreyScaleBTN_Click);
            this.GreyScaleBTN.MouseHover += new System.EventHandler(this.GreyScaleBTN_MouseHover);
            // 
            // InvertBTN
            // 
            this.InvertBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvertBTN.Location = new System.Drawing.Point(640, 393);
            this.InvertBTN.Name = "InvertBTN";
            this.InvertBTN.Size = new System.Drawing.Size(75, 23);
            this.InvertBTN.TabIndex = 16;
            this.InvertBTN.Text = "Invert";
            this.InvertBTN.UseVisualStyleBackColor = true;
            this.InvertBTN.Visible = false;
            this.InvertBTN.Click += new System.EventHandler(this.InvertBTN_Click);
            this.InvertBTN.MouseHover += new System.EventHandler(this.InvertBTN_MouseHover);
            // 
            // FiltersText
            // 
            this.FiltersText.AutoSize = true;
            this.FiltersText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FiltersText.Location = new System.Drawing.Point(591, 398);
            this.FiltersText.Name = "FiltersText";
            this.FiltersText.Size = new System.Drawing.Size(43, 13);
            this.FiltersText.TabIndex = 17;
            this.FiltersText.Text = "Filters - ";
            this.FiltersText.Visible = false;
            // 
            // zoomSlider
            // 
            this.zoomSlider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zoomSlider.Location = new System.Drawing.Point(403, 423);
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Size = new System.Drawing.Size(193, 45);
            this.zoomSlider.TabIndex = 18;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            // 
            // ZoomText
            // 
            this.ZoomText.AutoSize = true;
            this.ZoomText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZoomText.Location = new System.Drawing.Point(384, 428);
            this.ZoomText.Name = "ZoomText";
            this.ZoomText.Size = new System.Drawing.Size(13, 13);
            this.ZoomText.TabIndex = 20;
            this.ZoomText.Text = "0";
            // 
            // ResetZoomBTN
            // 
            this.ResetZoomBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetZoomBTN.Location = new System.Drawing.Point(594, 423);
            this.ResetZoomBTN.Name = "ResetZoomBTN";
            this.ResetZoomBTN.Size = new System.Drawing.Size(92, 23);
            this.ResetZoomBTN.TabIndex = 21;
            this.ResetZoomBTN.Text = "Reset Zoom";
            this.ResetZoomBTN.UseVisualStyleBackColor = true;
            this.ResetZoomBTN.Click += new System.EventHandler(this.ResetZoomBTN_Click);
            this.ResetZoomBTN.MouseHover += new System.EventHandler(this.ResetZoomBTN_MouseHover);
            // 
            // EditBarSection2
            // 
            this.EditBarSection2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBarSection2.Location = new System.Drawing.Point(329, -10);
            this.EditBarSection2.Name = "EditBarSection2";
            this.EditBarSection2.Size = new System.Drawing.Size(249, 42);
            this.EditBarSection2.TabIndex = 22;
            this.EditBarSection2.TabStop = false;
            this.EditBarSection2.Visible = false;
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.ContextMenuStrip = this.MainImageContextStrip;
            this.notify.Text = "PhotoViewer";
            this.notify.Visible = true;
            this.notify.BalloonTipClicked += new System.EventHandler(this.Notify_BalloonTipClicked);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SettingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLabel.Font = new System.Drawing.Font("HotKeys_01", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(689, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(40, 27);
            this.SettingsLabel.TabIndex = 23;
            this.SettingsLabel.Text = "⚙️";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            this.SettingsLabel.MouseHover += new System.EventHandler(this.SettingsLabel_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.ResetZoomBTN);
            this.Controls.Add(this.ZoomText);
            this.Controls.Add(this.zoomSlider);
            this.Controls.Add(this.FiltersText);
            this.Controls.Add(this.InvertBTN);
            this.Controls.Add(this.GreyScaleBTN);
            this.Controls.Add(this.FiltersBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectInfoBTN);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MiniControl);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.FlipYBTN);
            this.Controls.Add(this.FlipXBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.Rotate90BTN);
            this.Controls.Add(this.EditBar);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.ColourBar);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.EditBarSection2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Viewer & Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.MainImageContextStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltersBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBarSection2)).EndInit();
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
        private System.Windows.Forms.PictureBox MiniControl;
        private System.Windows.Forms.Button ProjectInfoBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.PictureBox FiltersBar;
        private System.Windows.Forms.Button GreyScaleBTN;
        private System.Windows.Forms.Button InvertBTN;
        private System.Windows.Forms.Label FiltersText;
        private System.Windows.Forms.TrackBar zoomSlider;
        private System.Windows.Forms.Label ZoomText;
        private System.Windows.Forms.Button ResetZoomBTN;
        private System.Windows.Forms.PictureBox EditBarSection2;
        private System.Windows.Forms.ContextMenuStrip MainImageContextStrip;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInLargeViewToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Label SettingsLabel;
    }
}

