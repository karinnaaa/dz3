using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    public enum DayoftheWeek
    {
        Monday, Tuesday, Wednesday, thursday, Friday, Saturday, Sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.Write("Введите значение а: \t");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: \t");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите значение d: \t");
            int D = int.Parse(Console.ReadLine());
            if (A >= D + 2 && B >= D + 2)
            {
                Console.WriteLine("Сможет");
            }
            else
            {
                Console.WriteLine("Не сможет(");
            }

            Console.ReadKey();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число 1<=n<=9 \t");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{n}*" + i + " = " + i * n);
            }
            Console.ReadKey();


            Console.WriteLine("Задание 3");
            Console.Write("Введите число ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a % 5 == 0 & a % 3 == 0 ? "БэнгБум" : a % 3 == 0 ? "Бэнг" : a % 5 == 0 ? "Бум" : "Мимо");
            Console.ReadKey();


            Console.WriteLine("Задание 4");
            Console.Write("Введите строку \t");
            string stroca = Console.ReadLine();
            int k = 0;
            foreach (char c in stroca)
            {
                if (char.IsUpper(c))
                {
                    k++;
                }
            }
            Console.WriteLine(k == stroca.Length ? "True" : "False");
            Console.ReadKey();


            Console.WriteLine("Задание 5");
            Console.Write("Введите число \t");
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= l; i++)
            {
                Console.Write($"{i} овца... ");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 6");
            try
            {
                int[] Mass = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Mass[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(String.Join(", ", Mass));
                int sum = 0;

                for (int i = 0; i < Mass.Length; i++)
                {
                    if (Mass[i] > 0)
                    {
                        sum = sum + Mass[i];
                    }
                }
                double arifm = sum / Mass.Length;
                Console.WriteLine("Среднее арифметическое = " + arifm);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Отрицательное значение");
            }
            finally
            {
                Console.WriteLine("Пока");
            }
            Console.ReadKey();

            Console.WriteLine("Задание 7");

            Console.Write("Введите номер карты \t");
            try
            {
                int card = int.Parse(Console.ReadLine());
                switch (card)
                {
                    case 6:
                        Console.WriteLine("Ваша карта - шестёрка");
                        break;
                    case 7:
                        Console.WriteLine("Ваша карта - семёрка");
                        break;
                    case 8:
                        Console.WriteLine("Ваша карта - восьмёрка");
                        break;
                    case 9:
                        Console.WriteLine("Ваша карта - девятка");
                        break;
                    case 10:
                        Console.WriteLine("Ваша карта - десятка");
                        break;
                    case 11:
                        Console.WriteLine("Ваша карта - валет");
                        break;
                    case 12:
                        Console.WriteLine("Ваша карта - дама");
                        break;
                    case 13:
                        Console.WriteLine("Ваша карта - король");
                        break;
                    case 14:
                        Console.WriteLine("Ваша карта - туз");
                        break;
                    default:
                        Console.WriteLine("Такой карты нет");
                        break;

                }

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            finally
            {
                Console.WriteLine("Пока");
            }
            Console.ReadKey();



            Console.WriteLine("Задание 8");
            int doll = 0;
            string[] toys = { "barbie doll", "hello Kitty", "car", "Baby Born", "Monster High", "Spider man", "Transformer", "lego", "barbie doll" };
            foreach (string s in toys)
            {
                if (s == "barbie doll" || s == "hello kitty")
                {
                    doll++;
                }

            }
            Console.WriteLine("Количество кукол: " + doll);
            Console.ReadKey();


            Console.WriteLine("Задание 9");
            Console.Write("Введите номер недели: \t");
            int Week = int.Parse(Console.ReadLine());
            switch (Week)
            {
                case 1:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(0));
                    break;
                case 2:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(1));
                    break;
                case 3:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(2));
                    break;
                case 4:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(3));
                    break;
                case 5:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(4));
                    break;
                case 6:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(5));
                    break;
                case 7:
                    Console.WriteLine(Enum.GetValues(typeof(DayoftheWeek)).GetValue(6));
                    break;
            }
            Console.ReadKey();


            Console.WriteLine("Задание 10");
            Random rand = new Random();
            int[] mass = new int[5];
            for (int i = 0; i < 5; i++)
            {
                mass[i] = rand.Next(-300, 300);
            }
            Console.WriteLine(String.Join(", ", mass));
            int N = mass.Length;
            int maxim = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        maxim = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = maxim;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", mass));
            Console.ReadKey();


            Console.WriteLine("Задание 11");
            Random random = new Random();
            int[] massiv = new int[5];
            for (int i = 0; i < 5; i++)
            {
                massiv[i] = random.Next(-300, 300);
            }
            Console.WriteLine(String.Join(", ", massiv));

            for (int i = 0; i < massiv.Length - 1; i++)
            {
                if (massiv[i] > massiv[i + 1])
                {
                    Console.WriteLine($"Нарушитель: {massiv[i]} ");
                    break;

                }
            }

            Console.ReadKey();


        }
    }

}
