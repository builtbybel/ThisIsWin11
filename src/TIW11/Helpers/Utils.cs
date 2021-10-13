using System;
using System.Diagnostics;
using System.IO;
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

        public void CheckForUpdates(bool InetStatusMessage, bool silentCheck = false)
        {
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

                if (equals == 0) //up-to-date
                {
                    //update check on app launch
                    if (silentCheck)
                    {
                        return;
                    }

                    MessageBox.Show("No new release found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (equals < 0) //unofficial!
                {
                    return;
                }
                else //update available
                {
                    if (MessageBox.Show("A new app version " + LatestVersion + " is available.\nDo you want to update?" + Environment.NewLine + versionContent, "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                            //delete previous version
                            if (File.Exists(archiveFile))
                            {
                                File.Delete(archiveFile);
                            }

                            //backup
                            File.Move(appFile, archiveFile);

                            //update
                            File.Move(tempFile, appFile);

                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (IsInet() == false)
            {
                if (InetStatusMessage == true)
                {
                    MessageBox.Show("Checking for App updates failed.\n\nCheck your Internet connection and try again.");
                }
            }
        }

        //check Inet
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

        //create data directory if non present
        public static void CreateDataDir()
        {
            bool dirExists = Directory.Exists(@"data");
            if (!dirExists)
                Directory.CreateDirectory(@"data");
        }

        //launch Urls in rtb control
        public static void LaunchUri(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        //check Urls in in rtb control
        public static bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}