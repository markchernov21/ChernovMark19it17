using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //создание рандома
            int R = -1; //вывод
            int check = 0; //проверка
            int enumeration; //перевод
            int a = 0;
            int b = 0;

            for (int i = 0; i < 1000; i++)
            {
                enumeration = rnd.Next(0, 10000); //вложение рандомного числа в переменную
                if (enumeration > check) { check = enumeration; } //проверка, что результат максимальный
                if ((enumeration % 7 == 0) && (a < enumeration)) { a = enumeration; }
                if ((enumeration % 2 == 0) && (b < enumeration)) { b = enumeration; }
                //Проверка переменной на условие (check кратна 14, максимальна и является произведением двух чисел
                 if ((check % 14 == 0) && (check > R) && (check == (a * b)))
                { R = check; }
            }
            Console.WriteLine(R);
        }
    }
}
