using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroApp
{
    internal static class Speakers
    {
        public static MMDevice GetIntegratedAudioDevice()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var devices = enumerator.EnumerateAudioEndPoints(
                    DataFlow.Render,
                    DeviceState.Active
                );

                return devices[0];
            }
        }

        public static MMDevice GetAudioDevice(string DeviceName)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var devices = enumerator.EnumerateAudioEndPoints(
                    DataFlow.Render,
                    DeviceState.Active
                );
                
                foreach (var device in devices)
                {
                    if (device.FriendlyName == DeviceName)
                    {
                        return device;
                    }
                }

                
                return devices[0];
            }
        }
        public static MMDeviceCollection GetAudioDevices()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var devices = enumerator.EnumerateAudioEndPoints(
                    DataFlow.Render,
                    DeviceState.Active
                );

                return devices;
            }
        }
    }
}
