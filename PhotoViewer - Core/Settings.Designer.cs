
namespace PhotoViewer
{
    partial class Settings
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
            this.CFUBTN = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.CFUOASChkBx = new System.Windows.Forms.CheckBox();
            this.ColourBox1 = new System.Windows.Forms.PictureBox();
            this.UpdatesTabBTN = new System.Windows.Forms.Button();
            this.EditFunctionBTN = new System.Windows.Forms.Button();
            this.OtherBTN = new System.Windows.Forms.Button();
            this.StartPhotoViewerLADBTN = new System.Windows.Forms.Button();
            this.OpenPrefsFolderBTN = new System.Windows.Forms.Button();
            this.ASWOPS = new System.Windows.Forms.CheckBox();
            this.ColourModeBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CFUBTN
            // 
            this.CFUBTN.Location = new System.Drawing.Point(302, 14);
            this.CFUBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CFUBTN.Name = "CFUBTN";
            this.CFUBTN.Size = new System.Drawing.Size(506, 27);
            this.CFUBTN.TabIndex = 0;
            this.CFUBTN.Text = "Check for updates";
            this.CFUBTN.UseVisualStyleBackColor = true;
            this.CFUBTN.Click += new System.EventHandler(this.CFUBTN_Click);
            // 
            // notify
            // 
            this.notify.Text = "PhotoViewer";
            this.notify.Visible = true;
            // 
            // CFUOASChkBx
            // 
            this.CFUOASChkBx.AutoSize = true;
            this.CFUOASChkBx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CFUOASChkBx.Location = new System.Drawing.Point(302, 47);
            this.CFUOASChkBx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CFUOASChkBx.Name = "CFUOASChkBx";
            this.CFUOASChkBx.Size = new System.Drawing.Size(188, 19);
            this.CFUOASChkBx.TabIndex = 1;
            this.CFUOASChkBx.Text = "Check for updates on app start";
            this.CFUOASChkBx.UseVisualStyleBackColor = false;
            this.CFUOASChkBx.CheckedChanged += new System.EventHandler(this.CFUOASChkBx_CheckedChanged);
            // 
            // ColourBox1
            // 
            this.ColourBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ColourBox1.Location = new System.Drawing.Point(-6, -25);
            this.ColourBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ColourBox1.Name = "ColourBox1";
            this.ColourBox1.Size = new System.Drawing.Size(301, 415);
            this.ColourBox1.TabIndex = 2;
            this.ColourBox1.TabStop = false;
            // 
            // UpdatesTabBTN
            // 
            this.UpdatesTabBTN.BackColor = System.Drawing.Color.Black;
            this.UpdatesTabBTN.ForeColor = System.Drawing.Color.White;
            this.UpdatesTabBTN.Location = new System.Drawing.Point(14, 14);
            this.UpdatesTabBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdatesTabBTN.Name = "UpdatesTabBTN";
            this.UpdatesTabBTN.Size = new System.Drawing.Size(260, 96);
            this.UpdatesTabBTN.TabIndex = 3;
            this.UpdatesTabBTN.Text = "Update Settings";
            this.UpdatesTabBTN.UseVisualStyleBackColor = false;
            this.UpdatesTabBTN.Click += new System.EventHandler(this.UpdatesTabBTN_Click);
            // 
            // EditFunctionBTN
            // 
            this.EditFunctionBTN.BackColor = System.Drawing.Color.White;
            this.EditFunctionBTN.ForeColor = System.Drawing.Color.Black;
            this.EditFunctionBTN.Location = new System.Drawing.Point(14, 117);
            this.EditFunctionBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditFunctionBTN.Name = "EditFunctionBTN";
            this.EditFunctionBTN.Size = new System.Drawing.Size(260, 96);
            this.EditFunctionBTN.TabIndex = 4;
            this.EditFunctionBTN.Text = "Editing Settings";
            this.EditFunctionBTN.UseVisualStyleBackColor = false;
            this.EditFunctionBTN.Click += new System.EventHandler(this.EditFunctionBTN_Click);
            // 
            // OtherBTN
            // 
            this.OtherBTN.BackColor = System.Drawing.Color.White;
            this.OtherBTN.ForeColor = System.Drawing.Color.Black;
            this.OtherBTN.Location = new System.Drawing.Point(14, 219);
            this.OtherBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OtherBTN.Name = "OtherBTN";
            this.OtherBTN.Size = new System.Drawing.Size(260, 96);
            this.OtherBTN.TabIndex = 6;
            this.OtherBTN.Text = "Other";
            this.OtherBTN.UseVisualStyleBackColor = false;
            this.OtherBTN.Click += new System.EventHandler(this.OtherBTN_Click);
            // 
            // StartPhotoViewerLADBTN
            // 
            this.StartPhotoViewerLADBTN.Location = new System.Drawing.Point(302, 14);
            this.StartPhotoViewerLADBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartPhotoViewerLADBTN.Name = "StartPhotoViewerLADBTN";
            this.StartPhotoViewerLADBTN.Size = new System.Drawing.Size(506, 27);
            this.StartPhotoViewerLADBTN.TabIndex = 7;
            this.StartPhotoViewerLADBTN.Text = "Open AppData for PhotoViewer";
            this.StartPhotoViewerLADBTN.UseVisualStyleBackColor = true;
            this.StartPhotoViewerLADBTN.Visible = false;
            this.StartPhotoViewerLADBTN.Click += new System.EventHandler(this.StartPhotoViewerLADBTN_Click);
            // 
            // OpenPrefsFolderBTN
            // 
            this.OpenPrefsFolderBTN.Location = new System.Drawing.Point(302, 48);
            this.OpenPrefsFolderBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenPrefsFolderBTN.Name = "OpenPrefsFolderBTN";
            this.OpenPrefsFolderBTN.Size = new System.Drawing.Size(506, 27);
            this.OpenPrefsFolderBTN.TabIndex = 8;
            this.OpenPrefsFolderBTN.Text = "Open PhotoViewer Preferences Folder";
            this.OpenPrefsFolderBTN.UseVisualStyleBackColor = true;
            this.OpenPrefsFolderBTN.Visible = false;
            this.OpenPrefsFolderBTN.Click += new System.EventHandler(this.OpenPrefsFolderBTN_Click);
            // 
            // ASWOPS
            // 
            this.ASWOPS.AutoSize = true;
            this.ASWOPS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ASWOPS.Location = new System.Drawing.Point(302, 19);
            this.ASWOPS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ASWOPS.Name = "ASWOPS";
            this.ASWOPS.Size = new System.Drawing.Size(219, 19);
            this.ASWOPS.TabIndex = 9;
            this.ASWOPS.Text = "Always Show Warning On Paint Start";
            this.ASWOPS.UseVisualStyleBackColor = false;
            this.ASWOPS.Visible = false;
            this.ASWOPS.CheckedChanged += new System.EventHandler(this.ASWOPS_CheckedChanged);
            // 
            // ColourModeBTN
            // 
            this.ColourModeBTN.Location = new System.Drawing.Point(302, 83);
            this.ColourModeBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ColourModeBTN.Name = "ColourModeBTN";
            this.ColourModeBTN.Size = new System.Drawing.Size(506, 27);
            this.ColourModeBTN.TabIndex = 10;
            this.ColourModeBTN.Text = "Change Colour Mode: Current = Light";
            this.ColourModeBTN.UseVisualStyleBackColor = true;
            this.ColourModeBTN.Visible = false;
            this.ColourModeBTN.Click += new System.EventHandler(this.ColourModeBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(290, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 349);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 336);
            this.Controls.Add(this.ColourModeBTN);
            this.Controls.Add(this.ASWOPS);
            this.Controls.Add(this.OtherBTN);
            this.Controls.Add(this.EditFunctionBTN);
            this.Controls.Add(this.UpdatesTabBTN);
            this.Controls.Add(this.ColourBox1);
            this.Controls.Add(this.CFUOASChkBx);
            this.Controls.Add(this.CFUBTN);
            this.Controls.Add(this.StartPhotoViewerLADBTN);
            this.Controls.Add(this.OpenPrefsFolderBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CFUBTN;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.CheckBox CFUOASChkBx;
        private System.Windows.Forms.PictureBox ColourBox1;
        private System.Windows.Forms.Button UpdatesTabBTN;
        private System.Windows.Forms.Button EditFunctionBTN;
        private System.Windows.Forms.Button OtherBTN;
        private System.Windows.Forms.Button StartPhotoViewerLADBTN;
        private System.Windows.Forms.Button OpenPrefsFolderBTN;
        private System.Windows.Forms.CheckBox ASWOPS;
        private System.Windows.Forms.Button ColourModeBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}