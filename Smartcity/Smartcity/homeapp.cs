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
    public partial class homeapp : Form
    {
        bool lights = false;

        public homeapp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boiler b = new boiler();
            b.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thermostat h = new thermostat();
            h.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffeemachine c = new coffeemachine();
            c.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lights == false)
            {
                lights = true;
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\lampon1.png");
                MessageBox.Show("Door and emergency lights are now ON!");
            }
            else
            {
                lights = false;
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\lampoff1.png");
                MessageBox.Show("Door and emergency lights are now OFF!");
            }
        }

        private void homeapp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, @"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\Smartcityhelp.chm");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\Smartcityhelp.chm");
        }
    }
}
