namespace StationWorkMode
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txbAbout = new System.Windows.Forms.TextBox();
            this.lblR11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbAbout
            // 
            this.txbAbout.Location = new System.Drawing.Point(12, 35);
            this.txbAbout.Multiline = true;
            this.txbAbout.Name = "txbAbout";
            this.txbAbout.ReadOnly = true;
            this.txbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbAbout.Size = new System.Drawing.Size(549, 198);
            this.txbAbout.TabIndex = 1;
            this.txbAbout.Text = resources.GetString("txbAbout.Text");
            // 
            // lblR11
            // 
            this.lblR11.AutoSize = true;
            this.lblR11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR11.Location = new System.Drawing.Point(12, 13);
            this.lblR11.Name = "lblR11";
            this.lblR11.Size = new System.Drawing.Size(78, 19);
            this.lblR11.TabIndex = 3;
            this.lblR11.Text = "What is it :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "What\'s new :";
            // 
            // txbNew
            // 
            this.txbNew.Location = new System.Drawing.Point(12, 258);
            this.txbNew.Multiline = true;
            this.txbNew.Name = "txbNew";
            this.txbNew.ReadOnly = true;
            this.txbNew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbNew.Size = new System.Drawing.Size(549, 246);
            this.txbNew.TabIndex = 2;
            this.txbNew.Text = resources.GetString("txbNew.Text");
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblR11);
            this.Controls.Add(this.txbNew);
            this.Controls.Add(this.txbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Work Station Mode";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAbout;
        private System.Windows.Forms.Label lblR11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNew;
    }
}