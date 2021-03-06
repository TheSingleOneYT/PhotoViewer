using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class MainUpdater : Form
    {
        public object LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

        int increaseBy = 100;

        public object NewVer;

        public MainUpdater()
        {
            InitializeComponent();
        }

        private async Task CheckForPVs()
        {
            var processes = Process.GetProcessesByName("PhotoViewer");

            foreach (var process in processes)
            {
                process.Kill();
            }
        }

        private async Task UpdatePV()
        {
            await CheckForPVs();

            await Task.Delay(1000);

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/update");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/update/new");

            var wc = new WebClient();
            wc.DownloadFile("https://github.com/TheSingleOneYT/PhotoViewer/releases/download/" + NewVer + "/files.zip", Directory.GetCurrentDirectory() + "/update/files.zip");

            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "/update/files.zip", Directory.GetCurrentDirectory() + "/update/new", true);

            int noOfFiles = 0;

            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/update/new"))
            {
                noOfFiles = noOfFiles + 1;
            }

            File.Delete(Directory.GetCurrentDirectory() + "/update/new/UU.exe");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/UU.runtimeconfig.json");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/UU.dll");

            if (File.Exists(Directory.GetCurrentDirectory() + "/update/new/Updater.exe"))
            {
                if (Assembly.GetExecutingAssembly().GetName().Version.ToString() != FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + "/update/new/Updater.exe").FileVersion)
                {
                    if (File.Exists(Directory.GetCurrentDirectory() + "/UU.exe"))
                    {
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = Directory.GetCurrentDirectory() + "/UU.exe"
                        });

                        var processes = Process.GetProcessesByName("Updater");

                        foreach (var process in processes)
                        {
                            process.Kill();
                        }
                    }
                }
            }

            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.exe");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.runtimeconfig.json");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.dll");

            increaseBy = 100 / (noOfFiles - 6);

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "/update/new");
            foreach (string file in files)
            {
                label1.Text = "Current item = " + Path.GetFileName(file);

                await Task.Delay(500);

                File.Copy(file, $"{Directory.GetCurrentDirectory() + "/"}{ Path.GetFileNameWithoutExtension(file) }{ Path.GetExtension(file) }", true);

                await Task.Delay(500);

                progressBar1.Increment(increaseBy);
            }

            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/update"))
            {
                File.Delete(file);
            }

            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/update/new"))
            {
                File.Delete(file);
            }

            Directory.Delete(Directory.GetCurrentDirectory() + "/update/new");
            Directory.Delete(Directory.GetCurrentDirectory() + "/update");

            File.Delete(LocalAppData + "/NewVer.txt");

            label1.Text = "COMPLETE!";
            MessageBox.Show("COMPLETE!", "Photo Viewer - Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process p = new();
            p.StartInfo.FileName = Directory.GetCurrentDirectory() + "/PhotoViewer.exe";
            p.Start();
            Application.Exit();
        }

        private async void MainUpdater_Load(object sender, System.EventArgs e)
        {
            int i = 0;
            var processes = Process.GetProcessesByName("Updater");

            foreach (var process in processes)
            {
                i++;
            }

            if (i > 1)
            {
                foreach (var process in processes)
                {
                    if (i > 1)
                    {
                        process.Kill();
                        i--;
                    }
                }
            }

            if (File.Exists(LocalAppData + "/NewVer.txt"))
            {
                NewVer = File.ReadAllText(LocalAppData + "/NewVer.txt");

                UpdateInfo.Text = $"New: {NewVer}";

                if (File.Exists(Directory.GetCurrentDirectory() + "/PhotoViewer.exe"))
                    UpdateInfo.Text = $"New: {NewVer}   Old: {FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + "/PhotoViewer.exe").FileVersion}";

                label2.Text = $"Updater Version: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";

                bool isAdmin = IsRunAsAdmin();

                if (isAdmin == true)
                {
                    await UpdatePV();
                }
                else
                {
                    MessageBox.Show("Is not an administrator. Please restart and click OK on the UAC Prompt.", "Updater for PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show($"Could not find NewVer.txt in {Directory.GetCurrentDirectory()}. This file tells the updater what version of Photo Viewer software to download.", "Updater for PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
