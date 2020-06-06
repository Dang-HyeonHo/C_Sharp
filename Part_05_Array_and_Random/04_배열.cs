using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_배열
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 배열의 방법

            /* 방법 1                     ※ 가장 많이 선호하는 방법
             * 
             * int[] num = new int[4];
             * 
             * num[0] = N;  num[1] = N;
             * num[2] = N;  num[3] = N;
             * 
             * 4 크기의 배열 - 0, 1, 2, 3  * 0부터 시작
             */

            /* 방법 2
             * 
             * int[] num = {N, N, N, N}
             */

            /* 방법 3
             * 
             * int [] num;
             * num = new int[4]
             * 
             * num[0] = N;  num[1] = N;
             * num[2] = N;  num[3] = N;
             */
        }
    }
}
