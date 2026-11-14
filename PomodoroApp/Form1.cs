using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class mainScreen : Form
    {

        private bool _isFocusSession = true;
        private int _sessionLengthInMin = 50;
        private int _breakLengthinMin = 15;
        private string _soundsPath = "D:\\VSProjects\\PomodoroApp\\PomodoroApp\\Sounds";

        private int _numOfSessionsForLongBreak = 4;
        private int _longbreakLengthinMin = 60;

        private int _sessionsCounter = 1;
        private int _timeInSec = 0;
        private SoundPlayer focusSound;
        //private SoundPlayer alarmSound;

        private AudioFileReader alarmSound;
        private WasapiOut outputDevice;

        private MMDevice speakerDevice;
        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            

            btnPause.Enabled = false;

            AppSettings.Load(
                ref _sessionLengthInMin,
                ref _breakLengthinMin,
                ref _longbreakLengthinMin,
                ref _numOfSessionsForLongBreak
            );


            
        }




        private void btnStart_Click(object sender, EventArgs e)
        {

            

            timer1.Start();
            btnStart.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            btnPause.Enabled = true;
           

        }

        private void PlayAlarm()
        {
            speakerDevice = Speakers.GetIntegratedAudioDevice();
            alarmSound = new AudioFileReader(Path.Combine(_soundsPath, "alarm1.wav"));
            outputDevice = new WasapiOut(speakerDevice, AudioClientShareMode.Shared, true, 100);

            outputDevice.Init(alarmSound);
            outputDevice.Play();
        }

        private void endFocusSession()
        {

            _timeInSec = 0;
            _isFocusSession = false;
            PlayAlarm();

            timer1.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            _sessionsCounter++;

            lbSessionsCounter.Text = (IsLongBreak()? "Long":"Short") +" Break";

            btnStart.Text = "Start Break";

            settingsToolStripMenuItem.Enabled = true;

        }


        private void endBreak()
        {
            _timeInSec = 0;
            _isFocusSession = true;
            PlayAlarm();
            timer1.Stop();

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            lbSessionsCounter.Text = " Session " + _sessionsCounter.ToString();

            btnStart.Text = "Start Focus";
            settingsToolStripMenuItem.Enabled = true;

        }


        private void setNewSettings(object obj,frmSettings.settingsArg args)
        {

            this._breakLengthinMin = args.breakLength;
            this._sessionLengthInMin = args.sessionLength;
            this._longbreakLengthinMin = args.longBreakLength;
            this._numOfSessionsForLongBreak = args.numOfSessionsForLongBreak;

            AppSettings.Save(this._sessionLengthInMin, this._breakLengthinMin,this._longbreakLengthinMin,this._numOfSessionsForLongBreak);

        }

        

    

        private bool IsLongBreak()
        {
            int endedSessions = (_sessionsCounter - 1);
            return  (endedSessions != 0) && (endedSessions % _numOfSessionsForLongBreak == 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeInSec++;
            


            int passedMinutes=_timeInSec / 60;
            int reminderSecondes = _timeInSec % 60;
            lbTimer.Text = passedMinutes.ToString("00") + ":" + reminderSecondes.ToString("00"); ;

            int timeInMin = _timeInSec / 60;

            if (_isFocusSession && timeInMin == _sessionLengthInMin)
            {

                endFocusSession();

            }
            else if(!_isFocusSession)
            {

                if (IsLongBreak() && timeInMin == _longbreakLengthinMin)
                {
                    endBreak();
                }
                else if(!IsLongBreak() && timeInMin == _breakLengthinMin)
                {
                    endBreak();
                }

            }




        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            focusSound.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings(this._sessionLengthInMin,this._breakLengthinMin,this._longbreakLengthinMin,this._numOfSessionsForLongBreak);

            frmSettings.onSettingsChanged += setNewSettings;

            frmSettings.ShowDialog();
        }
    }
}
