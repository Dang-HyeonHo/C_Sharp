using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_응용예제1
{
    public partial class Form1 : Form
    {
        int sum = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int coin = int.Parse(textBox1.Text);

                if (coin >= 1000)
                {
                    label5.Text = "정상적인 금액을 입금해주세요" + "\n" + "현재 계좌 잔액 : " + sum + "원";
                }
                else
                {
                    sum += coin;
                    label5.Text = "현재 계좌 잔액 : " + sum.ToString() + "원";
                }            
            }
            catch(Exception ex)
            {
                label5.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int coin = int.Parse(textBox2.Text);

                if (sum < coin)
                {
                    label5.Text = "정상적인 금액을 입금해주세요" + "\n" + "현재 계좌 잔액 : " + sum + "원";
                }
                else
                {
                    sum -= coin;
                    label5.Text = "현재 계좌 잔액 : " + sum.ToString() + "원";
                }                 
            }
            catch(Exception ex)
            {
                label5.Text = ex.Message;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
    }
}
