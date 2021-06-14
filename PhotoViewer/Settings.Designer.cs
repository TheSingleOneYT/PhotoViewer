
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
            this.AOEMOIIChkBx = new System.Windows.Forms.CheckBox();
            this.OtherBTN = new System.Windows.Forms.Button();
            this.StartPhotoViewerLADBTN = new System.Windows.Forms.Button();
            this.OpenPrefsFolderBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CFUBTN
            // 
            this.CFUBTN.Location = new System.Drawing.Point(259, 12);
            this.CFUBTN.Name = "CFUBTN";
            this.CFUBTN.Size = new System.Drawing.Size(434, 23);
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
            this.CFUOASChkBx.Location = new System.Drawing.Point(259, 41);
            this.CFUOASChkBx.Name = "CFUOASChkBx";
            this.CFUOASChkBx.Size = new System.Drawing.Size(172, 17);
            this.CFUOASChkBx.TabIndex = 1;
            this.CFUOASChkBx.Text = "Check for updates on app start";
            this.CFUOASChkBx.UseVisualStyleBackColor = true;
            this.CFUOASChkBx.CheckedChanged += new System.EventHandler(this.CFUOASChkBx_CheckedChanged);
            // 
            // ColourBox1
            // 
            this.ColourBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ColourBox1.Location = new System.Drawing.Point(-5, -22);
            this.ColourBox1.Name = "ColourBox1";
            this.ColourBox1.Size = new System.Drawing.Size(258, 360);
            this.ColourBox1.TabIndex = 2;
            this.ColourBox1.TabStop = false;
            // 
            // UpdatesTabBTN
            // 
            this.UpdatesTabBTN.BackColor = System.Drawing.Color.Black;
            this.UpdatesTabBTN.ForeColor = System.Drawing.Color.White;
            this.UpdatesTabBTN.Location = new System.Drawing.Point(12, 12);
            this.UpdatesTabBTN.Name = "UpdatesTabBTN";
            this.UpdatesTabBTN.Size = new System.Drawing.Size(223, 83);
            this.UpdatesTabBTN.TabIndex = 3;
            this.UpdatesTabBTN.Text = "Update Settings";
            this.UpdatesTabBTN.UseVisualStyleBackColor = false;
            this.UpdatesTabBTN.Click += new System.EventHandler(this.UpdatesTabBTN_Click);
            // 
            // EditFunctionBTN
            // 
            this.EditFunctionBTN.BackColor = System.Drawing.Color.White;
            this.EditFunctionBTN.ForeColor = System.Drawing.Color.Black;
            this.EditFunctionBTN.Location = new System.Drawing.Point(12, 101);
            this.EditFunctionBTN.Name = "EditFunctionBTN";
            this.EditFunctionBTN.Size = new System.Drawing.Size(223, 83);
            this.EditFunctionBTN.TabIndex = 4;
            this.EditFunctionBTN.Text = "Editing Settings";
            this.EditFunctionBTN.UseVisualStyleBackColor = false;
            this.EditFunctionBTN.Click += new System.EventHandler(this.EditFunctionBTN_Click);
            // 
            // AOEMOIIChkBx
            // 
            this.AOEMOIIChkBx.AutoSize = true;
            this.AOEMOIIChkBx.Location = new System.Drawing.Point(259, 16);
            this.AOEMOIIChkBx.Name = "AOEMOIIChkBx";
            this.AOEMOIIChkBx.Size = new System.Drawing.Size(209, 17);
            this.AOEMOIIChkBx.TabIndex = 5;
            this.AOEMOIIChkBx.Text = "Auto Open Edit Menu On Image Import";
            this.AOEMOIIChkBx.UseVisualStyleBackColor = true;
            this.AOEMOIIChkBx.Visible = false;
            this.AOEMOIIChkBx.CheckedChanged += new System.EventHandler(this.AOEMOIIChkBx_CheckedChanged);
            // 
            // OtherBTN
            // 
            this.OtherBTN.BackColor = System.Drawing.Color.White;
            this.OtherBTN.ForeColor = System.Drawing.Color.Black;
            this.OtherBTN.Location = new System.Drawing.Point(12, 190);
            this.OtherBTN.Name = "OtherBTN";
            this.OtherBTN.Size = new System.Drawing.Size(223, 83);
            this.OtherBTN.TabIndex = 6;
            this.OtherBTN.Text = "Other";
            this.OtherBTN.UseVisualStyleBackColor = false;
            this.OtherBTN.Click += new System.EventHandler(this.OtherBTN_Click);
            // 
            // StartPhotoViewerLADBTN
            // 
            this.StartPhotoViewerLADBTN.Location = new System.Drawing.Point(259, 12);
            this.StartPhotoViewerLADBTN.Name = "StartPhotoViewerLADBTN";
            this.StartPhotoViewerLADBTN.Size = new System.Drawing.Size(434, 23);
            this.StartPhotoViewerLADBTN.TabIndex = 7;
            this.StartPhotoViewerLADBTN.Text = "Open LocalAppData for PhotoViewer";
            this.StartPhotoViewerLADBTN.UseVisualStyleBackColor = true;
            this.StartPhotoViewerLADBTN.Visible = false;
            this.StartPhotoViewerLADBTN.Click += new System.EventHandler(this.StartPhotoViewerLADBTN_Click);
            // 
            // OpenPrefsFolderBTN
            // 
            this.OpenPrefsFolderBTN.Location = new System.Drawing.Point(259, 42);
            this.OpenPrefsFolderBTN.Name = "OpenPrefsFolderBTN";
            this.OpenPrefsFolderBTN.Size = new System.Drawing.Size(434, 23);
            this.OpenPrefsFolderBTN.TabIndex = 8;
            this.OpenPrefsFolderBTN.Text = "Open PhotoViewer Preferences Folder";
            this.OpenPrefsFolderBTN.UseVisualStyleBackColor = true;
            this.OpenPrefsFolderBTN.Visible = false;
            this.OpenPrefsFolderBTN.Click += new System.EventHandler(this.OpenPrefsFolderBTN_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 291);
            this.Controls.Add(this.OpenPrefsFolderBTN);
            this.Controls.Add(this.StartPhotoViewerLADBTN);
            this.Controls.Add(this.OtherBTN);
            this.Controls.Add(this.AOEMOIIChkBx);
            this.Controls.Add(this.EditFunctionBTN);
            this.Controls.Add(this.UpdatesTabBTN);
            this.Controls.Add(this.ColourBox1);
            this.Controls.Add(this.CFUOASChkBx);
            this.Controls.Add(this.CFUBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox AOEMOIIChkBx;
        private System.Windows.Forms.Button OtherBTN;
        private System.Windows.Forms.Button StartPhotoViewerLADBTN;
        private System.Windows.Forms.Button OpenPrefsFolderBTN;
    }
}