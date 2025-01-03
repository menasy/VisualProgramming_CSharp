using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H5Project1
{
    public partial class Form1 : Form
    {
        int price;
        int sigorta = 0;
        int ekBagaj = 0;
        int bebek = 0;
        double bindirim = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Uçak");
            comboBox1.Items.Add("Otobus");
            comboBox1.Items.Add("Tren");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("İstanbul");
            comboBox2.Items.Add("Şırnak");

            comboBox4.Items.Clear();
            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");


            comboBox4.Enabled = false;
        }

        private void refreshPrice(object sender, EventArgs e)
        {
            if (comboBox2.Text == "İstanbul" && comboBox1.Text == "Uçak")
            {
                textBox1.Text = "2500";
                price = 2500;
            }
            else if (comboBox2.Text == "Şırnak" && comboBox1.Text == "Uçak")
            {
                textBox1.Text = "2000";
                price = 2000;
            }
            else if (comboBox2.Text == "İstanbul" && comboBox1.Text == "Otobus")
            {
                textBox1.Text = "1500";
                price = 1500;
            }
            else if (comboBox2.Text == "Şırnak" && comboBox1.Text == "Otobus")
            {
                textBox1.Text = "1000";
                price = 1000;
            }
            else if (comboBox2.Text == "İstanbul" && comboBox1.Text == "Tren")
            {
                textBox1.Text = "500";
                price = 500;
            }
            else if (comboBox2.Text == "Şırnak" && comboBox1.Text == "Tren")
            {
                textBox1.Text = "250";
                price = 250;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPrice(sender, e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPrice(sender, e);
            if (comboBox2.Text == "İstanbul")
            {
                comboBox3.Items.Add("Şırnak");
            }
            else if (comboBox2.Text == "Şırnak")
            {
                comboBox3.Items.Add("İstanbul");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPrice(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                sigorta = 120;
            else
                sigorta = 0;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                comboBox4.Enabled = true;
            else
                comboBox4.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                bebek = 250;
            else
                bebek = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string radioText;
           double newPrice;
           double ekstra;

            if (radioButton1.Checked)
                radioText = radioButton1.Text;
            else if (radioButton2.Checked)
                radioText = radioButton2.Text;
            else
                radioText = "";

            if (radioButton1.Checked)
                bindirim = 0.50;
            else if (radioButton2.Checked)
                bindirim = 0.20;
            else
                bindirim = 0;
            newPrice = price + (price * bindirim);
            ekstra = sigorta + ekBagaj + bebek;
            newPrice += ekstra;
            
               textBox2.Text = "Ulaşım Türü\t\t\t:" + comboBox1.Text + Environment.NewLine + "\t\tNereden: " + comboBox2.Text + Environment.NewLine + "\t\tNereye: "
                + comboBox3.Text + Environment.NewLine + "Bilet Fiyatı\t\t\t\t:" + textBox1.Text + Environment.NewLine
                + "Ek Hizmetler: " + Environment.NewLine + "\t Sigorta: " + Convert.ToString(sigorta)
                + Environment.NewLine + "\tEk Bagaj: " + Convert.ToString(ekBagaj) + Environment.NewLine + "\t3 Yaş Altı Bebek: " + Convert.ToString(bebek) + Environment.NewLine
                +"Koltuk Türü\t\t\t:" + radioText + "%" + Convert.ToString(bindirim *100) + Environment.NewLine + "Toplam Fiyat\t\t\t: " + Convert.ToString(newPrice);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "1")
                ekBagaj = 50;
            else if (comboBox4.Text == "2")
                ekBagaj = 100;
            else if (comboBox4.Text == "3")
                ekBagaj = 200;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                bindirim = 0.20;
            else if (radioButton2.Checked)
                bindirim = 0.50;
            else
                bindirim = 0;
        }
    }
}
