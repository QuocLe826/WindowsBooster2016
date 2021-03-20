using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace WindowsBoosters.Compoments
{
    class Tweaks
    {
        private static RegistryKey key;
        public Tweaks() { }
        public static void DisableSystemRestore()
        {
            string osDrive = Path.GetPathRoot(Environment.SystemDirectory);
            ManagementScope scope = new ManagementScope("\\\\localhost\\root\\default");
            ManagementPath path = new ManagementPath("SystemRestore");
            ObjectGetOptions options = new ObjectGetOptions();
            ManagementClass process = new ManagementClass(scope, path, options);
            ManagementBaseObject inParams = process.GetMethodParameters("Disable");
            inParams["Drive"] = osDrive;
            ManagementBaseObject outParams = process.InvokeMethod("Disable", inParams, null);
        }
        public static void AutoEndTask()
        {
            key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            key.SetValue("AutoEndTasks", 1, RegistryValueKind.String);
            key.Close();
        }
        public static void DisableSytemRestore()
        {
            key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore", true);
            if(key == null)
                key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore");
            try
            {
                key.SetValue("DisableSR", 00000001, RegistryValueKind.DWord);
                key.SetValue("DisableConfig", 00000001, RegistryValueKind.DWord);
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Can't Disable System Restore Service", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            key.Close();
        }
        public static void OptimizeMenuShowDelay()
        {
            key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            key.SetValue("MenuShowDelay", 000,RegistryValueKind.String);
            key.Close();
        }
        public static void OptimizeHungAppTimeOut()
        {
            key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (key == null)
                key = Registry.Users.CreateSubKey("Control Panel\\Desktop");
            key.SetValue("HungAppTimeout", 2000,RegistryValueKind.String);
            key.Close();
        }
        public static void OptimizeWaitKillSVC()
        {
            key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            if (key == null)
                key = Registry.Users.CreateSubKey("Control Panel\\Desktop");
            key.SetValue("WaitToKillAppTimeout", 2000,RegistryValueKind.String);
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control", true);
            if (key == null)
                key = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control");
            key.SetValue("WaitToKillServiceTimeout", 2000, RegistryValueKind.String);
            key.Close();
        }
        public static void DisableCDBurningDFeatures()
        {
            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoCDBurning", 00000001, RegistryValueKind.DWord);
            key.Close();
        }
        public static void DisableWindowsSmartScreen()
        {
            if (SystemInfo.getOSName().Contains("Windows 7") == true)
                DevExpress.XtraEditors.XtraMessageBox.Show("Windows SmartScreen not on Windows 7!", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", true);
                if (key == null)
                    key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer");
                key.SetValue("SmartScreenEnabled", "Off", RegistryValueKind.String);
                key.Close();
            }
        }
        public static void DisableWindowsSideBar()
        {
            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Windows\\Sidebar", true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Windows\\Sidebar");
            key.SetValue("TurnOffSidebar", 1, RegistryValueKind.DWord);
            key.Close();
        }
        public static void DisableAutorun()
        {
            key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
            key.SetValue("NoDriveTypeAutoRun", 0xFF, RegistryValueKind.DWord);
            key.Close();
        }
        public static void Excute_Tweaks(List<DevExpress.XtraEditors.CheckEdit> cbxList, out bool isExcute)
        {
            isExcute = false;
            foreach (DevExpress.XtraEditors.CheckEdit items in cbxList)
            {
                if (items.Checked == true)
                { Excute(items); isExcute = true; }
            }
        }
        public static void Excute(DevExpress.XtraEditors.CheckEdit items)
        {
            if (items.Text == "Disable System Restore") DisableSystemRestore();
            if (items.Text == "Disable CD Burning Features") DisableCDBurningDFeatures();
            if (items.Text == "Disable Windows SmartScreen") DisableWindowsSmartScreen();        
            if (items.Text == "Disable Windows Sidebar") DisableWindowsSideBar(); 
            if (items.Text == "Speed Up Menu Show") OptimizeMenuShowDelay();
            if (items.Text == "Speed Shutdown Process") { OptimizeHungAppTimeOut(); OptimizeWaitKillSVC(); AutoEndTask(); }
            if (items.Text == "Disable Autorun For All Drives") DisableAutorun();
        }
        ~Tweaks()
        {
            key = null;
        }
    }
}
