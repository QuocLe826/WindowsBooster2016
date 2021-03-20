namespace Windows_Booster
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gb_SysInfo = new DevExpress.XtraEditors.GroupControl();
            this.lbProcessView = new DevExpress.XtraEditors.LabelControl();
            this.lbprocessor = new DevExpress.XtraEditors.LabelControl();
            this.lbArchitecture = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.lbOS = new System.Windows.Forms.Label();
            this.lbArchitectureView = new DevExpress.XtraEditors.LabelControl();
            this.lbMemoryView = new DevExpress.XtraEditors.LabelControl();
            this.lbOSView = new DevExpress.XtraEditors.LabelControl();
            this.cbxCleanTmpInternetFiles = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanPrefetchData = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanWindowsTempFiles = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanRecentItems = new DevExpress.XtraEditors.CheckEdit();
            this.cbxEmptyRecycleBin = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanInternetHistory = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanCookies = new DevExpress.XtraEditors.CheckEdit();
            this.cbxCleanTemporaryFiles = new DevExpress.XtraEditors.CheckEdit();
            this.List_SVC = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.cbxSpeedUpShutdown = new DevExpress.XtraEditors.CheckEdit();
            this.cbxSpeedUpMenuShow = new DevExpress.XtraEditors.CheckEdit();
            this.btnBoost = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.winCleanup = new DevExpress.XtraTab.XtraTabPage();
            this.services_manager = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.t_tweaks = new DevExpress.XtraTab.XtraTabPage();
            this.cbxDisableAutorun = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDisableSystemRestore = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDisableWinSideBar = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDisableSmartScreen = new DevExpress.XtraEditors.CheckEdit();
            this.cbxDisableCDBurningFeatures = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_SysInfo)).BeginInit();
            this.gb_SysInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanTmpInternetFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanPrefetchData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanWindowsTempFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanRecentItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmptyRecycleBin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanInternetHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanCookies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanTemporaryFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_SVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSpeedUpShutdown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSpeedUpMenuShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.winCleanup.SuspendLayout();
            this.services_manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).BeginInit();
            this.t_tweaks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableAutorun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableSystemRestore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableWinSideBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableSmartScreen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableCDBurningFeatures.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SysInfo
            // 
            this.gb_SysInfo.Controls.Add(this.lbProcessView);
            this.gb_SysInfo.Controls.Add(this.lbprocessor);
            this.gb_SysInfo.Controls.Add(this.lbArchitecture);
            this.gb_SysInfo.Controls.Add(this.lbRAM);
            this.gb_SysInfo.Controls.Add(this.lbOS);
            this.gb_SysInfo.Controls.Add(this.lbArchitectureView);
            this.gb_SysInfo.Controls.Add(this.lbMemoryView);
            this.gb_SysInfo.Controls.Add(this.lbOSView);
            this.gb_SysInfo.Location = new System.Drawing.Point(14, 12);
            this.gb_SysInfo.Name = "gb_SysInfo";
            this.gb_SysInfo.Size = new System.Drawing.Size(652, 144);
            this.gb_SysInfo.TabIndex = 0;
            this.gb_SysInfo.Text = "System Informations";
            this.gb_SysInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_SysInfo_Paint);
            // 
            // lbProcessView
            // 
            this.lbProcessView.Location = new System.Drawing.Point(12, 61);
            this.lbProcessView.Name = "lbProcessView";
            this.lbProcessView.Size = new System.Drawing.Size(51, 13);
            this.lbProcessView.TabIndex = 3;
            this.lbProcessView.Text = "Processor:";
            // 
            // lbprocessor
            // 
            this.lbprocessor.Location = new System.Drawing.Point(69, 61);
            this.lbprocessor.Name = "lbprocessor";
            this.lbprocessor.Size = new System.Drawing.Size(38, 13);
            this.lbprocessor.TabIndex = 2;
            this.lbprocessor.Text = "Unknow";
            // 
            // lbArchitecture
            // 
            this.lbArchitecture.AutoSize = true;
            this.lbArchitecture.Location = new System.Drawing.Point(84, 119);
            this.lbArchitecture.Name = "lbArchitecture";
            this.lbArchitecture.Size = new System.Drawing.Size(45, 13);
            this.lbArchitecture.TabIndex = 1;
            this.lbArchitecture.Text = "Unknow";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Location = new System.Drawing.Point(60, 91);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(45, 13);
            this.lbRAM.TabIndex = 1;
            this.lbRAM.Text = "Unknow";
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.Location = new System.Drawing.Point(111, 33);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(45, 13);
            this.lbOS.TabIndex = 1;
            this.lbOS.Text = "Unknow";
            // 
            // lbArchitectureView
            // 
            this.lbArchitectureView.Location = new System.Drawing.Point(12, 119);
            this.lbArchitectureView.Name = "lbArchitectureView";
            this.lbArchitectureView.Size = new System.Drawing.Size(66, 13);
            this.lbArchitectureView.TabIndex = 0;
            this.lbArchitectureView.Text = "Architecture: ";
            // 
            // lbMemoryView
            // 
            this.lbMemoryView.Location = new System.Drawing.Point(12, 91);
            this.lbMemoryView.Name = "lbMemoryView";
            this.lbMemoryView.Size = new System.Drawing.Size(45, 13);
            this.lbMemoryView.TabIndex = 0;
            this.lbMemoryView.Text = "Memory: ";
            // 
            // lbOSView
            // 
            this.lbOSView.Location = new System.Drawing.Point(12, 33);
            this.lbOSView.Name = "lbOSView";
            this.lbOSView.Size = new System.Drawing.Size(93, 13);
            this.lbOSView.TabIndex = 0;
            this.lbOSView.Text = "Operating System: ";
            // 
            // cbxCleanTmpInternetFiles
            // 
            this.cbxCleanTmpInternetFiles.Location = new System.Drawing.Point(217, 42);
            this.cbxCleanTmpInternetFiles.Name = "cbxCleanTmpInternetFiles";
            this.cbxCleanTmpInternetFiles.Properties.Caption = "Clean Temporary Internet Files";
            this.cbxCleanTmpInternetFiles.Size = new System.Drawing.Size(204, 19);
            this.cbxCleanTmpInternetFiles.TabIndex = 1;
            // 
            // cbxCleanPrefetchData
            // 
            this.cbxCleanPrefetchData.Location = new System.Drawing.Point(21, 92);
            this.cbxCleanPrefetchData.Name = "cbxCleanPrefetchData";
            this.cbxCleanPrefetchData.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCleanPrefetchData.Properties.Appearance.Options.UseForeColor = true;
            this.cbxCleanPrefetchData.Properties.Caption = "Clean Prefetch Data";
            this.cbxCleanPrefetchData.Size = new System.Drawing.Size(157, 19);
            this.cbxCleanPrefetchData.TabIndex = 0;
            // 
            // cbxCleanWindowsTempFiles
            // 
            this.cbxCleanWindowsTempFiles.Location = new System.Drawing.Point(21, 66);
            this.cbxCleanWindowsTempFiles.Name = "cbxCleanWindowsTempFiles";
            this.cbxCleanWindowsTempFiles.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCleanWindowsTempFiles.Properties.Appearance.Options.UseForeColor = true;
            this.cbxCleanWindowsTempFiles.Properties.Caption = "Clean Windows Temp Files";
            this.cbxCleanWindowsTempFiles.Size = new System.Drawing.Size(175, 19);
            this.cbxCleanWindowsTempFiles.TabIndex = 0;
            // 
            // cbxCleanRecentItems
            // 
            this.cbxCleanRecentItems.Location = new System.Drawing.Point(21, 41);
            this.cbxCleanRecentItems.Name = "cbxCleanRecentItems";
            this.cbxCleanRecentItems.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbxCleanRecentItems.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCleanRecentItems.Properties.Appearance.Options.UseBackColor = true;
            this.cbxCleanRecentItems.Properties.Appearance.Options.UseForeColor = true;
            this.cbxCleanRecentItems.Properties.Caption = " Clean Recent Items";
            this.cbxCleanRecentItems.Size = new System.Drawing.Size(157, 19);
            this.cbxCleanRecentItems.TabIndex = 0;
            // 
            // cbxEmptyRecycleBin
            // 
            this.cbxEmptyRecycleBin.Location = new System.Drawing.Point(217, 92);
            this.cbxEmptyRecycleBin.Name = "cbxEmptyRecycleBin";
            this.cbxEmptyRecycleBin.Properties.Caption = "Empty Recycle Bin";
            this.cbxEmptyRecycleBin.Size = new System.Drawing.Size(204, 19);
            this.cbxEmptyRecycleBin.TabIndex = 0;
            // 
            // cbxCleanInternetHistory
            // 
            this.cbxCleanInternetHistory.Location = new System.Drawing.Point(217, 67);
            this.cbxCleanInternetHistory.Name = "cbxCleanInternetHistory";
            this.cbxCleanInternetHistory.Properties.Caption = "Clean Internet History";
            this.cbxCleanInternetHistory.Size = new System.Drawing.Size(167, 19);
            this.cbxCleanInternetHistory.TabIndex = 0;
            // 
            // cbxCleanCookies
            // 
            this.cbxCleanCookies.Location = new System.Drawing.Point(217, 16);
            this.cbxCleanCookies.Name = "cbxCleanCookies";
            this.cbxCleanCookies.Properties.Caption = "Clean Cookies";
            this.cbxCleanCookies.Size = new System.Drawing.Size(98, 19);
            this.cbxCleanCookies.TabIndex = 0;
            // 
            // cbxCleanTemporaryFiles
            // 
            this.cbxCleanTemporaryFiles.Location = new System.Drawing.Point(21, 16);
            this.cbxCleanTemporaryFiles.Name = "cbxCleanTemporaryFiles";
            this.cbxCleanTemporaryFiles.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbxCleanTemporaryFiles.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCleanTemporaryFiles.Properties.Appearance.Options.UseBackColor = true;
            this.cbxCleanTemporaryFiles.Properties.Appearance.Options.UseForeColor = true;
            this.cbxCleanTemporaryFiles.Properties.Caption = "Clean Temporary Files";
            this.cbxCleanTemporaryFiles.Size = new System.Drawing.Size(157, 19);
            this.cbxCleanTemporaryFiles.TabIndex = 0;
            // 
            // List_SVC
            // 
            this.List_SVC.Cursor = System.Windows.Forms.Cursors.Default;
            this.List_SVC.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Bluetooth Support Service"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "Computer Browser"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "Family Safety"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("4", "Fax Service"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("5", "Smart Card"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("6", "Themes"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("7", "Offiline Files"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("8", "Remote Registry"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("9", "WebClient"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("10", "Windows Defender"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("11", "Windows Search"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("12", "Windows Error Reporting"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("13", "Windows Time")});
            this.List_SVC.Location = new System.Drawing.Point(9, 5);
            this.List_SVC.MultiColumn = true;
            this.List_SVC.Name = "List_SVC";
            this.List_SVC.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_SVC.Size = new System.Drawing.Size(482, 104);
            this.List_SVC.TabIndex = 0;
            // 
            // cbxSpeedUpShutdown
            // 
            this.cbxSpeedUpShutdown.Location = new System.Drawing.Point(203, 40);
            this.cbxSpeedUpShutdown.Name = "cbxSpeedUpShutdown";
            this.cbxSpeedUpShutdown.Properties.Caption = "Speed Up Shutdown Process";
            this.cbxSpeedUpShutdown.Size = new System.Drawing.Size(188, 19);
            this.cbxSpeedUpShutdown.TabIndex = 0;
            // 
            // cbxSpeedUpMenuShow
            // 
            this.cbxSpeedUpMenuShow.Location = new System.Drawing.Point(203, 15);
            this.cbxSpeedUpMenuShow.Name = "cbxSpeedUpMenuShow";
            this.cbxSpeedUpMenuShow.Properties.Caption = "Speed Up Menu Show";
            this.cbxSpeedUpMenuShow.Size = new System.Drawing.Size(188, 19);
            this.cbxSpeedUpMenuShow.TabIndex = 0;
            // 
            // btnBoost
            // 
            this.btnBoost.Appearance.BackColor = System.Drawing.Color.White;
            this.btnBoost.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBoost.Appearance.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoost.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBoost.Appearance.Options.UseBackColor = true;
            this.btnBoost.Appearance.Options.UseBorderColor = true;
            this.btnBoost.Appearance.Options.UseFont = true;
            this.btnBoost.Appearance.Options.UseForeColor = true;
            this.btnBoost.AppearancePressed.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoost.AppearancePressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnBoost.AppearancePressed.Options.UseFont = true;
            this.btnBoost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoost.Location = new System.Drawing.Point(232, 315);
            this.btnBoost.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBoost.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnBoost.Name = "btnBoost";
            this.btnBoost.Size = new System.Drawing.Size(171, 36);
            this.btnBoost.TabIndex = 3;
            this.btnBoost.Text = "BOOST NOW";
            this.btnBoost.Click += new System.EventHandler(this.btnBoost_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.xtraTabControl1.Location = new System.Drawing.Point(14, 162);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.winCleanup;
            this.xtraTabControl1.Size = new System.Drawing.Size(657, 152);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.winCleanup,
            this.services_manager,
            this.t_tweaks});
            // 
            // winCleanup
            // 
            this.winCleanup.Controls.Add(this.cbxCleanTemporaryFiles);
            this.winCleanup.Controls.Add(this.cbxCleanInternetHistory);
            this.winCleanup.Controls.Add(this.cbxCleanTmpInternetFiles);
            this.winCleanup.Controls.Add(this.cbxCleanCookies);
            this.winCleanup.Controls.Add(this.cbxEmptyRecycleBin);
            this.winCleanup.Controls.Add(this.cbxCleanRecentItems);
            this.winCleanup.Controls.Add(this.cbxCleanWindowsTempFiles);
            this.winCleanup.Controls.Add(this.cbxCleanPrefetchData);
            this.winCleanup.Name = "winCleanup";
            this.winCleanup.Size = new System.Drawing.Size(651, 124);
            this.winCleanup.Text = "Windows Cleanup";
            // 
            // services_manager
            // 
            this.services_manager.Controls.Add(this.labelControl1);
            this.services_manager.Controls.Add(this.toggleSwitch);
            this.services_manager.Controls.Add(this.List_SVC);
            this.services_manager.Name = "services_manager";
            this.services_manager.Size = new System.Drawing.Size(651, 124);
            this.services_manager.Text = "Services Manager";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(497, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Configure Services";
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Location = new System.Drawing.Point(497, 27);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.toggleSwitch.Properties.OffText = "Disable";
            this.toggleSwitch.Properties.OnText = "Enable";
            this.toggleSwitch.Properties.ValueOff = false;
            this.toggleSwitch.Size = new System.Drawing.Size(132, 24);
            this.toggleSwitch.TabIndex = 1;
            // 
            // t_tweaks
            // 
            this.t_tweaks.Controls.Add(this.cbxDisableAutorun);
            this.t_tweaks.Controls.Add(this.cbxDisableSystemRestore);
            this.t_tweaks.Controls.Add(this.cbxDisableWinSideBar);
            this.t_tweaks.Controls.Add(this.cbxDisableSmartScreen);
            this.t_tweaks.Controls.Add(this.cbxDisableCDBurningFeatures);
            this.t_tweaks.Controls.Add(this.cbxSpeedUpMenuShow);
            this.t_tweaks.Controls.Add(this.cbxSpeedUpShutdown);
            this.t_tweaks.Name = "t_tweaks";
            this.t_tweaks.Size = new System.Drawing.Size(651, 124);
            this.t_tweaks.Text = "Tweaks";
            // 
            // cbxDisableAutorun
            // 
            this.cbxDisableAutorun.Location = new System.Drawing.Point(203, 64);
            this.cbxDisableAutorun.Name = "cbxDisableAutorun";
            this.cbxDisableAutorun.Properties.Caption = "Disable AutoPlay For All Drives";
            this.cbxDisableAutorun.Size = new System.Drawing.Size(178, 19);
            this.cbxDisableAutorun.TabIndex = 5;
            // 
            // cbxDisableSystemRestore
            // 
            this.cbxDisableSystemRestore.Location = new System.Drawing.Point(23, 14);
            this.cbxDisableSystemRestore.Name = "cbxDisableSystemRestore";
            this.cbxDisableSystemRestore.Properties.Caption = "Disable System Restore";
            this.cbxDisableSystemRestore.Size = new System.Drawing.Size(132, 19);
            this.cbxDisableSystemRestore.TabIndex = 4;
            // 
            // cbxDisableWinSideBar
            // 
            this.cbxDisableWinSideBar.Location = new System.Drawing.Point(23, 90);
            this.cbxDisableWinSideBar.Name = "cbxDisableWinSideBar";
            this.cbxDisableWinSideBar.Properties.Caption = "Disable Windows Sidebar";
            this.cbxDisableWinSideBar.Size = new System.Drawing.Size(165, 19);
            this.cbxDisableWinSideBar.TabIndex = 3;
            // 
            // cbxDisableSmartScreen
            // 
            this.cbxDisableSmartScreen.Location = new System.Drawing.Point(23, 65);
            this.cbxDisableSmartScreen.Name = "cbxDisableSmartScreen";
            this.cbxDisableSmartScreen.Properties.Caption = "Disable Windows SmartScreen";
            this.cbxDisableSmartScreen.Size = new System.Drawing.Size(174, 19);
            this.cbxDisableSmartScreen.TabIndex = 2;
            // 
            // cbxDisableCDBurningFeatures
            // 
            this.cbxDisableCDBurningFeatures.Location = new System.Drawing.Point(23, 40);
            this.cbxDisableCDBurningFeatures.Name = "cbxDisableCDBurningFeatures";
            this.cbxDisableCDBurningFeatures.Properties.Caption = "Disable CD Burning Features";
            this.cbxDisableCDBurningFeatures.Size = new System.Drawing.Size(165, 19);
            this.cbxDisableCDBurningFeatures.TabIndex = 1;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.BorderColor = System.Drawing.Color.Red;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 358);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnBoost);
            this.Controls.Add(this.gb_SysInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Booster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_closing);
            ((System.ComponentModel.ISupportInitialize)(this.gb_SysInfo)).EndInit();
            this.gb_SysInfo.ResumeLayout(false);
            this.gb_SysInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanTmpInternetFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanPrefetchData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanWindowsTempFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanRecentItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmptyRecycleBin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanInternetHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanCookies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCleanTemporaryFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List_SVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSpeedUpShutdown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSpeedUpMenuShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.winCleanup.ResumeLayout(false);
            this.services_manager.ResumeLayout(false);
            this.services_manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).EndInit();
            this.t_tweaks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableAutorun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableSystemRestore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableWinSideBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableSmartScreen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDisableCDBurningFeatures.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb_SysInfo;
        private DevExpress.XtraEditors.CheckEdit cbxCleanTemporaryFiles;
        private DevExpress.XtraEditors.CheckEdit cbxCleanWindowsTempFiles;
        private DevExpress.XtraEditors.CheckEdit cbxCleanRecentItems;
        private DevExpress.XtraEditors.CheckEdit cbxCleanPrefetchData;
        private DevExpress.XtraEditors.CheckEdit cbxEmptyRecycleBin;
        private DevExpress.XtraEditors.CheckEdit cbxCleanInternetHistory;
        private DevExpress.XtraEditors.CheckEdit cbxCleanCookies;
        private System.Windows.Forms.Label lbArchitecture;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.Label lbOS;
        private DevExpress.XtraEditors.LabelControl lbArchitectureView;
        private DevExpress.XtraEditors.LabelControl lbMemoryView;
        private DevExpress.XtraEditors.LabelControl lbOSView;
        private DevExpress.XtraEditors.SimpleButton btnBoost;
        private DevExpress.XtraEditors.CheckEdit cbxSpeedUpShutdown;
        private DevExpress.XtraEditors.CheckEdit cbxSpeedUpMenuShow;
        private DevExpress.XtraEditors.CheckEdit cbxCleanTmpInternetFiles;
        private DevExpress.XtraEditors.LabelControl lbprocessor;
        private DevExpress.XtraEditors.LabelControl lbProcessView;
        private DevExpress.XtraEditors.CheckedListBoxControl List_SVC;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage services_manager;
        private DevExpress.XtraTab.XtraTabPage winCleanup;
        private DevExpress.XtraTab.XtraTabPage t_tweaks;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit cbxDisableCDBurningFeatures;
        private DevExpress.XtraEditors.CheckEdit cbxDisableSmartScreen;
        private DevExpress.XtraEditors.CheckEdit cbxDisableWinSideBar;
        private DevExpress.XtraEditors.CheckEdit cbxDisableSystemRestore;
        private DevExpress.XtraEditors.CheckEdit cbxDisableAutorun;
    }
}

