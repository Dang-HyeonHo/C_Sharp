using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_논리연산자_과제_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            /*  입영 가능 조건
             *
             *  성별은 남자
             *  나이는 19 ~ 28살
             *  신체등급은 1 ~ 3등급 만 가능하다고 설정
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = textBox1.Text;

            bool army = (gender == "남");

            label2.Text = "입영 가능한 성별입니다 + " + army;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox2.Text);

            bool old = (age >= 19) && (age <= 28);

            label4.Text = "입영 가능한 나이입니다 + " + old;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int grade = int.Parse(textBox3.Text);

            bool rank = (grade >= 1) && (3 >= grade);

            label7.Text = "현역 입영이 가능한 등급입니다 + " + rank;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox2.Text);
            int grade = int.Parse(textBox3.Text);
            string gender = textBox1.Text;

            bool old = (age >= 19) && (age <= 28);
            bool army = (gender == "남");
            bool rank = (grade >= 1) && (3 >= grade);

            bool yes = old && army && rank;

            label5.Text = "현역병 입영이 가능합니다 + " + yes;
        }
    }
}
