using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_if_for문_실습_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);

            if (age < 15 || age >= 60)
            {
                if (age == 12)
                {
                    label2.Text = "반액할인";
                }
                else
                {
                    label2.Text = "할인혜택";
                }
            }
            else
            {
                label2.Text = "할인혜택 없음";
            }
        }
    }
}
