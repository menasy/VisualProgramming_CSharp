using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H7Exam2
{
    public partial class Form1 : Form
    {
        int ekGaranti1 = 0;
        int ekGaranti2 = 0;
        double pesFiyat = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Fırın");
            comboBox1.Items.Add("Ketıl");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Buzdolabı");
            comboBox2.Items.Add("Bulaşık Makinası");

            comboBox3.Items.Clear();
            comboBox3.Items.Add("6");
            comboBox3.Items.Add("12");

            comboBox3.Enabled = false;
            openEnable1(sender, e, false);
            openEnable2(sender, e, false);
            openEnable3(sender, e, false);

        }

        private void openEnable1(object sender, EventArgs e, bool enVal)
        {
            comboBox1.Enabled = enVal;
            textBox1.Enabled = enVal;
            checkBox3.Enabled = enVal;

        }
        private void openEnable2(object sender, EventArgs e, bool enVal)
        {
            comboBox2.Enabled = enVal;
            textBox2.Enabled = enVal;
            checkBox4.Enabled = enVal;

        }

        private void openEnable3(object sender, EventArgs e, bool enVal)
        {
            radioButton1.Enabled = enVal;
            radioButton2.Enabled = enVal;
            textBox3.Enabled = enVal;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                openEnable1(sender, e, true);
            else
            {
                comboBox1.Text = "";
                label6.Text = "0";
                textBox1.Text = "";
                openEnable1(sender, e, false);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                openEnable2(sender, e, true);
            else
            {
                comboBox2.Text = "";
                label7.Text = "0";
                textBox2.Text = "";
                openEnable2(sender, e, false);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fırın")
            {
                label6.Text = "2000";
                openEnable3(sender, e, true);

            }
            else if (comboBox1.Text == "Ketıl")
            {
                label6.Text = "500";
                openEnable3(sender, e, true);

            }
            else
            {
                openEnable3(sender, e, false);
                label6.Text = "0";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Buzdolabı")
            {
                label7.Text = "5000";
                openEnable3(sender, e, true);

            }
            else if (comboBox2.Text == "Bulaşık Makinası")
            {
                label7.Text = "6500";
                openEnable3(sender, e, true);

            }
            else
            {
                openEnable3(sender, e, false);
                label7.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                ekGaranti1 = 200;
            else
                ekGaranti1 = 0;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                ekGaranti2 = 200;
            else
                ekGaranti2 = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                    pesFiyat = (Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + (Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + (ekGaranti1 + ekGaranti2));
                else if (checkBox1.Checked)
                    pesFiyat = Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + ekGaranti1;
                else if (checkBox2.Checked)
                    pesFiyat = Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text) + ekGaranti2;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox3.Enabled = true;
                if (checkBox1.Checked && checkBox2.Checked)
                    pesFiyat = (Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + (Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + (ekGaranti1 + ekGaranti2));
                else if (checkBox1.Checked)
                    pesFiyat = Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + ekGaranti1;
                else if (checkBox2.Checked)
                    pesFiyat = Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text) + ekGaranti2;
                if (comboBox3.Text == "6")
                    pesFiyat = pesFiyat + (pesFiyat * 0.10);
                else if (comboBox3.Text == "12")
                    pesFiyat = pesFiyat + (pesFiyat * 0.20);

            }
            else
            {
                comboBox3.Text = "";
                textBox3.Text = "";
                comboBox3.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox3.Enabled = true;
                if (checkBox1.Checked && checkBox2.Checked)
                    pesFiyat = (Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + (Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + (ekGaranti1 + ekGaranti2));
                else if (checkBox1.Checked)
                    pesFiyat = Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text) + ekGaranti1;
                else if (checkBox2.Checked)
                    pesFiyat = Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text) + ekGaranti2;
                if (comboBox3.Text == "6")
                    pesFiyat = pesFiyat + (pesFiyat * 0.10);
                else if (comboBox3.Text == "12")
                    pesFiyat = pesFiyat + (pesFiyat * 0.20);

            }
            else
                comboBox3.Enabled = false;
        }

        private void showRad1(object sender, EventArgs e)
        {
          
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    textBox3.Text = checkBox1.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text)) + Environment.NewLine
                                    + checkBox2.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + Environment.NewLine
                                    + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine;


                }
                else if (checkBox1.Checked)
                {
                    textBox3.Text = checkBox1.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text)) + Environment.NewLine
                                + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine;
                }
                else if (checkBox2.Checked)
                {
                    textBox3.Text = checkBox2.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + Environment.NewLine
                                + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine;
                }
      
        }
        private void showRad2(object sender, EventArgs e, double taksit)
        {

            if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox3.Text = checkBox1.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text)) + Environment.NewLine
                                + checkBox2.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + Environment.NewLine
                                + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine
                                + "Aylık Taksitli Fiyat\t\t\t:" + Convert.ToString(taksit) + Environment.NewLine;


            }
            else if (checkBox1.Checked)
            {
                textBox3.Text = checkBox1.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label6.Text) * Convert.ToInt32(textBox1.Text)) + Environment.NewLine
                            + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine
                             + "Aylık Taksitli Fiyat\t\t\t:" + Convert.ToString(taksit) + Environment.NewLine;

            }
            else if (checkBox2.Checked)
            {
                textBox3.Text = checkBox2.Text + "\t\t\t:" + Convert.ToString(Convert.ToInt32(label7.Text) * Convert.ToInt32(textBox2.Text)) + Environment.NewLine
                            + "Toplam\t\t\t:" + Convert.ToString(pesFiyat) + Environment.NewLine
                            + "Aylık Taksitli Fiyat\t\t\t:" + Convert.ToString(taksit) + Environment.NewLine;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double taksit = 0;

            if (checkBox1.Checked && textBox1.Text == "")
            {
                textBox3.Text = "Miktar giriniz !";
                return;
            }
            else if (checkBox1.Checked && textBox2.Text == "")
            {
                textBox3.Text = "Miktar giriniz !";
                return;
            }
           
            if (radioButton2.Checked)
            {
                if (comboBox3.Text == "6")
                    taksit = pesFiyat / 6;
                else if (comboBox3.Text == "12")
                    taksit = pesFiyat / 12;
            }

            if (radioButton2.Checked)
                showRad2(sender, e, taksit);
            else if (radioButton1.Checked)
                showRad1(sender, e);
       
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
