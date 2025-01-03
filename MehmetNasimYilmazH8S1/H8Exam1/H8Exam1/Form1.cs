using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H8Exam1
{
    public partial class Form1 : Form
    {
        string user = "menasy";
        string pass = "mn123";
        int hak = 3;
        int[] randNum = new int[4];
        Random rnd = new Random();
        Random rndAns = new Random();
        int dogru = 0;
        int yanlis = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void setVisRad(object sender, EventArgs e, bool check)
        {
            label4.Visible = check;
            label5.Visible = check;
            label6.Visible = check;


            label7.Visible = check;
            label8.Visible = check;
            label9.Visible = check;
            label10.Visible = check;

            radioButton1.Visible = check;
            radioButton2.Visible = check;
            radioButton3.Visible = check;
            radioButton4.Visible = check;

            button2.Visible = check;


        }

        private void setVisBut1(object sender, EventArgs e, bool check)
        {
            button1.Visible = check;
            label1.Visible = check;
            label2.Visible = check;
            textBox1.Visible = check;
            textBox2.Visible = check;
        }
        private void setVis(object sender, EventArgs e, bool check)
        {
            radioButton1.Visible = check;
            radioButton2.Visible = check;
            radioButton3.Visible = check;
            radioButton4.Visible = check;

            button2.Visible = check;
            button3.Visible = check;
            button4.Visible = check;


            label3.Visible = check;

            label4.Visible = check;
            label5.Visible = check;
            label6.Visible = check;


            label7.Visible = check;
            label8.Visible = check;
            label9.Visible = check;
            label10.Visible = check;

            label11.Visible = check;
            label12.Visible = check;
            label13.Visible = check;

        }
        private void button1_Click(object sender, EventArgs e) //Giriş
        {

            bool check = textBox1.Text == user && textBox2.Text == pass;
            if (check)
            {
                setVisRad(sender, e, true);
                hak = 3;
                setRandNum(sender, e);
            }
            else if  (!check && hak  > 0)
            {
                hak--;
                MessageBox.Show($"{hak} Deneme hakkınız kaldı !");
                return;
            }
            else if (!check && hak == 0)
            {
                label3.Visible = true;
                label3.Text = "DENEME HAKKINIZ KALMADI PROGRAMDAN ENGELLENDİNİZ !";
                setVisBut1(sender, e, false);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setVis(sender, e, false);
        }

        private void setRandNum(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                randNum[i] = rnd.Next(100);
            radioButton1.Text = Convert.ToString(randNum[0]);
            radioButton2.Text = Convert.ToString(randNum[1]);
            radioButton3.Text = Convert.ToString(randNum[2]);
            radioButton4.Text = Convert.ToString(randNum[3]);

        }

        private void checkAnswer(object sender, EventArgs e)
        {
            int i = rndAns.Next(4);

            if (radioButton1.Checked && radioButton1.Text == Convert.ToString(randNum[i]))
                dogru++;
            else if (radioButton2.Checked && radioButton2.Text == Convert.ToString(randNum[i]))
                dogru++;
            else if (radioButton3.Checked && radioButton3.Text == Convert.ToString(randNum[i]))
                dogru++;
            else if (radioButton4.Checked && radioButton4.Text == Convert.ToString(randNum[i]))
                dogru++;
            else
                yanlis++;
        }

        private void button2_Click(object sender, EventArgs e) // Cevapla
        {
            checkAnswer(sender, e);
            count++;

            label4.Text = Convert.ToString(count);
            if (count == 10)
            {
                count = 0;
                setVisRad(sender, e, false);
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                button3.Visible = true;
                button4.Visible = true;


                label11.Text = "Doğru sayısı: " + Convert.ToString(dogru);
                label12.Text = "Yanlış Sayısı: " + Convert.ToString(yanlis);

                if (dogru >= 5)
                    label13.Text = "BAŞARILI";
                else
                    label13.Text = "BAŞARISIZ";
                count = 0;
                dogru = 0;
                yanlis = 0;
            }
            setRandNum(sender, e);


        }

        private void button3_Click(object sender, EventArgs e) // rekrar
        {
            setVisRad(sender, e, true);

            label4.Text = "0";
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            setVis(sender, e, false);
            count = 0;
            dogru = 0;
            yanlis = 0;
            hak = 3;
            textBox1.Text = "";
            textBox2.Text = "";



        }
    }
}
