namespace VirtualWiFi
{
    partial class VirtualWiFi
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualWiFi));
            this.startStopBtn = new System.Windows.Forms.Button();
            this.launched = new System.Windows.Forms.Label();
            this.stopped = new System.Windows.Forms.Label();
            this.ssidLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.ssid = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.languageTool = new System.Windows.Forms.ToolStripMenuItem();
            this.englishTool = new System.Windows.Forms.ToolStripMenuItem();
            this.russianTool = new System.Windows.Forms.ToolStripMenuItem();
            this.minToTrayTool = new System.Windows.Forms.ToolStripMenuItem();
            this.startupTool = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openConsoleBtn = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.ListBox();
            this.expandTimer = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startStopBtn
            // 
            resources.ApplyResources(this.startStopBtn, "startStopBtn");
            this.startStopBtn.FlatAppearance.BorderSize = 0;
            this.startStopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopAction);
            // 
            // launched
            // 
            resources.ApplyResources(this.launched, "launched");
            this.launched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.launched.Name = "launched";
            // 
            // stopped
            // 
            resources.ApplyResources(this.stopped, "stopped");
            this.stopped.Name = "stopped";
            // 
            // ssidLabel
            // 
            resources.ApplyResources(this.ssidLabel, "ssidLabel");
            this.ssidLabel.Name = "ssidLabel";
            // 
            // pwdLabel
            // 
            resources.ApplyResources(this.pwdLabel, "pwdLabel");
            this.pwdLabel.Name = "pwdLabel";
            // 
            // ssid
            // 
            resources.ApplyResources(this.ssid, "ssid");
            this.ssid.Name = "ssid";
            this.ssid.TextChanged += new System.EventHandler(this.SsidEntering);
            // 
            // passTextBox
            // 
            resources.ApplyResources(this.passTextBox, "passTextBox");
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.TextChanged += new System.EventHandler(this.PassEentering);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTool,
            this.aboutTool});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsTool
            // 
            resources.ApplyResources(this.settingsTool, "settingsTool");
            this.settingsTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageTool,
            this.minToTrayTool,
            this.startupTool});
            this.settingsTool.Name = "settingsTool";
            // 
            // languageTool
            // 
            resources.ApplyResources(this.languageTool, "languageTool");
            this.languageTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.languageTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.languageTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishTool,
            this.russianTool});
            this.languageTool.Name = "languageTool";
            // 
            // englishTool
            // 
            resources.ApplyResources(this.englishTool, "englishTool");
            this.englishTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.englishTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.englishTool.Name = "englishTool";
            this.englishTool.Click += new System.EventHandler(this.SetEnglishLang);
            // 
            // russianTool
            // 
            resources.ApplyResources(this.russianTool, "russianTool");
            this.russianTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.russianTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.russianTool.Name = "russianTool";
            this.russianTool.Click += new System.EventHandler(this.SetRussianLang);
            // 
            // minToTrayTool
            // 
            resources.ApplyResources(this.minToTrayTool, "minToTrayTool");
            this.minToTrayTool.BackColor = System.Drawing.Color.White;
            this.minToTrayTool.Name = "minToTrayTool";
            this.minToTrayTool.Click += new System.EventHandler(this.MinimizeToTray);
            // 
            // startupTool
            // 
            resources.ApplyResources(this.startupTool, "startupTool");
            this.startupTool.BackColor = System.Drawing.Color.White;
            this.startupTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startupTool.Name = "startupTool";
            this.startupTool.Click += new System.EventHandler(this.SetStartup);
            // 
            // aboutTool
            // 
            resources.ApplyResources(this.aboutTool, "aboutTool");
            this.aboutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutTool.Name = "aboutTool";
            this.aboutTool.Click += new System.EventHandler(this.AboutMessage);
            // 
            // openConsoleBtn
            // 
            resources.ApplyResources(this.openConsoleBtn, "openConsoleBtn");
            this.openConsoleBtn.FlatAppearance.BorderSize = 0;
            this.openConsoleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.openConsoleBtn.Name = "openConsoleBtn";
            this.openConsoleBtn.UseVisualStyleBackColor = true;
            this.openConsoleBtn.Click += new System.EventHandler(this.ConsoleButtonClick);
            // 
            // console
            // 
            resources.ApplyResources(this.console, "console");
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Name = "console";
            // 
            // expandTimer
            // 
            this.expandTimer.Interval = 2;
            this.expandTimer.Tick += new System.EventHandler(this.ExpandConsole);
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.tray, "tray");
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayDoubleClick);
            // 
            // VirtualWiFi
            // 
            this.AcceptButton = this.startStopBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.console);
            this.Controls.Add(this.openConsoleBtn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.ssidLabel);
            this.Controls.Add(this.stopped);
            this.Controls.Add(this.launched);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VirtualWiFi";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.FormLoading);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label launched;
        private System.Windows.Forms.Label stopped;
        private System.Windows.Forms.Label ssidLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox ssid;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsTool;
        private System.Windows.Forms.ToolStripMenuItem languageTool;
        private System.Windows.Forms.ToolStripMenuItem englishTool;
        private System.Windows.Forms.ToolStripMenuItem russianTool;
        private System.Windows.Forms.ToolStripMenuItem aboutTool;
        private System.Windows.Forms.Button openConsoleBtn;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.Timer expandTimer;
        private System.Windows.Forms.ToolStripMenuItem minToTrayTool;
        private System.Windows.Forms.ToolStripMenuItem startupTool;
        private System.Windows.Forms.NotifyIcon tray;
    }
}

