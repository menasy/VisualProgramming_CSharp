using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2Project3
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ortalama;

            if (count == 0)
                count = 1;
            ortalama = sum / count;
            textBox2.Text = Convert.ToString(ortalama);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            count++;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
