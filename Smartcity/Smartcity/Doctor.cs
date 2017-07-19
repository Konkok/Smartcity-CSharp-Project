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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {     }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Ασθενής: " + textBox1.Text);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("Ημερομηνία ραντεβού: " + dateTimePicker1.Text);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("Ειδικότητα Ιατρού: ");
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                richTextBox1.AppendText( checkedListBox1.CheckedItems[i].ToString() + " ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η διαδικασία ολοκληρώθηκε με επιτυχία");
            this.Close();
        }
    }
}
