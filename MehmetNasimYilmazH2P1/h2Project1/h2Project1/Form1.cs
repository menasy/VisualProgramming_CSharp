using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2Project1
{
    public partial class Form1 : Form
    {
        int rand1;
        int rand2;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            rand1 = rnd.Next(0, 1000);
            rand1 = rnd.Next(0, 1000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxNum;
            int minNum;
            int txtNum;

            if (rand1 >= rand2)
            {
                maxNum = rand1;
                minNum = rand2;
            }
            else
            {
                maxNum = rand2;
                minNum = rand1;
            }
            txtNum = Convert.ToInt32(textBox1.Text);
            if (txtNum > minNum && txtNum < maxNum)
                textBox2.Text = "Girdiğiniz sayı random sayıların arasındadır";
            else if(txtNum < minNum)
                textBox2.Text = "Girdiğiniz sayı küçük sayıdan küçüktür";
            else if (txtNum > maxNum)
                textBox2.Text = "Girdiğiniz sayı büyük sayıdan büuüktür";
            else if (txtNum == minNum)
                textBox2.Text = "Girdiğiniz sayı küçük sayıya eşittir";
            else if (txtNum == maxNum)
                textBox2.Text = "Girdiğiniz sayı buyuk sayıya eşittir";


        }
    }
}
