using System;
using Microsoft.Win32;
namespace WindowsBoosters.Compoments
{
    class SystemInfo
    {
        public SystemInfo() { }
        public static string getSysType()
        {
            if (Environment.Is64BitOperatingSystem)
                return "64-Bit";
            return "32-Bit";
        }
        public static string getOSName()
        {
            RegistryKey os_key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",true);
            string os_ver = os_key.GetValue("CurrentVersion").ToString();
            return os_key.GetValue("ProductName").ToString();
        }
        public static string getRAM()
        {
            double RAM = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1048576;
            return RAM.ToString() + " MB";
        }
        public static string getProcessor()
        {
             RegistryKey key = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", false);
             return key.GetValue("ProcessorNameString").ToString();
        }
    }
}
