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
            this.lbFocusSessionTime = new System.Windows.Forms.Label();
            this.lbBreakTime = new System.Windows.Forms.Label();
            this.nudSessionLength = new System.Windows.Forms.NumericUpDown();
            this.nudBreakLength = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFocusSessionTime
            // 
            this.lbFocusSessionTime.AutoSize = true;
            this.lbFocusSessionTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFocusSessionTime.Location = new System.Drawing.Point(15, 121);
            this.lbFocusSessionTime.Name = "lbFocusSessionTime";
            this.lbFocusSessionTime.Size = new System.Drawing.Size(301, 37);
            this.lbFocusSessionTime.TabIndex = 0;
            this.lbFocusSessionTime.Text = "Focus Session Time:";
            // 
            // lbBreakTime
            // 
            this.lbBreakTime.AutoSize = true;
            this.lbBreakTime.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBreakTime.Location = new System.Drawing.Point(126, 201);
            this.lbBreakTime.Name = "lbBreakTime";
            this.lbBreakTime.Size = new System.Drawing.Size(191, 37);
            this.lbBreakTime.TabIndex = 1;
            this.lbBreakTime.Text = "Break Time:";
            // 
            // nudSessionLength
            // 
            this.nudSessionLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSessionLength.Location = new System.Drawing.Point(355, 118);
            this.nudSessionLength.Name = "nudSessionLength";
            this.nudSessionLength.Size = new System.Drawing.Size(204, 45);
            this.nudSessionLength.TabIndex = 2;
            // 
            // nudBreakLength
            // 
            this.nudBreakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreakLength.Location = new System.Drawing.Point(355, 198);
            this.nudBreakLength.Name = "nudBreakLength";
            this.nudBreakLength.Size = new System.Drawing.Size(204, 45);
            this.nudBreakLength.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(159, 354);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(188, 64);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(403, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 64);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudBreakLength);
            this.Controls.Add(this.nudSessionLength);
            this.Controls.Add(this.lbBreakTime);
            this.Controls.Add(this.lbFocusSessionTime);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.nudSessionLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakLength)).EndInit();
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
    }
}