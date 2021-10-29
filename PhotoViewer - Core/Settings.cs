using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhotoViewer
{
    public partial class Settings : Form
    {
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

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

            if (File.Exists(prefs + "/ColourMode.txt"))
            {
                var CM = File.ReadAllText(prefs + "/ColourMode.txt");

                if (CM == "l")
                {
                    ColourModeBTN.Text = "Change Colour Mode: Current = Light";
                    this.BackColor = Color.White;
                }
                else
                {
                    ColourModeBTN.Text = "Change Colour Mode: Current = Dark";
                    this.BackColor = Color.Gray;
                }
            }
            else
            {
                ColourModeBTN.Text = "Change Colour Mode: Current = Light";
                File.WriteAllText(prefs + "/ColourMode.txt", "l");
                this.BackColor = Color.White;
            }

            if (File.Exists(prefs + "/ASWOPS.txt"))
            {
                var prefonASWOPSChkBx = File.ReadAllText(prefs + "/ASWOPS.txt");

                if (prefonASWOPSChkBx == "true")
                {
                    ASWOPS.Checked = true;
                }
                else
                {
                    ASWOPS.Checked = false;
                }
            }
            else
            {
                ASWOPS.Checked = true;
                File.WriteAllText(prefs + "/ASWOPS.txt", "true");
            }
        }

        private void CFUBTN_Click(object sender, EventArgs e)
        {
            if (internetTest() == true)
            {
                var url = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/main/Update/Version.txt";
                var prURL = "https://raw.githubusercontent.com/TheSingleOneYT/PhotoViewer/pre-release/Update/Version.txt";
                var wc = new System.Net.WebClient();
                var GithubVer = wc.DownloadString(url).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                var PreRelease = wc.DownloadString(prURL).Split(new[] { '\r', '\n' })[0].Replace(" ", "");
                var AppVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                if (AppVer != GithubVer && PreRelease == AppVer)
                {
                    notify.Icon = SystemIcons.Application;
                    notify.BalloonTipText = "You are testing a Pre-Release. Downgrade to a release?";
                    notify.ShowBalloonTip(1000);
                    notify.BalloonTipClicked += Notify_BalloonTipClicked;
                    NewVer = GithubVer;
                }
                else if (AppVer != GithubVer)
                {
                    notify.Icon = SystemIcons.Application;
                    notify.BalloonTipText = "A new version of PhotoViewer is available. Click to install new version.";
                    notify.ShowBalloonTip(1000);
                    notify.BalloonTipClicked += Notify_BalloonTipClicked;
                    NewVer = GithubVer;
                }
            }
            else
            {
                MessageBox.Show("No internet connection. Please connect to the internet and try again. Error: PV006", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Notify_BalloonTipClicked(object sender, EventArgs e)
        {
            File.WriteAllText(LocalAppData + "/NewVer.txt", NewVer.ToString());

            Application.Exit();

            Process.Start(new ProcessStartInfo
            {
                FileName = Directory.GetCurrentDirectory() + "/Updater.exe",
                Verb = "runas",
                UseShellExecute = true
            });
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
            StartPhotoViewerLADBTN.Hide();
            OpenPrefsFolderBTN.Hide();
            ASWOPS.Hide();
            ColourModeBTN.Hide();
            ResetBTN.Hide();
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
            StartPhotoViewerLADBTN.Hide();
            OpenPrefsFolderBTN.Hide();
            ASWOPS.Show();
            ColourModeBTN.Hide();
            ResetBTN.Hide();
            EditFunctionBTN.BackColor = Color.Black;
            EditFunctionBTN.ForeColor = Color.White;
            UpdatesTabBTN.BackColor = Color.White;
            UpdatesTabBTN.ForeColor = Color.Black;
            OtherBTN.BackColor = Color.White;
            OtherBTN.ForeColor = Color.Black;
        }


        private void StartPhotoViewerLADBTN_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Environment.GetEnvironmentVariable("LocalAppData") + "/PhotoViewer",
                UseShellExecute = true
            });
        }

        private void OtherBTN_Click(object sender, EventArgs e)
        {
            CFUBTN.Hide();
            CFUOASChkBx.Hide();
            ASWOPS.Hide();
            StartPhotoViewerLADBTN.Show();
            OpenPrefsFolderBTN.Show();
            ColourModeBTN.Show();
            ResetBTN.Show();
            OtherBTN.BackColor = Color.Black;
            OtherBTN.ForeColor = Color.White;
            UpdatesTabBTN.BackColor = Color.White;
            UpdatesTabBTN.ForeColor = Color.Black;
            EditFunctionBTN.BackColor = Color.White;
            EditFunctionBTN.ForeColor = Color.Black;
        }

        private void OpenPrefsFolderBTN_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = (string)prefs,
                UseShellExecute = true
            });
        }

        private void ASWOPS_CheckedChanged(object sender, EventArgs e)
        {
            if (ASWOPS.Checked == true)
            {
                File.WriteAllText(prefs + "/ASWOPS.txt", "true");
            }
            else
            {
                File.WriteAllText(prefs + "/ASWOPS.txt", "false");
            }
        }

        private void ColourModeBTN_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Changing this will cause a restart. Please save your work, then change this option. Press OK to change colour mode.", "Photo Viewer & Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (msg == DialogResult.OK)
            {
                if (ColourModeBTN.Text.Contains("Light"))
                {
                    File.WriteAllText(prefs + "/ColourMode.txt", "d");
                    ColourModeBTN.Text = "Change Colour Mode: Current = Dark";
                }
                else
                {
                    File.WriteAllText(prefs + "/ColourMode.txt", "l");
                    ColourModeBTN.Text = "Change Colour Mode: Current = Light";
                }

                Application.Exit();
                Process.Start(new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true
                });
            }
        }

        public static bool internetTest(int timeoutMs = 10000, string url = "https://www.google.com")
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you sure you want to reset all settings? This will cause a restart. If you have an work open, please save your work, then press this button. Press OK to reset settings.", "Photo Viewer & Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (msg == DialogResult.OK)
            {
                foreach (var file in Directory.GetFiles(prefs.ToString()))
                {
                    File.Delete(file);
                }

                Application.Exit();
                Process.Start(new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true
                });
            }
        }
    }
}
