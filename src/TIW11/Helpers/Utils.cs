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

        private MainWindow mainForm = null;

        //capture screen and post web intent to twitter
        public void CaptureToShare(Form frm)
        {
            mainForm = frm as MainWindow;

            Form f = mainForm;
            Bitmap bmp = new Bitmap(f.Width, f.Height);
            f.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Title = "Location",
                Filter = "PNG Images|*.png",
                FileName = "ThisIsWin11-" + mainForm.lblSubHeader.Text + "\x20" + osInfo.ComputerName
            };

            DialogResult result = dialog.ShowDialog(mainForm);

            if (result == DialogResult.OK)
            {
                bmp.Save(dialog.FileName);

                MessageBox.Show("Click <OK> to prepare the Twitter status. After that you just need to upload the result image you just created." + dialog.FileName);
                Process.Start(Helpers.Strings.TweetIntent); //tweet Web Intent
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

                if (equals == 0)
                {
                    return; //up-to-date
                }
                else if (equals < 0)
                {
                    return; //higher than available
                }
                else // New version
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

            //check Inet
            bool IsInet()
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