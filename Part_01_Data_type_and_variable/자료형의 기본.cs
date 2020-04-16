using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_자료형의_기본
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData = 1;
            label1.Text = "int의 종류 중 하나는 " + iData + "이다.";
            textBox1.Text = iData.ToString();

            // int는 소수점이 없는 자연수일 때 사용
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData = 0.01;
            label1.Text = "double의 종류 중 하나는 " + dData + "이다.";
            textBox1.Text = dData.ToString();

            // double은 소수점이 있는 실수일 때 사용
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sData = "현호";
            label1.Text = "string의 종류 중 하나는 " + sData + "이다.";
            textBox1.Text = sData;

            // string은 모든 문자를 사용할 때 사용
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Data = double.Parse(textBox1.Text);
            label1.Text = Data.ToString();
            
            // int와 double를 텍스트로 표현하고 싶으면 '.ToString()'을 사용
        }
    }
}
