using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Settings : Form
    {
        public object NewVer;

        public object prefs = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer/Preferences";

        public Settings()
        {
            InitializeComponent();

            if (File.Exists(prefs + "/CFUOASChkBx.txt"))
            {
                var prefonCFUOASCB = File.ReadAllText(prefs + "/CFUOASChkBx.txt");

                if (prefonCFUOASCB == "true")
                {
                    CFUOASChkBx.Checked = true;
                }
                else
                {
                    CFUOASChkBx.Checked = false;
                }
            }
            else
            {
                CFUOASChkBx.Checked = true;
            }

            if (File.Exists(prefs + "/AOEMOIIChkBx.txt"))
            {
                var prefonAOEMOIIChkBx = File.ReadAllText(prefs + "/AOEMOIIChkBx.txt");

                if (prefonAOEMOIIChkBx == "true")
                {
                    AOEMOIIChkBx.Checked = true;
                }
                else
                {
                    AOEMOIIChkBx.Checked = false;
                }
            }
            else
            {
                File.WriteAllText(prefs + "/AOEMOIIChkBx.txt", "false");
            }
        }

        private void CFUBTN_Click(object sender, EventArgs e)
        {
            var url = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/main/Update/Version.txt";
            var wc = new System.Net.WebClient();
            var GithubVer = wc.DownloadString(url).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
            var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            if (AppVer == GithubVer)
            {
                notify.Icon = SystemIcons.Application;
                notify.BalloonTipText = "You have the latest version of Photo Viewer & Editor.";
                notify.ShowBalloonTip(1000);
            }
            else
            {
                notify.Icon = SystemIcons.Application;
                notify.BalloonTipText = "A new version of PhotoViewer is available. Click to install new version";
                notify.ShowBalloonTip(1000);
                notify.BalloonTipClicked += Notify_BalloonTipClicked;
                NewVer = GithubVer;
            }
        }

        private void Notify_BalloonTipClicked(object sender, EventArgs e)
        {
            var process = "https://github.com/TheSingleOneYT/PhotoViewer/releases/download/" + NewVer + "/PhotoViewer.exe";
            Process.Start(process);
            var Downloads = @"C:\Users\" + SystemInformation.UserName.ToString() + @"\Downloads";
            Application.Exit();

            while (File.Exists(Downloads + "/PhotoViewer.exe") == false)
            {
                this.Cursor = Cursors.WaitCursor;
            }

            notify.Icon = SystemIcons.Application;
            notify.BalloonTipText = "Download Complete!";
            notify.ShowBalloonTip(1000);

            Process.Start(Downloads + "/PhotoViewer.exe");
        }

        private void CFUOASChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (CFUOASChkBx.Checked == true)
            {
                File.WriteAllText(prefs + "/CFUOASChkBx.txt", "true");
            }
            else
            {
                File.WriteAllText(prefs + "/CFUOASChkBx.txt", "false");
            }
        }

        private void UpdatesTabBTN_Click(object sender, EventArgs e)
        {
            CFUBTN.Show();
            CFUOASChkBx.Show();
            AOEMOIIChkBx.Hide();
            StartPhotoViewerLADBTN.Hide();
            OpenPrefsFolderBTN.Hide();
            UpdatesTabBTN.BackColor = Color.Black;
            UpdatesTabBTN.ForeColor = Color.White;
            EditFunctionBTN.BackColor = Color.White;
            EditFunctionBTN.ForeColor = Color.Black;
            OtherBTN.BackColor = Color.White;
            OtherBTN.ForeColor = Color.Black;
        }

        private void EditFunctionBTN_Click(object sender, EventArgs e)
        {
            CFUBTN.Hide();
            CFUOASChkBx.Hide();
            AOEMOIIChkBx.Show();
            StartPhotoViewerLADBTN.Hide();
            OpenPrefsFolderBTN.Hide();
            EditFunctionBTN.BackColor = Color.Black;
            EditFunctionBTN.ForeColor = Color.White;
            UpdatesTabBTN.BackColor = Color.White;
            UpdatesTabBTN.ForeColor = Color.Black;
            OtherBTN.BackColor = Color.White;
            OtherBTN.ForeColor = Color.Black;
        }

        private void AOEMOIIChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (AOEMOIIChkBx.Checked == true)
            {
                File.WriteAllText(prefs + "/AOEMOIIChkBx.txt", "true");
            }
            else
            {
                File.WriteAllText(prefs + "/AOEMOIIChkBx.txt", "false");
            }
        }

        private void StartPhotoViewerLADBTN_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer");
        }

        private void OtherBTN_Click(object sender, EventArgs e)
        {
            CFUBTN.Hide();
            CFUOASChkBx.Hide();
            AOEMOIIChkBx.Hide();
            StartPhotoViewerLADBTN.Show();
            OpenPrefsFolderBTN.Show();
            OtherBTN.BackColor = Color.Black;
            OtherBTN.ForeColor = Color.White;
            UpdatesTabBTN.BackColor = Color.White;
            UpdatesTabBTN.ForeColor = Color.Black;
            EditFunctionBTN.BackColor = Color.White;
            EditFunctionBTN.ForeColor = Color.Black;
        }

        private void OpenPrefsFolderBTN_Click(object sender, EventArgs e)
        {
            Process.Start((string)prefs);
        }
    }
}
