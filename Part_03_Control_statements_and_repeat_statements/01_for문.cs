using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_for문
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
             * for (시작 값 ; 조건(범위) ; 증감) { 내용 }
             * for (int i = 0; i < 50; i++) { 내용 }
             * 
             * 초기값 확인 -> 초기값이 조건문에 true 인지 확인 -> (ture) 내용 실행 > 증감
             * 
             * i = 0 0 < 50 내용 i++ > i = 1
             * i = 1 1 < 50 내용 i++ > i = 2
             * ...
             * i = 49 49 < 50 내용 i++ > i = 50
             * i = 50 50 < 50 false
             * for문 { } 끝난 뒤에 있는 수식
             */
            
            label1.Text = "";

            int num = int.Parse(textBox1.Text);

            for (int i = 0; i <= num; i++)
            {
                label1.Text += i + "\n";
            }
        }
    }
}
