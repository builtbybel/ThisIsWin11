using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class MainWindow : Form
    {
        private PageTitle INavPage = PageTitle.Welcome;
        private Features.OS osInfo = new Features.OS();

        public MainWindow()
        {
            InitializeComponent();
            UISelection();
            NavigationView();
            EnumTableOfContents();
        }

        /// <summary>
        /// Some UI nicety
        /// </summary>
        private void UISelection()
        {
            this.MinimumSize = new Size(800, 735);

            // Presenter button ONLY on Win11
            if (osInfo.IsWin11())
            {
                lnkSubHeader.Text = "*Windows 11 aka Sun Valley" + "\x20"
                          + osInfo.GetVersion() + "\x20"
                          + osInfo.Is64Bit();
            }
            else
            {
                // btnPresenter.Enabled = false;
                lnkSubHeader.Text = "*This is not Windows 11 (some features are not available)";
            }

            btnSettings.Text = "\uE713";       // Settings
            btnRecheck.Text = "\ue72c";        // Refresh
            btnBack.Text = "\uE72B";           // Back
            btnNext.Text = "\uE72A";           // Next

            // Some tooltip options
            _ = new ToolTip
            {
                AutoPopDelay = 15000,
                IsBalloon = true
            };
        }

        private void btnRecheck_Click(object sender, EventArgs e)
        {
            if (INavPage > PageTitle.Welcome)
            {
                INavPage = 0;
                cbTable.SelectedIndex = 0;
            }

            NavigationView();
            Helpers.Utils.AppUpdate(); // Check for app updates
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            if (INavPage > PageTitle.Welcome)
            {
                INavPage--;
                cbTable.SelectedItem = INavPage++;
            }

            NavigationView();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            INavPage++;
            NavigationView();

            cbTable.SelectedItem = INavPage++;
        }

        // Enum Breadcrumbs to cb
        private void EnumTableOfContents()
        {
            cbTable.DataSource = Enum.GetValues(typeof(PageTitle));
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageTitle index;
            Enum.TryParse<PageTitle>(cbTable.SelectedValue.ToString(), out index);

            INavPage = index;

            NavigationView();
        }

        public void NavigationView()
        {
            btnBack.Enabled = INavPage > PageTitle.Welcome;

            switch (INavPage)
            {
                case PageTitle.Welcome:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Welcome, " + Environment.UserName;
                    richDesc.Text = "Lets make sure everything is set up how you want it.\n\nUse the <Next> and <Previous> buttons to navigate through the features of Windows 11.\n\n" +
                                    "Use the <Demonstrate this page> button to get the feature presented once (if it is available).\n\n" +
                                    "Pages marked with <This page can be configured> will allow you to apply immediately the right configuration (in development).\n\n" +
                                    "If you are not yet working with Windows 11, the <Demonstrate this page> button will not work.";
                    pbView.ImageLocation = "";
                    break;

                case PageTitle.NewLook:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "A new look";
                    richDesc.Text = "As you already see, Windows 11 features a clean design with rounded corners, pastel shades and a centered Start menu and Taskbar.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-look.png?raw=true";
                    break;

                case PageTitle.StartMenu:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "New Start Menu";
                    richDesc.Text = "Of all the new Windows 11 features, the new launcher-style floating Start Menu is the most distinctive part of Microsoft’s next-gen desktop OS.\n\n" +
                                        "Unlike the traditional Start Menu, the new Start — as Microsoft is calling it — sits right at the center of the taskbar.\n\n" +
                                        "It has a flyout design with pinned and recommended apps accompanying each other. So far in my usage, the recommendations are pretty good. It quickly offers me access to documents, photos, and apps I have recently installed.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-startmenu.png?raw=true";
                    break;

                case PageTitle.ActionCenter:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Action Center";
                    richDesc.Text = "Another great feature of Windows 11 is the revamped Action Center.\n\n" +
                                    "It follows a design language that we have seen on mobile OSes, and I quite like this mobile - first approach to important system toggles\n\n" +
                                    "You can now simply click on the unified “WiFi, volume and battery” button to open the new Action Center. It packs all the necessary controls, including brightness and volume sliders. You can also add more toggles like before.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-actioncenter.png?raw=true";
                    break;

                case PageTitle.FileExplorer:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Modern File Explorer";
                    richDesc.Text = "The new experience of file explorer didn’t come with multiple Tabs options similar to tabs in the Microsoft Edge browser.\n\n" +
                                     "By default, File Explorer is now optimized for tablet users.\n\n" +
                                    "The File Explorer interface is not changing dramatically, but there are several noticeable changes. For example, Microsoft is replacing the Windows 8-era ribbon toolbar with a redesigned top menu called command bar allowing you quick access to commonly used actions like share, delete, rename, etc";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-fileexplorer.png?raw=true";
                    break;

                case PageTitle.MicrosoftStore:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "New Microsoft Store";
                    richDesc.Text = "There’s a complete UI overhaul on the app store and some speed improvements.\n\n" +
                                   "The key change is allowing more apps into the store. The Microsoft Store is changing on Windows 11, and eventually Windows 10, to include any traditional desktop apps.\n\n" +
                                    "Microsoft previously restricted developers to its Universal Windows Apps, before then allowing some desktop apps that were packaged to use its store for updates. Now any app can be part of the store, a move that aligns with the Windows Package Manager Microsoft released last year.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-msstore.png?raw=true";
                    break;

                case PageTitle.SettingsApp:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Redesigned Settings App";
                    richDesc.Text = "The Settings app has been redesigned with a radically different look and it is now using a new navigation menu on the left, similar to Control Panel.\n\n" +
                                    "It comes with a slightly reorganized layout which enables easier access to all your PC settings.\n\n" +
                                    "We’re also getting new pages to customize the touch keyboard, Windows snapping, multitasking and other advanced features like “Wake on Touch” in the new operating system.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-settingsapp.png?raw=true";
                    break;

                case PageTitle.WindowsUpdates:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Faster Windows Updates";
                    richDesc.Text = "Yes, you read that right. With Windows 11, you will have a much faster Windows update process, thanks to the background installation mechanism. Microsoft has promised that Windows updates will now be 40% smaller, making the process even more efficient. ";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-windowsupdates.png?raw=true";
                    break;

                case PageTitle.SnapLayouts:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Snap Layouts";
                    richDesc.Text = "Snap is a productivity feature that helps users arrange applications and other windows logically on-screen.\n\n" +
                                    "In 2019, Microsoft relaunched the PowerToys brand with a new utility called FancyZones that extends the Snap experience to allow for more complex and useful on-screen window layouts. A key part of this utility, incredibly, has been integrated into Windows 11 and is now called Snap Layouts.\n\n" +
                                    "When you're working in a bunch of open windows, Windows 11 will let you arrange them in different layouts on the screen, and will save all of those windows in that arrangement. ";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-snaplayouts.png?raw=true";
                    break;

                case PageTitle.Widgets:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Widgets";
                    richDesc.Text = "With Windows 11, Microsoft has brought Widgets, where you can find all kinds of information with just a click. It’s similar to Google Assistant’s Snapshot and the “Today View” in Apple’s iOS 15 or macOS Monterey.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-widgets.png?raw=true";
                    break;

                case PageTitle.GestureControls:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Advanced Gesture Controls";
                    richDesc.Text = "Gestures have long been part of Windows 10, but frankly speaking, they were not very smooth, and the transitions between apps and virtual desktops were awful. With the new Advanced Gesture Controls and mandatory precision touchpad requirement for Windows 11, things might get better.\n\n" +
                                    "Now, you can customize three-finger and four-finger swipes according to your preference.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-gestures.png?raw=true";
                    break;

                case PageTitle.WallpapersNSounds:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "New Wallpapers && Sounds";
                    richDesc.Text = "Along with Windows 11, Microsoft has also brought a series of beautiful wallpapers, sounds, and themes. Wallpapers such as Captured Motion, Flow, Sunrise, Glow are some of the nicest wallpapers you can find on a desktop OS.\n\n" +
                                    "Also, the startup and notification sound is really good.\nPress the Magic Button to listen to the startup sound.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-wallpapers.png?raw=true";
                    break;

                case PageTitle.LockScreen:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "New Minimal Lock Screen";
                    richDesc.Text = "Windows 11 supports animated lock-screen background on PCs that have accelerometer.\n\n" +
                                    "It applies an acrylic blur in the background, and the new variable Segoe UI font makes things even better. If you don’t want all the links and recommendations on the lock screen, you can disable them from Settings for a clean lock screen.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-lockscreen.png?raw=true";
                    break;

                case PageTitle.TouchKeyboard:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Touch Keyboard Improvements";
                    richDesc.Text = "Windows 11 comes with a Touch Keyboard feature that remains turned off by default. You can use this touch keyboard on a computer or laptop, which is not a touch screen. It is a handy application if your physical keyboard is totally not working or a few keys are not working.\n\n" +
                                    "Microsoft made it more intuitive to use by drawing inspiration from smartphone keyboards.\n\nEven you can use this Touch Keyboard as a substitute for a mechanical keyboard.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-touchkeyboard.png?raw=true";
                    break;

                case PageTitle.AndroidApps:
                    btnConfigurator.Enabled = false;
                    lblSubHeader.Text = "Android Apps Support";
                    richDesc.Text = "Android apps will be coming to Windows 11 and installable from within the new Microsoft Store via the Amazon Appstore.\n\n" +
                                    "However, Android app support has not been added in the current 22000.51 preview build. Microsoft has confirmed that the option to install Android apps will arrive in the upcoming builds.\n\n" +
                                    "The best part is that you can even sideload APKs on your Windows 11 PC.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-androidapps.png?raw=true";
                    break;

                case PageTitle.Privacy:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Privacy";
                    richDesc.Text = "One thing Microsoft didn't discuss is about Windows 11 privacy.\n\n" +
                                    "Since Windows 11 Home will essentially require a Microsoft account for most users, data harvesting is part of the package. \n\n" +
                                    "In Windows 11, you'll be able to continue editing cloud files per its algorithmically populated \"Recommended\" section in the new Start Menu.\n" +
                                    "Your browser history will sync between Edge on PC and Edge on mobile, as it already does. Your Skype and Teams conversations will sync as you'd expect too, and your Windows 11 features will migrate to new PCs if you upgrade.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-privacy.png?raw=true";
                    break;

                case PageTitle.Apps:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "Apps";
                    richDesc.Text = "First Windows 11 preview still insists with bloatware.\n\n" +
                                     "Apparently Windows 11 is also lighter than Windows 10 as for the preinstalled apps.\n\n" +
                                    "The good thing is that at least some of the Windows 10 apps aren’t installed. However, you will still have installed all the hoard of apps that belong to Microsoft, such as Mail and Calendar, Your Phone, Mixed Reality Portal, Solitaire Collection, Get Help, Paoint 3D, XBox Game Bar, etc.\n\n" +
                                     "Use the <Configure this page> link to uninstall pre-installed apps.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-apps.png?raw=true";
                    break;

                case PageTitle.Thanks:
                    btnConfigurator.Enabled = true;
                    lblSubHeader.Text = "That's it";
                    richDesc.Text = "Thanks for using me.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-end.png?raw=true";
                    break;
            }
        }

        private void btnPresenter_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (INavPage)
            {
                case PageTitle.Welcome:
                    MessageBox.Show("All right, take it easy. There's nothing to see here.");
                    break;

                case PageTitle.NewLook:
                    MessageBox.Show("Maybe next time...but first enjoy what you see.");
                    break;

                case PageTitle.StartMenu:
                    try
                    {
                        Helpers.Keystrokes.KeyDown(Keys.LWin);
                        Helpers.Keystrokes.KeyUp(Keys.LWin);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); break; }

                    break;

                case PageTitle.ActionCenter:
                    try
                    {
                        Helpers.Keystrokes.KeyDown(Keys.LWin);
                        Helpers.Keystrokes.KeyDown(Keys.A);
                        Helpers.Keystrokes.KeyUp(Keys.LWin);
                        Helpers.Keystrokes.KeyUp(Keys.A);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.FileExplorer:
                    try
                    {
                        Helpers.Keystrokes.KeyDown(Keys.LWin);
                        Helpers.Keystrokes.KeyDown(Keys.E);
                        Helpers.Keystrokes.KeyUp(Keys.LWin);
                        Helpers.Keystrokes.KeyUp(Keys.E);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.MicrosoftStore:

                    try
                    {
                        Process.Start("ms-windows-store://home");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case PageTitle.SettingsApp:
                    try
                    {
                        Process.Start("ms-settings://");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case PageTitle.WindowsUpdates:
                    try
                    {
                        Process.Start("ms-settings:windowsupdate-action");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case PageTitle.SnapLayouts:
                    try
                    {
                        Helpers.Keystrokes.KeyDown(Keys.LWin);
                        Helpers.Keystrokes.KeyDown(Keys.Z);
                        Helpers.Keystrokes.KeyUp(Keys.LWin);
                        Helpers.Keystrokes.KeyUp(Keys.Z);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.Widgets:

                    try
                    {
                        Helpers.Keystrokes.KeyDown(Keys.LWin);
                        Helpers.Keystrokes.KeyDown(Keys.W);
                        Helpers.Keystrokes.KeyUp(Keys.LWin);
                        Helpers.Keystrokes.KeyUp(Keys.W);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.GestureControls:

                    try
                    {
                        Process.Start("ms-settings:mousetouchpad");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.WallpapersNSounds:

                    try
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\Media\Windows Logon.wav");
                        player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.LockScreen:

                    try
                    {
                        Features.LockScreen.LockWorkStation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.TouchKeyboard:

                    try
                    {
                        Process.Start("ms-settings:easeofaccess-keyboard");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.AndroidApps:

                    try
                    {
                        Process.Start("https://www.theverge.com/2021/6/24/22548428/microsoft-windows-11-android-apps-support-amazon-store");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    break;

                case PageTitle.Privacy:

                    try
                    {
                        // Process.Start("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    break;

                case PageTitle.Apps:

                    try
                    {
                        Process.Start("ms-settings:appsfeatures");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    break;

                case PageTitle.Thanks:

                    btnRecheck.PerformClick();

                    break;
            }
        }

        private void btnConfigurator_Click(object sender, EventArgs e)
        {
            switch (INavPage)
            {
                case PageTitle.Welcome:
                    MessageBox.Show("We are working on giving you the possibility to configure certain settings pages in a fast and uncomplicated way.");
                    break;

                case PageTitle.NewLook:
                    Process.Start("ms-settings:personalization-background");
                    break;

                case PageTitle.StartMenu:
                    Process.Start("ms-settings:personalization-start");
                    break;

                case PageTitle.ActionCenter:
                    Process.Start("ms-settings:notifications");
                    break;

                case PageTitle.FileExplorer:

                    try
                    {
                        Process proc = new Process();
                        proc.StartInfo.UseShellExecute = false;
                        proc.StartInfo.FileName = "rundll32.exe";
                        proc.StartInfo.Arguments = "shell32.dll,Options_RunDLL 0";
                        proc.Start();

                        break;
                    }
                    catch { }

                    break;

                case PageTitle.MicrosoftStore:

                    break;

                case PageTitle.SettingsApp:

                    break;

                case PageTitle.WindowsUpdates:
                    Process.Start("ms-settings:windowsupdate-options");
                    break;

                case PageTitle.SnapLayouts:

                    break;

                case PageTitle.Widgets:

                    break;

                case PageTitle.GestureControls:

                    break;

                case PageTitle.WallpapersNSounds:

                    break;

                case PageTitle.LockScreen:
                    Process.Start("ms-settings:lockscreen");

                    break;

                case PageTitle.TouchKeyboard:

                    break;

                case PageTitle.AndroidApps:

                    break;

                case PageTitle.Privacy:
                    Process.Start("ms-settings:privacy-general");
                    break;

                case PageTitle.Apps:

                    var startInfo = new ProcessStartInfo()
                    {
                        FileName = "powershell.exe",
                        Arguments = "Get-AppxPackage -AllUsers | Out-GridView -PassThru | Remove-AppxPackage",
                        UseShellExecute = false,
                        CreateNoWindow = false,
                    }; Process.Start(startInfo).WaitForExit();

                    break;

                case PageTitle.Thanks:

                    if (MessageBox.Show("Thanks for the tour!\n\n" +
                        "You might want to look for app updates so that the next tour will be even more exciting?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // New release available!
                    {
                        Helpers.Utils.AppUpdate(); // Update check
                        btnRecheck.PerformClick();
                    }
                    break;
            }
        }

        /// <summary>
        ///  Add some watermark
        /// </summary>
        /*    private void pbView_Paint(object sender, PaintEventArgs e)
            {
                if (INavPage == 0)

                {
                    return;
                }
                using (Font font = new Font("Segeo UI Semiglight", 8))
                {
                    e.Graphics.DrawString("https://github.com/builtbybel/ThisIsWin11", font, Brushes.HotPink, new Point(0, 0));
                }
            } */

        /// <summary>
        /// Buttons/Links and menu events
        /// </summary>
        private void richDesc_LinkClicked(object sender, LinkClickedEventArgs e) => ThisIsWin11.Helpers.Utils.LaunchUri(e.LinkText);

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("ms-settings:about");

        private void btnSettings_Click(object sender, EventArgs e) => this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);

        private void optionCaptureToShare_Click(object sender, EventArgs e) => CaptureToShare();

        private void infoApp_Click(object sender, EventArgs e)
        {
            lblSubHeader.Text = infoApp.Text;
            richDesc.Text = this.Text + "\n" +
                                    "Version: " + Program.GetCurrentVersionTostring() + "\n\n" +
                                    "It's all open source https://github.com/builtbybel/ThisIsWin11\n\n" +
                                    "MIT License\n\n" +
                                    "(C) 2021, Builtbybel";
        }

        private void CaptureToShare()
        {
            Form f = ActiveForm;
            Bitmap bmp = new Bitmap(f.Width, f.Height);
            f.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Title = "Location",
                Filter = "PNG Images|*.png",
                FileName = "ThisIsWin11-" + lblSubHeader.Text + "\x20" + osInfo.ComputerName
            };

            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                bmp.Save(dialog.FileName);

                MessageBox.Show("Click <OK> to prepare the Twitter status. After that you just need to upload the result image you just created." + dialog.FileName);
                Process.Start(Helpers.Strings.TweetIntent); // Tweet Web Intent
            }
        }
    }
}