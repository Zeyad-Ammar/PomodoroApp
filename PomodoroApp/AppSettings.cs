using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Windows.Forms;
namespace PomodoroApp
{
    internal class AppSettings
    {
        

        static private string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\PomodoroApp";
        

        public static void Load(ref int focusMinutes, ref int breakMinutes)
        {
            try
            {
                string sessionLength = Registry.GetValue(_keyPath, "sessionLength", null) as string;
                string breakLength = Registry.GetValue(_keyPath, "breakLength", null) as string;


                focusMinutes = int.Parse(sessionLength);
                breakMinutes=int.Parse(breakLength);
            }
            catch (Exception ex)
            {
                focusMinutes = 50;
                breakMinutes = 15;
            } 

            

            
        }

        public static void Save(int sessionLength,int breakLength)
        {
            try
            {
                Registry.SetValue(_keyPath, "sessionLength", sessionLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "breakLength", breakLength.ToString(), RegistryValueKind.String);
            }
            catch (Exception ex) {

                MessageBox.Show("an error happened, try again");
            
            }

        }

     
    }
}
