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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void καφετέριαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cafe c = new Cafe();
            c.ShowDialog();
        }
    }
}
