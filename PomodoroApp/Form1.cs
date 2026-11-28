using BussinessLayer;
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
        private string _soundsPath ;
        private int _sessionNumber = 1;
        private int _timeInSec = 0;
        private int _addedTimeInMins = 0;

        
        private AudioFileReader alarmSound;
        private WasapiOut outputDevice;
        private frmExtraTime frmExtraTime;
        private MMDevice speakerDevice;
        public mainScreen()
        {
            InitializeComponent();
             _soundsPath = Path.Combine( AppDomain.CurrentDomain.BaseDirectory,"Sounds");
        }

        
        private void mainScreen_Load(object sender, EventArgs e)
        {

            btnPause.Enabled = false;

            AppSettings.LoadTimeSettings();
            AppSettings.LoadSpeakersSettings();

            lbMessage.Text = EncouragementMessage.GetRandomMessage();

            UpdateTargetTimeLabel();

           
        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            StopAlarm();
            if(frmExtraTime != null)
                frmExtraTime.Close();
            _timeInSec = 0;
            timer1.Start();
            btnStart.Enabled = false;
            MainMenu.Enabled = false;
            btnPause.Enabled = true;
           

        }

        private void StopAlarm()
        {
            if(outputDevice!= null)
                outputDevice.Stop();
        }
        private void PlayAlarm()
        {
            speakerDevice = Speakers.GetAudioDevice(AppSettings._audioDeviceName);
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
            frmExtraTime = new frmExtraTime(AppSettings._defaultAddingTime);
            frmExtraTime.onExtraTimeChanged += AddExtraTime;
            Rectangle workingArea = Screen.FromControl(this).WorkingArea;

            frmExtraTime.StartPosition = FormStartPosition.Manual;

            frmExtraTime.Location = new Point(
                workingArea.Right - frmExtraTime.Width - 15,
                workingArea.Bottom - frmExtraTime.Height - 15
            );

            frmExtraTime.Show();
        }

 
        private void ContinueFocusSession()
        {
            _isFocusSession = true;
            StopAlarm();
            timer1.Start();
            _sessionNumber--;
            btnPause.Enabled = true;
            btnStart.Enabled = false;
            UpdateTargetTimeLabel();
            lbSessionsCounter.Text = " Session " + _sessionNumber.ToString();
            btnStart.Text = "Start Focus";
            MainMenu.Enabled=false;
            

        }
        private void UpdateTargetTimeLabel()
        {
            if (_isFocusSession)
            {
                lbTargetTime.Text = $"Session Time ({AppSettings.TargetFocusTime(_addedTimeInMins)})";

            }
            else
            {
                lbTargetTime.Text = $"Break Time ({AppSettings.TargetBreakTime(_sessionNumber-1,_addedTimeInMins)})";

            }
        }
        private void EndFocusSession()
        {

            
            _isFocusSession = false;
            PlayAlarm();
            timer1.Stop();
            ShowExtraTimeForm();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            _sessionNumber++;
            MainMenu.Enabled = true;


            lbSessionsCounter.Text = (AppSettings.IsLongBreak(_sessionNumber-1)? "Long":"Short") +" Break";
            UpdateTargetTimeLabel();
            
            btnStart.Text = "Start Break";


        }
        private void EndBreak()
        {

            _addedTimeInMins = 0;
            _isFocusSession = true;
            PlayAlarm();
            timer1.Stop();

            btnPause.Enabled = false;
            btnStart.Enabled = true;
            lbSessionsCounter.Text = " Session " + _sessionNumber.ToString();
            UpdateTargetTimeLabel();
            btnStart.Text = "Start Focus";
            MainMenu.Enabled = true;

            lbMessage.Text =  EncouragementMessage.GetRandomMessage();

        }

        private void SetNewTimeSettings(object obj,frmSettings.settingsArg args)
        {


            AppSettings.SaveTimeSettings(
                args.sessionLength,
                args.breakLength,
                args.longBreakLength,
                args.numOfSessionsForLongBreak,
                args.defaultExtraAdd,
                args.rewardMinEach
                );

            
            UpdateTargetTimeLabel();


        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeInSec++;
            


            int passedMinutes=_timeInSec / 60;
            int reminderSecondes = _timeInSec % 60;
            lbTimer.Text = passedMinutes.ToString("00") + ":" + reminderSecondes.ToString("00"); ;

            int timeInMin = _timeInSec / 60;

            if (_isFocusSession && timeInMin == AppSettings.TargetFocusTime(_addedTimeInMins))
            {

                EndFocusSession();

            }
            else if (!_isFocusSession && timeInMin == AppSettings.TargetBreakTime(_sessionNumber - 1, _addedTimeInMins))
            {
                    EndBreak();
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
            frmSettings frmSettings = new frmSettings(AppSettings._sessionLength, AppSettings._breakLength, AppSettings._longBreakLength, AppSettings._numOfSessionsForLongBreak, AppSettings._defaultAddingTime, AppSettings._rewardMinEach);

            frmSettings.onSettingsChanged += SetNewTimeSettings;

            frmSettings.ShowDialog();
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMessages frmMessages = new frmMessages();
            frmMessages.Show();

        }

        private void SetNewSpeakersSettings(string DeviceName)
        {
            AppSettings.SaveSpeakersSettings(DeviceName);

        }

        private void speakersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSpeakersConfig frmSpeakersConfig = new frmSpeakersConfig(AppSettings._audioDeviceName);
            frmSpeakersConfig.onSelectedDevice += SetNewSpeakersSettings;
            frmSpeakersConfig.Show();
        }
    }
}
