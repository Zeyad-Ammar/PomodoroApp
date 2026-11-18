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
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessionsForLongBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFocusSessionTime
            // 
            this.lbFocusSessionTime.AutoSize = true;
            this.lbFocusSessionTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFocusSessionTime.Location = new System.Drawing.Point(254, 36);
            this.lbFocusSessionTime.Name = "lbFocusSessionTime";
            this.lbFocusSessionTime.Size = new System.Drawing.Size(301, 37);
            this.lbFocusSessionTime.TabIndex = 0;
            this.lbFocusSessionTime.Text = "Focus Session Time:";
            // 
            // lbBreakTime
            // 
            this.lbBreakTime.AutoSize = true;
            this.lbBreakTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBreakTime.Location = new System.Drawing.Point(364, 119);
            this.lbBreakTime.Name = "lbBreakTime";
            this.lbBreakTime.Size = new System.Drawing.Size(191, 37);
            this.lbBreakTime.TabIndex = 1;
            this.lbBreakTime.Text = "Break Time:";
            // 
            // nudSessionLength
            // 
            this.nudSessionLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSessionLength.Location = new System.Drawing.Point(669, 33);
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
            this.nudSessionLength.Size = new System.Drawing.Size(204, 45);
            this.nudSessionLength.TabIndex = 2;
            this.nudSessionLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBreakLength
            // 
            this.nudBreakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreakLength.Location = new System.Drawing.Point(669, 116);
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
            this.nudBreakLength.Size = new System.Drawing.Size(204, 45);
            this.nudBreakLength.TabIndex = 3;
            this.nudBreakLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(250, 407);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(188, 64);
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
            this.btnCancel.Location = new System.Drawing.Point(494, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 64);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudLongBreakLength
            // 
            this.nudLongBreakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLongBreakLength.Location = new System.Drawing.Point(669, 200);
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
            this.nudLongBreakLength.Size = new System.Drawing.Size(204, 45);
            this.nudLongBreakLength.TabIndex = 7;
            this.nudLongBreakLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbLongBreak
            // 
            this.lbLongBreak.AutoSize = true;
            this.lbLongBreak.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLongBreak.Location = new System.Drawing.Point(282, 203);
            this.lbLongBreak.Name = "lbLongBreak";
            this.lbLongBreak.Size = new System.Drawing.Size(273, 37);
            this.lbLongBreak.TabIndex = 6;
            this.lbLongBreak.Text = "Long Break Time:";
            // 
            // nudNumberOfSessionsForLongBreak
            // 
            this.nudNumberOfSessionsForLongBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfSessionsForLongBreak.Location = new System.Drawing.Point(669, 282);
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
            this.nudNumberOfSessionsForLongBreak.Size = new System.Drawing.Size(204, 45);
            this.nudNumberOfSessionsForLongBreak.TabIndex = 9;
            this.nudNumberOfSessionsForLongBreak.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumOfSessionsForLongBreak
            // 
            this.lbNumOfSessionsForLongBreak.AutoSize = true;
            this.lbNumOfSessionsForLongBreak.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOfSessionsForLongBreak.Location = new System.Drawing.Point(56, 282);
            this.lbNumOfSessionsForLongBreak.Name = "lbNumOfSessionsForLongBreak";
            this.lbNumOfSessionsForLongBreak.Size = new System.Drawing.Size(499, 37);
            this.lbNumOfSessionsForLongBreak.TabIndex = 8;
            this.lbNumOfSessionsForLongBreak.Text = "Num Of Sessions For Long Break:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 495);
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
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfSessionsForLongBreak)).EndInit();
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
    }
}