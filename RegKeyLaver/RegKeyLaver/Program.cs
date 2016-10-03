using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegKeyLaver
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey rKey = Registry.ClassesRoot.OpenSubKey(@"Directory\shell", true);
            String[] names = rKey.GetSubKeyNames();
            foreach (String s in names)
            {
                Console.WriteLine(rKey.ToString());
                Console.ReadLine();
            }
            RegistryKey newKey = rKey.CreateSubKey("Tester");
           
            RegistryKey newSubKey = newKey.CreateSubKey("command");
            newSubKey.SetValue("", @"C:\Users\MZK\Desktop\TestAfRegShortcut.exe " + "\"" + "%1" + "\"");
            String[] namess = rKey.GetSubKeyNames();
            foreach (String s in namess)
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }
            Console.ReadLine();

            newSubKey.Close();
            newKey.Close();
            rKey.Close();
        }
    }
}
