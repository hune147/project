using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPage1Next_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnPage2Next_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnPage3Prev_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnPage3Next_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btnPage4Next_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
    }
}
