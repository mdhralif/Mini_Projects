using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1= new Form1();
            f1.Show();
            this.Hide();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Hp\\Desktop\\Verification";
            bool flag = true;
            if (File.Exists(file))
            {
                if (unametextbox.Text.Length >= 6 && pwtextbox.Text.Length >= 6)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (line == unametextbox.Text)
                        {
                            flag = false; break;
                        }
                    }
                    if (flag == true)
                    {
                        if (pwtextbox.Text == retypetextbox.Text)
                        {
                            File.AppendAllText(file, nametextbox.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, unametextbox.Text);
                            File.AppendAllText(file, "\n");
                            File.AppendAllText(file, pwtextbox.Text);
                            File.AppendAllText(file, "\n");
                            Form1 f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A user with the same user name already exists!");
                    }
                }
                else
                {
                    MessageBox.Show("Username and password must be at least six characters!");
                }
            }

        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
    

