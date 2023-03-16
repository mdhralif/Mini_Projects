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

            string file = "C:\\Users\\Hp\\Desktop\\Verification";
            bool flag1 = false;
            bool flag2 = false;

            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                int i = 1;
                foreach (string line in lines)
                {
                    if (i % 3 == 2 && line == user_textbox.Text) flag1 = true;
                    if (i % 3 == 0 && line == user_textbox.Text) flag2 = true;
                    i++;
                }

            }
            if (flag1 && flag2)
            {
                username = user_textbox.Text;
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }

        }
    }
}
