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
    }
}
