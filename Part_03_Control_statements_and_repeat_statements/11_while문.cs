using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int i = 0;

            label1.Text = "";

            while (i <= num)            {
                label1.Text += i.ToString() + "\n";
                i += 1;
                // 조건식을 확인
                // 내용 (증감)
            }

            for (i = 0; i <= num; i++)
            {
                // 초기값 확인
                // 조건식 확인 - 부터 반복
                // 내용
                // 증감
            }

            /*
             * <복합 연산자>
             * a = a + 1    >   a += 1
             * a = a - 1    >   a -= 1
             * a = a * 1    >   a *= 1
             * a = a / 1    >   a /= 1
             * 
             * <증감 연산자>
             * a++; >  a의 원래값을 사용하고 ++(1만 증가)     > a
             * ++a; >  a를 사용하기 전에 ++(1만 증가)         > a+1
             * a--; --a;
             */
        }
    }
}
