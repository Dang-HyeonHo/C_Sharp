using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_논리연산자_실습_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            string gender = textBox2.Text;

            bool man = (5 <= age && age <= 15) && (gender == "남");
            bool woman = (8 <= age && age <= 20) && (gender == "여");

            bool dc = man || woman;

            label4.Text = "이 사람은 할인 받을 수 있는 사람인가 : " + dc;
        }
    }
}
