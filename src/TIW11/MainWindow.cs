using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsWin11
{
    public partial class MainWindow : Form
    {
        private PageTitle INavPage = PageTitle.Welcome;
        private ThisIsWin11.Features.OS osInfo = new ThisIsWin11.Features.OS();

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
                lnkSubHeader.Text = "Windows 11 aka Sun Valley" + "\x20"
                          + osInfo.GetVersion() + "\x20"
                          + osInfo.Is64Bit();
            }
            else
            {
                btnPresenter.Enabled = false;
                lnkSubHeader.Text = "This is not Windows 11";
            }

            btnSettings.Text = "\uE713";        // Settings
            btnRecheck.Text = "\ue72c";        // Reset

            // Some tooltip options
            ToolTip tt = new ToolTip
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

        public void NavigationView()
        {
            btnPrev.Enabled = INavPage > PageTitle.Welcome;

            switch (INavPage)
            {
                case PageTitle.Welcome:
                    lblFeature.Text = "Welcome";
                    richDesc.Text = "How to use\nUse the<Next> and<Previous> buttons to navigate through the features of Windows 11.\n\n" +
                                    "Use the <Show the Magic> button to get the feature presented once (if it is available).\n\n" +
                                    "If you are not yet working with Windows 11, the <Magic> button will unfortunately not work.";
                    pbView.ImageLocation = "";
                    break;

                case PageTitle.NewLook:
                    lblFeature.Text = "A new look";
                    richDesc.Text = "As you already see, Windows 11 features a clean design with rounded corners, pastel shades and a centered Start menu and Taskbar.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/1-look.png?raw=true";
                    break;

                case PageTitle.StartMenu:
                    lblFeature.Text = "New Start Menu";
                    richDesc.Text = "Of all the new Windows 11 features, the new launcher-style floating Start Menu is the most distinctive part of Microsoft’s next-gen desktop OS.\n\n" +
                                        "Unlike the traditional Start Menu, the new Start — as Microsoft is calling it — sits right at the center of the taskbar.\n\n" +
                                        "It has a flyout design with pinned and recommended apps accompanying each other. So far in my usage, the recommendations are pretty good. It quickly offers me access to documents, photos, and apps I have recently installed.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/2-startmenu.png?raw=true";
                    break;

                case PageTitle.ActionCenter:

                    lblFeature.Text = "Action Center";
                    richDesc.Text = "Another great feature of Windows 11 is the revamped Action Center.\n\n" +
                                    "It follows a design language that we have seen on mobile OSes, and I quite like this mobile - first approach to important system toggles\n\n" +
                                    "You can now simply click on the unified “WiFi, volume and battery” button to open the new Action Center. It packs all the necessary controls, including brightness and volume sliders. You can also add more toggles like before.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/3-actioncenter.png?raw=true";
                    break;

                case PageTitle.FileExplorer:
                    lblFeature.Text = "Modern File Explorer";
                    richDesc.Text = "The new experience of file explorer didn’t come with multiple Tabs options similar to tabs in the Microsoft Edge browser.\n\n" +
                                     "By default, File Explorer is now optimized for tablet users.\n\n" +
                                    "The File Explorer interface is not changing dramatically, but there are several noticeable changes. For example, Microsoft is replacing the Windows 8-era ribbon toolbar with a redesigned top menu called command bar allowing you quick access to commonly used actions like share, delete, rename, etc";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/4-fileexplorer.png?raw=true";
                    break;

                case PageTitle.MicrosoftStore:
                    lblFeature.Text = "New Microsoft Store";
                    richDesc.Text = "There’s a complete UI overhaul on the app store and some speed improvements.\n\n" +
                           "The key change is allowing more apps into the store. The Microsoft Store is changing on Windows 11, and eventually Windows 10, to include any traditional desktop apps.\n\n" +
                           "Microsoft previously restricted developers to its Universal Windows Apps, before then allowing some desktop apps that were packaged to use its store for updates. Now any app can be part of the store, a move that aligns with the Windows Package Manager Microsoft released last year.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/5-msstore.png?raw=true";
                    break;

                case PageTitle.SettingsApp:
                    lblFeature.Text = "Redesigned Settings App";
                    richDesc.Text = "The Settings app has been redesigned with a radically different look and it is now using a new navigation menu on the left, similar to Control Panel.\n\n" +
                              "It comes with a slightly reorganized layout which enables easier access to all your PC settings.\n\n" +
                              "We’re also getting new pages to customize the touch keyboard, Windows snapping, multitasking and other advanced features like “Wake on Touch” in the new operating system.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/6-settingsapp.png?raw=true";
                    break;

                case PageTitle.WindowsUpdates:
                    lblFeature.Text = "Faster Windows Updates";
                    richDesc.Text = "Yes, you read that right. With Windows 11, you will have a much faster Windows update process, thanks to the background installation mechanism. Microsoft has promised that Windows updates will now be 40% smaller, making the process even more efficient. ";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/7-windowsupdates.png?raw=true";
                    break;

                case PageTitle.SnapLayouts:
                    lblFeature.Text = "Snap Layouts";
                    richDesc.Text = "Snap is a productivity feature that helps users arrange applications and other windows logically on-screen.\n\n" +
                        "In 2019, Microsoft relaunched the PowerToys brand with a new utility called FancyZones that extends the Snap experience to allow for more complex and useful on-screen window layouts. A key part of this utility, incredibly, has been integrated into Windows 11 and is now called Snap Layouts.\n\n" +
                        "When you're working in a bunch of open windows, Windows 11 will let you arrange them in different layouts on the screen, and will save all of those windows in that arrangement. ";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/8-snaplayouts.png?raw=true";
                    break;

                case PageTitle.Widgets:
                    lblFeature.Text = "Widgets";
                    richDesc.Text = "With Windows 11, Microsoft has brought Widgets, where you can find all kinds of information with just a click. It’s similar to Google Assistant’s Snapshot and the “Today View” in Apple’s iOS 15 or macOS Monterey.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/9-widgets.png?raw=true";
                    break;

                case PageTitle.GestureControls:
                    lblFeature.Text = "Advanced Gesture Controls";
                    richDesc.Text = "Gestures have long been part of Windows 10, but frankly speaking, they were not very smooth, and the transitions between apps and virtual desktops were awful. With the new Advanced Gesture Controls and mandatory precision touchpad requirement for Windows 11, things might get better.\n\n" +
                                    "Now, you can customize three-finger and four-finger swipes according to your preference.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/10-gestures.png?raw=true";
                    break;

                case PageTitle.WallpapersNSounds:
                    lblFeature.Text = "New Wallpapers && Sounds";
                    richDesc.Text = "Along with Windows 11, Microsoft has also brought a series of beautiful wallpapers, sounds, and themes. Wallpapers such as Captured Motion, Flow, Sunrise, Glow are some of the nicest wallpapers you can find on a desktop OS.\n\n" +
                                    "Also, the startup and notification sound is really good.\nPress the Magic Button to listen to the startup sound.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/11-wallpapers.png?raw=true";
                    break;

                case PageTitle.LockScreen:
                    lblFeature.Text = "New Minimal Lock Screen";
                    richDesc.Text = "Windows 11 supports animated lock-screen background on PCs that have accelerometer.\n\n" +
                                    "It applies an acrylic blur in the background, and the new variable Segoe UI font makes things even better. If you don’t want all the links and recommendations on the lock screen, you can disable them from Settings for a clean lock screen.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/12-lockscreen.png?raw=true";
                    break;

                case PageTitle.TouchKeyboard:
                    lblFeature.Text = "Touch Keyboard Improvements";
                    richDesc.Text = "Windows 11 comes with a Touch Keyboard feature that remains turned off by default. You can use this touch keyboard on a computer or laptop, which is not a touch screen. It is a handy application if your physical keyboard is totally not working or a few keys are not working.\n\n" +
                                "Microsoft made it more intuitive to use by drawing inspiration from smartphone keyboards.\n\nEven you can use this Touch Keyboard as a substitute for a mechanical keyboard.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/13-touchkeyboard.jpg?raw=true";
                    break;

                case PageTitle.AndroidApps:
                    lblFeature.Text = "Android Apps Support";
                    richDesc.Text = "Android apps will be coming to Windows 11 and installable from within the new Microsoft Store via the Amazon Appstore.\n\n" +
                        "However, Android app support has not been added in the current 22000.51 preview build. Microsoft has confirmed that the option to install Android apps will arrive in the upcoming builds.\n\n" +
                        "The best part is that you can even sideload APKs on your Windows 11 PC.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/14-androidapps.png?raw=true";
                    break;

                case PageTitle.Thanks:
                    lblFeature.Text = "That's it";
                    richDesc.Text = "Thanks for using me.\n\nPlease use the magic button one last time.";
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/15-thanks.png?raw=true";
                    break;
            }
        }

        private void btnPrev_Click(object sender, System.EventArgs e)
        {
            if (INavPage > PageTitle.Welcome)
            {
                INavPage--;
            }

            NavigationView();
            Helpers.Utils.AppUpdate(); // Update check
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            INavPage++;
            NavigationView();
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
                        ThisIsWin11.Features.LockScreen.LockWorkStation();
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

                case PageTitle.Thanks:

                    if (MessageBox.Show("Thanks for the tour!\n\n"
                        + "You might want to look for app updates so that the next tour will be even more exciting?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // New release available!
                    {
                        Helpers.Utils.AppUpdate();
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

        private void richDesc_LinkClicked(object sender, LinkClickedEventArgs e) => ThisIsWin11.Helpers.Utils.LaunchUri(e.LinkText);

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("ms-settings:about");

        private void btnSettings_Click(object sender, EventArgs e) => this.menuMain.Show(Cursor.Position.X, Cursor.Position.Y);

        private void optionCaptureToShare_Click(object sender, EventArgs e) => CaptureToShare();

        private void infoApp_Click(object sender, EventArgs e)
        {
            richDesc.Text = "Info about this App\n" +
                                    Program.GetCurrentVersionTostring() + "\n\n" +
                                    "It's all open source https://github.com/builtbybel/ThisIsWin11\n\n" +
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
                FileName = "ThisIsWin11-" + lblFeature.Text + "\x20" + osInfo.ComputerName
            };

            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                bmp.Save(dialog.FileName);

                MessageBox.Show("Click <OK> to prepare the Twitter status. After that you just need to upload the result image you just created." + dialog.FileName);
                Process.Start(Helpers.Strings.TweetIntent); // Tweet Web Intent
            }
        }

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
    }
}