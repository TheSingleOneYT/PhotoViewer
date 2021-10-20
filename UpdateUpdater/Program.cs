using System.Diagnostics;
using System.IO;

namespace UpdateUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(Directory.GetCurrentDirectory() + "/update/new/Updater.exe", Directory.GetCurrentDirectory() + "/Updater.exe", true);
            File.Copy(Directory.GetCurrentDirectory() + "/update/new/Updater.dll", Directory.GetCurrentDirectory() + "/Updater.dll", true);
            File.Copy(Directory.GetCurrentDirectory() + "/update/new/Updater.runtimeconfig.json", Directory.GetCurrentDirectory() + "/Updater.runtimeconfig.json", true);

            Process.Start(new ProcessStartInfo
            {
                FileName = Directory.GetCurrentDirectory() + "/Updater.exe",
                Verb = "runas",
                UseShellExecute = true
            });

            var processes = Process.GetProcessesByName("UU");

            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }
}
