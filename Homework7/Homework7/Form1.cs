using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 400, 600, leng, -Math.PI/2);
        }

        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        int n;
        double leng;


        void drawCayleyTree(int n, double x0, double y0, double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
            Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {
            if (textBox1.Text != null)
            {
                n = Int32.Parse(textBox1.Text);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                leng = double.Parse(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null) { 
            per1 = double.Parse(textBox3.Text);
        }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text!= null){
                per2 = double.Parse(textBox4.Text);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
            {
                th1 = double.Parse(textBox5.Text);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
            {
                th2 = double.Parse(textBox6.Text);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
