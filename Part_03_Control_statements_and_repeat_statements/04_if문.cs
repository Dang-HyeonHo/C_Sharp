using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_if문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = textBox1.Text;

            // if -> (else if) -> (else)
            
            if (gender == "여자" || gender == "여성" || gender == "여")
                //if 의 조건이 ture 일 때
                label1.Text = "입장하신 사용자는 여자입니다.";

            else if (gender == "남자" || gender == "남성" || gender == "남")            
                //if 의 조건 말고 또 다른 조건이 필요할 때 else if
                label1.Text = "입장하신 사용자는 남자입니다.";

            else            
                // 위의 조건이 모두 false 일때
                label1.Text = "다시 입력해주세요.";
        }
    }
}
