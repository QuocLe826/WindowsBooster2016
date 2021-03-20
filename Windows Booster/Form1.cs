using System;
using System.Windows.Forms;
using WindowsBoosters.Compoments;
using System.Collections.Generic;
namespace Windows_Booster
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
            xtraTabControl1.LookAndFeel.SetSkinStyle("DevExpress Dark Style");
            if (SystemInfo.getOSName().Contains("Windows XP") == true || SystemInfo.getOSName().Contains("Windows Vista") == true)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Operating System not suitable!", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            AddItemsToWindowsCleanup();
            AddItemsToTweaks();
            
        }
        
        private void gb_SysInfo_Paint(object sender, PaintEventArgs e)
        {
            lbOS.Text = "Microsoft " + SystemInfo.getOSName().ToString();
            lbprocessor.Text = SystemInfo.getProcessor().ToString();
            lbRAM.Text = SystemInfo.getRAM().ToString();
            lbArchitecture.Text = SystemInfo.getSysType().ToString();     
        }
        List<DevExpress.XtraEditors.CheckEdit> cbxList_WC = new List<DevExpress.XtraEditors.CheckEdit>();
        List<DevExpress.XtraEditors.CheckEdit> cbxList_Tweaks = new List<DevExpress.XtraEditors.CheckEdit>();

        public void AddItemsToWindowsCleanup()
        {
            cbxList_WC.Add(cbxCleanTemporaryFiles);
            cbxList_WC.Add(cbxCleanRecentItems);
            cbxList_WC.Add(cbxCleanWindowsTempFiles);
            cbxList_WC.Add(cbxCleanPrefetchData);
            cbxList_WC.Add(cbxCleanCookies);
            cbxList_WC.Add(cbxCleanTmpInternetFiles);
            cbxList_WC.Add(cbxCleanInternetHistory);
            cbxList_WC.Add(cbxEmptyRecycleBin);
        }
        public void AddItemsToTweaks()
        {
            cbxList_Tweaks.Add(cbxDisableSystemRestore);
            cbxList_Tweaks.Add(cbxDisableCDBurningFeatures);
            cbxList_Tweaks.Add(cbxDisableSmartScreen);               
            cbxList_Tweaks.Add(cbxDisableWinSideBar);
            cbxList_Tweaks.Add(cbxSpeedUpMenuShow);
            cbxList_Tweaks.Add(cbxSpeedUpShutdown);
            cbxList_Tweaks.Add(cbxDisableAutorun);
        }

        private void btnBoost_Click(object sender, EventArgs e)
        {
            bool isExcute_WinCleanup;
            WindowsCleanup.Excute_WindowsCleanup(cbxList_WC, out isExcute_WinCleanup);

            WindowsServices.ChangeStatusServices(List_SVC, toggleSwitch);

            bool isExcute_Tweaks;
            Tweaks.Excute_Tweaks(cbxList_Tweaks, out isExcute_Tweaks);

            if (SystemInfo.getOSName().Contains("Windows 7") == true && cbxDisableSmartScreen.Checked == true && (cbxDisableSystemRestore.Checked == false && cbxDisableCDBurningFeatures.Checked == false && cbxDisableWinSideBar.Checked == false && cbxSpeedUpMenuShow.Checked == false && cbxSpeedUpShutdown.Checked == false && cbxDisableAutorun.Checked == false))
                isExcute_Tweaks = false;
            if (isExcute_WinCleanup == true || isExcute_Tweaks == true)
                DevExpress.XtraEditors.XtraMessageBox.Show("Boost Completed.", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }
    }
}
