using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_계산기
{
    public partial class Form1 : Form
    {
        double result = 0;  // 수식이 적용되는 부분 : 결과
               
        public Form1()
        {
            InitializeComponent();
            label1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                double num = double.Parse(textBox1.Text);
                result += num;  // 더하기
                label1.Text = result.ToString();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            try
            {
                double num = double.Parse(textBox1.Text);
                result -= num;  // 빼기
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                result *= num;  //곱하기
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);

                if (num != 0)
                {
                    result /= num;  //나누기
                    label1.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                result = 0;     //초기화 (계산기 C ==)
                label1.Text = result.ToString();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
