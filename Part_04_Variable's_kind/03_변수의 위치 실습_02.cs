using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_응용예제2
{
    
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int sum = 0;

                if (n > 0 && n < 50000)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        sum += i;
                        label2.Text = "합 : " + sum;
                    }
                }
                else
                {
                    label2.Text = "50000 이하의 숫자를 입력해주세요";
                }

                count++;
                label3.Text = "프로그램 실행 후 현재까지의 이용횟수 : " + count.ToString();
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                label3.Text = ex.Message;
            }
        }
    }
}
