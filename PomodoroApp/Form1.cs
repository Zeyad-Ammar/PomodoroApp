using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics;
using System.Drawing;
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

        private int _sessionsCounter = 0;
        private int _timeInSec = 0;
        private SoundPlayer focusSound;
        private SoundPlayer alarmSound;

       

        public mainScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            focusSound = new SoundPlayer(@"Sounds/rain.wav");
            alarmSound = new SoundPlayer(@"Sounds/alarm1.wav");
            btnPause.Enabled = false;
            AppSettings.Load(ref _sessionLengthInMin,ref _breakLengthinMin);

            

        }



       
        private void btnStart_Click(object sender, EventArgs e)
        {

            alarmSound.Stop();

            timer1.Start();

            

            if (_isFocusSession)
            {
               // focusSound.PlayLooping();
                
            }
            
            btnStart.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            btnPause.Enabled = true;
           

        }


        private void endFocusSession()
        {

            _timeInSec = 0;
            _isFocusSession = false;
            focusSound.Stop();
            alarmSound.Play();


            timer1.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;

            btnStart.Text = "Start Break";

            _sessionsCounter++;
            lbSessionsCounter.Text = _sessionsCounter.ToString() + " Sessions";
            settingsToolStripMenuItem.Enabled = true;

        }


        private void endBreak()
        {
            _timeInSec = 0;
            _isFocusSession = true;
            alarmSound.Play();
            timer1.Stop();

            btnPause.Enabled = false;
            btnStart.Enabled = true;

            btnStart.Text = "Start Focus";
            settingsToolStripMenuItem.Enabled = true;

        }


        private void setNewSettings(object obj,frmSettings.settingsArg args)
        {

            this._breakLengthinMin = args.breakLength;
            this._sessionLengthInMin = args.sessionLength;

            AppSettings.Save(this._sessionLengthInMin, this._breakLengthinMin);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeInSec++;
            


            TimeSpan ts = TimeSpan.FromSeconds(_timeInSec);
            lbTimer.Text = ts.ToString(@"mm\:ss");

            int timeInMin = _timeInSec / 60;

            if (_isFocusSession && timeInMin == _sessionLengthInMin)
            {

                //end focus session

                endFocusSession();



            }
            else if(!_isFocusSession&& timeInMin == _breakLengthinMin)
            {

               endBreak();


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
            frmSettings frmSettings = new frmSettings(this._sessionLengthInMin,this._breakLengthinMin);

            frmSettings.onSettingsChanged += setNewSettings;

            frmSettings.ShowDialog();
        }
    }
}
