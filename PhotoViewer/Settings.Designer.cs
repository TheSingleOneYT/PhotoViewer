
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
            this.SuspendLayout();
            // 
            // CFUBTN
            // 
            this.CFUBTN.Location = new System.Drawing.Point(12, 12);
            this.CFUBTN.Name = "CFUBTN";
            this.CFUBTN.Size = new System.Drawing.Size(297, 23);
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
            this.CFUOASChkBx.Location = new System.Drawing.Point(12, 41);
            this.CFUOASChkBx.Name = "CFUOASChkBx";
            this.CFUOASChkBx.Size = new System.Drawing.Size(172, 17);
            this.CFUOASChkBx.TabIndex = 1;
            this.CFUOASChkBx.Text = "Check for updates on app start";
            this.CFUOASChkBx.UseVisualStyleBackColor = true;
            this.CFUOASChkBx.CheckedChanged += new System.EventHandler(this.CFUOASChkBx_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 69);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CFUBTN;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.CheckBox CFUOASChkBx;
    }
}