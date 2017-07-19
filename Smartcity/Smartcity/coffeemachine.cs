using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Smartcity
{
    public partial class coffeemachine : Form
    {

        bool state = false;
        
        public coffeemachine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == false)
            {
                state = true;
                button1.BackColor = Color.LawnGreen;
                button1.Text = "ON";
                MessageBox.Show("Coffee Machine is now preparing your selected Coffee!");
                if (radioButton3.Checked)
                { 
                    SerialPort myport = new SerialPort();
                    myport.BaudRate = 9600;
                    myport.PortName = "COM3";

                    try
                    {
                        myport.Open();
                        if (myport.IsOpen)
                        {
                            myport.WriteLine("10");
                        }
                    }
                    catch(Exception e1)
                    {
                        MessageBox.Show("The machine is currently unavailable...");
                    }
                }
            }
            else
            {
                state = false;
                button1.BackColor = Color.Red;
                button1.Text = "OFF";
                MessageBox.Show("Coffee Machine is OFF!");
            }
        }
    }
}
