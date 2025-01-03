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
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hotel A");
            comboBox1.Items.Add("Hotel B");
            comboBox1.Items.Add("Hotel C");

            //combobox2
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Araç A");
            comboBox2.Items.Add("Araç B");
            comboBox2.Items.Add("Araç C");

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = checkTab(sender, e);
        }

        private void refreshInfo1(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                if (radioButton1.Checked)
                    label4.Text = "2000";
                else if (radioButton2.Checked)
                    label4.Text = "3000";
                else if (radioButton3.Checked)
                    label4.Text = "5000";
                else
                    label4.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton1.Checked)
                    label4.Text = "6000";
                else if (radioButton2.Checked)
                    label4.Text = "7000";
                else if (radioButton3.Checked)
                    label4.Text = "8000";
                else
                    label4.Text = "1000";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (radioButton1.Checked)
                    label4.Text = "9000";
                else if (radioButton2.Checked)
                    label4.Text = "9500";
                else if (radioButton3.Checked)
                    label4.Text = "12000";
                else
                    label4.Text = "1000";
            }
        }

        private void refreshInfo2(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                if (radioButton4.Checked)
                    label11.Text = "1000";
                else if (radioButton5.Checked)
                    label11.Text = "1200";
                else if (radioButton6.Checked)
                    label11.Text = "1400";
                else
                    label11.Text = "500";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                if (radioButton4.Checked)
                    label11.Text = "2000";
                else if (radioButton5.Checked)
                    label11.Text = "2300";
                else if (radioButton6.Checked)
                    label11.Text = "2600";
                else
                    label11.Text = "500";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                if (radioButton4.Checked)
                    label11.Text = "3000";
                else if (radioButton5.Checked)
                    label11.Text = "3500";
                else if (radioButton6.Checked)
                    label11.Text = "4000";
                else
                    label11.Text = "500";
            }
        }

        private void refreshCheckbox2(object sender, EventArgs e)
        {


            if (checkBox4.Checked)
                label12.Text = "500";
            else
                label12.Text = "0";
            if (checkBox5.Checked)
                label13.Text = "100";
            else
                label13.Text = "0";
            if (checkBox6.Checked)
                label14.Text = "300";
            else
                label14.Text = "0";


        }
        private void refreshCheckbox1(object sender, EventArgs e)
        {


            if (checkBox1.Checked)
                label5.Text = "300";
            else
                label5.Text = "0";
            if (checkBox2.Checked)
                label6.Text = "500";
            else
                label6.Text = "0";
            if (checkBox3.Checked)
                label7.Text = "200";
            else
                label7.Text = "0";


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInfo1(sender,e);

        }
        //      Radiobutton tab 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo1(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo1(sender, e);

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo1(sender, e);

        }
        //      Checkbox tab1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox1(sender, e);
        } 

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox1(sender, e);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox1(sender, e);
        }
        //              Araç Kiralam Tab2

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInfo2(sender, e);
        }

           //           Radiobutton tab2
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo2(sender, e);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo2(sender, e);

        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            refreshInfo2(sender, e);

        }
            
        //      Checkbox 
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox2(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox2(sender, e);

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            refreshCheckbox2(sender, e);

        }

        private string takeRadiobutton1(object sender, EventArgs e)
        {
            string rdbtn;

            if (radioButton1.Checked)
                rdbtn = radioButton1.Text;
            else if (radioButton2.Checked)
                rdbtn = radioButton2.Text;
            else if (radioButton3.Checked)
                rdbtn = radioButton3.Text;
            else
                rdbtn = "";
            return rdbtn;
        }
        private string takeRadiobutton2(object sender, EventArgs e)
        {
            string rdbtn;

            if (radioButton4.Checked)
                rdbtn = radioButton4.Text;
            else if (radioButton5.Checked)
                rdbtn = radioButton5.Text;
            else if (radioButton6.Checked)
                rdbtn = radioButton6.Text;
            else
                rdbtn = "";
            return rdbtn;
        }

        private bool checkTab(object sender, EventArgs e)
        {
            if (label4.Text != "Fiyat" && label5.Text != "Fiyat" && label6.Text != "Fiyat" && label7.Text != "Fiyat" && label11.Text != "Fiyat" && label12.Text != "Fiyat" && label13.Text != "Fiyat" && label14.Text != "Fiyat")
                return (true);
            else
                return (false);
     
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string rdbtn = takeRadiobutton1(sender, e);
            string rdbtn2 = takeRadiobutton2(sender, e);
            int sum;

            sum = Convert.ToInt32(label4.Text) + Convert.ToInt32(label5.Text) + Convert.ToInt32(label6.Text)
                   + Convert.ToInt32(label11.Text) + Convert.ToInt32(label12.Text) + Convert.ToInt32(label13.Text) + Convert.ToInt32(label14.Text);


            textBox1.Text = "Otel\t\t\t\t:" + comboBox1.Text + Environment.NewLine + "\t\t\t" + rdbtn + "\t:" + label4.Text + Environment.NewLine
                + "\tEk Hizmetler" + Environment.NewLine + "\t\t\t" + checkBox1.Text + "\t:" + label5.Text + Environment.NewLine
                + "\t\t\t" + checkBox2.Text + "\t:" + label6.Text + Environment.NewLine
                + "\t\t\t" + checkBox3.Text + "\t:" + label6.Text + Environment.NewLine
                //Araç kısmı
                + "Araç\t\t\t\t:" + comboBox2.Text + Environment.NewLine + "\t\t\t" + rdbtn2 + "\t:" + label11.Text + Environment.NewLine
                + "\tEk Hizmetler" + Environment.NewLine + "\t\t\t" + checkBox4.Text + "\t\t:" + label12.Text + Environment.NewLine
                + "\t\t\t" + checkBox5.Text + "\t:" + label13.Text + Environment.NewLine
                + "\t\t\t" + checkBox6.Text + "\t:" + label14.Text + Environment.NewLine + Environment.NewLine
                + "Toplam Hesap\t\t\t:" + Convert.ToString(sum) + "₺";

         }
    }
}
