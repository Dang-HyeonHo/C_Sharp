using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_연산자_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            label1.Text = dData.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            label1.Text = dData.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            label1.Text = dData.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dDate = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            label1.Text = dDate.ToString();
            
            label1.Text += "\n" + 3 + "5"; // 덧붙이기 연습

            /*label1.Text = dDate.Tosting + "\n" + 3 + "5"; -> dDate.Tosting
                                                               35*/
            // 정수 3 + 정수 5 = 정수 8
            // 문자 3 + 문자 5 = 문자 35
            // 정수 < 실수 < 문자 (큰걸 따라가)
            // 정수 3 + 문자 5 = 문자 35
        }
    }
}
