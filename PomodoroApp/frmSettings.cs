using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class frmSettings : Form
    {

        private int _sessionLength;
        private int _breakLength;
        private int _longBreakLength;
        private int _numOfSessionsForLongBreak;
        public frmSettings(int currentSessionLength,int currentBreakLength,int currentLongBreakLength,int currentNumOfSessionsForLongBreak)
        {
            InitializeComponent();
            this._sessionLength = currentSessionLength;
            this._breakLength = currentBreakLength;
            nudSessionLength.Value = currentSessionLength;
            nudBreakLength.Value = currentBreakLength;
            nudLongBreakLength.Value = currentLongBreakLength;
            nudNumberOfSessionsForLongBreak.Value = currentNumOfSessionsForLongBreak;
        }


       public class settingsArg:EventArgs {

            public int sessionLength { get; set; }

            public int breakLength { get; set; }

            public int longBreakLength { get; set; }

            public int numOfSessionsForLongBreak {  get; set; }
            
           public settingsArg(int sessionLength, int breakLength,int longBreakLength,int numOfSessionsForLongBreak)
            {
                this.sessionLength = sessionLength;
                this.breakLength = breakLength;
                this.longBreakLength = longBreakLength;
                this.numOfSessionsForLongBreak = numOfSessionsForLongBreak;
            }

           public settingsArg()
           {

           }
        
        }



        public event EventHandler<settingsArg> onSettingsChanged;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitChanges(int newSessionLength,int newBreakLength,int newLongBreakLength,int newNumOfSessionsForLongBreak)
        {
            settingsArg settingsArg = new settingsArg(newSessionLength,newBreakLength,newLongBreakLength,newNumOfSessionsForLongBreak);

            onSettingsChanged?.Invoke(this, settingsArg);

        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            this._sessionLength=(int)nudSessionLength.Value;
            this._breakLength=(int)nudBreakLength.Value;
            this._longBreakLength = (int)nudLongBreakLength.Value;
            this._numOfSessionsForLongBreak = (int)nudNumberOfSessionsForLongBreak.Value;


            submitChanges(_sessionLength, _breakLength,_longBreakLength,_numOfSessionsForLongBreak);
          

            this.Close();
        }
    }
}
