using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_if문_실습_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int korean = int.Parse(textBox1.Text);
            int math = int.Parse(textBox2.Text);
            int english = int.Parse(textBox3.Text);

            int sum = korean + math + english;
            double average = sum / 3;
            // 평균 = 전체의 합 / 항목의 종류

            label6.Text = "과목의 평균은 " + average.ToString() + ", 성적 평가는 ";

            if (average <= 100 && average > 90)
            {
                label6.Text += "'수'";
            }
            else if (average <= 90 && average > 80)
            {
                label6.Text += "'우'";
            }
            else if (average <= 80 && average > 70)
            {
                label6.Text += "'미'";
            }
            else if (average <= 70 && average > 60)
            {
                label6.Text += "'양'";
            }
            else if (average <= 60 && average >= 0)
            {
                label6.Text += "'가'";
            }
            label6.Text += "입니다.";
        }
    }
}
