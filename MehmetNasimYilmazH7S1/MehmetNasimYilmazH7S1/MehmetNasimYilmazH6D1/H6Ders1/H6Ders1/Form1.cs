using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H6Ders1
{
    public partial class Form1 : Form
    {
        const int sirIst = 2500;
        const int sirMar = 1000;
        const int marIst = 2000;
        int iadeliBilet = 0, sigorta = 0, ekBagaj = 0, yemekPrice = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Şırnak");
            comboBox1.Items.Add("Mardin");
            comboBox1.Items.Add("Istanbul");

            comboBox3.Visible = false; // ek bagaj
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }



        private void refreshTextbox(object sender, EventArgs e, int sirIst, int sirMar, int marIst)
        {
            string sir_ist, sir_mar, mar_ist;

            sir_ist = Convert.ToString(sirIst);
            sir_mar = Convert.ToString(sirMar);
            mar_ist = Convert.ToString(marIst);

            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.Text == "Istanbul")
                    textBox1.Text = sir_ist;
                else if (comboBox2.Text == "Mardin")
                    textBox1.Text = sir_mar;
                else
                    textBox1.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.Text == "Istanbul")
                    textBox1.Text = mar_ist;
                else if (comboBox2.Text == "Şırnak")
                    textBox1.Text = sir_mar;
                else
                    textBox1.Text = "0";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.Text == "Şırnak")
                    textBox1.Text = sir_ist;
                else if (comboBox2.Text == "Mardin")
                    textBox1.Text = mar_ist;
                else
                    textBox1.Text = "0";
            }
            else
                textBox1.Text = "0";
        }
        private void refreshRadioButn(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                refreshTextbox(sender, e, sirIst, sirMar, marIst);
            else if (radioButton2.Checked)
                refreshTextbox(sender, e, sirIst * 2, sirMar * 2, marIst * 2);
            else if (radioButton3.Checked)
                refreshTextbox(sender, e, sirIst * 5, sirMar * 5, marIst * 5);
        }


        private void fillCombobox(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("Mardin");
                comboBox2.Items.Add("Istanbul");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("Şırnak");
                comboBox2.Items.Add("Istanbul");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("Şırnak");
                comboBox2.Items.Add("Mardin");
            }
        }

        // Tek yon gidiş donuş Çoklu Radiobutton tab1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           refreshRadioButn(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           refreshRadioButn(sender, e);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           refreshRadioButn(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
        //          Nereden Nereye combobx Tab1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCombobox(sender, e);
            refreshRadioButn(sender, e);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshRadioButn(sender, e);

        }

        //  Yolcu Sayısı Butonar tab1 azaltma
        private void handleLabel(object sender, EventArgs e, Label lbl, int amount)
        {
            int val = Convert.ToInt32(lbl.Text);
            if (amount == 1)
                val += amount;
            else if (amount == -1)
                if (val > 0)
                    val += amount;
            lbl.Text = Convert.ToString(val);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label8, -1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label9, -1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label10, -1);

        }

        //          Button tab1 arttırma
        private void button4_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label8, 1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label9, 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            handleLabel(sender, e, label10, 1);

        }

    

        //Ek Hizmetler checkbox Tab1

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                iadeliBilet = 250;
            else
                iadeliBilet = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                yemekPrice = 500;
            else
                yemekPrice = 0;
        }

      

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
               sigorta = 500;
            else
                sigorta = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                comboBox3.Visible = true;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("5 Kilo");
                comboBox3.Items.Add("10 Kilo");
                comboBox3.Items.Add("15 Kilo");
            }
            else
                comboBox3.Visible = false;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (comboBox3.SelectedIndex == 0)
                    ekBagaj = 5 * 50;
                else if (comboBox3.SelectedIndex == 1)
                    ekBagaj = 10 * 50;
                else if (comboBox3.SelectedIndex == 2)
                    ekBagaj = 15 * 50;
                else
                    ekBagaj = 0;
            }
            else
                ekBagaj = 0;
           
        }

        private int countCheck(object sender, EventArgs e)
        {
            int val;

            val = Convert.ToInt32(label8.Text) + Convert.ToInt32(label9.Text) + Convert.ToInt32(label10.Text);
            if (radioButton3.Checked)
            {
                if (val != 5)
                    MessageBox.Show("Çoklu Bilet aldığınız için tüm yolcuların girilmesi gerek (5)");
            }
               
            else
            {
                if (val != 1)
                    MessageBox.Show("Yolcu bilgilerini doğru şekilde giriniz (1 Kişi)");
             }
                
            return val;
        }

        // Hesaplama Butonu
        private void button7_Click(object sender, EventArgs e)
        {
            int count;

            count = countCheck(sender, e);
            if (count == 0)
                return;
            double price, newPrice;
            double cocukIndirim, bebkIndırim;

            price = Convert.ToInt32(textBox1.Text);
            // indirim
            cocukIndirim = Convert.ToInt32(1000) * (Convert.ToInt32(label9.Text) * 0.25);
            bebkIndırim = Convert.ToInt32(1000) * (Convert.ToInt32(label10.Text) * 0.50);
            price = price - (cocukIndirim + bebkIndırim);

            //zamlı
            newPrice = price;
            price = price + iadeliBilet + yemekPrice + sigorta + ekBagaj;

            textBox2.Text = "Fiyat Bilgileri" + Environment.NewLine
                + "\tUçak Fiyatı\t\t:" + textBox1.Text + "₺" + Environment.NewLine
                + "İndirimler" + Environment.NewLine
                + "\tÇocuk İndirimi\t\t:" + Convert.ToString(cocukIndirim) + "₺" + Environment.NewLine
                + "\tBebek İndirimi\t\t:" + Convert.ToString(bebkIndırim) + "₺" + Environment.NewLine
                + "\tToplam İndirim\t\t:" + Convert.ToString(cocukIndirim + bebkIndırim) + "₺" + Environment.NewLine
                + "Zamlar" + Environment.NewLine
                + "Ek Hizmetler" + Environment.NewLine
                + "\tİadeli Bilet\t\t:" + Convert.ToString(iadeliBilet) + "₺" + Environment.NewLine
                + "\tYemek Fiyatı\t\t:" + Convert.ToString(yemekPrice) + "₺" + Environment.NewLine
                + "\tSigorta\t\t\t:" + Convert.ToString(sigorta) + "₺" + Environment.NewLine
                + "\tEk Bagaj\t\t\t:" + Convert.ToString(ekBagaj) + "₺" + Environment.NewLine
                + "Toplam Fiyat\t\t\t:" + Convert.ToString(price) + "₺" + Environment.NewLine;


        }

    }
}
