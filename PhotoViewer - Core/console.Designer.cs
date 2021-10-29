
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
            this.components = new System.ComponentModel.Container();
            this.Submit = new System.Windows.Forms.Button();
            this.OutputFeed = new System.Windows.Forms.RichTextBox();
            this.OutputMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.InputFeed = new System.Windows.Forms.TextBox();
            this.InputMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoAboutDYM = new System.Windows.Forms.Label();
            this.OutputMS.SuspendLayout();
            this.InputMS.SuspendLayout();
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
            this.OutputFeed.ContextMenuStrip = this.OutputMS;
            this.OutputFeed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputFeed.Location = new System.Drawing.Point(12, 83);
            this.OutputFeed.Name = "OutputFeed";
            this.OutputFeed.ReadOnly = true;
            this.OutputFeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.OutputFeed.Size = new System.Drawing.Size(484, 245);
            this.OutputFeed.TabIndex = 2;
            this.OutputFeed.Text = "";
            this.OutputFeed.WordWrap = false;
            // 
            // OutputMS
            // 
            this.OutputMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.OutputMS.Name = "OutputMS";
            this.OutputMS.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Feed:";
            // 
            // InputFeed
            // 
            this.InputFeed.AutoCompleteCustomSource.AddRange(new string[] {
            "edit",
            "help",
            "output",
            "input",
            "info",
            "console",
            "run",
            "application",
            "update",
            "resize",
            "errorc",
            "mainerror",
            "medfi",
            "edit-invert",
            "edit-gs",
            "edit-90",
            "edit-180",
            "edit-270",
            "help-show",
            "output-clear",
            "output-copy",
            "input-clear",
            "input-copy",
            "info-ver",
            "info-projectinfo",
            "info-github",
            "info-website",
            "console-hide",
            "run-website",
            "run-github",
            "application-kill",
            "application-restart",
            "application-show \"s",
            "application-show \"h",
            "application-show",
            "update-do",
            "resize-show",
            "errorc-1",
            "errorc-2",
            "mainerror-001",
            "mainerror-002",
            "mainerror-003",
            "mainerror-004",
            "mainerror-005",
            "mainerror-006",
            "medfi-filter",
            "medfi-resize",
            "medfi-create",
            "medfi-convert"});
            this.InputFeed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.InputFeed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.InputFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputFeed.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputFeed.ContextMenuStrip = this.InputMS;
            this.InputFeed.Location = new System.Drawing.Point(12, 12);
            this.InputFeed.Name = "InputFeed";
            this.InputFeed.Size = new System.Drawing.Size(403, 23);
            this.InputFeed.TabIndex = 4;
            // 
            // InputMS
            // 
            this.InputMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.clearToolStripMenuItem1});
            this.InputMS.Name = "InputMS";
            this.InputMS.Size = new System.Drawing.Size(103, 48);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // InfoAboutDYM
            // 
            this.InfoAboutDYM.AutoSize = true;
            this.InfoAboutDYM.ForeColor = System.Drawing.Color.Black;
            this.InfoAboutDYM.Location = new System.Drawing.Point(12, 38);
            this.InfoAboutDYM.Name = "InfoAboutDYM";
            this.InfoAboutDYM.Size = new System.Drawing.Size(246, 15);
            this.InfoAboutDYM.TabIndex = 6;
            this.InfoAboutDYM.Text = "(Press enter or click submit to run command)";
            // 
            // console
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.InfoAboutDYM);
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
            this.OutputMS.ResumeLayout(false);
            this.InputMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RichTextBox OutputFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputFeed;
        private System.Windows.Forms.Label InfoAboutDYM;
        private System.Windows.Forms.ContextMenuStrip OutputMS;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip InputMS;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
    }
}