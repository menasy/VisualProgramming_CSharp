using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H8Exam2
{
    public partial class Form1 : Form
    {
        int[] randNum = new int[4];
        Random rnd = new Random();
        Random rndAns = new Random();
        int azalt = 0;
        int hak = 0;
        int valLab = 0;
        double oran = 0;
        double totalPara = 0;
        public Form1()
        {
            InitializeComponent();
            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Left; 
            panel1.Width = this.ClientSize.Width / 2;
            panel1.BackColor = Color.Yellow; 
            this.Controls.Add(panel1); 

    
            Panel panel2 = new Panel();
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = Color.Navy;
            this.Controls.Add(panel2); 
        }

        private void setVis1(object sender, EventArgs e, bool check)
        {
            label1.Visible = check;
            textBox1.Visible = check;
            button1.Visible = check;
        }

        private void setVis2(object sender, EventArgs e, bool check)
        {
            checkBox1.Visible = check;
            checkBox2.Visible = check;
            checkBox3.Visible = check;

            radioButton1.Visible = check;
            radioButton2.Visible = check;
            radioButton3.Visible = check;
            radioButton4.Visible = check;

            comboBox1.Visible = check;
            comboBox2.Visible = check;
            comboBox3.Visible = check;
            comboBox4.Visible = check;

            button3.Visible = check;
            button4.Visible = check;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setVis2(sender, e, false);
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) // başla
        {
            setVis1(sender, e, false);
            setVis2(sender, e, true);
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // yatır
        {
            if (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) < 1200)
            {
                MessageBox.Show(" Lutfen geçerli bir miktar girin!");
                return;
            }
            else
            {
                label2.Text = "Toplam para: " + textBox1.Text;
                totalPara = Convert.ToInt32(textBox1.Text);
                button2.Enabled = true;

            }
        }

        private void fillCombo(object sender, EventArgs e, int len, ComboBox comb)
        {
            comb.Items.Clear();
            for (int i = 1; i < len; i++)
            {
                comb.Items.Add(Convert.ToString(i));
            }
        }

        private void callCombo(object sender, EventArgs e, int len)
        {
            fillCombo(sender, e, len, comboBox1);
            fillCombo(sender, e, len, comboBox2);
            fillCombo(sender, e, len, comboBox3);
            fillCombo(sender, e, len, comboBox4);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                callCombo(sender, e, 9);
                setRandNum(sender, e, 9);
                azalt = 300;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked)
            {
                callCombo(sender, e, 16);
                setRandNum(sender, e, 16);
                azalt = 240;

                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked && !checkBox2.Checked && !checkBox1.Checked)
            {
                azalt = 200;
                callCombo(sender, e, 21);
                setRandNum(sender, e, 21);

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }

        }

        private void refreshRadio(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                oran = Convert.ToInt32(radioButton1.Text);
            else if (radioButton2.Checked)
                oran = Convert.ToInt32(radioButton2.Text);
            else if (radioButton3.Checked)
                oran = Convert.ToInt32(radioButton3.Text);
            else if (radioButton4.Checked)
                oran = Convert.ToInt32(radioButton4.Text);


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            refreshRadio(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            refreshRadio(sender, e);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            refreshRadio(sender, e);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            refreshRadio(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (totalPara < 1200)
            {
                MessageBox.Show(" Lutfen geçerli bir miktar girin!");
                return;
            }
            else
            {
                
                label3.Text = "1200";

                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;

                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";

                comboBox1.ForeColor = Color.Black;
                comboBox2.ForeColor = Color.Black;
                comboBox3.ForeColor = Color.Black;
                comboBox4.ForeColor = Color.Black;


                button4.Enabled = false;
                button3.Enabled = true;
            }
        }

        private bool checkInRand(object sender, EventArgs e, ComboBox comb)
        {
            int val = Convert.ToInt32(comb.Text);
            for (int i = 0; i < 4; i++)
            {
                if (val == randNum[i])
                    return (true);
            }
            return (false);

        }
        private void setRandNum(object sender, EventArgs e, int len)
        {
            for (int i = 0; i < 4; i++)
                randNum[i] = rnd.Next(1, len);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            double tmp;
            double dblOran;
            bool checkVal;

            checkVal = true;
            valLab = Convert.ToInt32(label3.Text);
            if (!checkInRand(sender, e, comboBox1) || !checkInRand(sender, e, comboBox2) || !checkInRand(sender, e, comboBox3) || !checkInRand(sender, e, comboBox4))
            {
                valLab -= azalt;
                checkVal = false;
            }

            if (checkInRand(sender,e,comboBox1))
            {
                comboBox1.ForeColor = Color.Green;
                comboBox1.Enabled = false;

            }
            else
            {
                comboBox1.ForeColor = Color.Red;

            }
            if (checkInRand(sender, e, comboBox2))
            {
                comboBox2.ForeColor = Color.Green;
                comboBox2.Enabled = false;


            }
            else
            {
                comboBox2.ForeColor = Color.Red;

            }
            if (checkInRand(sender, e, comboBox3))
            {
                comboBox3.ForeColor = Color.Green;
                comboBox3.Enabled = false;

            }
            else
            {
                comboBox3.ForeColor = Color.Red;

            }
            if (checkInRand(sender, e, comboBox4))
            {
                comboBox4.ForeColor = Color.Green;
                comboBox4.Enabled = false;

            }
            else
            {
                comboBox4.ForeColor = Color.Red;

            }
            label3.Text = Convert.ToString(valLab);
            if (checkVal == true)
            {
                dblOran = oran / 100;
                tmp = Convert.ToInt32(label3.Text) * dblOran;
                totalPara += tmp;
                button3.Enabled = false;
                button4.Enabled = true;
                label2.Text = "Toplam Para: " + Convert.ToString(totalPara);
            }
            if (valLab == 0 && !checkVal)
            {
                dblOran = oran / 100;
                tmp = 1200 * dblOran;
                totalPara -= tmp;
                label2.Text = "Toplam Para: " + Convert.ToString(totalPara);
                button3.Enabled = false;
                button4.Enabled = true;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
