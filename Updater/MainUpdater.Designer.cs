
namespace Updater
{
    partial class MainUpdater
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUpdater));
            this.EditingBar = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EditingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // EditingBar
            // 
            this.EditingBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditingBar.Location = new System.Drawing.Point(-8, -3);
            this.EditingBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditingBar.Name = "EditingBar";
            this.EditingBar.Size = new System.Drawing.Size(354, 37);
            this.EditingBar.TabIndex = 27;
            this.EditingBar.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Current file:";
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.AutoSize = true;
            this.UpdateInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateInfo.Location = new System.Drawing.Point(7, 4);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(107, 25);
            this.UpdateInfo.TabIndex = 28;
            this.UpdateInfo.Text = "New: x.x.x.x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Updater Version: ";
            // 
            // MainUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 112);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.UpdateInfo);
            this.Controls.Add(this.EditingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Viewer - Updater";
            this.Load += new System.EventHandler(this.MainUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox EditingBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateInfo;
        private System.Windows.Forms.Label label2;
    }
}

