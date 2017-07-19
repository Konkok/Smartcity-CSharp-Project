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
    public partial class Supermarket : Form
    {
        public Supermarket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Πελάτης: " + textBox1.Text);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("Διεύθνση αποστολής: " + textBox2.Text);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("Προϊόντα: " );
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                richTextBox1.AppendText(checkedListBox1.CheckedItems[i].ToString() + " ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
