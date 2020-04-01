using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_실습02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random ran = new System.Random();

            int[] num = new int[5];
            int bonus;
            
            label1.Text = "당첨번호 : ";

            for (int i = 0; i < num.Length; i++)
            {
                int temp = ran.Next(1, 100);    // 임시저장
                int cnt = 0;                    // 중복되는 것이 있는지

                for (int j = 0; j < i; j++)     // 현재보다 앞에 있는 인덱스 중, 중복된 값이 있는지
                {
                    if (temp == num[j])
                        cnt++;
                }

                if (cnt > 0)                    // 중복된 값이 있을 경우
                    i--;
                else
                    num[i] = temp;              // 중복된 값이 없을 경우 (임시값을 배열에 저장)
            }

            for (int i = 0; i < num.Length; i++)
                label1.Text += num[i] + ", ";

            label1.Text = label1.Text.TrimEnd(' ', ',');

            while (true)
            {
                int cnt = 0;
                int i = 0;
                int temp = ran.Next(1, 100);         // 임시저장

                for (i = 0; i < num.Length; i++)     // 현재보다 앞에 있는 인덱스 중, 중복된 값이 있는지
                {
                    if (temp == num[i])
                        cnt++;
                }

                if (cnt > 0)                         // 중복된 값이 있을 경우
                    i--;
                else                {
                    bonus = temp;                    // 중복된 값이 없을 경우 (임시값을 배열에 저장)
                    break;
                }
            }

            label1.Text += "\n보너스 번호 : " + bonus;
        }
    }
}
