using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Utils
    {
        private SettingsWindow settingsForm = null;

        public void CheckForUpdates(Form frm, bool silentCheck = false)
        {
            settingsForm = frm as SettingsWindow;

            if (IsInet() == true)
            {
                string versionContent = new WebClient().DownloadString(Strings.Uri.URL_GITCHANGELOG);
                string assemblyInfo = new WebClient().DownloadString(Strings.Uri.URL_ASSEMBLY);

                try
                {
                    var readVersion = assemblyInfo.Split('\n');
                    var infoVersion = readVersion.Where(t => t.Contains("[assembly: AssemblyFileVersion"));
                    var latestVersion = "";
                    foreach (var item in infoVersion)
                    {
                        latestVersion = item.Substring(item.IndexOf('(') + 2, item.LastIndexOf(')') - item.IndexOf('(') - 3);
                    }

                    if (latestVersion ==
                        Program.GetCurrentVersionTostring())                                                     // Up-to-date

                    {
                        if (silentCheck)                                                                         // Check on opening form
                        {
                            return;
                        }

                        MessageBox.Show("No new release found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (latestVersion !=                                                                        // Update available
                       Program.GetCurrentVersionTostring())

                    {
                        settingsForm.lblAssembly.Text = Program.GetCurrentVersionTostring() + " Dev";
                        settingsForm.btnCheckForUpdates.BackColor
                            = Color.FromArgb(223, 246, 221);
                        settingsForm.btnCheckForUpdates.FlatAppearance.BorderSize
                            = 0;
                        settingsForm.btnCheckForUpdates.ForeColor
                            = Color.Black;
                        settingsForm.btnCheckForUpdates.Text
                            = "Update ready to install v" + latestVersion;

                        if (settingsForm.buttonInstallUpdate && MessageBox.Show($"Do you want to install the update: {latestVersion}?" + Environment.NewLine + versionContent, @"App update available",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                WebClient client = new WebClient
                                {
                                    Encoding = Encoding.UTF8
                                };

                                Assembly currentAssembly = Assembly.GetEntryAssembly();

                                if (currentAssembly == null)
                                {
                                    currentAssembly = Assembly.GetCallingAssembly();
                                }

                                string appName = Path.GetFileNameWithoutExtension(currentAssembly.Location);
                                string appDir = Path.GetDirectoryName(currentAssembly.Location);
                                string appExtension = Path.GetExtension(currentAssembly.Location);

                                string archiveFile = Path.Combine(appDir, "TIW11_old" + appExtension);
                                string appFile = Path.Combine(appDir, appName + appExtension);
                                string tempFile = Path.Combine(appDir, "TIW11_tmp" + appExtension);

                                client.DownloadFile(string.Format("https://github.com/builtbybel/ThisIsWin11/releases/download/{0}/TIW11_updateonly.exe", latestVersion), tempFile);

                                if (File.Exists(archiveFile)) { File.Delete(archiveFile); }              // Delete previous version

                                File.Move(appFile, archiveFile);                                         // Backup

                                File.Move(tempFile, appFile);                                            // Update app!

                                var dataPackage =                                                        // Update data package!
                                     string.Format("https://github.com/builtbybel/ThisIsWin11/releases/download/{0}/data_updateonly.zip", latestVersion);

                                if (URLExists(dataPackage))

                                {
                                    try
                                    {
                                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);

                                        client.DownloadFileAsync(new Uri(dataPackage.Trim()), Application.StartupPath + "\\data_updateonly" + Path.GetExtension(dataPackage.ToString()));
                                    }
                                    catch (Exception ex)
                                    { MessageBox.Show(ex.Message, ""); }
                                }
                                else
                                    Application.Restart();
                            }
                            catch // Catch error 404 if no tag for new version available
                            { MessageBox.Show("The update distribution is most likely currently being prepared.\nPlease try again in a few minutes.", "We are not ready yet."); }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Checking for App updates failed.\n{ex.Message}", settingsForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (IsInet() == false)
            {
                MessageBox.Show("Checking for App updates failed.\n\nCheck your Internet connection and try again.");
            }
        }

        // Check Inet
        public static bool IsInet()
        {
            try
            {
                using (var CheckInternet = new WebClient())
                using (CheckInternet.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            settingsForm.progress.Visible = true;
            settingsForm.progress.Value = e.ProgressPercentage;
            settingsForm.btnCheckForUpdates.Invoke((MethodInvoker)(() => settingsForm.btnCheckForUpdates.Text = "Updating " + $"{e.ProgressPercentage}%"));
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string dataZip = Application.StartupPath + "\\data";

            try
            {
                if (Directory.Exists(dataZip)) Directory.Delete(dataZip, true);     // Delete old data dir

                ZipFile.ExtractToDirectory(Application.StartupPath + "\\data_updateonly.zip", Application.StartupPath);
                File.Delete(Application.StartupPath + "\\data_updateonly.zip");

                MessageBox.Show("Update completed.\nA restart is required for the changes to take effect.", settingsForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, settingsForm.Text); }

            Application.Restart();
        }

        // Verify existence of web resource
        public bool URLExists(string url)
        {
            bool result = true;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Timeout = 1200;
            webRequest.Method = "HEAD";

            try
            {
                webRequest.GetResponse();
            }
            catch
            {
                result = false;
            }

            return result;
        }

        // Launch Urls in rtb control
        public static void LaunchUri(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        // Check Urls in in rtb control
        public static bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}