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
    public partial class Cafe : Form
    {
        public Cafe()
        {
            InitializeComponent();
        }

        int X1;
        int X2;
        int X3;
        int X4;
        int sum = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Η πληρωμή θα γίνει μέσω της κάρτας: ");
            richTextBox1.AppendText(numericUpDown4.Value.ToString() + " του πελάτη");
            richTextBox1.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(numericUpDown1.Value.ToString() + " ");
            int count = Convert.ToInt32(numericUpDown1.Value);
            X1 = 3 * count;
            sum = sum + X1;
            richTextBox2.AppendText(X1+"");
            richTextBox2.AppendText(Environment.NewLine);

            if ((radioButton1.Checked) && (checkBox1.Checked))
            {
                richTextBox1.AppendText("Freddo Cappuccino Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton1.Checked) && (checkBox2.Checked))
            {
                richTextBox1.AppendText("Freddo Cappuccino Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton1.Checked) && (checkBox3.Checked))
            {
                richTextBox1.AppendText("Freddo Cappuccino Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton2.Checked) && (checkBox1.Checked))
            {
                richTextBox1.AppendText("Cappuccino Caldo Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton2.Checked) && (checkBox2.Checked))
            {
                richTextBox1.AppendText("Cappuccino Caldo Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton2.Checked) && (checkBox3.Checked))
            {
                richTextBox1.AppendText("Cappuccino Caldo Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton3.Checked) && (checkBox1.Checked))
            {
                richTextBox1.AppendText("Cappuccino Latte Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton3.Checked) && (checkBox2.Checked))
            {
                richTextBox1.AppendText("Cappuccino Latte Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton3.Checked) && (checkBox3.Checked))
            {
                richTextBox1.AppendText("Cappuccino Latte Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(numericUpDown2.Value.ToString() + " ");
            int count2 = Convert.ToInt32(numericUpDown2.Value);
            X2 = 3 * count2;
            sum = sum + X2;
            richTextBox2.AppendText(X2 + "");
            richTextBox2.AppendText(Environment.NewLine);
            if ((radioButton6.Checked) && (checkBox6.Checked))
            {
                richTextBox1.AppendText("Freddo Espresso Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton6.Checked) && (checkBox5.Checked))
            {
                richTextBox1.AppendText("Freddo Espresso Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton6.Checked) && (checkBox4.Checked))
            {
                richTextBox1.AppendText("Freddo Espresso Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton5.Checked) && (checkBox6.Checked))
            {
                richTextBox1.AppendText("Espresso Caldo Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton5.Checked) && (checkBox5.Checked))
            {
                richTextBox1.AppendText("Espresso Caldo Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton5.Checked) && (checkBox4.Checked))
            {
                richTextBox1.AppendText("Espresso Caldo Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton4.Checked) && (checkBox6.Checked))
            {
                richTextBox1.AppendText("Espresso Latte Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton4.Checked) && (checkBox5.Checked))
            {
                richTextBox1.AppendText("Espresso Latte Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton4.Checked) && (checkBox4.Checked))
            {
                richTextBox1.AppendText("Espresso Latte Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(numericUpDown3.Value.ToString() + " ");
            int count3 = Convert.ToInt32(numericUpDown3.Value);
            X3 = 2 * count3;
            sum = sum + X3;
            richTextBox2.AppendText(X3 + "");
            richTextBox2.AppendText(Environment.NewLine);
            if (checkBox7.Checked)
            {
                richTextBox1.AppendText("Χυμό Πορτοκάλι");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if (checkBox8.Checked)
            {
                richTextBox1.AppendText("Νερό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if (checkBox9.Checked)
            {
                richTextBox1.AppendText("Coca Cola");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(numericUpDown5.Value.ToString() + " ");
            int count4 = Convert.ToInt32(numericUpDown5.Value);
            X4 = 3 * count4;
            sum = sum + X4;
            richTextBox2.AppendText(X4 + "");
            richTextBox2.AppendText(Environment.NewLine);
            if ((radioButton7.Checked) && (checkBox10.Checked))
            {
                richTextBox1.AppendText("NES Ζεστό Σκέτο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton7.Checked) && (checkBox11.Checked))
            {
                richTextBox1.AppendText("NES Ζεστό Μέτριο");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton7.Checked) && (checkBox12.Checked))
            {
                richTextBox1.AppendText("NES Ζεστό Γλυκό");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton8.Checked) && (checkBox10.Checked))
            {
                richTextBox1.AppendText("Φραπέ Σκέτο χωρίς γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton8.Checked) && (checkBox11.Checked))
            {
                richTextBox1.AppendText("Φραπέ Μέτριο χωρίς γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton8.Checked) && (checkBox12.Checked))
            {
                richTextBox1.AppendText("Φραπέ Γλυκό χωρίς γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton9.Checked) && (checkBox10.Checked))
            {
                richTextBox1.AppendText("Φραπέ Σκέτο με γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton9.Checked) && (checkBox11.Checked))
            {
                richTextBox1.AppendText("Φραπέ Μέτριο με γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else if ((radioButton9.Checked) && (checkBox12.Checked))
            {
                richTextBox1.AppendText("Φραπέ Γλυκό με γάλα");
                richTextBox1.AppendText(Environment.NewLine);
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        { }
        
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας θα είναι έτοιμη όταν περάσετε από το κατάστημα και το κόστος είναι " + sum  + " ευρώ" );
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\Smartcityhelp.chm");
        }

    }
}