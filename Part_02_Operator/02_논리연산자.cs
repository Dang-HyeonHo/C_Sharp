using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_논리연산자
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 논리연산자
            // 그리고(AND &&) 또한(OR ||)
            // AND(&&) : T && T (T), T && F (F), F && F (F)
            // OR(||) : T || T (T), T || F (T), F || F (F)
            // ex) 15세 미만, 65세 초과인 사람은 할인

            int iData = int.Parse(textBox1.Text);
            bool bData = iData < 15 || iData > 65;
            label1.Text = "이 사람은 할인을 받을 수 있는 나이이다. : " + bData;
        }
    }
}
