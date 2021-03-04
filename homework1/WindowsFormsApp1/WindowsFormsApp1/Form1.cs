using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string s = "";
        public static string a = "";
        public static string b = "";
        public static float c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e)
        {
            s = button1.Text;
        }

        private void button2_click(object sender, EventArgs e)
        {
            s = button2.Text;
        }

        private void button3_clock(object sender, EventArgs e)
        {
            s = button3.Text;
        }

        private void button4_click(object sender, EventArgs e)
        {
            s = button4.Text;
        }

        private void button5_click(object sender, EventArgs e)
        {
            answer_changed(sender, e);
        }

        private void text1_changed(object sender, EventArgs e)
        {
            a = textBox1.Text;
        }

        private void text2_changed(object sender, EventArgs e)
        {
            b = textBox2.Text;
        }

        private void answer_changed(object sender, EventArgs e)
        {
            float x = float.Parse(a);
            float y = float.Parse(b);
            if (s == "+")
            {
                c = x + y;
                textBox3.Text = c.ToString();
            }
            else if (s == "-")
            {
                c = x - y;
                textBox3.Text = c.ToString();
            }
            else if (s == "*")
            {
                c = x * y;
                textBox3.Text = c.ToString();
            }
            else if(s == "/"){
                if (b == "0")
                {
                    textBox3.Text = "false";
                }
                else
                {
                    textBox3.Text = c.ToString();
                }
            }
        }
    }
}
