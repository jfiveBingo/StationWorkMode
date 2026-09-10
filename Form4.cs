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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txbAbout.SelectionStart = txbAbout.Text.Length;
            txbNew.SelectionStart = txbNew.Text.Length;
        }
    }
}
