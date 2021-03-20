using System.Diagnostics;
using DevExpress.XtraEditors;
using System.Collections.Generic;
namespace WindowsBoosters.Compoments
{
    class WindowsServices
    {
        #region Propertties
        //Bluetooth Support Service: bthserv
        //Computer Browser: Browser
        //Family Safety: WPCSvc
        //Fax: Fax
        //Smart card: SCardSvr
        //Themes: Themes
        //Offline Files: CscService
        //Remote Registry: RemoteRegistry
        //Web Client: WebClient
        //Windows Time: W32Time
        //WER: WerSvc
        //Windows Defender: WinDefend
        //Windows Search: WSearch
        private static List<string> svc_name = new List<string>() { "bthserv", "Browser", "WPCSvc", "Fax", "SCardSvr", "Themes", "CscService", "RemoteRegistry", "WebClient", "WinDefend", "WSearch", "WerSvc", "W32Time"};
        
        #endregion
        public WindowsServices()
        {
        }
        ~WindowsServices()
        {
            svc_name = null;
        }
        public static void AutomaticSvc(string name)
        {
            Process.Start("sc.exe", "start " + name);
            Process.Start("sc.exe", " config " + name + " start= auto");
        }
        public static void AutomaticSvc(int index)
        {
            Process.Start("sc.exe", "start " + svc_name[index]);
            Process.Start("sc.exe", " config " + svc_name[index] + " start= auto");
        }
        public static void ManualSvc(string name)
        {
            Process.Start("sc.exe", "stop " + name);
            Process.Start("sc.exe", " config " + name + " start= demand");
        }
        public static void DisableSvc(string name)
        {
            Process.Start("sc.exe", "stop " + name);
            Process.Start("sc.exe", " config " + name + " start= disabled");
        }
        public static void DisableSvc(int index)
        {
            Process.Start("sc.exe", "stop " + svc_name[index]);
            Process.Start("sc.exe", " config " + svc_name[index] + " start= disabled");
        }
        public static void EnableSVC_List(CheckedListBoxControl cbxList)
        {
            for (int i = 0; i < cbxList.CheckedItemsCount; i++)
                AutomaticSvc(int.Parse(cbxList.CheckedItems[i].ToString()));
        }
        public static void ChangeStatusServices(CheckedListBoxControl cbxList, ToggleSwitch toggleSwitch)
        {
            if (!toggleSwitch.IsOn)
            {
                for (int i = 0; i < cbxList.CheckedItemsCount; i++)
                {
                    Process.Start("sc.exe", "stop " + svc_name[i]);
                    Process.Start("sc.exe", " config " + svc_name[i] + " start= disabled");
                }
            }
            else
            {
                for (int i = 0; i < cbxList.CheckedItemsCount; i++)
                {
                    Process.Start("sc.exe", "start " + svc_name[i]);
                    Process.Start("sc.exe", " config " + svc_name[i] + " start= auto");
                }
            }
        }
    }
}
