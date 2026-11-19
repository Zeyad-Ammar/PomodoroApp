namespace PomodoroApp
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.lbFocusSessionTime = new System.Windows.Forms.Label();
            this.lbBreakTime = new System.Windows.Forms.Label();
            this.nudSessionLength = new System.Windows.Forms.NumericUpDown();
            this.nudBreakLength = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudLongBreakLength = new System.Windows.Forms.NumericUpDown();
            this.lbLongBreak = new System.Windows.Forms.Label();
            this.nudNumberOfSessionsForLongBreak = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfSessionsForLongBreak = new System.Windows.Forms.Label();
            this.nudDefaultExtraTime = new System.Windows.Forms.NumericUpDown();
            this.lbDefaultAddTime = new System.Windows.Forms.Label();
            this.nudRewardMinuteEach = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessionsForLongBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultExtraTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRewardMinuteEach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFocusSessionTime
            // 
            this.lbFocusSessionTime.AutoSize = true;
            this.lbFocusSessionTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFocusSessionTime.Location = new System.Drawing.Point(244, 30);
            this.lbFocusSessionTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFocusSessionTime.Name = "lbFocusSessionTime";
            this.lbFocusSessionTime.Size = new System.Drawing.Size(185, 31);
            this.lbFocusSessionTime.TabIndex = 0;
            this.lbFocusSessionTime.Text = "Focus Session:";
            // 
            // lbBreakTime
            // 
            this.lbBreakTime.AutoSize = true;
            this.lbBreakTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBreakTime.Location = new System.Drawing.Point(263, 93);
            this.lbBreakTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBreakTime.Name = "lbBreakTime";
            this.lbBreakTime.Size = new System.Drawing.Size(166, 31);
            this.lbBreakTime.TabIndex = 1;
            this.lbBreakTime.Text = "Short Break:";
            // 
            // nudSessionLength
            // 
            this.nudSessionLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSessionLength.Location = new System.Drawing.Point(459, 27);
            this.nudSessionLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSessionLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSessionLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSessionLength.Name = "nudSessionLength";
            this.nudSessionLength.Size = new System.Drawing.Size(153, 37);
            this.nudSessionLength.TabIndex = 2;
            this.nudSessionLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSessionLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // nudBreakLength
            // 
            this.nudBreakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreakLength.Location = new System.Drawing.Point(459, 90);
            this.nudBreakLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudBreakLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBreakLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBreakLength.Name = "nudBreakLength";
            this.nudBreakLength.Size = new System.Drawing.Size(153, 37);
            this.nudBreakLength.TabIndex = 3;
            this.nudBreakLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBreakLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(161, 401);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(141, 52);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(344, 401);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudLongBreakLength
            // 
            this.nudLongBreakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLongBreakLength.Location = new System.Drawing.Point(459, 154);
            this.nudLongBreakLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudLongBreakLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLongBreakLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongBreakLength.Name = "nudLongBreakLength";
            this.nudLongBreakLength.Size = new System.Drawing.Size(153, 37);
            this.nudLongBreakLength.TabIndex = 7;
            this.nudLongBreakLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongBreakLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // lbLongBreak
            // 
            this.lbLongBreak.AutoSize = true;
            this.lbLongBreak.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLongBreak.Location = new System.Drawing.Point(268, 157);
            this.lbLongBreak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLongBreak.Name = "lbLongBreak";
            this.lbLongBreak.Size = new System.Drawing.Size(161, 31);
            this.lbLongBreak.TabIndex = 6;
            this.lbLongBreak.Text = "Long Break:";
            // 
            // nudNumberOfSessionsForLongBreak
            // 
            this.nudNumberOfSessionsForLongBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfSessionsForLongBreak.Location = new System.Drawing.Point(459, 217);
            this.nudNumberOfSessionsForLongBreak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNumberOfSessionsForLongBreak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumberOfSessionsForLongBreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfSessionsForLongBreak.Name = "nudNumberOfSessionsForLongBreak";
            this.nudNumberOfSessionsForLongBreak.Size = new System.Drawing.Size(153, 37);
            this.nudNumberOfSessionsForLongBreak.TabIndex = 9;
            this.nudNumberOfSessionsForLongBreak.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfSessionsForLongBreak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // lbNumOfSessionsForLongBreak
            // 
            this.lbNumOfSessionsForLongBreak.AutoSize = true;
            this.lbNumOfSessionsForLongBreak.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfSessionsForLongBreak.Location = new System.Drawing.Point(13, 220);
            this.lbNumOfSessionsForLongBreak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumOfSessionsForLongBreak.Name = "lbNumOfSessionsForLongBreak";
            this.lbNumOfSessionsForLongBreak.Size = new System.Drawing.Size(416, 31);
            this.lbNumOfSessionsForLongBreak.TabIndex = 8;
            this.lbNumOfSessionsForLongBreak.Text = "Num Of Sessions For Long Break:";
            // 
            // nudDefaultExtraTime
            // 
            this.nudDefaultExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDefaultExtraTime.Location = new System.Drawing.Point(459, 280);
            this.nudDefaultExtraTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDefaultExtraTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDefaultExtraTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefaultExtraTime.Name = "nudDefaultExtraTime";
            this.nudDefaultExtraTime.Size = new System.Drawing.Size(153, 37);
            this.nudDefaultExtraTime.TabIndex = 11;
            this.nudDefaultExtraTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDefaultExtraTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // lbDefaultAddTime
            // 
            this.lbDefaultAddTime.AutoSize = true;
            this.lbDefaultAddTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefaultAddTime.Location = new System.Drawing.Point(191, 283);
            this.lbDefaultAddTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDefaultAddTime.Name = "lbDefaultAddTime";
            this.lbDefaultAddTime.Size = new System.Drawing.Size(238, 31);
            this.lbDefaultAddTime.TabIndex = 10;
            this.lbDefaultAddTime.Text = "Default Extra Add:";
            // 
            // nudRewardMinuteEach
            // 
            this.nudRewardMinuteEach.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRewardMinuteEach.Location = new System.Drawing.Point(459, 344);
            this.nudRewardMinuteEach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRewardMinuteEach.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRewardMinuteEach.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRewardMinuteEach.Name = "nudRewardMinuteEach";
            this.nudRewardMinuteEach.Size = new System.Drawing.Size(153, 37);
            this.nudRewardMinuteEach.TabIndex = 13;
            this.nudRewardMinuteEach.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRewardMinuteEach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudValidate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reward 1 Minute Each Extra:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 469);
            this.Controls.Add(this.nudRewardMinuteEach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDefaultExtraTime);
            this.Controls.Add(this.lbDefaultAddTime);
            this.Controls.Add(this.nudNumberOfSessionsForLongBreak);
            this.Controls.Add(this.lbNumOfSessionsForLongBreak);
            this.Controls.Add(this.nudLongBreakLength);
            this.Controls.Add(this.lbLongBreak);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudBreakLength);
            this.Controls.Add(this.nudSessionLength);
            this.Controls.Add(this.lbBreakTime);
            this.Controls.Add(this.lbFocusSessionTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessionsForLongBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultExtraTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRewardMinuteEach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFocusSessionTime;
        private System.Windows.Forms.Label lbBreakTime;
        private System.Windows.Forms.NumericUpDown nudSessionLength;
        private System.Windows.Forms.NumericUpDown nudBreakLength;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudLongBreakLength;
        private System.Windows.Forms.Label lbLongBreak;
        private System.Windows.Forms.NumericUpDown nudNumberOfSessionsForLongBreak;
        private System.Windows.Forms.Label lbNumOfSessionsForLongBreak;
        private System.Windows.Forms.NumericUpDown nudDefaultExtraTime;
        private System.Windows.Forms.Label lbDefaultAddTime;
        private System.Windows.Forms.NumericUpDown nudRewardMinuteEach;
        private System.Windows.Forms.Label label1;
    }
}