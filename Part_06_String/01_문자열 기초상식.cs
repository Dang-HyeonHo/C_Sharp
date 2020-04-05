using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_문자열_기초상식
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox1.Text;

                if (num.Length != 13)
                {
                    label2.Text = "숫자 13자리를 입력해주세요.";
                }
                else if (num.IndexOf("-") > 0)      // IndexOf("!") -> 괄호 안에 있는 문자를 찾는 명령어
                {
                    label2.Text = "'-'빼고 입력하세요.";
                }
                else
                {
                    label2.Text = "정상 입력되었습니다.";
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
