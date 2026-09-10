using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StationWorkMode
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnSendBC_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            StringBuilder data = new StringBuilder();
            data.Append(txbDataBC.Text);
            principalForm.TestSendDataBC(data);
            

        }

        private void btnSendBG_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            StringBuilder data = new StringBuilder();
            data.Append(txbDataBG.Text);
            principalForm.TestSendDataBG(data);
        }

        private void btnTestIdle_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            
            
            principalForm.IdleTest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            principalForm.StopIdleTest();
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            principalForm.SetLabel(txbLabelBC.Text, txbLabelBG.Text);
        }

        private void btnStartSend_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            StringBuilder data = new StringBuilder();
            data.Append(txbDataBC.Text);
            principalForm.TestSendDataBC(data);
            data.Append(txbDataBG.Text);
            principalForm.TestSendDataBG(data);

        }

        private void btnStopSend_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnBCRM_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            StringBuilder data = new StringBuilder();
            principalForm.ForceBCRangMissing();
        }

        private void btnBGRM_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            StringBuilder data = new StringBuilder();
            principalForm.ForceBGRangMissing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPlan form3 = new FormPlan();
            form3.Show();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            principalForm.ChangePath(cbxPath.Text);
        }
    }
}
