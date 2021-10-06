using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ThisIsWin11.Helpers
{
    internal class Utils
    {
        private readonly Showcase.OS osInfo = new Showcase.OS();

        public static Version CurrentVersion = new Version(Application.ProductVersion);
        public static Version LatestVersion;

        private HomeWindow showcaseForm = null;

        //capture screen and post web intent to twitter
        public void CaptureToShare(Form frm)
        {
            showcaseForm = frm as HomeWindow;

            Form f = showcaseForm;
            Bitmap bmp = new Bitmap(f.Width, f.Height);
            f.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "PNG Images|*.png",
                FileName = "ThisIsWin11-" + showcaseForm.lblHeader.Text + "\x20" + osInfo.ComputerName
            };

            DialogResult result = dialog.ShowDialog(showcaseForm);

            if (result == DialogResult.OK)
            {
                bmp.Save(dialog.FileName);

                MessageBox.Show("Click <OK> to prepare the Twitter status. After that you just need to upload the result image you just created." + dialog.FileName);
                Process.Start(Strings.TweetIntent); //tweet Web Intent
            }
        }

        public void CheckForUpdates(bool InetStatusMessage)
        {
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
                    MessageBox.Show("No new release found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (equals < 0) //um, unofficial!
                {
                    MessageBox.Show("Looks like an unoffical release.\nTry again later...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //update available
                {
                    if (MessageBox.Show("A new app version " + LatestVersion + " is available.\nDo you want to goto the Github update page?" + Environment.NewLine + versionContent, "App update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process.Start(Strings.Uri.GitUpdateRepo + LatestVersion);
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