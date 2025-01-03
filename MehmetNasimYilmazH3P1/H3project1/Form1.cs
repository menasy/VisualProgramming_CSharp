using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            comboBox1.Items.Add("Sayi");
            comboBox1.Items.Add("Harf");

           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] harfler = new object[] { "A", "B", "C", "D", "E", "G", "H" };
            int i = 0;
            if (comboBox1.SelectedItem.ToString() == "Sayi")
                while (++i < 11)
                    comboBox2.Items.Add(Convert.ToString(i));
            else
                comboBox2.Items.AddRange(harfler);
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }
    }
}
