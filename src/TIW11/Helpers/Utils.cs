using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    public static class Utils
    {
        public static Version CurrentVersion = new Version(Application.ProductVersion);
        public static Version LatestVersion;

        public static void AppUpdate()
        {
            try
            {
                string versionContent = new WebClient().DownloadString(Helpers.Strings.Uri.GitVersionHint);

                WebRequest hreq = WebRequest.Create(Helpers.Strings.Uri.GitVersionCheck);
                hreq.Timeout = 10000;
                hreq.Headers.Set("Cache-Control", "no-cache, no-store, must-revalidate");

                WebResponse hres = hreq.GetResponse();
                StreamReader sr = new StreamReader(hres.GetResponseStream());

                LatestVersion = new Version(sr.ReadToEnd().Trim());

                sr.Dispose();
                hres.Dispose();

                var equals = LatestVersion.CompareTo(CurrentVersion);

                if (equals == 0)
                {
                    return; // up-to-date
                }
                else if (equals < 0)
                {
                    return; // higher than available
                }
                else // new version
                {
                    if (MessageBox.Show("A new app version " + LatestVersion + " is available.\nDo you want to goto the Github update page?" + Environment.NewLine + versionContent, "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // New release available!
                    {
                        Process.Start(Helpers.Strings.Uri.GitUpdateRepo + LatestVersion);
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Launch Urls in richtext
        /// </summary>
        public static void LaunchUri(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        /// <summary>
        /// Check Urls in in richtext
        /// </summary>
        public static bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}