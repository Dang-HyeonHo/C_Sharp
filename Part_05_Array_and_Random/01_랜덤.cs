using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_랜덤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random ranNum = new System.Random();

            /*
            int num1 = ranNum.Next(1, 5);
            int num2 = ranNum.Next(6, 20);

            label1.Text = num1 + ", " + num2;
            */

            int[] num = new int[5];     // new int[5] = index 크기 5 [0, 1, 2, 3, 4]
            label1.Text = "";

            for (int i = 0; i < num.Length; i++)
                num[i] = ranNum.Next(1, 50);    // (START, END) START부터 END - 1까지

            for (int i = 0; i < num.Length; i++)
               label1.Text += num[i] + ", ";

            label1.Text = label1.Text.TrimEnd(' ', ',');
        }
    }
}
