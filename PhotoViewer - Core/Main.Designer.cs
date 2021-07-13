
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
            this.MainImageContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInLargeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColourBar = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.MiniControl = new System.Windows.Forms.PictureBox();
            this.ProjectInfoBTN = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.zoomSlider = new System.Windows.Forms.TrackBar();
            this.ZoomText = new System.Windows.Forms.Label();
            this.ResetZoomBTN = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.EditingBar = new System.Windows.Forms.PictureBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditLabel = new System.Windows.Forms.Label();
            this.EditCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flipAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLabel = new System.Windows.Forms.Label();
            this.ViewCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewInLargeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.MainImage = new PhotoViewer.MovablePB(this.components);
            this.ConsoleBTN = new System.Windows.Forms.Button();
            this.MainImageContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditingBar)).BeginInit();
            this.FileCMS.SuspendLayout();
            this.EditCMS.SuspendLayout();
            this.ViewCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainImageContextStrip
            // 
            this.MainImageContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.resetImageToolStripMenuItem,
            this.openInLargeViewToolStripMenuItem});
            this.MainImageContextStrip.Name = "MainImageContextStrip";
            this.MainImageContextStrip.Size = new System.Drawing.Size(173, 92);
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
            this.ColourBar.Location = new System.Drawing.Point(-12, 483);
            this.ColourBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ColourBar.Name = "ColourBar";
            this.ColourBar.Size = new System.Drawing.Size(948, 42);
            this.ColourBar.TabIndex = 1;
            this.ColourBar.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 495);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(116, 15);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "PhotoViewer - Hello!";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(896, -1);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.Minimize.Font = new System.Drawing.Font("HotKeys_01", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minimize.Location = new System.Drawing.Point(858, -5);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.MiniControl.Location = new System.Drawing.Point(798, -12);
            this.MiniControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MiniControl.Name = "MiniControl";
            this.MiniControl.Size = new System.Drawing.Size(142, 48);
            this.MiniControl.TabIndex = 11;
            this.MiniControl.TabStop = false;
            // 
            // ProjectInfoBTN
            // 
            this.ProjectInfoBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectInfoBTN.Location = new System.Drawing.Point(669, 4);
            this.ProjectInfoBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProjectInfoBTN.Name = "ProjectInfoBTN";
            this.ProjectInfoBTN.Size = new System.Drawing.Size(121, 27);
            this.ProjectInfoBTN.TabIndex = 12;
            this.ProjectInfoBTN.Text = "Project Info";
            this.ProjectInfoBTN.UseVisualStyleBackColor = true;
            this.ProjectInfoBTN.Click += new System.EventHandler(this.ProjectInfoBTN_Click);
            this.ProjectInfoBTN.MouseHover += new System.EventHandler(this.ProjectInfoBTN_MouseHover);
            // 
            // zoomSlider
            // 
            this.zoomSlider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zoomSlider.Location = new System.Drawing.Point(590, 488);
            this.zoomSlider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zoomSlider.Name = "zoomSlider";
            this.zoomSlider.Size = new System.Drawing.Size(225, 45);
            this.zoomSlider.TabIndex = 18;
            this.zoomSlider.Scroll += new System.EventHandler(this.zoomSlider_Scroll);
            // 
            // ZoomText
            // 
            this.ZoomText.AutoSize = true;
            this.ZoomText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZoomText.Location = new System.Drawing.Point(580, 494);
            this.ZoomText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZoomText.Name = "ZoomText";
            this.ZoomText.Size = new System.Drawing.Size(13, 15);
            this.ZoomText.TabIndex = 20;
            this.ZoomText.Text = "0";
            // 
            // ResetZoomBTN
            // 
            this.ResetZoomBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetZoomBTN.Location = new System.Drawing.Point(817, 488);
            this.ResetZoomBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResetZoomBTN.Name = "ResetZoomBTN";
            this.ResetZoomBTN.Size = new System.Drawing.Size(107, 27);
            this.ResetZoomBTN.TabIndex = 21;
            this.ResetZoomBTN.Text = "Reset Zoom";
            this.ResetZoomBTN.UseVisualStyleBackColor = true;
            this.ResetZoomBTN.Click += new System.EventHandler(this.ResetZoomBTN_Click);
            this.ResetZoomBTN.MouseHover += new System.EventHandler(this.ResetZoomBTN_MouseHover);
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
            this.SettingsLabel.Font = new System.Drawing.Font("HotKeys_01", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsLabel.Location = new System.Drawing.Point(804, 0);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(40, 27);
            this.SettingsLabel.TabIndex = 23;
            this.SettingsLabel.Text = "⚙️";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            this.SettingsLabel.MouseHover += new System.EventHandler(this.SettingsLabel_MouseHover);
            // 
            // EditingBar
            // 
            this.EditingBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditingBar.Location = new System.Drawing.Point(-7, -1);
            this.EditingBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditingBar.Name = "EditingBar";
            this.EditingBar.Size = new System.Drawing.Size(807, 37);
            this.EditingBar.TabIndex = 25;
            this.EditingBar.TabStop = false;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FileLabel.ContextMenuStrip = this.FileCMS;
            this.FileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.Location = new System.Drawing.Point(13, 6);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(41, 25);
            this.FileLabel.TabIndex = 26;
            this.FileLabel.Text = "File";
            this.FileLabel.Click += new System.EventHandler(this.FileLabel_Click);
            // 
            // FileCMS
            // 
            this.FileCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.FileCMS.Name = "FileCMS";
            this.FileCMS.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.MainImage_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditLabel.ContextMenuStrip = this.EditCMS;
            this.EditLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditLabel.Location = new System.Drawing.Point(60, 6);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(44, 25);
            this.EditLabel.TabIndex = 27;
            this.EditLabel.Text = "Edit";
            this.EditLabel.Click += new System.EventHandler(this.EditLabel_Click);
            // 
            // EditCMS
            // 
            this.EditCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipAxisToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.paintToolStripMenuItem});
            this.EditCMS.Name = "EditCMS";
            this.EditCMS.Size = new System.Drawing.Size(119, 92);
            // 
            // flipAxisToolStripMenuItem
            // 
            this.flipAxisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipXToolStripMenuItem,
            this.flipYToolStripMenuItem});
            this.flipAxisToolStripMenuItem.Name = "flipAxisToolStripMenuItem";
            this.flipAxisToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.flipAxisToolStripMenuItem.Text = "Flip Axis";
            // 
            // flipXToolStripMenuItem
            // 
            this.flipXToolStripMenuItem.Name = "flipXToolStripMenuItem";
            this.flipXToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.flipXToolStripMenuItem.Text = "Flip X";
            this.flipXToolStripMenuItem.Click += new System.EventHandler(this.FlipXBTN_Click);
            // 
            // flipYToolStripMenuItem
            // 
            this.flipYToolStripMenuItem.Name = "flipYToolStripMenuItem";
            this.flipYToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.flipYToolStripMenuItem.Text = "Flip Y";
            this.flipYToolStripMenuItem.Click += new System.EventHandler(this.FlipYBTN_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate90ToolStripMenuItem,
            this.rotate180ToolStripMenuItem,
            this.rotate270ToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rotate90ToolStripMenuItem.Text = "Rotate 90⁰";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.Rotate90BTN_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rotate180ToolStripMenuItem.Text = "Rotate 180⁰";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // rotate270ToolStripMenuItem
            // 
            this.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            this.rotate270ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rotate270ToolStripMenuItem.Text = "Rotate 270⁰";
            this.rotate270ToolStripMenuItem.Click += new System.EventHandler(this.rotate270ToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.greyScaleToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.InvertBTN_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.greyScaleToolStripMenuItem.Text = "GreyScale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.GreyScaleBTN_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.PaintBTN_Click);
            // 
            // ViewLabel
            // 
            this.ViewLabel.AutoSize = true;
            this.ViewLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewLabel.ContextMenuStrip = this.ViewCMS;
            this.ViewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewLabel.Location = new System.Drawing.Point(110, 6);
            this.ViewLabel.Name = "ViewLabel";
            this.ViewLabel.Size = new System.Drawing.Size(53, 25);
            this.ViewLabel.TabIndex = 28;
            this.ViewLabel.Text = "View";
            this.ViewLabel.Click += new System.EventHandler(this.ViewLabel_Click);
            // 
            // ViewCMS
            // 
            this.ViewCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInLargeViewToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.ViewCMS.Name = "ViewCMS";
            this.ViewCMS.Size = new System.Drawing.Size(181, 70);
            // 
            // viewInLargeViewToolStripMenuItem
            // 
            this.viewInLargeViewToolStripMenuItem.Name = "viewInLargeViewToolStripMenuItem";
            this.viewInLargeViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewInLargeViewToolStripMenuItem.Text = "View In Large View";
            this.viewInLargeViewToolStripMenuItem.Click += new System.EventHandler(this.openInLargeViewToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.ResetZoomBTN_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpLabel.Location = new System.Drawing.Point(169, 6);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(51, 25);
            this.HelpLabel.TabIndex = 29;
            this.HelpLabel.Text = "Help";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // MainImage
            // 
            this.MainImage.ContextMenuStrip = this.MainImageContextStrip;
            this.MainImage.Location = new System.Drawing.Point(-3, 34);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(944, 452);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 30;
            this.MainImage.TabStop = false;
            this.MainImage.Click += new System.EventHandler(this.MainImage_Click);
            this.MainImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainImage_DragDrop);
            this.MainImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainImage_DragEnter);
            // 
            // ConsoleBTN
            // 
            this.ConsoleBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsoleBTN.Location = new System.Drawing.Point(580, 4);
            this.ConsoleBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConsoleBTN.Name = "ConsoleBTN";
            this.ConsoleBTN.Size = new System.Drawing.Size(81, 27);
            this.ConsoleBTN.TabIndex = 31;
            this.ConsoleBTN.Text = "Console";
            this.ConsoleBTN.UseVisualStyleBackColor = true;
            this.ConsoleBTN.Click += new System.EventHandler(this.ConsoleBTN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.ConsoleBTN);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.ViewLabel);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.ResetZoomBTN);
            this.Controls.Add(this.ZoomText);
            this.Controls.Add(this.zoomSlider);
            this.Controls.Add(this.ProjectInfoBTN);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseLabel);
            this.Controls.Add(this.MiniControl);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ColourBar);
            this.Controls.Add(this.EditingBar);
            this.Controls.Add(this.MainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Viewer & Editor";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MainImageContextStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditingBar)).EndInit();
            this.FileCMS.ResumeLayout(false);
            this.EditCMS.ResumeLayout(false);
            this.ViewCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ColourBar;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.PictureBox MiniControl;
        private System.Windows.Forms.Button ProjectInfoBTN;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.TrackBar zoomSlider;
        private System.Windows.Forms.Label ZoomText;
        private System.Windows.Forms.Button ResetZoomBTN;
        private System.Windows.Forms.ContextMenuStrip MainImageContextStrip;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInLargeViewToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.PictureBox EditingBar;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label EditLabel;
        private System.Windows.Forms.Label ViewLabel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.ContextMenuStrip FileCMS;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip EditCMS;
        private System.Windows.Forms.ToolStripMenuItem flipAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ViewCMS;
        private System.Windows.Forms.ToolStripMenuItem viewInLargeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
        private MovablePB MainImage;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Button ConsoleBTN;
    }
}

