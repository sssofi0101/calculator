using System;
using System.Linq;

namespace КАЛЬКУЛЯТОР
{

    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите первый элемент:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй элемент:");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - умножение");
            Console.WriteLine("3 - вычитание");
            Console.WriteLine("4 - деление");
            Console.WriteLine();


            int deistvie = Convert.ToInt32(Console.ReadLine());
            switch (deistvie)
            {
                case 1:
                    Slogenie(c1, c2);
                    break;
                case 2:
                    Ymnozgenie(c1, c2);
                    break;
                case 3:
                    Vychitanie(c1, c2);
                    break;
                default:
                    Console.WriteLine("Вы выбрали неправильное действие");
                    break;
            }


        }
        static void Slogenie(int c1, int c2)
        {
            const string probel = " ";
            string probel1 = " ";
            string palochka = "_";

            bool a = false, b = false;
            int c3 = c1 + c2;
            string c1str = Convert.ToString(c1), c2str = Convert.ToString(c2), c3str = Convert.ToString(c3);
            if (c3 < 0)
            {

                c3 = c3 * (-1);
            }
            if (c1 < 0)
            {
                c1 = c1 * (-1);
                a = true;
            }
            if (c2 < 0)
            {
                c2 = c2 * (-1);
                b = true;
            }
            int CountC1 = (int)Math.Log10(c1) + 1;
            int CountC2 = (int)Math.Log10(c2) + 1;
            int CountC3 = (int)Math.Log10(c3) + 1;
            bool proverka = false;
            if ((CountC3 > CountC1) && (CountC3 > CountC2))
            {
                proverka = true;

            }
            if (CountC2 == CountC1)
            {
                c1str = probel + c1;
                c2str = probel + c2;
            }
            else if (CountC2 > CountC1)
            {

                while (CountC2 > CountC1)
                {
                    probel1 += probel;
                    CountC2--;
                }

                c1str = probel1 + c1;
                c2str = probel + c2;
            }
            else if (CountC1 > CountC2)
            {
                while (CountC1 > CountC2)
                {
                    probel1 += probel;

                    CountC1--;
                }
                c1str = probel + c1;
                c2str = probel1 + c2;
            }

            Console.Clear();
            if (a == true)
            {

                if (proverka == true)
                {
                    c1str = "-" + c1str;
                    c2str = probel + c2str;
                }
                else c1str = "-" + c1str;
                c2str = probel + c2str;
            }
            if (b == true)
            {
                if (proverka == true)
                {
                    c2str = "-" + c2str;
                    c1str = probel + c1str;
                }
                else c2str = "-" + c2str;
                c1str = probel + c1str;
            }
            Console.Write(c1str);
            Console.WriteLine();
            Console.Write("+");
            Console.WriteLine();
            Console.Write(c2str);
            Console.WriteLine();
            if (proverka == false)
            {
                Console.Write(probel);
            }

            for (int i = 0; i < c3str.Length; i++)
            {
                Console.Write(palochka);
            }
            Console.WriteLine();
            if (proverka == false)
            {
                c3str = probel + c3str;
            }

            Console.WriteLine(c3str);




            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Калькулятор V1. Над калькулятором работали:");
            Console.WriteLine("Степан Немченко (https://github.com/BadLog1n/)");
            Console.WriteLine("Cофья Сохина (https://github.com/sssofi0101/)");
            Console.WriteLine("На данный момент в калькуляторе доступны не все функции, но мы работаем над этим ;)");
            Console.ReadKey();

        }
        static void Ymnozgenie(int c1, int c2)
        {
            int pamat;
            const string probel = " ";

            string palochka = "_";

            int c3 = 0;
            c3 = c1 * c2;






            int a = 0, b = 0;
            string pamatstr = null, c1str = Convert.ToString(c1), c2str = Convert.ToString(c2), c3str = Convert.ToString(c3);
            if (c1 < 0)
            {
                c1 = c1 * (-1);
                c3 = c3 * (-1);
                a = 1;

            }
            if (c2 < 0)
            {
                c2 = c2 * (-1);
                c3 = c3 * (-1);
                b = 1;
            }
            int CountC1 = (int)Math.Log10(c1) + 1;
            int CountC2 = (int)Math.Log10(c2) + 1;
            int CountC3 = (int)Math.Log10(c3) + 1;

            if (CountC1 < CountC2)
            {
                pamat = c1;
                c1 = c2;
                c2 = pamat;
                pamatstr = c1str;
                c1str = c2str;
                c2str = pamatstr;
            }
            CountC1 = (int)Math.Log10(c1) + 1;
            CountC2 = (int)Math.Log10(c2) + 1;
            int ch = CountC2;






            if ((a == 0) && (b == 1))
            {
                while (CountC1 != CountC3 + 1)
                {
                    c1str = probel + c1str;
                    CountC1++;
                }
                while (CountC2 != CountC3)
                {
                    c2str = probel + c2str;
                    CountC2++;
                }
            }

            else if ((a == 1) && (b == 0))
            {
                while (CountC1 != CountC3)
                {
                    c1str = probel + c1str;
                    CountC1++;
                }
                while (CountC2 != CountC3 + 1)
                {
                    c2str = probel + c2str;
                    CountC2++;
                }

            }
            else if ((a == 1) && (b == 1))

            {
                while (CountC1 != CountC3 - 1)
                {
                    c1str = probel + c1str;
                    CountC1++;
                }
                while (CountC2 != CountC3 - 1)
                {
                    c2str = probel + c2str;
                    CountC2++;
                }
                a = 0;
                b = 0;
            }
            else
            {
                while (CountC1 < CountC3)
                {
                    c1str = probel + c1str;
                    CountC1++;
                }
                while (CountC2 < CountC3)
                {
                    c2str = probel + c2str;
                    CountC2++;
                }
            }
            int pod = 1;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(c1str);
            Console.WriteLine("*");
            Console.WriteLine(c2str);
            for (int i = 0; i < c1str.Length; i++)
            {
                Console.Write(palochka);
            }
            Console.WriteLine();
            int ch1 = ch;
            int sum, sum1 = 0;
            var digitArray = c2.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            string s1 = null;
            for (int i = (digitArray.Length - 1); i >= 0; i--)
            {
                int CountC6 = CountC3;
                int element = c1 * digitArray[i];

                string elementstr = Convert.ToString(element);

                int CountC5 = (int)Math.Log10(element) + 1;
                for (pod = 1; pod != ch; pod++)
                {

                    elementstr = probel + elementstr;

                }
                sum = elementstr.Length;
                ch--;
                sum1 = sum;
                if ((a == 1) || (b == 1))
                {
                    Console.WriteLine(probel + elementstr);
                }
                else
                {
                    while (CountC6 > elementstr.Length)
                    {
                        elementstr = probel + elementstr;
                        CountC6--;
                    }
                    Console.WriteLine(elementstr);
                }
                CountC3--;
                s1 = elementstr;
            }



            for (int i = 0; i < c1str.Length; i++)
            {
                Console.Write(palochka);
            }
            Console.WriteLine();
            Console.WriteLine(c3str);
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Калькулятор V1. Над калькулятором работали:");
            Console.WriteLine("Степан Немченко (https://github.com/BadLog1n/)");
            Console.WriteLine("Cофья Сохина (https://github.com/sssofi0101/)");
            Console.WriteLine("На данный момент в калькуляторе доступны не все функции, но мы работаем над этим ;)");
            Console.ReadKey();
        }
        static void Vychitanie(int c1, int c2)
        {
            const string probel = " ";
            string probel1 = " ";
            string palochka = "_";
            int c3 = 0;



            bool proverka = false;
            string c1str = Convert.ToString(c1), c2str = Convert.ToString(c2), c3str = Convert.ToString(c3);
            if ((c1 < 0) && (c2 >= 0)) { c3 = -(Math.Abs(c1) + c2); }
            if ((c1 > 0) && (c2 < 0)) { c3 = -(c1 + Math.Abs(c2)); }
            if (c1 >= 0)
            {
                if (c2 > c1) { c3 = -(c2 - c1); }
                else { c3 = c1 - c2; }
            }
            int CountC1 = 0; int CountC2 = 0; int CountC3 = 0;
            if (c1 < 0) { CountC1 = (int)Math.Log10(Math.Abs(c1)) + 2; } else { if (c1 == 0) { CountC1 = 1; } else { CountC1 = (int)Math.Log10(Math.Abs(c1)) + 1; } }
            if (c2 < 0) { CountC2 = (int)Math.Log10(Math.Abs(c2)) + 2; } else { if (c2 == 0) { CountC2 = 1; } else { CountC2 = (int)Math.Log10(Math.Abs(c2)) + 1; } }
            if (c3 < 0) { CountC3 = (int)Math.Log10(Math.Abs(c3)) + 2; } else { if (c3 == 0) { CountC3 = 1; } else { CountC3 = (int)Math.Log10(Math.Abs(c3)) + 1; } }
            if ((CountC3 > CountC1) && (CountC3 > CountC2))
            {
                proverka = true;

            }
            string pr = " ";
            if (CountC2 == CountC1)
            {
                c1str = probel + c1;
                c2str = probel + c2;
                if (CountC3 == CountC1) { pr = probel; }
                if (CountC3 < CountC1)
                {
                    while (CountC1 > CountC3)
                    {
                        pr += probel;
                        CountC1--;
                    }
                }
            }
            else if (CountC2 > CountC1)
            {

                while (CountC2 > CountC1)
                {
                    probel1 += probel;
                    CountC2--;
                }

                c1str = probel1 + c1;
                c2str = probel + c2;
                if (CountC3 == CountC2) { pr = probel; }
                if (CountC3 == CountC1) { pr = probel1; }
                if ((CountC3 < CountC1) && (CountC3 < CountC2)) { pr = probel1 + probel; }


            }
            else if (CountC1 > CountC2)
            {
                while (CountC1 > CountC2)
                {
                    probel1 += probel;

                    CountC1--;
                }
                c1str = probel + c1;
                c2str = probel1 + c2;
                if (CountC3 == CountC2) { pr = probel1; }
                if (CountC3 == CountC1) { pr = probel; }
                if ((CountC3 < CountC1) && (CountC3 < CountC2)) { pr = probel1 + probel; }
            }

            Console.Clear();
            Console.Write(c1str);
            Console.WriteLine();
            Console.Write("-");
            Console.WriteLine();
            Console.Write(c2str);
            Console.WriteLine();

            if (proverka == false)
            {
                if (c3 < 0) { Console.Write(probel); } else { Console.Write(pr); };

            }

            for (int i = 0; i < CountC3; i++)
            {
                Console.Write(palochka);
            }
            Console.WriteLine();
            if (proverka == true)
            {

                Console.WriteLine(c3);
            }
            else
            {

                if (c3 < 0) { Console.Write(probel); } else { { Console.Write(pr); } }
                Console.WriteLine(c3);

            }



            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Калькулятор V1. Над калькулятором работали:");
            Console.WriteLine("Степан Немченко (https://github.com/BadLog1n/)");
            Console.WriteLine("Cофья Сохина (https://github.com/sssofi0101/)");
            Console.WriteLine("На данный момент в калькуляторе доступны не все функции, но мы работаем над этим ;)");
            Console.ReadKey();
        }
    }

}

