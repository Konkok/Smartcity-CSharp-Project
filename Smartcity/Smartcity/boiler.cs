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
    public partial class boiler : Form
    {

        bool state = false;

        public boiler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == false)
            {
                state = true;
                button1.BackColor = Color.LawnGreen;
                MessageBox.Show("Boiler is ON!");
            }
            else
            {
                state = false;
                button1.BackColor = Color.Red;
                button1.Text = "ON";
                MessageBox.Show("Boiler is OFF!");
            }
        }
    }
}
