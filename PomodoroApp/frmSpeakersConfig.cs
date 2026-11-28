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
    public partial class frmSpeakersConfig : Form
    {
        private string speakerName { get; set; }
        public frmSpeakersConfig(string speakerName="")
        {
            InitializeComponent();
            this.speakerName = speakerName;

        }

        private void frmSpeakersConfig_Load(object sender, EventArgs e)
        {
            var audioDevices = Speakers.GetAudioDevices();

            int selectedIdx = 0;
            int idx = 0;
            foreach (var item in audioDevices)
            {
                if (speakerName == item.FriendlyName)
                {
                    selectedIdx = idx;
                }
                cbSpeakerDevices.Items.Add(item.FriendlyName);
                idx++;
            }

            cbSpeakerDevices.SelectedIndex = selectedIdx;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action<string> onSelectedDevice;
        private void btnSave_Click(object sender, EventArgs e)
        {
            onSelectedDevice?.Invoke(cbSpeakerDevices.SelectedItem.ToString());
            this.Close();
        }
    }
}
