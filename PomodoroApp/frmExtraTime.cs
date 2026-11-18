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
    public partial class frmExtraTime : Form
    {
        private Timer autoCloserTimer;
        public frmExtraTime()
        {
            

            InitializeComponent();
            SetAutoCloserTimer();
            autoCloserTimer.Start();

        }

        private void SetAutoCloserTimer()
        {
            autoCloserTimer = new Timer();
            autoCloserTimer.Interval = 15 * 1000;
            
            autoCloserTimer.Tick += (s, e) => {
                autoCloserTimer.Stop();
                this.Close();
            };

        }
        public class ExtraTimeArgs : EventArgs
        {
            public int ExtraTime { get; }

            public bool AddExtraTime { get; }

            public ExtraTimeArgs()
            {
                this.AddExtraTime= false;
            }
            public ExtraTimeArgs(int ExtraTime)
            {
                this.ExtraTime = ExtraTime;
                this.AddExtraTime = true;
            }
        }
        public EventHandler<ExtraTimeArgs> onExtraTimeChanged;



        private void txtExtraFocusTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTakeBrake_Click(object sender, EventArgs e)
        {
            onExtraTimeChanged?.Invoke(this, new ExtraTimeArgs());
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int extraTime = 0;
            int.TryParse(txtExtraFocusTime.Text.ToString(),out extraTime);
            onExtraTimeChanged?.Invoke(this, new ExtraTimeArgs(extraTime));
            this.Close();
        }

        private void frmExtraTime_Load(object sender, EventArgs e)
        {
            txtExtraFocusTime.Focus();
        }
    }
}
