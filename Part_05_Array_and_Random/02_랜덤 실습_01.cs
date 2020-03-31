using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_실습01
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

            string[] person = new string[5];
            string[] food = new string[3];

            person[0] = "A";
            person[1] = "B";
            person[2] = "C";
            person[3] = "D";
            person[4] = "E";

            food[0] = "짜장면";
            food[1] = "간짜장";
            food[2] = "짜장라면";

            int ranPerson = ran.Next(0, 5);
            int ranFood = ran.Next(0, 3);

            label2.Text = "골든벨 할 사람 : " + person[ranPerson] + "\n골든벨 할 음식 : " + food[ranFood];
        }
    }
}
