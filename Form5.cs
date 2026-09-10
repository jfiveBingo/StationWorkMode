using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationWorkMode
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            //mettre les valeur dans la principalForm...
            //principalForm.LoadRgProgram();
            principalForm.dataBase = txbDatabase.Text;
            principalForm.server = txbServer.Text;
            principalForm.user = txbUser.Text;
            principalForm.password = txbPassword.Text;

        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            var principalForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            //mettre les valeur dans la principalForm...
            //principalForm.LoadRgProgram();
            principalForm.dataBase = txbDatabase.Text;
            principalForm.server = txbServer.Text;
            principalForm.user = txbUser.Text;
            principalForm.password = txbPassword.Text;

            this.Close();
        }
    }
}
