using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PomodoroApp
{
    public static class AppSettings
    {
        
        static public int _sessionLength { get; private set; }
        static public int _breakLength { get; private set; }
        static public int _longBreakLength { get; private set; }
        static public int _numOfSessionsForLongBreak { get; private set; }
        static public int _defaultAddingTime { get; private set; }

        static public int _rewardMinEach { get; private set; }


        static private string _keyPath = @"HKEY_CURRENT_USER\SOFTWARE\PomodoroApp";
        

        public static void Load()
        {
            try
            {
                 _sessionLength = int.Parse(Registry.GetValue(_keyPath, "sessionLength", null) as string);
                 _breakLength = int.Parse(Registry.GetValue(_keyPath, "breakLength", null) as string);
                 _longBreakLength = int.Parse(Registry.GetValue(_keyPath, "longBreakLength", null) as string);
                 _numOfSessionsForLongBreak= int.Parse(Registry.GetValue(_keyPath, "sessionsNumForLongBreak", null) as string);
                 _defaultAddingTime = int.Parse(Registry.GetValue(_keyPath, "defaultExtraAddTime", null) as string);
                 _rewardMinEach = int.Parse(Registry.GetValue(_keyPath, "rewardMinEach", null) as string);



               
            }
            catch 
            {
                _sessionLength = 50;
                _breakLength =   15;
                _longBreakLength =  60;
                _numOfSessionsForLongBreak =  4;
                _defaultAddingTime =  5;
                _rewardMinEach =   3;
            } 

            

            
        }

        public static void Save(int sessionLength,int breakLength,int longBreakLength,int numOfSessionsForLongBreak, int defaultExtraAddMinutes,  int rewardMinuteEach)
        {
           
            try
            {


                _sessionLength = sessionLength;
                _breakLength = breakLength;
                _longBreakLength = longBreakLength;
                _numOfSessionsForLongBreak = numOfSessionsForLongBreak;
                _defaultAddingTime = defaultExtraAddMinutes;
                _rewardMinEach = rewardMinuteEach;

                Registry.SetValue(_keyPath, "sessionLength", sessionLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "breakLength", breakLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "longBreakLength", longBreakLength.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "sessionsNumForLongBreak", numOfSessionsForLongBreak.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "defaultExtraAddTime", defaultExtraAddMinutes.ToString(), RegistryValueKind.String);
                Registry.SetValue(_keyPath, "rewardMinEach", rewardMinuteEach.ToString(), RegistryValueKind.String);

                

            }
            catch (Exception ex) {

                throw new AccessViolationException("Can't save the settings because "+ ex.Message );
            
            }

        }

        private static int RewardBreakMinutes(int totalAddedTime)
        {
            return totalAddedTime / _rewardMinEach
                + (totalAddedTime % _rewardMinEach != 0 ? 1 : 0);
        }
        public static int TargetBreakTime(int endedSessions,int totalAddedTime)
        {
            return (IsLongBreak(endedSessions) ? _longBreakLength : _breakLength) + RewardBreakMinutes(totalAddedTime);
        }
        public static bool IsLongBreak(int endedSessions)
        {
            return (endedSessions != 0) && (endedSessions % _numOfSessionsForLongBreak == 0);
        }

        public static int TargetFocusTime(int totalAddedTime)
        {
            return AppSettings._sessionLength + totalAddedTime;
        }

    }
}
