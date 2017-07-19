using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartcity
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cafe c = new Cafe();
            c.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homeapp h = new homeapp();
            h.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\Smartcityhelp.chm");
        }
    }
}
