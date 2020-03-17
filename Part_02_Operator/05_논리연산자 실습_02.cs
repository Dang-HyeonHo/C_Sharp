using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_논리연산자_실습_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kind = textBox1.Text;

            bool KY = (kind == "강아지") || (kind == "고양이");

            label2.Text = "진료가 가능한 종입니다 + " + KY;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox2.Text);

            bool MY = (month >= 0 && 30 >= month);

            label4.Text = "진료가 가능한 개월입니다 + " + MY;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox2.Text);
            string kind = textBox1.Text;

            bool KY = (kind == "강아지") || (kind == "고양이");
            bool MY = (month >= 0 && 30 >= month);

            bool yes = KY && MY;

            label5.Text = "이 동물의 진료를 받을 수 있는건가 : + " + yes;
        }
    }
}
