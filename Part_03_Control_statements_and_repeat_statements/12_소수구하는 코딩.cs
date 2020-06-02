using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_소수구하는_코딩
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
                int a = int.Parse(textBox1.Text);
                int count = 0;

                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                        count++;
                    if (count == 2)
                        label1.Text = a + "는 소수입니다";
                    else
                        label1.Text = a + "는 소수가 아닙니다";
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
