
namespace PhotoViewer
{
    partial class console
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
            this.InputFeed = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.OutputFeed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputFeed
            // 
            this.InputFeed.Location = new System.Drawing.Point(12, 12);
            this.InputFeed.Name = "InputFeed";
            this.InputFeed.Size = new System.Drawing.Size(403, 23);
            this.InputFeed.TabIndex = 0;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(421, 12);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // OutputFeed
            // 
            this.OutputFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFeed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputFeed.Enabled = false;
            this.OutputFeed.Location = new System.Drawing.Point(12, 61);
            this.OutputFeed.Name = "OutputFeed";
            this.OutputFeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.OutputFeed.Size = new System.Drawing.Size(484, 267);
            this.OutputFeed.TabIndex = 2;
            this.OutputFeed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Feed:";
            // 
            // console
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputFeed);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.InputFeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "console";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console - PhotoViewer & Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFeed;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox OutputFeed;
        private System.Windows.Forms.Label label1;
    }
}