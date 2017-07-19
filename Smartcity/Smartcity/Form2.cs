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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cafe c = new Cafe();
            c.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Security s = new Security();
            s.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Supermarket m = new Supermarket();
            m.ShowDialog();
        }
    }
}
