using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hotel A");
            comboBox1.Items.Add("Hotel B");
            comboBox1.Items.Add("Hotel C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hotel A")
                textBox1.Text = "2500";
            else if (comboBox1.Text == "Hotel B")
                textBox1.Text = "3500";
            else if (comboBox1.Text == "Hotel C")
                textBox1.Text = "4500";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hotel A")
                textBox1.Text = "5500";
            else if (comboBox1.Text == "Hotel B")
                textBox1.Text = "6500";
            else if (comboBox1.Text == "Hotel C")
                textBox1.Text = "7500";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hotel A")
                textBox1.Text = "8500";
            else if (comboBox1.Text == "Hotel B")
                textBox1.Text = "9500";
            else if (comboBox1.Text == "Hotel C")
                textBox1.Text = "9550";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            int timeHotel;

            price = Convert.ToInt32(textBox1.Text);
            timeHotel =  Convert.ToInt32(textBox2.Text);

            textBox3.Text = Convert.ToString(price * timeHotel);
        }   
    }
}
