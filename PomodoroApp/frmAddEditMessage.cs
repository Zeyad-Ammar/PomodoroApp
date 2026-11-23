using BussinessLayer;
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
    public partial class frmAddEditMessage : Form
    {
        private EncouragementMessage message;
        public frmAddEditMessage(int messageID = -1)
        {
            InitializeComponent();
            if (messageID != -1)
            {
                this.message = EncouragementMessage.GetMessage(messageID);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMessage()
        {
            EncouragementMessage.AddMessage(rtbMessage.Text);
        }

        private void EditMessage()
        {
            EncouragementMessage.EditMessage(message.ID, rtbMessage.Text);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (message != null)
            {
                EditMessage();
            }
            else
            {
                AddMessage();
            }
            this.Close();
        }

        private void frmAddEditMessage_Load(object sender, EventArgs e)
        {
            if (message != null)
            {
                lbTitle.Text = "Edit Encouragement Message";
                this.Text = "Edit Message";
                rtbMessage.Text = message.message;
            }
            else
            {
                this.Text = "Add Message";
                lbTitle.Text = "Add Encouragement Message";
            }
        }
    }
}
