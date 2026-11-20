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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeBrake = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudExtraAddTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraAddTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(51, 178);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 71);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Focus Session Completed!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "You\'ve finished your focus session. \r\nWould you like to continue?";
            // 
            // btnTakeBrake
            // 
            this.btnTakeBrake.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTakeBrake.FlatAppearance.BorderSize = 0;
            this.btnTakeBrake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnTakeBrake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeBrake.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeBrake.Location = new System.Drawing.Point(294, 178);
            this.btnTakeBrake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeBrake.Name = "btnTakeBrake";
            this.btnTakeBrake.Size = new System.Drawing.Size(217, 71);
            this.btnTakeBrake.TabIndex = 4;
            this.btnTakeBrake.Text = "Take a brake";
            this.btnTakeBrake.UseVisualStyleBackColor = false;
            this.btnTakeBrake.Click += new System.EventHandler(this.btnTakeBrake_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PomodoroApp.Properties.Resources.add_button;
            this.pictureBox1.Location = new System.Drawing.Point(392, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nudExtraAddTime
            // 
            this.nudExtraAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExtraAddTime.Location = new System.Drawing.Point(451, 85);
            this.nudExtraAddTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudExtraAddTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtraAddTime.Name = "nudExtraAddTime";
            this.nudExtraAddTime.Size = new System.Drawing.Size(107, 57);
            this.nudExtraAddTime.TabIndex = 6;
            this.nudExtraAddTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtraAddTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudExtraAddTime_KeyPress);
            // 
            // frmExtraTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(573, 263);
            this.Controls.Add(this.nudExtraAddTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTakeBrake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmExtraTime";
            this.ShowInTaskbar = false;
            this.Text = "Pomodoro";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmExtraTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraAddTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakeBrake;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudExtraAddTime;
    }
}