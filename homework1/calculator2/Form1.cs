using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        string f;
        int num,num2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = Int32.Parse(this.textBox1.Text);
            
            this.textBox1.Text = "";
            Button b = (Button)sender;
            f = b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
             num = Int32.Parse(this.textBox1.Text);
            
            this.textBox1.Text = "";
            Button b = (Button)sender;
            f = b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
             num = Int32.Parse(this.textBox1.Text);
            this.textBox1.Text = "";
            Button b = (Button)sender;
            f = b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        { 
             num = Int32.Parse(this.textBox1.Text);
            
            this.textBox1.Text = "";
            Button b = (Button)sender;
            f = b.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength - 1 != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            this.textBox1.Text += a.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num2 = Int32.Parse(this.textBox1.Text);
            switch (f) {
                case "+": this.textBox1.Text = (num + num2).ToString();break;
                case "-": this.textBox1.Text = (num - num2).ToString();break;
                case "*": this.textBox1.Text = (num * num2).ToString();break;
                case "/": this.textBox1.Text = (num / num2).ToString();break;
            }
        }
    }
}
