using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class MainUpdater : Form
    {
        int increaseBy = 100;

        public object NewVer;

        public MainUpdater()
        {
            InitializeComponent();
        }

        private async Task UpdatePV()
        {
            var wc = new WebClient();
            wc.DownloadFile("https://github.com/TheSingleOneYT/PhotoViewer/releases/download/" + NewVer + "/files.zip", Directory.GetCurrentDirectory() + "/update/files.zip");

            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            ZipFile.ExtractToDirectory(Directory.GetCurrentDirectory() + "/update/files.zip", Directory.GetCurrentDirectory() + "/update/new", true);

            int noOfFiles = 0;

            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "/update/new"))
            {
                noOfFiles++;
            }

            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.exe");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.runtimeconfig.json");
            File.Delete(Directory.GetCurrentDirectory() + "/update/new/Updater.dll");

            //noOfFiles = noOfFiles - 3;

            increaseBy = 100 / noOfFiles;

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

            label1.Text = "COMPLETE!";
            MessageBox.Show("COMPLETE!", "Photo Viewer - Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process p = new();
            p.StartInfo.FileName = Directory.GetCurrentDirectory() + "/PhotoViewer.exe";
            p.Start();
            Application.Exit();
        }

        private void MainUpdater_Load(object sender, System.EventArgs e)
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

            if (File.Exists(Directory.GetCurrentDirectory() + "/NewVer.txt"))
            {
                NewVer = File.ReadAllText(Directory.GetCurrentDirectory() + "/NewVer.txt");
            }
            else
            {
                MessageBox.Show($"Could not find NewVer.txt in {Directory.GetCurrentDirectory()}. This file tells the updater what version of Photo Viewer software to download.", "Updater for PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            UpdateInfo.Text = $"New: {NewVer}";

            if (File.Exists(Directory.GetCurrentDirectory() + "/PhotoViewer.exe"))
                UpdateInfo.Text = $"New: {NewVer}   Old: {FileVersionInfo.GetVersionInfo(Directory.GetCurrentDirectory() + "/PhotoViewer.exe").FileVersion}";

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/update");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/update/new");
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            await UpdatePV();
        }
    }
}
