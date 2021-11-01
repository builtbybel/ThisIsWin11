using System;
using System.Diagnostics;
using System.Windows.Forms;
using ThisIsWin11.Presenter;

namespace ThisIsWin11
{
    public partial class HomeWindow : Form
    {
        private Helpers.Utils utilInfo = new Helpers.Utils();
        private Presenter.OS osInfo = new Presenter.OS();
        private PageTitle INavPage = PageTitle.GetStarted;

        private static readonly string componentsVersion = "40";

        private void menuPresenterInfo_Click(object sender, EventArgs e) => MessageBox.Show("Presenter for Windows 11\nComponents Version: " + Program.GetCurrentVersionTostring() + "." + componentsVersion + " (EOL February 28, 2022)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private MainWindow mainForm = null;

        public HomeWindow(Form frm)
        {
            mainForm = frm as MainWindow;
            InitializeComponent();
        }

        private void HomeWindow_Shown(object sender, EventArgs e)
        {
            NavigationView();
            EnumTableOfContents();

            UISelection();
        }

        // Some UI nicety
        private void UISelection()
        {
            // Presenter button ONLY on Win11
            if (osInfo.IsWin11())
            {
                if (!Helpers.Utils.IsInet())
                    lnkSubHeader.Text = "We cannot connect to the Internet.\n Some functions of the Windows 11 Presenter module are not available.";
                else
                    lnkSubHeader.Text = "*Windows 11 aka Sun Valley" + "\x20"
                           + osInfo.GetVersion() + "\x20"
                           + osInfo.Is64Bit();
            }
            else
            {
                btnPresenter.Visible = false;
                lnkSubHeader.Text = "*This is not Windows 11 (some features are not available)";
            }

            btnPresenterMenu.Text = "\uE712";
            btnHome.Text = "\uE80F";
            btnBack.Text = "\uE72B";
            btnNext.Text = "\uE72A";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (INavPage > PageTitle.GetStarted)
            {
                INavPage = 0;
                cbTable.SelectedIndex = 0;
            }

            NavigationView();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            if (INavPage == PageTitle.Custom)
            {
                INavPage = 0;
                cbTable.SelectedIndex = 0;
                NavigationView();
            }
            else
            {
                INavPage++;
                NavigationView();

                cbTable.SelectedItem = INavPage++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (INavPage > PageTitle.GetStarted)
            {
                INavPage--;
                cbTable.SelectedItem = INavPage++;
            }

            NavigationView();
        }

        // Enum breadcrumbs to cb
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
            btnBack.Enabled = INavPage > PageTitle.GetStarted;

            switch (INavPage)
            {
                case PageTitle.GetStarted:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Hi " + Environment.UserName;
                    lblDesc.Text = "Lets make sure everything is set up how you want it.\n\nUse the <Next> and <Previous> buttons to run a guided tour of Windows 11.\n\n" +
                                    "Use the <Preview this page> button on the left panel to get the feature presented once (if it is available).\n" +
                                    "Pages marked with <Configure this page> will allow you to change immediately the Windows configuration.\n" +
                                    "Pages marked with <Customize this page> will allow you to apply custom tasks from the community.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/startpage.png?raw=true";

                    break;

                case PageTitle.NewLook:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "A new look";
                    lblDesc.Text = "As you already see, Windows 11 features a clean design with rounded corners, pastel shades and a centered Start menu and Taskbar.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-look.png?raw=true";

                    break;

                case PageTitle.StartMenu:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "New Start Menu";
                    lblDesc.Text = "Of all the new Windows 11 features, the new launcher-style floating Start Menu is the most distinctive part of Microsoft’s next-gen desktop OS.\n\n" +
                                        "Unlike the traditional Start Menu, the new Start — as Microsoft is calling it — sits right at the center of the taskbar.\n\n" +
                                        "It has a flyout design with pinned and recommended apps accompanying each other.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-startmenu.png?raw=true";

                    break;

                case PageTitle.ActionCenter:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Action Center";
                    lblDesc.Text = "Another great feature of Windows 11 is the revamped Action Center.\n\n" +
                                    "It follows a design language that we have seen on mobile OSes, and I quite like this mobile - first approach to important system toggles\n\n" +
                                    "You can now simply click on the unified “WiFi, volume and battery” button to open the new Action Center. It packs all the necessary controls, including brightness and volume sliders. You can also add more toggles like before.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-actioncenter.png?raw=true";

                    break;

                case PageTitle.FileExplorer:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Modern File Explorer";
                    lblDesc.Text = "The new experience of file explorer didn’t come with multiple Tabs options similar to tabs in the Microsoft Edge browser.\n\n" +
                                     "By default, File Explorer is now optimized for tablet users.\n\n" +
                                    "The File Explorer interface is not changing dramatically, but there are several noticeable changes. For example, Microsoft is replacing the Windows 8-era ribbon toolbar with a redesigned top menu called command bar allowing you quick access to commonly used actions like share, delete, rename, etc";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-fileexplorer.png?raw=true";

                    break;

                case PageTitle.MicrosoftStore:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "New Microsoft Store";
                    lblDesc.Text = "There’s a complete UI overhaul on the app store and some speed improvements.\n\n" +
                                   "The key change is allowing more apps into the store. The Microsoft Store is changing on Windows 11, and eventually Windows 10, to include any traditional desktop apps.\n\n" +
                                    "Microsoft previously restricted developers to its Universal Windows Apps, before then allowing some desktop apps that were packaged to use its store for updates. Now any app can be part of the store, a move that aligns with the Windows Package Manager Microsoft released last year.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-msstore.png?raw=true";

                    break;

                case PageTitle.SettingsApp:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Redesigned Settings App";
                    lblDesc.Text = "The Settings app has been redesigned with a radically different look and it is now using a new navigation menu on the left, similar to Control Panel.\n\n" +
                                    "It comes with a slightly reorganized layout which enables easier access to all your PC settings.\n\n" +
                                    "We’re also getting new pages to customize the touch keyboard, Windows snapping, multitasking and other advanced features like “Wake on Touch” in the new operating system.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-settingsapp.png?raw=true";

                    break;

                case PageTitle.WindowsUpdates:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Faster Windows Updates";
                    lblDesc.Text = "Yes, you read that right. With Windows 11, you will have a much faster Windows update process, thanks to the background installation mechanism. Microsoft has promised that Windows updates will now be 40% smaller, making the process even more efficient. ";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-windowsupdates.png?raw=true";

                    break;

                case PageTitle.SnapLayouts:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Snap Layouts";
                    lblDesc.Text = "Snap is a productivity feature that helps users arrange applications and other windows logically on-screen.\n\n" +
                                    "In 2019, Microsoft relaunched the PowerToys brand with a new utility called FancyZones that extends the Snap experience to allow for more complex and useful on-screen window layouts. A key part of this utility, incredibly, has been integrated into Windows 11 and is now called Snap Layouts.\n\n" +
                                    "When you're working in a bunch of open windows, Windows 11 will let you arrange them in different layouts on the screen, and will save all of those windows in that arrangement. ";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-snaplayouts.png?raw=true";

                    break;

                case PageTitle.Widgets:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Widgets";
                    lblDesc.Text = "With Windows 11, Microsoft has brought Widgets, where you can find all kinds of information with just a click. It’s similar to Google Assistant’s Snapshot and the “Today View” in Apple’s iOS 15 or macOS Monterey.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-widgets.png?raw=true";

                    break;

                case PageTitle.GestureControls:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Advanced Gesture Controls";
                    lblDesc.Text = "Gestures have long been part of Windows 10, but frankly speaking, they were not very smooth, and the transitions between apps and virtual desktops were awful. With the new Advanced Gesture Controls and mandatory precision touchpad requirement for Windows 11, things might get better.\n\n" +
                                    "Now, you can customize three-finger and four-finger swipes according to your preference.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-gestures.png?raw=true";

                    break;

                case PageTitle.WallpapersNSounds:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "New Wallpapers && Sounds";
                    lblDesc.Text = "Along with Windows 11, Microsoft has also brought a series of beautiful wallpapers, sounds, and themes. Wallpapers such as Captured Motion, Flow, Sunrise, Glow are some of the nicest wallpapers you can find on a desktop OS.\n\n" +
                                    "Also, the startup and notification sound is really good.\nPress the Magic Button to listen to the startup sound.\n\n" +
                                    "You will find great new wallpapers for Microsoft products also here https://wallpaperhub.app";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-wallpapers.png?raw=true";

                    break;

                case PageTitle.LockScreen:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "New Minimal Lock Screen";
                    lblDesc.Text = "Windows 11 supports animated lock-screen background on PCs that have accelerometer.\n\n" +
                                    "It applies an acrylic blur in the background, and the new variable Segoe UI font makes things even better. If you don’t want all the links and recommendations on the lock screen, you can disable them from Settings for a clean lock screen.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-lockscreen.png?raw=true";

                    break;

                case PageTitle.TouchKeyboard:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Touch Keyboard Improvements";
                    lblDesc.Text = "Windows 11 comes with a Touch Keyboard feature that remains turned off by default. You can use this touch keyboard on a computer or laptop, which is not a touch screen. It is a handy application if your physical keyboard is totally not working or a few keys are not working.\n\n" +
                                    "Microsoft made it more intuitive to use by drawing inspiration from smartphone keyboards.\n\nEven you can use this Touch Keyboard as a substitute for a mechanical keyboard.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-touchkeyboard.png?raw=true";
                    break;

                case PageTitle.AndroidApps:
                    btnPresenter.Visible = true;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "Android Apps Support";
                    lblDesc.Text = "Android apps will be coming to Windows 11 and installable from within the new Microsoft Store via the Amazon Appstore.\n\n" +
                                    "However, Android app support has not been added in the current 22000.51 preview build. Microsoft has confirmed that the option to install Android apps will arrive in the upcoming builds.\n\n" +
                                    "The best part is that you can even sideload APKs on your Windows 11 PC.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-androidapps.png?raw=true";

                    break;

                case PageTitle.Gaming:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Gaming";
                    lblDesc.Text = "If you're a gamer, Windows 11 was made for you and the following three features will make it great for gaming.\n\n" +
                                    "1. During the Windows 11 unveiling, Microsoft announced support for Auto HDR that would elevate the viewing experience while playing games.\n\n" +
                                    "HDR stands for High Dynamic Range, as opposed to SDR or Standard Dynamic Range. With a higher range of colors, HDR gives more vibrant and realistic colors to your video games and makes the sceneries look even better.\n\n" +
                                    "2. Microsoft also revealed that the DirectStorage API will come to Windows PCs. DirectStorage is an API that allows the GPU to load game data directly from the SSD and skip the CPU processing. With DirectStorage, the GPU processes and decompresses the data itself.\n\n" +
                                    "3. Windows 11 will have an deeper Implementation of the Xbox App. The Xbox app and Game Pass are built-in features, giving Game Pass Ultimate subscribers instant access to a massive catalog of video games along with Xbox Cloud Gaming.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-gaming.png?raw=true";

                    break;

                case PageTitle.Privacy:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Privacy";
                    lblDesc.Text = "One thing Microsoft didn't discuss is about Windows 11 privacy.\n\n" +
                                    "Since Windows 11 Home will essentially require a Microsoft account for most users, data harvesting is part of the package. \n\n" +
                                    "In Windows 11, you'll be able to continue editing cloud files per its algorithmically populated \"Recommended\" section in the new Start Menu.\n" +
                                    "Your browser history will sync between Edge on PC and Edge on mobile, as it already does. Your Skype and Teams conversations will sync as you'd expect too, and your Windows 11 features will migrate to new PCs if you upgrade.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-privacy.png?raw=true";

                    break;

                case PageTitle.Apps:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Apps";
                    lblDesc.Text = "First Windows 11 preview still insists with bloatware.\n\n" +
                                     "Apparently Windows 11 is also lighter than Windows 10 as for the preinstalled apps.\n\n" +
                                    "The good thing is that at least some of the Windows 10 apps aren’t installed. However, you will still have installed all the hoard of apps that belong to Microsoft, such as Mail and Calendar, Your Phone, Mixed Reality Portal, Solitaire Collection, Get Help, Paint 3D, XBox Game Bar, etc.\n\n" +
                                    "To uninstall pre-installed apps press <Customize this page> button.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/page-apps.png?raw=true";

                    break;

                case PageTitle.Finish:
                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = true;
                    btnCustomizer.Visible = false;
                    lblHeader.Text = "That's it";
                    lblDesc.Text = "We're finish setting up your device.";
                    pbView.Visible = true;
                    pbView.ImageLocation = "https://github.com/builtbybel/ThisIsWin11/blob/main/assets/pages/endpage.png?raw=true";

                    break;

                case PageTitle.Custom:

                    btnPresenter.Visible = false;
                    btnConfigurator.Visible = false;
                    btnCustomizer.Visible = true;
                    lblHeader.Text = "Community customizations";
                    lblDesc.Text = "You will find here custom tasks and script files to customize Windows 11 according to your wishes.\n\nTo open the customization page press <Customize this page> button.";
                    pbView.Visible = false;
                    pbView.ImageLocation = "";

                    break;
            }
        }

        private void btnPresenter_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (INavPage)
            {
                case PageTitle.GetStarted:

                    break;

                case PageTitle.NewLook:
                    Process.Start("ms-settings:personalization-background");

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
                        Presenter.LockScreen.LockWorkStation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }

                    break;

                case PageTitle.TouchKeyboard:

                    break;

                case PageTitle.AndroidApps:

                    try
                    {
                        Process.Start("https://blogs.windows.com/windows-insider/2021/10/20/announcing-android-apps-on-windows-11-preview-for-windows-insiders-in-the-beta-channel/");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                    break;

                case PageTitle.Gaming:

                    break;

                case PageTitle.Privacy:

                    break;

                case PageTitle.Apps:

                    break;

                case PageTitle.Finish:

                    btnHome.PerformClick();
                    break;

                case PageTitle.Custom:

                    break;
            }
        }

