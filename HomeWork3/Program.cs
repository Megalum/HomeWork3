using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputStr(string str)
            {
                Console.Write(str);
                return Console.ReadLine();
            }

            int[] InputMas(string str)
            {
                int[] mas = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    mas[i] = InputInt($"{str}[{i+1}] = ");
                }
                return mas;
            }

            int InputInt(string str)
            {
                Console.Write(str);
                return Convert.ToInt32(Console.ReadLine());
            }

            //Задаине 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            Console.WriteLine("Задаине 1");
            string stroka = InputStr("Введите пятизначное число: ");
            if (stroka[0] == stroka[4] && stroka[1] == stroka[3])
                Console.WriteLine($"Число {stroka} является палиндромом");
            else Console.WriteLine($"Число {stroka} не является палиндромом");
            Console.WriteLine();

            //Задаине 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            double Formula(int[] a, int[] b)
            {
                return Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2));
            }

            Console.WriteLine("Задаине 2");
            int[] mas1 = new int[3], mas2 = new int[3];
            mas1 = InputMas("A");
            mas2 = InputMas("B");
            Console.WriteLine($"Растояние между точками А и В = {Math.Round(Formula(mas1, mas2),2)}");
            Console.WriteLine();

            //Задаине 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            Console.WriteLine("Задаине 3");
            int nummber = InputInt("Введите число ");
            Console.Write(nummber + " --> ");
            for (int i = 1; i <= nummber; i++)
            {
                if (i == nummber)
                    Console.WriteLine(Math.Pow(i, 3));
                else
                    Console.Write($"{Math.Pow(i, 3)}, ");
            }

            Console.ReadKey();
        }
    }
}
