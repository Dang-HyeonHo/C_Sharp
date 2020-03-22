using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_if문_실습_01
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
            string gender = textBox2.Text;

            if (((age >= 5 && age <= 15) && gender == "남") || ((age >= 8 && age <= 20) && gender == "여"))
            {
                label4.Text = "할인 대상자입니다.";
            }
            else
            {
                label4.Text = "할인 대상자가 아닙니다.";
            }
        }
    }
}
