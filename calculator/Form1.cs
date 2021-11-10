using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        Button button1 = b1(Convert.ToInt32);

        }

        private Button b1(Func<object, int> toInt32)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            Button button2 = b1(Convert.ToInt32);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";

        }
        public static double Add(double arg1, double arg2)
        {
            double num1;
            num1 = arg1 + arg2;
            return num1;
         
        }
        public static double minos(double arg1, double arg2)
        {
            double num1;
            num1 = arg1 - arg2;
            return num1;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int num1 ;
            int num2;
            if (button12.Enabled)
            {
                minos( button1, button2);
            }
            else
            {
                if(button11.Enabled)

                label1.Text = Add(num1, num2).ToString();
            }
        }

     
    }
}
