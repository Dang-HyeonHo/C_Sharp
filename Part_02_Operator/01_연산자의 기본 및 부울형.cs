using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_연산자의_기본_및_부울형_사용
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // a + b > 더하기 (정수)
        // a - b > 빼기   (정수)
        // a * b > 곱하기 (정수)
        // a / b > 나누기 (정수, 실수)

        private void button1_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            label1.Text = button1.Text;
            label2.Text = dData.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            label1.Text = button2.Text;
            label2.Text = dData.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            label1.Text = button3.Text;
            label2.Text = dData.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dData = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            label1.Text = button4.Text;
            label2.Text = dData.ToString();
        }

        //부울형(bool) [참 true / 거짓 false]을 판별

        // 연산자의 종류
        // == (같다)  != (다르다) 
        // >= (이상)  <= (이하)
        // > (초과)   < (미만)

        private void button5_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) > double.Parse(textBox2.Text);
            label1.Text = ">";
            label2.Text = "결과는 " + bData;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) >= double.Parse(textBox2.Text);
            label1.Text = ">=";
            label2.Text = "결과는 " + bData;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) == double.Parse(textBox2.Text);
            label1.Text = "==";
            label2.Text = "결과는 " + bData;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) < double.Parse(textBox2.Text);
            label1.Text = "<";
            label2.Text = "결과는 " + bData;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) <= double.Parse(textBox2.Text);
            label1.Text = "<=";
            label2.Text = "결과는 " + bData;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool bData = double.Parse(textBox1.Text) != double.Parse(textBox2.Text);
            label1.Text = "!=";
            label2.Text = "결과는 " + bData;
        }
    }
}
