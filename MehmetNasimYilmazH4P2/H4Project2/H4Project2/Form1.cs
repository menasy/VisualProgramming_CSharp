using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4Project2
{
    public partial class Form1 : Form
    {
        int price;
        double indirim;
        int kargoSigortasi;
        int hizliTes;
        int eskiMusteri;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kitap");
            comboBox1.Items.Add("Kalem");
            comboBox1.Items.Add("Roket");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kitap")
                textBox1.Text = "50";
            else if (comboBox1.Text == "Kalem")
                textBox1.Text = "20";
            else if (comboBox1.Text == "Roket")
                textBox1.Text = "200";
            price = Convert.ToInt32(textBox1.Text);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                kargoSigortasi = 40;
                hizliTes = 50;
            }
            else
            {
                kargoSigortasi = 40;
                hizliTes = 0;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked && checkBox2.Checked)
            {
                kargoSigortasi = 40;
                hizliTes = 50;
            }
            else
            {
                kargoSigortasi = 0;
                hizliTes = 50;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            indirim = 50;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            indirim = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            double normTutar;
            double indirimTutar;
            double toplamTutar;
            string str;
            if (radioButton1.Checked)
                str = radioButton1.Text;
            else if (radioButton2.Checked)
                str = radioButton1.Text;
            else
                str = "bos";

            count = Convert.ToInt32(textBox2.Text);
            normTutar = count * price + kargoSigortasi + hizliTes;
            indirimTutar = (normTutar * (indirim / 100));
            toplamTutar = normTutar - indirimTutar;
            textBox3.Text = "Ürün\t\t\t:" + comboBox1.Text + Environment.NewLine + "\t Fiyatı: " + textBox1.Text + Environment.NewLine + "\t Adedi: "
                + textBox2.Text + Environment.NewLine + "Ek Hizmetler: " + Environment.NewLine + "\t Kargo Sigortası: " + Convert.ToString(kargoSigortasi)
                + Environment.NewLine + "\tHızlı Teslimat: " + Convert.ToString(hizliTes) + Environment.NewLine + "İndirim: " + Environment.NewLine + "\t"
                + Environment.NewLine +  str + "\t:%" + Convert.ToString(indirim) + Environment.NewLine + Environment.NewLine + "Toplam Fiyat\t\t\t: " + Convert.ToString(toplamTutar);



        }
    }
}
