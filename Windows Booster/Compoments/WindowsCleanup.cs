using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;

namespace WindowsBoosters.Compoments
{
    class WindowsCleanup
    {
        #region Properties
        //================Empty Recycle Bin========================//
        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000002,
            SHRB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        //================Empty Recycle Bin========================//

        private static string TempFolder = Environment.ExpandEnvironmentVariables("%TEMP%");
        private static string Recent = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\Microsoft\\Windows\\Recent");
        private static string Prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\Prefetch");
        private static string TempWindows = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\Temp");
        private static string WIN_DOWNLOAD_DATA = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%\\SoftwareDistribution\\Download");
        private static string Temporary_Internet_Files = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
        private static string Cookies = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
        private static string InternetHistory = Environment.GetFolderPath(Environment.SpecialFolder.History);
        #endregion

        #region Methods
        public WindowsCleanup() { }
        ~WindowsCleanup()
        {
            TempFolder = null;
            Recent = null;
            Prefetch = null;
            TempWindows = null;
            WIN_DOWNLOAD_DATA = null;
            Temporary_Internet_Files = null;
            Cookies = null;
        }
        public static void EmptyFolderContents(string foldername)
        {

            foreach (var folder in Directory.GetDirectories(foldername))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }

            foreach (var file in Directory.GetFiles(foldername))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
        }
        public static void CleanTempFolder()
        {
            EmptyFolderContents(TempFolder);
        }
        public static void CleanRecents()
        {
            EmptyFolderContents(Recent);
        }
        public static void CleanPrefetch()
        {
            EmptyFolderContents(Prefetch);
        }
        public static void CleanTempWindows()
        {
            EmptyFolderContents(TempWindows);
        }
        public static void CleanRunHistory()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU", true);
            try
            {
                foreach (string keyName in key.GetSubKeyNames())
                {
                    key.DeleteSubKey(keyName);
                }
            }
            catch
            {
                MessageBox.Show("Can't Delete Run History", "Windows Booster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CleanCookies()
        {
            EmptyFolderContents(Cookies);
        }
        public static void CleanInternetHistory()
        {
            EmptyFolderContents(InternetHistory);
        }
        public static void Clean_Windows_Download_Data()
        {
            EmptyFolderContents(WIN_DOWNLOAD_DATA);
        }
        public static void Clean_Temporary_Internet_Files()
        {
            EmptyFolderContents(Temporary_Internet_Files);
        }
        public static void CleanRecycleBin()
        {
            try
            {
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }

        public static void Excute_WindowsCleanup(List<DevExpress.XtraEditors.CheckEdit> cbxList, out bool is_excute)
        {
            is_excute = false;
            foreach (DevExpress.XtraEditors.CheckEdit items in cbxList)
            {
                if (items.Checked == true)
                { Excute(items); is_excute = true; }
            }
        }
        public static void Excute(DevExpress.XtraEditors.CheckEdit items)
        {
            if (items.Text == "Clean Temporary Files")
                CleanTempFolder();
            if (items.Text == " Clean Recent Items")
                CleanRecents();
            if (items.Text == "Clean Windows Temp Files")
                CleanTempWindows();
            if (items.Text == "Clean Prefetch Data")
                CleanPrefetch();
            if (items.Text == "Clean Cookies")
                CleanCookies();
            if (items.Text == "Clean Temporary Internet Files")
                Clean_Temporary_Internet_Files();
            if (items.Text == "Clean Internet History")
                CleanInternetHistory();
            if (items.Text == "Empty Recycle Bin")
                CleanRecycleBin();
        }
        #endregion
    }
}