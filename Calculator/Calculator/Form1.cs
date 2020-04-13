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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Кнопка, отвечающая за информацию о длине строки
        {
            string a = textBox2.Text.Length.ToString();
            label6.Text = a;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Кнопка, отвечающая за заглавные буквы(перевод в них)
        {
            textBox3.Text = textBox2.Text.ToUpper();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//Кнопка, отвечающая за строчные буквы(перевод в них)
        {
            textBox3.Text = textBox2.Text.ToLower();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)// Кнопка, отвечающая за статистику
        {
            {
                int vowel = 0;
                int consonant = 0;
                List<Char> vowels = new List<char>() { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю' };
                List<Char> consonants = new List<char>()
                { 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п'
                , 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б' };
                foreach (char chr in textBox2.Text)
                {
                    if (vowels.Contains(chr))
                    {
                        vowel++;
                    }
                    if (consonants.Contains(chr))
                    {
                        consonant++;
                    }
                }
                string input = textBox2.Text;
                int Letter = 0;
                int Digit = 0;
                for (int i = 0; i < input.Length; i++)
                {

                    if (char.IsLetter(input[i]))
                        Letter++;
                    if (char.IsDigit(input[i]))
                        Digit++;
                }
                label7.Text = ("Букв : " + Letter.ToString());
                label8.Text = ("Цифр : " + Digit.ToString());
                label9.Text = ("Строк : " + textBox2.Lines.Length);
                label10.Text = ("Гласных : " + vowel.ToString());
                label11.Text = ("Согласных : " + consonant.ToString());


            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)// Кнопка, отвечающая за извлечение подстроки
        {
            string text = textBox2.Text;
            text = textBox2.Text.Substring(5); 
            textBox3.Text = text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) // Кнопка, отвечающая за исправление ошибок
        {
            string text = textBox2.Text;
            string[] trues = new string[] { "жи", "ши", "ча", "ща", "чу", "щу" };
            string[] errors = new string[] { "жы", "шы", "чя", "щя", "чю", "щю" };
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                for (int j = 0; j < errors.Length; j++)
                {
                    try
                    {
                        if (textBox2.Text.Contains(errors[j])) 
                            text = textBox2.Text.Replace(errors[j], trues[j]); 
                        textBox3.Text = text;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Строка не может быть пустой!");
                    }

                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) // Кнопка, отвечающая за преобразование строки
        {
            string text = textBox2.Text;
            string[] str = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять" };
            string[] num = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                    try
                    {
                        if (textBox2.Text.Contains(str[j]))
                            text = textBox2.Text.Replace(str[j], num[j]);
                        textBox3.Text = text;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Строка не может быть пустой!");
                    }
                
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
