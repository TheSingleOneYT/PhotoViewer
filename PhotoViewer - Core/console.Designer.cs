
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
            this.Submit = new System.Windows.Forms.Button();
            this.OutputFeed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputFeed = new System.Windows.Forms.TextBox();
            this.DYMText = new System.Windows.Forms.Label();
            this.InfoAboutDYM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.OutputFeed.BackColor = System.Drawing.Color.White;
            this.OutputFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFeed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputFeed.Location = new System.Drawing.Point(12, 89);
            this.OutputFeed.Name = "OutputFeed";
            this.OutputFeed.ReadOnly = true;
            this.OutputFeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.OutputFeed.Size = new System.Drawing.Size(484, 239);
            this.OutputFeed.TabIndex = 2;
            this.OutputFeed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Feed:";
            // 
            // InputFeed
            // 
            this.InputFeed.Location = new System.Drawing.Point(12, 12);
            this.InputFeed.Name = "InputFeed";
            this.InputFeed.Size = new System.Drawing.Size(403, 23);
            this.InputFeed.TabIndex = 4;
            this.InputFeed.TextChanged += new System.EventHandler(this.InputFeed_TextChanged);
            this.InputFeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFeed_KeyDown);
            // 
            // DYMText
            // 
            this.DYMText.AutoSize = true;
            this.DYMText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DYMText.ForeColor = System.Drawing.Color.Black;
            this.DYMText.Location = new System.Drawing.Point(12, 38);
            this.DYMText.Name = "DYMText";
            this.DYMText.Size = new System.Drawing.Size(88, 15);
            this.DYMText.TabIndex = 5;
            this.DYMText.Text = "No Predictions.";
            this.DYMText.Click += new System.EventHandler(this.DYMText_Click);
            // 
            // InfoAboutDYM
            // 
            this.InfoAboutDYM.AutoSize = true;
            this.InfoAboutDYM.ForeColor = System.Drawing.Color.Black;
            this.InfoAboutDYM.Location = new System.Drawing.Point(201, 38);
            this.InfoAboutDYM.Name = "InfoAboutDYM";
            this.InfoAboutDYM.Size = new System.Drawing.Size(295, 15);
            this.InfoAboutDYM.TabIndex = 6;
            this.InfoAboutDYM.Text = "(Press enter or click to enter prediction into input feed)";
            // 
            // console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.InfoAboutDYM);
            this.Controls.Add(this.DYMText);
            this.Controls.Add(this.InputFeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputFeed);
            this.Controls.Add(this.Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "console";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console - PhotoViewer & Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox OutputFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputFeed;
        private System.Windows.Forms.Label DYMText;
        private System.Windows.Forms.Label InfoAboutDYM;
    }
}