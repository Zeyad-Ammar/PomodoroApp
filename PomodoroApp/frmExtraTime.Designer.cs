namespace PomodoroApp
{
    partial class frmExtraTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtraTime));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExtraFocusTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeBrake = new System.Windows.Forms.Button();
            this.lbAddSimbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(40, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 72);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExtraFocusTime
            // 
            this.txtExtraFocusTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraFocusTime.Location = new System.Drawing.Point(417, 82);
            this.txtExtraFocusTime.Name = "txtExtraFocusTime";
            this.txtExtraFocusTime.Size = new System.Drawing.Size(105, 56);
            this.txtExtraFocusTime.TabIndex = 1;
            this.txtExtraFocusTime.Text = "5";
            this.txtExtraFocusTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraFocusTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Focus Session Completed!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "You\'ve finished your focus session. \r\nWould you like to continue?";
            // 
            // btnTakeBrake
            // 
            this.btnTakeBrake.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTakeBrake.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeBrake.Location = new System.Drawing.Point(280, 179);
            this.btnTakeBrake.Name = "btnTakeBrake";
            this.btnTakeBrake.Size = new System.Drawing.Size(217, 72);
            this.btnTakeBrake.TabIndex = 4;
            this.btnTakeBrake.Text = "Take a brake";
            this.btnTakeBrake.UseVisualStyleBackColor = false;
            this.btnTakeBrake.Click += new System.EventHandler(this.btnTakeBrake_Click);
            // 
            // lbAddSimbol
            // 
            this.lbAddSimbol.AutoSize = true;
            this.lbAddSimbol.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddSimbol.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbAddSimbol.Location = new System.Drawing.Point(363, 83);
            this.lbAddSimbol.Name = "lbAddSimbol";
            this.lbAddSimbol.Size = new System.Drawing.Size(50, 53);
            this.lbAddSimbol.TabIndex = 5;
            this.lbAddSimbol.Text = "+";
            // 
            // frmExtraTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(530, 263);
            this.Controls.Add(this.lbAddSimbol);
            this.Controls.Add(this.btnTakeBrake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtraFocusTime);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtraTime";
            this.ShowInTaskbar = false;
            this.Text = "Pomodoro";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmExtraTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExtraFocusTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakeBrake;
        private System.Windows.Forms.Label lbAddSimbol;
    }
}