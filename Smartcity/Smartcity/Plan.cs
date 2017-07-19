using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Smartcity
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
        }


        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string home = "Δρυάδων+34,+Γαλάτσι";
            

            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("https://www.google.gr/maps/dir/");
                query.Append(home+"/");






                string x="";
                if (comboBox1.Text != "")
                {
                    x = comboBox1.Text;


                    if (x == "Πανεπιστήμιο")
                    {
                        query.Append("Πανεπιστήμιο+Πειραιώς/");
                    }
                    else if (x == "Καφετέρια")
                    {
                        query.Append("Mikel+Γαλάτσι/");
                    }
                    else if (x == "Φίλος")
                    {
                        query.Append("Δόλιανης+43/");
                    }
                    else if (x == "Σπίτι")
                    {
                        query.Append("Δρυάδων+34,+Γαλάτσι/");
                    }
                    else
                    {
                        query.Append(Prompt.ShowDialog("Προορισμός:", "Ώρα 08:00") + "/");
                        
                    }
                }



                if (comboBox2.Text != "")
                {
                    x = comboBox2.Text;


                    if (x == "Πανεπιστήμιο")
                    {
                        query.Append("Πανεπιστήμιο+Πειραιώς/");
                    }
                    else if (x == "Καφετέρια")
                    {
                        query.Append("Mikel+Γαλάτσι/");
                    }
                    else if (x == "Φίλος")
                    {
                        query.Append("Δόλιανης+43/");
                    }
                    else if (x == "Σπίτι")
                    {
                        query.Append("Δρυάδων+34,+Γαλάτσι/");
                    }
                    else
                    {
                        query.Append(Prompt.ShowDialog("Προορισμός:", "Ώρα 10:00") + "/");
                        
                    }
                }



                if (comboBox3.Text != "")
                {
                    x = comboBox3.Text;


                    if (x == "Πανεπιστήμιο")
                    {
                        query.Append("Πανεπιστήμιο+Πειραιώς/");
                    }
                    else if (x == "Καφετέρια")
                    {
                        query.Append("Mikel+Γαλάτσι/");
                    }
                    else if (x == "Φίλος")
                    {
                        query.Append("Δόλιανης+43/");
                    }
                    else if (x == "Σπίτι")
                    {
                        query.Append("Δρυάδων+34,+Γαλάτσι/");
                    }
                    else
                    {
                        query.Append(Prompt.ShowDialog("Προορισμός:", "Ώρα 12:00") + "/");
                    }
                }


                if (comboBox4.Text != "")
                {
                    x = comboBox4.Text;


                    if (x == "Πανεπιστήμιο")
                    {
                        query.Append("Πανεπιστήμιο+Πειραιώς/");
                    }
                    else if (x == "Καφετέρια")
                    {
                        query.Append("Mikel+Γαλάτσι/");
                    }
                    else if (x == "Φίλος")
                    {
                        query.Append("Δόλιανης+43/");
                    }
                    else if (x == "Σπίτι")
                    {
                        query.Append("Δρυάδων+34,+Γαλάτσι/");
                    }
                    else
                    {
                        query.Append(Prompt.ShowDialog("Προορισμός:", "Ώρα 14:00") + "/");
                    }
                }


                if (comboBox5.Text != "")
                {
                    x = comboBox5.Text;


                    if (x == "Πανεπιστήμιο")
                    {
                        query.Append("Πανεπιστήμιο+Πειραιώς/");
                    }
                    else if (x == "Καφετέρια")
                    {
                        query.Append("Mikel+Γαλάτσι/");
                    }
                    else if (x == "Φίλος")
                    {
                        query.Append("Δόλιανης+43/");
                    }
                    else if (x == "Σπίτι")
                    {
                        query.Append("Δρυάδων+34,+Γαλάτσι/");
                    }
                    else
                    {
                        query.Append(Prompt.ShowDialog("Προορισμός:", "Ώρα 16:00") + "/");

                    }
                }



                

                //Uri url = new Uri("https://www.google.gr/maps/dir/Δρυάδων 34, Γαλάτσι 111 46/Πανεπιστήμιο+Πειραιώς");
                Uri url = new Uri(query.ToString());
                //Uri url = new Uri("https://www.google.gr/maps/place/@38.0194281,23.7439517,15z/data=!3m1!4b1!4m5!3m4!1s0x14a1a28473fc2781:0x1c00bd30206d0ba0!8m2!3d38.0192869!4d23.7520535!5m1!1e1");



                webBrowser1.Navigate(url);
                //webBrowser1.Navigate(url + "!5m1!1e1");
                //MessageBox.Show(url.ToString());
                // AIzaSyDDVFAgSfaaqZERXBF3PUuaf0-_pgMrBeg    api key
            }
            catch { }
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            Key.Close();
        }

        private void Traffic_Click(object sender, EventArgs e)
        {
            Uri url1 = new Uri("https://www.google.gr/maps/place/@38.0194281,23.7439517,15z/data=!3m1!4b1!4m5!3m4!1s0x14a1a28473fc2781:0x1c00bd30206d0ba0!8m2!3d38.0192869!4d23.7520535!5m1!1e1");
            webBrowser1.Navigate(url1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\Konstantinos\Desktop\SmartCity 1.0.0\Smartcity\Smartcity\Smartcityhelp.chm");
        }

           


    }
}
