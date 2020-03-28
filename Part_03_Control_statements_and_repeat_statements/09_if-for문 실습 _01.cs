using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_실전01
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
                int num = int.Parse(textBox1.Text);
                int i = 1;
                label2.Text = "";

                if (num > 4 && num < 13)
                {
                    for (i = 1; i <= 100; i++)
                    {
                        label2.Text += i.ToString() + " ";

                        if (i % num == 0)
                        {
                            label2.Text += "\n";
                            // 1 % 5 = 1
                            // 2 % 5 = 2
                            // 3 % 5 = 3
                            // 4 % 5 = 4
                            // 5 % 5 = 0
                        }
                    }
                }
                else
                {
                    label2.Text = "4 초과 13 미만의 수를 입력해주세요.";
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
    }
}
