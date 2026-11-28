namespace PomodoroApp
{
    partial class frmSpeakersConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpeakersConfig));
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbSpeakerDevices = new System.Windows.Forms.ComboBox();
            this.lbSpeakerDevice = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(219, 39);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(379, 53);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Speakers Settings";
            // 
            // cbSpeakerDevices
            // 
            this.cbSpeakerDevices.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbSpeakerDevices.DropDownHeight = 300;
            this.cbSpeakerDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpeakerDevices.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpeakerDevices.FormattingEnabled = true;
            this.cbSpeakerDevices.IntegralHeight = false;
            this.cbSpeakerDevices.ItemHeight = 31;
            this.cbSpeakerDevices.Location = new System.Drawing.Point(287, 195);
            this.cbSpeakerDevices.Name = "cbSpeakerDevices";
            this.cbSpeakerDevices.Size = new System.Drawing.Size(509, 39);
            this.cbSpeakerDevices.TabIndex = 1;
            this.cbSpeakerDevices.Text = "Select Speaker You Want sound play on";
            // 
            // lbSpeakerDevice
            // 
            this.lbSpeakerDevice.AutoSize = true;
            this.lbSpeakerDevice.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpeakerDevice.Location = new System.Drawing.Point(21, 195);
            this.lbSpeakerDevice.Name = "lbSpeakerDevice";
            this.lbSpeakerDevice.Size = new System.Drawing.Size(251, 38);
            this.lbSpeakerDevice.TabIndex = 2;
            this.lbSpeakerDevice.Text = "Speaker Device:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(415, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(220, 69);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(139, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 69);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSpeakersConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbSpeakerDevice);
            this.Controls.Add(this.cbSpeakerDevices);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSpeakersConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speakers Settings";
            this.Load += new System.EventHandler(this.frmSpeakersConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbSpeakerDevices;
        private System.Windows.Forms.Label lbSpeakerDevice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}