using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Utils
    {
        public static Version CurrentVersion = new Version(Application.ProductVersion);
        public static Version LatestVersion;

        private SettingsWindow settingsForm = null;

        public void CheckForUpdates(Form frm, bool InetStatusMessage, bool silentCheck = false)
        {
            settingsForm = frm as SettingsWindow;

            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            if (IsInet() == true)
            {
                string versionContent = new WebClient().DownloadString(Strings.Uri.GitVersionHint);

                WebRequest hreq = WebRequest.Create(Strings.Uri.GitVersionCheck);
                hreq.Timeout = 10000;
                hreq.Headers.Set("Cache-Control", "no-cache, no-store, must-revalidate");

                WebResponse hres = hreq.GetResponse();
                StreamReader sr = new StreamReader(hres.GetResponseStream());

                LatestVersion = new Version(sr.ReadToEnd().Trim());

                sr.Dispose();
                hres.Dispose();

                var equals = LatestVersion.CompareTo(CurrentVersion);

                if (equals == 0)          // Up-to-date
                {
                    // Update check on app launch
                    if (silentCheck)
                    {
                        return;
                    }

                    MessageBox.Show("No new release found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (equals < 0)     // Unofficial!
                {
                    return;
                }
                else                    // Update available
                {
                    if (MessageBox.Show("A new app version " + LatestVersion + " is available.\nDo you want to install the update?" + Environment.NewLine + versionContent, "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
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

                            client.DownloadFile(string.Format("https://github.com/builtbybel/ThisIsWin11/releases/download/{0}/TIW11_updateonly.exe", LatestVersion), tempFile);

                            if (File.Exists(archiveFile)) { File.Delete(archiveFile); }              // Delete previous version

                            File.Move(appFile, archiveFile);                                         // Backup

                            File.Move(tempFile, appFile);                                            // Update app!

                            UpdateDataPackage();                                                     // Update data package!
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message); }
                    }
                }
            }
            else if (IsInet() == false)
            {
                if (InetStatusMessage == true)
                {
                    // Update check on app launch
                    if (silentCheck)
                    {
                        return;
                    }

                    MessageBox.Show("Checking for App updates failed.\n\nCheck your Internet connection and try again.");
                }
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

        /// <summary>
        ///  Update data package
        /// </summary>
        private void UpdateDataPackage()
        {
            string dataZip = string.Format("https://github.com/builtbybel/ThisIsWin11/releases/download/{0}/data_updateonly.zip", LatestVersion);

            if (URLExists(dataZip))

            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);

                        client.DownloadFileAsync(new Uri(dataZip.Trim()), Application.StartupPath + "\\data_updateonly" + Path.GetExtension(dataZip.ToString()));
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, settingsForm.Text); }
            }
            else
                Application.Restart();
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

        // Create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"data");
            if (!dirExists)
                Directory.CreateDirectory(@"data");
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