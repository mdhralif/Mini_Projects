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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Authentication
{
    public partial class Form1 : Form
    {
        public static Form1 form1instance;
        public string username;
        public Form1()
        {
            InitializeComponent();
            form1instance = this;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string file = "C:\\Users\\Hp\\Desktop\\Verification\\Authentication\\pass.txt";
            bool flag = false;

            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                for(int i = 0; i < lines.Length; i++)
                {
                    if (i % 3 == 1 && lines[i] == user_textbox.Text)
                    {
                        if (lines[i+1] == pwtextbox.Text) flag = true;

                    }
                }

            }
            if (flag)
            {
                username = user_textbox.Text;
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else MessageBox.Show("Username or password incorrect!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
