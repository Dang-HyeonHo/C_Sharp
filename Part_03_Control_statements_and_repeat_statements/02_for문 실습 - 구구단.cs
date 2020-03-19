using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_for문_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * 구구단의 시작은 1부터 -> int i 값을 1로 설정
             */
            int i = 1;
            int num = int.Parse(textBox1.Text);

            label2.Text = "";

            if (num >= 2 && num <= 9)
            {
                for (i = 1; i <= 9; i++)
                {
                    label2.Text += num + " X " + i + " = " + (num * i) + "\n";
                }
            }
            else
            {
                label2.Text = "다시 입력하세요";
            }
        }
    }
}
