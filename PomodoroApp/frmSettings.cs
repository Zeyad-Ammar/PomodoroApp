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

       
        public frmSettings(int currentSessionLength,int currentBreakLength,int currentLongBreakLength,int currentNumOfSessionsForLongBreak,int defaultExtraAdd,int rewardMinEach)
        {
            InitializeComponent();
            nudSessionLength.Value = currentSessionLength;
            nudBreakLength.Value = currentBreakLength;
            nudLongBreakLength.Value = currentLongBreakLength;
            nudNumberOfSessionsForLongBreak.Value = currentNumOfSessionsForLongBreak;
            nudDefaultExtraTime.Value = defaultExtraAdd;
            nudRewardMinuteEach.Value = rewardMinEach;
        }


       public class settingsArg:EventArgs {

            public int sessionLength { get; set; }

            public int breakLength { get; set; }

            public int longBreakLength { get; set; }

            public int numOfSessionsForLongBreak {  get; set; }

            public int defaultExtraAdd { get; set; }
            public int rewardMinEach { get; set; }



            public settingsArg(int sessionLength, int breakLength,int longBreakLength,int numOfSessionsForLongBreak,int defaultExtraAdd,int rewardMinEach)
            {
                this.sessionLength = sessionLength;
                this.breakLength = breakLength;
                this.longBreakLength = longBreakLength;
                this.numOfSessionsForLongBreak = numOfSessionsForLongBreak;
                this.defaultExtraAdd = defaultExtraAdd;
                this.rewardMinEach = rewardMinEach;
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

        private void submitChanges(int newSessionLength,int newBreakLength,int newLongBreakLength,int newNumOfSessionsForLongBreak,int defaultExtraAdd,int rewardMinEach)
        {
            settingsArg settingsArg = new settingsArg(newSessionLength,newBreakLength,newLongBreakLength,newNumOfSessionsForLongBreak,defaultExtraAdd,rewardMinEach);

            onSettingsChanged?.Invoke(this, settingsArg);

        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            int sessionLength=(int)nudSessionLength.Value;
            int breakLength=(int)nudBreakLength.Value;
            int longBreakLength = (int)nudLongBreakLength.Value;
            int numOfSessionsForLongBreak = (int)nudNumberOfSessionsForLongBreak.Value;
            int defaultExtraAddTime=(int)nudDefaultExtraTime.Value;
            int rewardMinEach=(int)nudRewardMinuteEach.Value;

            submitChanges(sessionLength, breakLength,longBreakLength,numOfSessionsForLongBreak,defaultExtraAddTime,rewardMinEach);
          

            this.Close();
        }

        private void nudValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
