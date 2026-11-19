using BussinessLayer;
using Microsoft.Win32;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroApp
{
    public class AppSettings
    {
        

        static private string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\PomodoroApp";
        

        public static void Load(ref int focusMinutes, ref int breakMinutes,ref int longBreakMinutes,ref int numOfSessionsForLongBreak,ref int defaultExtraAddMinutes,ref int rewardMinuteEach)
        {
            try
            {
                string sessionLength = Registry.GetValue(_keyPath, "sessionLength", null) as string;
                string breakLength = Registry.GetValue(_keyPath, "breakLength", null) as string;
                string longBreakLength = Registry.GetValue(_keyPath, "longBreakLength", null) as string;
                string sessionNumForLongBreak= Registry.GetValue(_keyPath, "sessionsNumForLongBreak", null) as string;
                string defaultExtraAddTime = Registry.GetValue(_keyPath, "defaultExtraAddTime", null) as string;
                string rewardMinEach = Registry.GetValue(_keyPath, "rewardMinEach", null) as string;



                focusMinutes = int.Parse(sessionLength);
                breakMinutes=int.Parse(breakLength);
                longBreakMinutes=int.Parse(longBreakLength);
                numOfSessionsForLongBreak = int.Parse(sessionNumForLongBreak);
                defaultExtraAddMinutes = int.Parse(defaultExtraAddTime);
                rewardMinuteEach = int.Parse(rewardMinEach);
            }
            catch (Exception ex)
            {
                focusMinutes = 50;
                breakMinutes = 15;
                longBreakMinutes = 60;
                numOfSessionsForLongBreak = 4;
                defaultExtraAddMinutes = 5;
                rewardMinuteEach = 3;
            } 

            

            
        }

        public static void Save(int sessionLength,int breakLength,int longBreakLength,int numOfSessionsForLongBreak, int defaultExtraAddMinutes,  int rewardMinuteEach)
        {
           
            try
            {
                Registry.SetValue(_keyPath, "sessionLength", sessionLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "breakLength", breakLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "longBreakLength", longBreakLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "sessionsNumForLongBreak", numOfSessionsForLongBreak.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "defaultExtraAddTime", defaultExtraAddMinutes.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "rewardMinEach", rewardMinuteEach.ToString(), RegistryValueKind.String);

                

            }
            catch (Exception ex) {

                throw new AccessViolationException("Can't save the settings");
            
            }

        }

        

    }
}
