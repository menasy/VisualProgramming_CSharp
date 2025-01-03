using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int num = Convert.ToInt32(textBox1.Text);
            while(++i < num)
                if (i % 12 == 0)
                    textBox2.AppendText(Convert.ToString(i) + Environment.NewLine);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