        private void btnConfigurator_Click(object sender, EventArgs e)
        {
            switch (INavPage)
            {
                case PageTitle.GetStarted:
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
                    Process.Start("ms-settings:mousetouchpad");
                    break;

                case PageTitle.WallpapersNSounds:
                    Process.Start("ms-settings:personalization-background");
                    break;

                case PageTitle.LockScreen:
                    Process.Start("ms-settings:lockscreen");

                    break;

                case PageTitle.TouchKeyboard:

                    Process.Start("ms-settings:easeofaccess-keyboard");
                    break;

                case PageTitle.AndroidApps:

                    break;

                case PageTitle.Gaming:
                    Process.Start("ms-settings:gaming-gamebar");
                    break;

                case PageTitle.Privacy:
                    Process.Start("ms-settings:privacy-general");
                    break;

                case PageTitle.Apps:

                    Process.Start("ms-settings:appsfeatures-app");

                    break;

                case PageTitle.Finish:

                    btnHome.PerformClick();

                    break;

                case PageTitle.Custom:

                    break;
            }
        }

        private void btnCustomizer_Click(object sender, EventArgs e)
        {
            switch (INavPage)
            {
                case PageTitle.MicrosoftStore:

                    mainForm.btnPackages.PerformClick();
                    break;

                case PageTitle.Apps:

                    mainForm.btnApps.PerformClick();
                    break;

                case PageTitle.Custom:

                    mainForm.btnAutomate.PerformClick();
                    break;

                default:

                    mainForm.btnSystem.PerformClick();
                    break;
            }
        }

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Helpers.Utils.IsInet()) Process.Start("ms-settings:windowsupdate-action");
            else Process.Start("ms-settings:network-status");
        }

        private void btnPresenterMenu_Click(object sender, EventArgs e) => this.menuPresenter.Show(Cursor.Position.X, Cursor.Position.Y);

        private void pbView_Paint(object sender, PaintEventArgs e) => pbView.Controls.Add(btnPresenter);
    }
}