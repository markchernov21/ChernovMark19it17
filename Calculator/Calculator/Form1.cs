using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator_ChernovMark : Form
    {
        public double a, b, c, d;
        public int temp;
        public int count;
        public void obrabotka(string textBox1)
        {
            try
            {
                int i = Convert.ToInt32(textBox1);
                textBox1 = Convert.ToString(i);
            }
            catch (FormatException)
            {

                MessageBox.Show("Введено нечисловое значение!", "Ошибка");//Исключение на ввод букв
            }
        }

        public Calculator_ChernovMark()
        {
            InitializeComponent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void a1_Click(object sender, EventArgs e) //Кнопка, отвечающая за 1
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void a2_Click(object sender, EventArgs e) //Кнопка, отвечающая за 2
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void a3_Click(object sender, EventArgs e) //Кнопка, отвечающая за 3
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void a4_Click(object sender, EventArgs e) //Кнопка, отвечающая за 4
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void a5_Click(object sender, EventArgs e) //Кнопка, отвечающая за 5
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void a6_Click(object sender, EventArgs e) //Кнопка, отвечающая за 6
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void a7_Click(object sender, EventArgs e) //Кнопка, отвечающая за 7
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void a8_Click(object sender, EventArgs e) //Кнопка, отвечающая за 8
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void Plus_Click(object sender, EventArgs e) //Кнопка, отвечающая за +
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            temp = 2;
            label2.Text = $"{a}+";

        }

        private void Minus_Click(object sender, EventArgs e) //Кнопка, отвечающая за -
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            temp = 1;

            label2.Text = $"{a}-";
        }

        private void Umnoghit_Click(object sender, EventArgs e) //Кнопка, отвечающая за *
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            temp = 3;


            label2.Text = $"{a}*";
        }

        private void Delenie_Click(object sender, EventArgs e) //Кнопка, отвечающая за /
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
            temp = 4;


            label2.Text = $"{a}/";
        }

        private void Delete_Click(object sender, EventArgs e) //Кнопка, отвечающая за очистку
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            d = 0;
            label2.Text = "0";
        }

        private void Ravno_Click(object sender, EventArgs e) //Кнопка, отвечающая за =
        {

            obrabotka(textBox1.Text);

            cal(temp);
        }

        private void sinus_Click(object sender, EventArgs e) //Кнопка, отвечающая за синус
        {
            obrabotka(textBox1.Text);

            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            temp = 6;



            label2.Text = $"sin:{a}";
        }

        private void cosinus_Click(object sender, EventArgs e) //Кнопка, отвечающая за косинус
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            temp = 5;


            label2.Text = $"cos:{a}";
        }

        private void tangens_Click(object sender, EventArgs e) //Кнопка, отвечающая за тангенс
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);

            textBox1.Clear();
            temp = 7;



            label2.Text = $"tg:{a}";
        }

        private void catangens_Click(object sender, EventArgs e) //Кнопка, отвечающая за катангенс
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
            label2.Text = $"ctg:{a}";
            textBox1.Clear();
            temp = 8;


            label2.Text = $"ctg:{a}";
        }

        private void coren_Click(object sender, EventArgs e) //Кнопка, отвечающая за корень
        {
            obrabotka(textBox1.Text);

            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            temp = 13;

            label2.Text = $"√:{a}";
        }

        private void ctepen_Click(object sender, EventArgs e) //Кнопка, отвечающая за степень
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            temp = 15;

            label2.Text = $"x^2:{a}";
        }

        private void log_Click(object sender, EventArgs e) //Кнопка, отвечающая за логарифм 
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            temp = 14;


            label2.Text = $"log:{a}";
        }

        private void a9_Click(object sender, EventArgs e) //Кнопка, отвечающая за 9
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void ae_Click(object sender, EventArgs e) //Кнопка, отвечающая за число e
        {
            textBox1.Text = textBox1.Text + "2.718281828459045";
        }

        private void Dvoich_Click(object sender, EventArgs e) //Кнопка, отвечающая за перевод в двоич. систему счис.
        {
            try
            {
                d = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)d, 2);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = (":(");
            }
        }

        private void Vosmerich_Click(object sender, EventArgs e) //Кнопка, отвечающая за перевод в восьмерич. систему счис.
        {
            try
            {
                d = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)d, 8);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = (":(");
            }
        }

        private void Decitich_Click(object sender, EventArgs e) //Кнопка, отвечающая за перевод в десятич. систему счис.
        {
            try
            {
                d = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)d, 10);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = (":(");
            }
        }

        private void Shesnadd_Click(object sender, EventArgs e) //Кнопка, отвечающая за перевод в шестнадцатерич. систему счис.
        {
            try
            {
                d = int.Parse(textBox1.Text);
                string result = Convert.ToString((int)d, 16);
                textBox1.Text = result;
            }
            catch (FormatException)
            {
                label1.Text = (":(");
            }
        }

        private void a0_Click(object sender, EventArgs e) //Кнопка, отвечающая за 0
        {
            textBox1.Text = textBox1.Text + "0";
        }
        public void cal(int temp)// Кнопка, отвечающая за =
        {

            switch (temp)
            {
                case 1:
                    b = a - Convert.ToInt32(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + Convert.ToInt32(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * Convert.ToInt32(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / Convert.ToInt32(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Cos(a);
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Sin(a);
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = 1 / Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;
                case 13:
                    b = Math.Sqrt(a);
                    textBox1.Text = b.ToString();
                    break;
                case 14:
                    b = Math.Log(a);
                    textBox1.Text = b.ToString();
                    break;
                case 15:
                    b = Math.Pow(a, 2);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
