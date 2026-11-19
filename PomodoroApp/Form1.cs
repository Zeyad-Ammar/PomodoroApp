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
        private int _addedTimeInMins = 0;
        private int _reward1MinBreakForEach = 3;
        private int _defaultExtraAddTime = 5;
        private AudioFileReader alarmSound;
        private WasapiOut outputDevice;
        private frmExtraTime frmExtraTime;
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
                ref _numOfSessionsForLongBreak,
                ref _defaultExtraAddTime,
                ref _reward1MinBreakForEach
            );

           UpdateTargetTime();
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            StopAlarm();
            if(frmExtraTime != null)
                frmExtraTime.Close();
            _timeInSec = 0;
            timer1.Start();
            btnStart.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            btnPause.Enabled = true;
           

        }

        private void StopAlarm()
        {
            if(outputDevice!= null)
                outputDevice.Stop();
        }
        private void PlayAlarm()
        {
            speakerDevice = Speakers.GetIntegratedAudioDevice();
            alarmSound = new AudioFileReader(Path.Combine(_soundsPath, "alarm1.wav"));
            outputDevice = new WasapiOut(speakerDevice, AudioClientShareMode.Shared, true, 100);

            outputDevice.Init(alarmSound);
            outputDevice.Play();
        }

        private void AddExtraTime(object sender,frmExtraTime.ExtraTimeArgs e)
        {
            if (e.AddExtraTime)
            {
                _addedTimeInMins += e.ExtraTime;
                ContinueFocusSession();
            }
            else
            {
                btnStart.PerformClick();
            }
           
        }

        private void ShowExtraTimeForm()
        {
            frmExtraTime = new frmExtraTime(_defaultExtraAddTime);
            frmExtraTime.onExtraTimeChanged += AddExtraTime;
            Rectangle workingArea = Screen.FromControl(this).WorkingArea;

            frmExtraTime.StartPosition = FormStartPosition.Manual;

            frmExtraTime.Location = new Point(
                workingArea.Right - frmExtraTime.Width - 15,
                workingArea.Bottom - frmExtraTime.Height - 15
            );

            frmExtraTime.Show();
        }

        private int TargetFocusTime()
        {
           return  _sessionLengthInMin + _addedTimeInMins;
        }
        private void ContinueFocusSession()
        {
            _isFocusSession = true;
            StopAlarm();
            timer1.Start();
            _sessionsCounter--;
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            UpdateTargetTime();
            lbSessionsCounter.Text = " Session " + _sessionsCounter.ToString();
            btnStart.Text = "Start Focus";
            settingsToolStripMenuItem.Enabled = false;

        }

        private void UpdateTargetTime()
        {
            if (_isFocusSession)
            {
                lbTargetTime.Text = $"Target Time ({TargetFocusTime()})";

            }
            else
            {
                lbTargetTime.Text = $"Target Time ({TargetBreakTime()})";

            }
        }
        private int RewardBreakMinutes()
        {
            return _addedTimeInMins / _reward1MinBreakForEach 
                + (_addedTimeInMins % _reward1MinBreakForEach) != 0 ? 1 : 0;
        }
        private int TargetBreakTime()
        {
            return (IsLongBreak() ? _longbreakLengthinMin : _breakLengthinMin) + RewardBreakMinutes() ;
        }
        private void EndFocusSession()
        {

            
            _isFocusSession = false;
            PlayAlarm();
            timer1.Stop();
            ShowExtraTimeForm();
            UpdateTargetTime();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            _sessionsCounter++;

            lbSessionsCounter.Text = (IsLongBreak()? "Long":"Short") +" Break";

            btnStart.Text = "Start Break";

            settingsToolStripMenuItem.Enabled = true;

        }

        private void EndBreak()
        {

            _addedTimeInMins = 0;
            _isFocusSession = true;
            PlayAlarm();
            timer1.Stop();

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            lbSessionsCounter.Text = " Session " + _sessionsCounter.ToString();
            UpdateTargetTime();
            btnStart.Text = "Start Focus";
            settingsToolStripMenuItem.Enabled = true;

        }

        private void SetNewSettings(object obj,frmSettings.settingsArg args)
        {

            _breakLengthinMin = args.breakLength;
            _sessionLengthInMin = args.sessionLength;
            _longbreakLengthinMin = args.longBreakLength;
            _numOfSessionsForLongBreak = args.numOfSessionsForLongBreak;
            _defaultExtraAddTime = args.defaultExtraAdd;
            _reward1MinBreakForEach = args.rewardMinEach;
            AppSettings.Save(
                _sessionLengthInMin,
                _breakLengthinMin,
                _longbreakLengthinMin,
                _numOfSessionsForLongBreak,
                _defaultExtraAddTime,
                _reward1MinBreakForEach
                );

            UpdateTargetTime();


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

            if (_isFocusSession && timeInMin == (_sessionLengthInMin + _addedTimeInMins))
            {

                EndFocusSession();

            }
            else if(!_isFocusSession)
            {

                int rewardBreakTime = _addedTimeInMins / _reward1MinBreakForEach + (_addedTimeInMins % _reward1MinBreakForEach!=0? 1:0);

                if (IsLongBreak() && timeInMin == (_longbreakLengthinMin + rewardBreakTime))
                {
                    EndBreak();
                }
                else if(!IsLongBreak() && timeInMin == (_breakLengthinMin +rewardBreakTime))
                {
                    EndBreak();
                }

            }




        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnPause.Text = "Resume";
            }
            else
            {
                btnPause.Text = "Pause";
                timer1.Start();
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings(this._sessionLengthInMin,this._breakLengthinMin,this._longbreakLengthinMin,this._numOfSessionsForLongBreak,this._defaultExtraAddTime,this._reward1MinBreakForEach);

            frmSettings.onSettingsChanged += SetNewSettings;

            frmSettings.ShowDialog();
        }
    }
}
