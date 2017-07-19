﻿using System;
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
    public partial class thermostat : Form
    {

        bool state = false;
        
        public thermostat()
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
                MessageBox.Show("Thermostat is ON!");
            }
            else
            {
                state = false;
                button1.BackColor = Color.Red;
                button1.Text = "OFF";
                MessageBox.Show("Thermostat is OFF!");
            }
        }

        private void thermostat_Load(object sender, EventArgs e)
        {

        }
    }
}
