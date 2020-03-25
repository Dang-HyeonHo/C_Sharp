using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_변수위치
{
    public partial class Form1 : Form
    {
        int A_coin = 0;
        int B_coin = 0;

        public Form1()
        {
            InitializeComponent();  // 버튼을 누르지 않아도 디자인 창에 표출
            label2.Text = "A씨의 계좌총액 : " + A_coin.ToString();
            label3.Text = "B씨의 계좌총액 : " + B_coin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int coin = int.Parse(textBox1.Text);

                A_coin += coin;
                B_coin += coin;

                label2.Text = "A씨의 계좌총액 : " + A_coin.ToString();
                label3.Text = "B씨의 계좌총액 : " + B_coin.ToString();
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
