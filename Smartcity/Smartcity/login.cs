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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string usr = "user1";
        string psw = "12345";
        string usr2 = "user2";
        string psw2 = "67890";
        string usr3 = "user3";
        string psw3 = "10112";
        private void username_TextChanged(object sender, EventArgs e)
        {      }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((username.Text == usr) && (password.Text == psw)) || ((username.Text == usr2) && (password.Text == psw2)) || ((username.Text == usr3) && (password.Text == psw3)))
            {
                intro h = new intro();
                this.Hide();
                h.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your credentials are incorrect. Please try again...");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, @"C:\Users\xristos\Desktop\Smartcity\Smartcityhelp.chm");
            }
        }
    }
}
