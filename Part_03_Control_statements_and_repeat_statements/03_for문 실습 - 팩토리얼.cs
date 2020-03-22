using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_if_for문_실습_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);

            label2.Text = num + "! = ";

            for (int i = num; i > 0; i--)
                label2.Text += i + " X ";

            label2.Text = label2.Text.TrimEnd(' ', 'X');
        }
    }
}
