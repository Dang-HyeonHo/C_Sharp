using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_if_for문_실습_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            label2.Text = "";

            for (i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                {
                    label2.Text += "짝 ";
                }
                else
                {
                    label2.Text += i.ToString() + " ";
                }
            }
        }
    }
}
