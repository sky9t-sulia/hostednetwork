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
            this.startStopBtn.FlatAppearance.BorderSize = 0;
            this.startStopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.startStopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startStopBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.startStopBtn.Location = new System.Drawing.Point(120, 125);
            this.startStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(135, 75);
            this.startStopBtn.TabIndex = 0;
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.StartStopAction);
            // 
            // launched
            // 
            this.launched.AutoSize = true;
            this.launched.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.launched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.launched.Location = new System.Drawing.Point(13, 139);
            this.launched.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.launched.Name = "launched";
            this.launched.Size = new System.Drawing.Size(0, 19);
            this.launched.TabIndex = 1;
            // 
            // stopped
            // 
            this.stopped.AutoSize = true;
            this.stopped.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.stopped.Location = new System.Drawing.Point(13, 174);
            this.stopped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopped.Name = "stopped";
            this.stopped.Size = new System.Drawing.Size(0, 19);
            this.stopped.TabIndex = 2;
            // 
            // ssidLabel
            // 
            this.ssidLabel.AutoSize = true;
            this.ssidLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ssidLabel.Location = new System.Drawing.Point(13, 48);
            this.ssidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ssidLabel.Name = "ssidLabel";
            this.ssidLabel.Size = new System.Drawing.Size(0, 17);
            this.ssidLabel.TabIndex = 3;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwdLabel.Location = new System.Drawing.Point(13, 89);
            this.pwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(0, 17);
            this.pwdLabel.TabIndex = 4;
            // 
            // ssid
            // 
            this.ssid.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ssid.Location = new System.Drawing.Point(85, 41);
            this.ssid.Margin = new System.Windows.Forms.Padding(4);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(170, 27);
            this.ssid.TabIndex = 5;
            this.ssid.TextChanged += new System.EventHandler(this.SsidEntering);
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passTextBox.Location = new System.Drawing.Point(85, 82);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(170, 27);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.TextChanged += new System.EventHandler(this.PassEentering);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTool,
            this.aboutTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsTool
            // 
            this.settingsTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageTool,
            this.minToTrayTool,
            this.startupTool});
            this.settingsTool.Name = "settingsTool";
            this.settingsTool.Size = new System.Drawing.Size(12, 20);
            // 
            // languageTool
            // 
            this.languageTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.languageTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.languageTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishTool,
            this.russianTool});
            this.languageTool.Name = "languageTool";
            this.languageTool.Size = new System.Drawing.Size(152, 22);
            // 
            // englishTool
            // 
            this.englishTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.englishTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.englishTool.Name = "englishTool";
            this.englishTool.Size = new System.Drawing.Size(129, 22);
            this.englishTool.Text = "English";
            this.englishTool.Click += new System.EventHandler(this.SetEnglishLang);
            // 
            // russianTool
            // 
            this.russianTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.russianTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.russianTool.Name = "russianTool";
            this.russianTool.Size = new System.Drawing.Size(129, 22);
            this.russianTool.Text = "Русский";
            this.russianTool.Click += new System.EventHandler(this.SetRussianLang);
            // 
            // minToTrayTool
            // 
            this.minToTrayTool.BackColor = System.Drawing.Color.White;
            this.minToTrayTool.Name = "minToTrayTool";
            this.minToTrayTool.Size = new System.Drawing.Size(152, 22);
            this.minToTrayTool.Click += new System.EventHandler(this.MinimizeToTray);
            // 
            // startupTool
            // 
            this.startupTool.BackColor = System.Drawing.Color.White;
            this.startupTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startupTool.Name = "startupTool";
            this.startupTool.Size = new System.Drawing.Size(152, 22);
            this.startupTool.Click += new System.EventHandler(this.SetStartup);
            // 
            // aboutTool
            // 
            this.aboutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutTool.Name = "aboutTool";
            this.aboutTool.Size = new System.Drawing.Size(12, 20);
            this.aboutTool.Click += new System.EventHandler(this.AboutMessage);
            // 
            // openConsoleBtn
            // 
            this.openConsoleBtn.FlatAppearance.BorderSize = 0;
            this.openConsoleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.openConsoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openConsoleBtn.Location = new System.Drawing.Point(262, 37);
            this.openConsoleBtn.Name = "openConsoleBtn";
            this.openConsoleBtn.Size = new System.Drawing.Size(17, 162);
            this.openConsoleBtn.TabIndex = 8;
            this.openConsoleBtn.UseVisualStyleBackColor = true;
            this.openConsoleBtn.Click += new System.EventHandler(this.ConsoleButtonClick);
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.ItemHeight = 16;
            this.console.Location = new System.Drawing.Point(285, 39);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(887, 160);
            this.console.TabIndex = 9;
            // 
            // expandTimer
            // 
            this.expandTimer.Interval = 2;
            this.expandTimer.Tick += new System.EventHandler(this.ExpandConsole);
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.BalloonTipText = "VirtualWiFi is now minimized to tray.. Double Click to show main window.";
            this.tray.BalloonTipTitle = "VirtualWiFi";
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Visible = true;
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayDoubleClick);
            // 
            // VirtualWiFi
            // 
            this.AcceptButton = this.startStopBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(283, 211);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VirtualWiFi";
            this.Opacity = 0.99D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Virtual WiFi";
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

