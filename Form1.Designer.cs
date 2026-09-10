namespace StationWorkMode
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblModeBG = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblR11 = new System.Windows.Forms.Label();
            this.lblR12 = new System.Windows.Forms.Label();
            this.lblR5 = new System.Windows.Forms.Label();
            this.lblR4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDataBG = new System.Windows.Forms.Label();
            this.lblR6 = new System.Windows.Forms.Label();
            this.timerBC = new System.Windows.Forms.Timer(this.components);
            this.timerBG = new System.Windows.Forms.Timer(this.components);
            this.lblR13 = new System.Windows.Forms.Label();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            this.timerNoDataBG = new System.Windows.Forms.Timer(this.components);
            this.ctxAck = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRgMissBC = new System.Windows.Forms.Timer(this.components);
            this.timerFirstTime = new System.Windows.Forms.Timer(this.components);
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnMoreData = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblEndString = new System.Windows.Forms.Label();
            this.lblCompilationMode = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblLastBgModeDB = new System.Windows.Forms.Label();
            this.btnLessData = new System.Windows.Forms.Button();
            this.lblRgStatus = new System.Windows.Forms.Label();
            this.lblTCAlarm = new System.Windows.Forms.Label();
            this.lblRgMessageBG = new System.Windows.Forms.Label();
            this.lblRgMessage = new System.Windows.Forms.Label();
            this.btnAckBG = new System.Windows.Forms.Button();
            this.btnAckTC = new System.Windows.Forms.Button();
            this.btnAck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxAlarmBG = new System.Windows.Forms.PictureBox();
            this.picBoxAlarm = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDataBaseTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangingPlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGBModeTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.timerFirstTimeBG = new System.Windows.Forms.Timer(this.components);
            this.timerRgMissBG = new System.Windows.Forms.Timer(this.components);
            this.ctxAckBG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTC = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerDB = new System.Windows.Forms.Timer(this.components);
            this.ctxAck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarmBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ctxAckBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2.Location = new System.Drawing.Point(21, 71);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(120, 29);
            this.lblR2.TabIndex = 2;
            this.lblR2.Text = "Bouchaoui";
            this.lblR2.Click += new System.EventHandler(this.lblR2_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(169, 69);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(91, 33);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "No TM";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMode.TextChanged += new System.EventHandler(this.lblMode_TextChanged);
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblData.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(22, 57);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(303, 65);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "80 F6 1C E7 84 A8 EE 33 82 A8 EE 01 06 10 00 6C\r\n0C 52 02 00 00 00 00 00 46 21 28" +
    " 48 1D 22 18 00\r\n03 00 07 40 1D 22 81 43 8B 16 00 00 00 00 00 00\r\n00 00 00 00 00" +
    " 00 00 00";
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR3.Location = new System.Drawing.Point(21, 124);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(134, 29);
            this.lblR3.TabIndex = 2;
            this.lblR3.Text = "Boughezoul";
            // 
            // lblModeBG
            // 
            this.lblModeBG.AutoSize = true;
            this.lblModeBG.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblModeBG.ForeColor = System.Drawing.Color.Black;
            this.lblModeBG.Location = new System.Drawing.Point(169, 122);
            this.lblModeBG.Name = "lblModeBG";
            this.lblModeBG.Size = new System.Drawing.Size(91, 33);
            this.lblModeBG.TabIndex = 3;
            this.lblModeBG.Text = "No TM";
            this.lblModeBG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblModeBG.TextChanged += new System.EventHandler(this.lblModeBG_TextChanged);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 500;
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTime.Font = new System.Drawing.Font("Eras Medium ITC", 30F);
            this.lblTime.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTime.Location = new System.Drawing.Point(20, 209);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 46);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "14:42";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblR11
            // 
            this.lblR11.AutoSize = true;
            this.lblR11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR11.Location = new System.Drawing.Point(21, 31);
            this.lblR11.Name = "lblR11";
            this.lblR11.Size = new System.Drawing.Size(68, 23);
            this.lblR11.TabIndex = 2;
            this.lblR11.Text = "Station";
            // 
            // lblR12
            // 
            this.lblR12.AutoSize = true;
            this.lblR12.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR12.Location = new System.Drawing.Point(168, 31);
            this.lblR12.Name = "lblR12";
            this.lblR12.Size = new System.Drawing.Size(57, 23);
            this.lblR12.TabIndex = 2;
            this.lblR12.Text = "Mode";
            // 
            // lblR5
            // 
            this.lblR5.AutoSize = true;
            this.lblR5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR5.Location = new System.Drawing.Point(24, 29);
            this.lblR5.Name = "lblR5";
            this.lblR5.Size = new System.Drawing.Size(176, 23);
            this.lblR5.TabIndex = 2;
            this.lblR5.Text = "Bouchaoui Raw Data";
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR4.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblR4.Location = new System.Drawing.Point(38, 182);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(87, 23);
            this.lblR4.TabIndex = 2;
            this.lblR4.Text = "UTC Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(756, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 2;
            // 
            // lblDataBG
            // 
            this.lblDataBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDataBG.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBG.Location = new System.Drawing.Point(22, 150);
            this.lblDataBG.Name = "lblDataBG";
            this.lblDataBG.Size = new System.Drawing.Size(303, 65);
            this.lblDataBG.TabIndex = 4;
            this.lblDataBG.Text = "80 F6 1C E7 84 A8 EE 33 82 A8 EE FD 10 00 00 80\r\n58 99 03 00 00 00 00 00 46 21 36" +
    " 35 1D 22 05 00\r\n00 00 00 00 92";
            // 
            // lblR6
            // 
            this.lblR6.AutoSize = true;
            this.lblR6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR6.Location = new System.Drawing.Point(24, 122);
            this.lblR6.Name = "lblR6";
            this.lblR6.Size = new System.Drawing.Size(187, 23);
            this.lblR6.TabIndex = 2;
            this.lblR6.Text = "Boughezoul Raw Data";
            // 
            // timerBC
            // 
            this.timerBC.Interval = 2000;
            this.timerBC.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerBG
            // 
            this.timerBG.Interval = 2000;
            this.timerBG.Tick += new System.EventHandler(this.timerBG_Tick);
            // 
            // lblR13
            // 
            this.lblR13.AutoSize = true;
            this.lblR13.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR13.Location = new System.Drawing.Point(279, 31);
            this.lblR13.Name = "lblR13";
            this.lblR13.Size = new System.Drawing.Size(50, 23);
            this.lblR13.TabIndex = 2;
            this.lblR13.Text = "Light";
            // 
            // timerTest
            // 
            this.timerTest.Interval = 4000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(256, 27);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(60, 20);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // timerNoDataBG
            // 
            this.timerNoDataBG.Interval = 4000;
            this.timerNoDataBG.Tick += new System.EventHandler(this.timerNoDataBG_Tick);
            // 
            // ctxAck
            // 
            this.ctxAck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ackToolStripMenuItem});
            this.ctxAck.Name = "ctxAck";
            this.ctxAck.Size = new System.Drawing.Size(95, 26);
            // 
            // ackToolStripMenuItem
            // 
            this.ackToolStripMenuItem.Name = "ackToolStripMenuItem";
            this.ackToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.ackToolStripMenuItem.Text = "Ack";
            this.ackToolStripMenuItem.Click += new System.EventHandler(this.ackToolStripMenuItem_Click);
            // 
            // timerRgMissBC
            // 
            this.timerRgMissBC.Interval = 1800000;
            this.timerRgMissBC.Tick += new System.EventHandler(this.timerRgMissBC_Tick);
            // 
            // timerFirstTime
            // 
            this.timerFirstTime.Interval = 900;
            this.timerFirstTime.Tick += new System.EventHandler(this.timerFirstTime_Tick);
            // 
            // txbLog
            // 
            this.txbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbLog.Location = new System.Drawing.Point(5, 5);
            this.txbLog.MaxLength = 100000;
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(665, 70);
            this.txbLog.TabIndex = 10;
            this.txbLog.TextChanged += new System.EventHandler(this.txbLog_TextChanged);
            // 
            // btnMoreData
            // 
            this.btnMoreData.Location = new System.Drawing.Point(3, 133);
            this.btnMoreData.Name = "btnMoreData";
            this.btnMoreData.Size = new System.Drawing.Size(15, 41);
            this.btnMoreData.TabIndex = 11;
            this.btnMoreData.Text = "<";
            this.btnMoreData.UseVisualStyleBackColor = true;
            this.btnMoreData.Click += new System.EventHandler(this.btnMoreData_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txbLog);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(675, 343);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblR5);
            this.splitContainer2.Panel1.Controls.Add(this.lblEndString);
            this.splitContainer2.Panel1.Controls.Add(this.lblCompilationMode);
            this.splitContainer2.Panel1.Controls.Add(this.lblUpdateDate);
            this.splitContainer2.Panel1.Controls.Add(this.lblLastBgModeDB);
            this.splitContainer2.Panel1.Controls.Add(this.btnLessData);
            this.splitContainer2.Panel1.Controls.Add(this.lblR6);
            this.splitContainer2.Panel1.Controls.Add(this.btnTest);
            this.splitContainer2.Panel1.Controls.Add(this.lblData);
            this.splitContainer2.Panel1.Controls.Add(this.lblDataBG);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblTime);
            this.splitContainer2.Panel2.Controls.Add(this.lblRgStatus);
            this.splitContainer2.Panel2.Controls.Add(this.lblTCAlarm);
            this.splitContainer2.Panel2.Controls.Add(this.lblRgMessageBG);
            this.splitContainer2.Panel2.Controls.Add(this.lblRgMessage);
            this.splitContainer2.Panel2.Controls.Add(this.btnAckBG);
            this.splitContainer2.Panel2.Controls.Add(this.btnAckTC);
            this.splitContainer2.Panel2.Controls.Add(this.btnAck);
            this.splitContainer2.Panel2.Controls.Add(this.lblR12);
            this.splitContainer2.Panel2.Controls.Add(this.btnMoreData);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.lblR4);
            this.splitContainer2.Panel2.Controls.Add(this.lblR2);
            this.splitContainer2.Panel2.Controls.Add(this.lblR11);
            this.splitContainer2.Panel2.Controls.Add(this.lblR13);
            this.splitContainer2.Panel2.Controls.Add(this.picBoxAlarmBG);
            this.splitContainer2.Panel2.Controls.Add(this.lblMode);
            this.splitContainer2.Panel2.Controls.Add(this.picBoxAlarm);
            this.splitContainer2.Panel2.Controls.Add(this.lblR3);
            this.splitContainer2.Panel2.Controls.Add(this.lblModeBG);
            this.splitContainer2.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer2.Panel2.Controls.Add(this.lblTime2);
            this.splitContainer2.Panel2.Controls.Add(this.lblTime3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(675, 259);
            this.splitContainer2.SplitterDistance = 332;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblEndString
            // 
            this.lblEndString.AutoSize = true;
            this.lblEndString.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndString.Location = new System.Drawing.Point(142, 234);
            this.lblEndString.Name = "lblEndString";
            this.lblEndString.Size = new System.Drawing.Size(72, 14);
            this.lblEndString.TabIndex = 15;
            this.lblEndString.Text = "lastEndString";
            // 
            // lblCompilationMode
            // 
            this.lblCompilationMode.AutoSize = true;
            this.lblCompilationMode.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompilationMode.Location = new System.Drawing.Point(258, 234);
            this.lblCompilationMode.Name = "lblCompilationMode";
            this.lblCompilationMode.Size = new System.Drawing.Size(58, 14);
            this.lblCompilationMode.TabIndex = 15;
            this.lblCompilationMode.Text = "cmp mode";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDate.Location = new System.Drawing.Point(19, 9);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(56, 14);
            this.lblUpdateDate.TabIndex = 15;
            this.lblUpdateDate.Text = "u1701 1955";
            // 
            // lblLastBgModeDB
            // 
            this.lblLastBgModeDB.AutoSize = true;
            this.lblLastBgModeDB.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBgModeDB.Location = new System.Drawing.Point(19, 231);
            this.lblLastBgModeDB.Name = "lblLastBgModeDB";
            this.lblLastBgModeDB.Size = new System.Drawing.Size(66, 14);
            this.lblLastBgModeDB.TabIndex = 15;
            this.lblLastBgModeDB.Text = "lastBGMode";
            // 
            // btnLessData
            // 
            this.btnLessData.Location = new System.Drawing.Point(3, 133);
            this.btnLessData.Name = "btnLessData";
            this.btnLessData.Size = new System.Drawing.Size(15, 41);
            this.btnLessData.TabIndex = 11;
            this.btnLessData.Text = ">";
            this.btnLessData.UseVisualStyleBackColor = true;
            this.btnLessData.Click += new System.EventHandler(this.btnLessData_Click);
            // 
            // lblRgStatus
            // 
            this.lblRgStatus.AutoSize = true;
            this.lblRgStatus.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgStatus.Location = new System.Drawing.Point(174, 5);
            this.lblRgStatus.Name = "lblRgStatus";
            this.lblRgStatus.Size = new System.Drawing.Size(159, 14);
            this.lblRgStatus.TabIndex = 15;
            this.lblRgStatus.Text = "Date : 01/01/1001 Ranging is : N/A";
            // 
            // lblTCAlarm
            // 
            this.lblTCAlarm.AutoSize = true;
            this.lblTCAlarm.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCAlarm.ForeColor = System.Drawing.Color.Red;
            this.lblTCAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTCAlarm.ImageIndex = 0;
            this.lblTCAlarm.Location = new System.Drawing.Point(21, 54);
            this.lblTCAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTCAlarm.Name = "lblTCAlarm";
            this.lblTCAlarm.Size = new System.Drawing.Size(103, 15);
            this.lblTCAlarm.TabIndex = 15;
            this.lblTCAlarm.Text = "TC FORGOTTEN !!";
            this.lblTCAlarm.Visible = false;
            // 
            // lblRgMessageBG
            // 
            this.lblRgMessageBG.AutoSize = true;
            this.lblRgMessageBG.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRgMessageBG.ForeColor = System.Drawing.Color.Red;
            this.lblRgMessageBG.Image = global::StationWorkMode.Properties.Resources.pngwing_com__1_;
            this.lblRgMessageBG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRgMessageBG.Location = new System.Drawing.Point(21, 157);
            this.lblRgMessageBG.Name = "lblRgMessageBG";
            this.lblRgMessageBG.Size = new System.Drawing.Size(131, 17);
            this.lblRgMessageBG.TabIndex = 14;
            this.lblRgMessageBG.Text = "     BG Rang. Missing";
            this.lblRgMessageBG.Visible = false;
            // 
            // lblRgMessage
            // 
            this.lblRgMessage.AutoSize = true;
            this.lblRgMessage.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRgMessage.ForeColor = System.Drawing.Color.Red;
            this.lblRgMessage.Image = global::StationWorkMode.Properties.Resources.pngwing_com__1_;
            this.lblRgMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRgMessage.Location = new System.Drawing.Point(21, 105);
            this.lblRgMessage.Name = "lblRgMessage";
            this.lblRgMessage.Size = new System.Drawing.Size(131, 17);
            this.lblRgMessage.TabIndex = 14;
            this.lblRgMessage.Text = "     BC Rang. Missing";
            this.lblRgMessage.Visible = false;
            // 
            // btnAckBG
            // 
            this.btnAckBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAckBG.Image = global::StationWorkMode.Properties.Resources.pngwing_com__4_;
            this.btnAckBG.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAckBG.Location = new System.Drawing.Point(152, 152);
            this.btnAckBG.Margin = new System.Windows.Forms.Padding(1);
            this.btnAckBG.Name = "btnAckBG";
            this.btnAckBG.Size = new System.Drawing.Size(119, 26);
            this.btnAckBG.TabIndex = 13;
            this.btnAckBG.Text = "      Acknowledge";
            this.btnAckBG.UseVisualStyleBackColor = true;
            this.btnAckBG.Visible = false;
            this.btnAckBG.Click += new System.EventHandler(this.btnAckBG_Click);
            // 
            // btnAckTC
            // 
            this.btnAckTC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAckTC.Image = global::StationWorkMode.Properties.Resources.pngwing_com__4_;
            this.btnAckTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAckTC.Location = new System.Drawing.Point(152, 50);
            this.btnAckTC.Name = "btnAckTC";
            this.btnAckTC.Size = new System.Drawing.Size(119, 26);
            this.btnAckTC.TabIndex = 13;
            this.btnAckTC.Text = "     Acknowledge";
            this.btnAckTC.UseVisualStyleBackColor = true;
            this.btnAckTC.Visible = false;
            this.btnAckTC.Click += new System.EventHandler(this.btnAckTC_Click);
            // 
            // btnAck
            // 
            this.btnAck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAck.Image = global::StationWorkMode.Properties.Resources.pngwing_com__4_;
            this.btnAck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAck.Location = new System.Drawing.Point(152, 100);
            this.btnAck.Name = "btnAck";
            this.btnAck.Size = new System.Drawing.Size(119, 26);
            this.btnAck.TabIndex = 13;
            this.btnAck.Text = "     Acknowledge";
            this.btnAck.UseVisualStyleBackColor = true;
            this.btnAck.Visible = false;
            this.btnAck.Click += new System.EventHandler(this.btnAck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // picBoxAlarmBG
            // 
            this.picBoxAlarmBG.Image = global::StationWorkMode.Properties.Resources.BlackLight;
            this.picBoxAlarmBG.Location = new System.Drawing.Point(276, 112);
            this.picBoxAlarmBG.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxAlarmBG.Name = "picBoxAlarmBG";
            this.picBoxAlarmBG.Size = new System.Drawing.Size(53, 53);
            this.picBoxAlarmBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAlarmBG.TabIndex = 5;
            this.picBoxAlarmBG.TabStop = false;
            // 
            // picBoxAlarm
            // 
            this.picBoxAlarm.Image = global::StationWorkMode.Properties.Resources.BlackLight;
            this.picBoxAlarm.Location = new System.Drawing.Point(276, 59);
            this.picBoxAlarm.Name = "picBoxAlarm";
            this.picBoxAlarm.Size = new System.Drawing.Size(53, 53);
            this.picBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAlarm.TabIndex = 5;
            this.picBoxAlarm.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogToolStripMenuItem,
            this.stopDataBaseTSMItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveLogToolStripMenuItem.Text = "Save Log";
            this.saveLogToolStripMenuItem.Click += new System.EventHandler(this.saveLogToolStripMenuItem_Click);
            // 
            // stopDataBaseTSMItem
            // 
            this.stopDataBaseTSMItem.Enabled = false;
            this.stopDataBaseTSMItem.Name = "stopDataBaseTSMItem";
            this.stopDataBaseTSMItem.Size = new System.Drawing.Size(154, 22);
            this.stopDataBaseTSMItem.Text = "Stop DataBase";
            this.stopDataBaseTSMItem.Click += new System.EventHandler(this.stopDataBaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rangingPlanToolStripMenuItem1,
            this.refreshToolStripMenuItem,
            this.refreshGBModeTSMItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // rangingPlanToolStripMenuItem1
            // 
            this.rangingPlanToolStripMenuItem1.Name = "rangingPlanToolStripMenuItem1";
            this.rangingPlanToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.rangingPlanToolStripMenuItem1.Text = "Ranging Plan";
            this.rangingPlanToolStripMenuItem1.Click += new System.EventHandler(this.rangingPlanToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.refreshToolStripMenuItem.Text = "Refresh Ranging plan";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // refreshGBModeTSMItem
            // 
            this.refreshGBModeTSMItem.Name = "refreshGBModeTSMItem";
            this.refreshGBModeTSMItem.Size = new System.Drawing.Size(191, 22);
            this.refreshGBModeTSMItem.Text = "Refresh BG Mode";
            this.refreshGBModeTSMItem.Click += new System.EventHandler(this.dBConnexionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime2.Font = new System.Drawing.Font("Eras Medium ITC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.Color.Black;
            this.lblTime2.Location = new System.Drawing.Point(208, 209);
            this.lblTime2.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(121, 46);
            this.lblTime2.TabIndex = 1;
            this.lblTime2.Text = "14:42";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTime3.Font = new System.Drawing.Font("Eras Medium ITC", 20F);
            this.lblTime3.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTime3.Location = new System.Drawing.Point(135, 217);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(51, 31);
            this.lblTime3.TabIndex = 1;
            this.lblTime3.Text = " 00";
            // 
            // timerFirstTimeBG
            // 
            this.timerFirstTimeBG.Interval = 900;
            this.timerFirstTimeBG.Tick += new System.EventHandler(this.timerFirstTimeBG_Tick);
            // 
            // timerRgMissBG
            // 
            this.timerRgMissBG.Interval = 1800000;
            this.timerRgMissBG.Tick += new System.EventHandler(this.timerRgMissBG_Tick);
            // 
            // ctxAckBG
            // 
            this.ctxAckBG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ctxAckBG.Name = "ctxAckBG";
            this.ctxAckBG.Size = new System.Drawing.Size(110, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem1.Text = "AckBG";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // timerTC
            // 
            this.timerTC.Interval = 6000;
            this.timerTC.Tick += new System.EventHandler(this.timerTC_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Alarm");
            this.imageList1.Images.SetKeyName(1, "Acknowl");
            // 
            // timerDB
            // 
            this.timerDB.Interval = 6000;
            this.timerDB.Tick += new System.EventHandler(this.timerDB_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 343);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Work Mode v 1.3.3";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctxAck.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarmBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxAckBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox picBoxAlarm;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblModeBG;
        private System.Windows.Forms.PictureBox picBoxAlarmBG;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblR11;
        private System.Windows.Forms.Label lblR12;
        private System.Windows.Forms.Label lblR5;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDataBG;
        private System.Windows.Forms.Label lblR6;
        private System.Windows.Forms.Timer timerBC;
        private System.Windows.Forms.Timer timerBG;
        private System.Windows.Forms.Label lblR13;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Timer timerNoDataBG;
        private System.Windows.Forms.Timer timerRgMissBC;
        private System.Windows.Forms.Timer timerFirstTime;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnMoreData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnLessData;
        private System.Windows.Forms.Timer timerFirstTimeBG;
        private System.Windows.Forms.Timer timerRgMissBG;
        private System.Windows.Forms.ContextMenuStrip ctxAck;
        private System.Windows.Forms.ToolStripMenuItem ackToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxAckBG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnAck;
        private System.Windows.Forms.Label lblRgMessage;
        private System.Windows.Forms.Label lblRgMessageBG;
        private System.Windows.Forms.Button btnAckBG;
        private System.Windows.Forms.Label lblRgStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem rangingPlanToolStripMenuItem1;
        private System.Windows.Forms.Timer timerTC;
        private System.Windows.Forms.Label lblTCAlarm;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAckTC;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblLastBgModeDB;
        private System.Windows.Forms.Timer timerDB;
        private System.Windows.Forms.ToolStripMenuItem stopDataBaseTSMItem;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.ToolStripMenuItem refreshGBModeTSMItem;
        private System.Windows.Forms.Label lblCompilationMode;
        private System.Windows.Forms.Label lblEndString;
    }
}

