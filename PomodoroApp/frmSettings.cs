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

        private int sessionLength;
        private int breakLength;
        public frmSettings(int CurrentSessionLength,int CurrentBreakLength)
        {
            InitializeComponent();
            this.sessionLength = CurrentSessionLength;
            this.breakLength = CurrentBreakLength;
            nudSessionLength.Value = CurrentSessionLength;
            nudBreakLength.Value = CurrentBreakLength;
        }


       public class settingsArg:EventArgs {

            public int sessionLength { get; set; }

            public int breakLength { get; set; }
            
           public settingsArg(int sessionLength, int breakLength)
            {
                this.sessionLength = sessionLength;
                this.breakLength = breakLength;
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

        private void submitChanges(int newSessionLength,int newBreakLength)
        {
            settingsArg settingsArg = new settingsArg(newSessionLength,newBreakLength);

            onSettingsChanged?.Invoke(this, settingsArg);

        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            this.sessionLength=(int)nudSessionLength.Value;
            this.breakLength=(int)nudBreakLength.Value; 

            submitChanges(sessionLength, breakLength);
          

            this.Close();
        }
    }
}
