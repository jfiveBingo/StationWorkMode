namespace StationWorkMode
{
    partial class Form6
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.picBoxAlarmBG = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.picBoxAlarm = new System.Windows.Forms.PictureBox();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblModeBG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarmBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.Font = new System.Drawing.Font("Eras Medium ITC", 30F);
            this.lblTime.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTime.Location = new System.Drawing.Point(5, 136);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 46);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "14:42";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTime3.Font = new System.Drawing.Font("Eras Medium ITC", 20F);
            this.lblTime3.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTime3.Location = new System.Drawing.Point(120, 144);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(51, 31);
            this.lblTime3.TabIndex = 3;
            this.lblTime3.Text = " 00";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblR2.Location = new System.Drawing.Point(12, 33);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(27, 19);
            this.lblR2.TabIndex = 6;
            this.lblR2.Text = "BC";
            // 
            // picBoxAlarmBG
            // 
            this.picBoxAlarmBG.Image = global::StationWorkMode.Properties.Resources.BlackLight;
            this.picBoxAlarmBG.Location = new System.Drawing.Point(126, 65);
            this.picBoxAlarmBG.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxAlarmBG.Name = "picBoxAlarmBG";
            this.picBoxAlarmBG.Size = new System.Drawing.Size(43, 43);
            this.picBoxAlarmBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAlarmBG.TabIndex = 10;
            this.picBoxAlarmBG.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(45, 25);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(75, 27);
            this.lblMode.TabIndex = 8;
            this.lblMode.Text = "No TM";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBoxAlarm
            // 
            this.picBoxAlarm.Image = global::StationWorkMode.Properties.Resources.BlackLight;
            this.picBoxAlarm.Location = new System.Drawing.Point(126, 12);
            this.picBoxAlarm.Name = "picBoxAlarm";
            this.picBoxAlarm.Size = new System.Drawing.Size(43, 43);
            this.picBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAlarm.TabIndex = 11;
            this.picBoxAlarm.TabStop = false;
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Font = new System.Drawing.Font("Candara", 12F);
            this.lblR3.Location = new System.Drawing.Point(12, 76);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(28, 19);
            this.lblR3.TabIndex = 7;
            this.lblR3.Text = "BG";
            // 
            // lblModeBG
            // 
            this.lblModeBG.AutoSize = true;
            this.lblModeBG.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            this.lblModeBG.ForeColor = System.Drawing.Color.Black;
            this.lblModeBG.Location = new System.Drawing.Point(45, 78);
            this.lblModeBG.Name = "lblModeBG";
            this.lblModeBG.Size = new System.Drawing.Size(75, 27);
            this.lblModeBG.TabIndex = 9;
            this.lblModeBG.Text = "No TM";
            this.lblModeBG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 193);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.picBoxAlarmBG);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.picBoxAlarm);
            this.Controls.Add(this.lblR3);
            this.Controls.Add(this.lblModeBG);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTime3);
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Opacity = 0.8D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarmBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.PictureBox picBoxAlarmBG;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox picBoxAlarm;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblModeBG;
    }
}