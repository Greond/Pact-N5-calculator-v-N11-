using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Канкулятор
{
    public partial class Form1 : Form
    {
        public string textbox_text;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '/';
        }

        private void answer_Click(object sender, EventArgs e)
        {
            
            double rez = Convert.ToDouble(new DataTable().Compute(textBox1.Text, ""));
            textBox1.Text = rez.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void степень_Click(object sender, EventArgs e)
        {
            double x  = Convert.ToDouble(textBox1.Text);
            x = x * x * x;
            textBox1.Text = x.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            x = Math.Log10(x);
            textBox1.Text = x.ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            x = Math.Tan(x);
         
            if (x < 0)
            {
                x = x * -1;
            }
            x = 180/Math.PI * x;
            textBox1.Text = x.ToString();
        }
    }
}
