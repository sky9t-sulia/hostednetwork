using Microsoft.Win32;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace VirtualWiFi
{
    public partial class VirtualWiFi : Form
    {
        public VirtualWiFi()
        {
            InitializeComponent();
        }

        public void Init() {
            tray.Visible = false;
            if (Properties.Settings.Default.isStartup == true) {
                startupTool.CheckState = CheckState.Checked;
            }
            ssid.Text = Properties.Settings.Default.ssid;
            passTextBox.Text = Properties.Settings.Default.password;
            var lang = Properties.Settings.Default.currentLang;
            SetLanguage(lang);
        }

        private void Launch(string ssid, string pass) {
            ExecuteCommand("@echo Resetting hosted network...");
            ExecuteCommand("netsh wlan set hostednetwork mode = disallow");
            ExecuteCommand("netsh wlan set hostednetwork mode = allow");
            ExecuteCommand("@echo Hosted network resetted...");
            ExecuteCommand("@echo Starting hosted network...");
            ExecuteCommand("netsh wlan set hostednetwork ssid = " + ssid + " key = " + pass);
            ExecuteCommand("netsh wlan start hostednetwork");
            console.Items.Add("********************************************************************");
            console.Items.Add("");
            Properties.Settings.Default.isLaunched = true;
            startStopBtn.Text = GetTextFromRes("launchStop", Properties.Settings.Default.currentLang);
            launched.Text = GetTextFromRes("launched", Properties.Settings.Default.currentLang);
            stopped.Text = "";
        }

        private void Stop() {
            ExecuteCommand("@echo Stopping hosted network...");
            ExecuteCommand("netsh wlan stop hostednetwork");
            console.Items.Add("********************************************************************");
            console.Items.Add("");
            Properties.Settings.Default.isLaunched = false;
            startStopBtn.Text = GetTextFromRes("launchStart", Properties.Settings.Default.currentLang);
            stopped.Text = GetTextFromRes("stopped", Properties.Settings.Default.currentLang);
            launched.Text = "";
        }


        public void ExecuteCommand(string command) {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            console.Items.Add((String.IsNullOrEmpty(output) ? "(none)" : output));
            console.Items.Add((String.IsNullOrEmpty(error) ? "" : error));
            process.Close();
        }

        private void SetLanguage(string lang) {
            if(lang == "") { lang = "english"; }

            if (Properties.Settings.Default.isLaunched) {
                stopped.Text = "";
                launched.Text = GetTextFromRes("launched", lang);
                startStopBtn.Text = GetTextFromRes("launchStop", lang);
            } else {
                launched.Text = "";
                stopped.Text = GetTextFromRes("stopped", lang);
                startStopBtn.Text = GetTextFromRes("launchStart", lang);
            }
            startupTool.Text = GetTextFromRes("startuptool", lang);
            minToTrayTool.Text = GetTextFromRes("hidetotraytool", lang);
            ssidLabel.Text = GetTextFromRes("ssidlabel", lang);
            pwdLabel.Text = GetTextFromRes("pwdlabel", lang);
            settingsTool.Text = GetTextFromRes("settingstool", lang);
            languageTool.Text = GetTextFromRes("languagetool", lang);
            aboutTool.Text = GetTextFromRes("abouttool", lang);
            openConsoleBtn.Text = GetTextFromRes("console", lang);
        }

        private string GetTextFromRes(string key, string lang) {
            if(lang == "") { lang = "english"; }
            ResourceManager rm = new ResourceManager("VirtualWiFi." + lang, GetType().Assembly);
            var entry =
                rm.GetResourceSet(System.Threading.Thread.CurrentThread.CurrentCulture, true, true)
                  .OfType<DictionaryEntry>()
                  .FirstOrDefault(e => e.Key.ToString() == key);
            var value = entry.Value.ToString();
            return value;
        }

        private void SetRussianLang(object sender, EventArgs e) {
            Properties.Settings.Default.currentLang = "russian";
            SetLanguage("russian");
        }

        private void SetEnglishLang(object sender, EventArgs e) {
            Properties.Settings.Default.currentLang = "english";
            SetLanguage("english");
        }

        private void SaveSettings(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.isExpanded = false;
            Properties.Settings.Default.Save(); // Сохранить настройки
        }

        public void StartStopAction(object sender, EventArgs e) {
            if(ssid.Text.Length < 3) { ssid.BackColor = Color.Red; return; }
            if(passTextBox.Text.Length < 8) { passTextBox.BackColor = Color.Red; return; }
            var isLaunched = Properties.Settings.Default.isLaunched;
            if (!isLaunched) {
                var ssid = Properties.Settings.Default.ssid;
                var pwd =  Properties.Settings.Default.password;
                Launch(ssid, pwd);
            } else {
                Stop();
            }
        }

        private void SsidEntering(object sender, EventArgs e) {
            if(this.Text.Length > 3) { ssid.BackColor = SystemColors.Window; }
            Properties.Settings.Default.ssid = ssid.Text;
        }

        private void PassEentering(object sender, EventArgs e) {
            if(passTextBox.Text.Length >= 8 && passTextBox.BackColor != SystemColors.Window) {
                passTextBox.BackColor = SystemColors.Window;
            }
            Properties.Settings.Default.password = passTextBox.Text;
        }

        private void FormLoading(object sender, EventArgs e) {
            Init();
        }

        private void ConsoleButtonClick(object sender, EventArgs e) {
            expandTimer.Start();
        }

        private void ExpandConsole(object sender, EventArgs e) {
            if (Properties.Settings.Default.isExpanded == false) {
                if (this.Width <= 1200) {
                    this.Width += 40;
                } else {
                    Properties.Settings.Default.isExpanded = true;
                    expandTimer.Stop();
                }
            } else {
                if (this.Width > 299) {
                    this.Width -= 40;
                } else {
                    Properties.Settings.Default.isExpanded = false;
                    expandTimer.Stop();
                }
            }
        }

        private void AboutMessage(object sender, EventArgs e) {
            var msg = MessageBox.Show(GetTextFromRes("about",Properties.Settings.Default.currentLang),"VirtualWiFi",MessageBoxButtons.OK);
        }

        private void SetStartup(object sender, EventArgs e) {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (Properties.Settings.Default.isStartup == true) {
                startupTool.CheckState = CheckState.Unchecked;
                Properties.Settings.Default.isStartup = false;
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("VirtualWiFi", false);

            } else {
                startupTool.CheckState = CheckState.Checked;
                Properties.Settings.Default.isStartup = true;
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("VirtualWiFi", Application.ExecutablePath.ToString());
            }
        }
        bool firstTime = true;
        private void MinimizeToTray(object sender, EventArgs e) {
            this.ShowInTaskbar = false;
            tray.Visible = true;
            if (firstTime) {
                tray.ShowBalloonTip(2000);
                firstTime = false;
            }
            this.Hide();
        }

        private void TrayDoubleClick(object sender, MouseEventArgs e) {
            this.ShowInTaskbar = true;
            tray.Visible = false;
            this.Show();
        }
    }
}
