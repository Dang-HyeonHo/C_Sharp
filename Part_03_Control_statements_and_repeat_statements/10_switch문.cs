using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch문
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

            switch (num)
            {
                case 0:     // textBox1.Text == 0 일때만 반응
                    label1.Text = "0입니다.";
                    break;  // 반복문을 1회 벗어난다.
                case 1:
                    label1.Text = "1입니다.";
                    break;
                default:    // 지정값을 제외한 값일 경우 반응
                    label1.Text = "0과 1은 아니네요.";
                    break;
            }
        }
    }
}
