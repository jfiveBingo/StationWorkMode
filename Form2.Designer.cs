namespace StationWorkMode
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDataBC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDataBG = new System.Windows.Forms.TextBox();
            this.btnSendBC = new System.Windows.Forms.Button();
            this.btnSendBG = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLabelBC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLabelBG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBGRM = new System.Windows.Forms.Button();
            this.btnBCRM = new System.Windows.Forms.Button();
            this.btnLabel = new System.Windows.Forms.Button();
            this.btnTestIdle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartSend = new System.Windows.Forms.Button();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.cbxPath = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FrameBC";
            // 
            // txbDataBC
            // 
            this.txbDataBC.Location = new System.Drawing.Point(103, 36);
            this.txbDataBC.Name = "txbDataBC";
            this.txbDataBC.Size = new System.Drawing.Size(167, 20);
            this.txbDataBC.TabIndex = 1;
            this.txbDataBC.Text = "AA BB CC 91";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FrameBG";
            // 
            // txbDataBG
            // 
            this.txbDataBG.Location = new System.Drawing.Point(103, 80);
            this.txbDataBG.Name = "txbDataBG";
            this.txbDataBG.Size = new System.Drawing.Size(167, 20);
            this.txbDataBG.TabIndex = 1;
            this.txbDataBG.Text = "AA BB CC 91";
            // 
            // btnSendBC
            // 
            this.btnSendBC.Location = new System.Drawing.Point(288, 34);
            this.btnSendBC.Name = "btnSendBC";
            this.btnSendBC.Size = new System.Drawing.Size(75, 23);
            this.btnSendBC.TabIndex = 2;
            this.btnSendBC.Text = "Send BC";
            this.btnSendBC.UseVisualStyleBackColor = true;
            this.btnSendBC.Click += new System.EventHandler(this.btnSendBC_Click);
            // 
            // btnSendBG
            // 
            this.btnSendBG.Location = new System.Drawing.Point(288, 78);
            this.btnSendBG.Name = "btnSendBG";
            this.btnSendBG.Size = new System.Drawing.Size(75, 23);
            this.btnSendBG.TabIndex = 2;
            this.btnSendBG.Text = "Send BG";
            this.btnSendBG.UseVisualStyleBackColor = true;
            this.btnSendBG.Click += new System.EventHandler(this.btnSendBG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "labelBC";
            // 
            // txbLabelBC
            // 
            this.txbLabelBC.Location = new System.Drawing.Point(74, 11);
            this.txbLabelBC.Name = "txbLabelBC";
            this.txbLabelBC.Size = new System.Drawing.Size(167, 20);
            this.txbLabelBC.TabIndex = 4;
            this.txbLabelBC.Text = "TM+RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "labelBG";
            // 
            // txbLabelBG
            // 
            this.txbLabelBG.Location = new System.Drawing.Point(74, 37);
            this.txbLabelBG.Name = "txbLabelBG";
            this.txbLabelBG.Size = new System.Drawing.Size(167, 20);
            this.txbLabelBG.TabIndex = 4;
            this.txbLabelBG.Text = "TM+RG";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbLabelBG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBGRM);
            this.panel1.Controls.Add(this.btnBCRM);
            this.panel1.Controls.Add(this.btnLabel);
            this.panel1.Controls.Add(this.txbLabelBC);
            this.panel1.Location = new System.Drawing.Point(403, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 142);
            this.panel1.TabIndex = 5;
            // 
            // btnBGRM
            // 
            this.btnBGRM.Location = new System.Drawing.Point(185, 112);
            this.btnBGRM.Name = "btnBGRM";
            this.btnBGRM.Size = new System.Drawing.Size(121, 23);
            this.btnBGRM.TabIndex = 2;
            this.btnBGRM.Text = "BG Rang. Missing ";
            this.btnBGRM.UseVisualStyleBackColor = true;
            this.btnBGRM.Click += new System.EventHandler(this.btnBGRM_Click);
            // 
            // btnBCRM
            // 
            this.btnBCRM.Location = new System.Drawing.Point(16, 112);
            this.btnBCRM.Name = "btnBCRM";
            this.btnBCRM.Size = new System.Drawing.Size(121, 23);
            this.btnBCRM.TabIndex = 2;
            this.btnBCRM.Text = "BC Rang. Missing ";
            this.btnBCRM.UseVisualStyleBackColor = true;
            this.btnBCRM.Click += new System.EventHandler(this.btnBCRM_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(259, 37);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(75, 23);
            this.btnLabel.TabIndex = 2;
            this.btnLabel.Text = "OK";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // btnTestIdle
            // 
            this.btnTestIdle.Location = new System.Drawing.Point(18, 132);
            this.btnTestIdle.Name = "btnTestIdle";
            this.btnTestIdle.Size = new System.Drawing.Size(75, 23);
            this.btnTestIdle.TabIndex = 6;
            this.btnTestIdle.Text = "Idle";
            this.btnTestIdle.UseVisualStyleBackColor = true;
            this.btnTestIdle.Click += new System.EventHandler(this.btnTestIdle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop Idle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartSend
            // 
            this.btnStartSend.Location = new System.Drawing.Point(214, 132);
            this.btnStartSend.Name = "btnStartSend";
            this.btnStartSend.Size = new System.Drawing.Size(75, 23);
            this.btnStartSend.TabIndex = 2;
            this.btnStartSend.Text = "Start Send";
            this.btnStartSend.UseVisualStyleBackColor = true;
            this.btnStartSend.Click += new System.EventHandler(this.btnStartSend_Click);
            // 
            // btnStopSend
            // 
            this.btnStopSend.Location = new System.Drawing.Point(312, 132);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(75, 23);
            this.btnStopSend.TabIndex = 2;
            this.btnStopSend.Text = "Stop Send";
            this.btnStopSend.UseVisualStyleBackColor = true;
            this.btnStopSend.Click += new System.EventHandler(this.btnStopSend_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "RG ON/OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(355, 226);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Force path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // cbxPath
            // 
            this.cbxPath.FormattingEnabled = true;
            this.cbxPath.Items.AddRange(new object[] {
            "\\\\OP1\\Users\\Public\\Boughrara\\file.dat",
            "D:\\file.dat"});
            this.cbxPath.Location = new System.Drawing.Point(69, 228);
            this.cbxPath.Name = "cbxPath";
            this.cbxPath.Size = new System.Drawing.Size(262, 21);
            this.cbxPath.TabIndex = 8;
            this.cbxPath.Text = "\\\\OP1\\Users\\Public\\Boughrara\\file.dat";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 363);
            this.Controls.Add(this.cbxPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestIdle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStopSend);
            this.Controls.Add(this.btnStartSend);
            this.Controls.Add(this.btnSendBG);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnSendBC);
            this.Controls.Add(this.txbDataBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDataBC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDataBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDataBG;
        private System.Windows.Forms.Button btnSendBC;
        private System.Windows.Forms.Button btnSendBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLabelBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLabelBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTestIdle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Button btnStartSend;
        private System.Windows.Forms.Button btnStopSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBGRM;
        private System.Windows.Forms.Button btnBCRM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ComboBox cbxPath;
    }
}