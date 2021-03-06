﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, choice;

            Console.WriteLine("1. Ввести число A");
            Console.WriteLine("2. Ввести число B");
            Console.WriteLine("3. Сложить A и B");
            Console.WriteLine("4. Вычесть B из A");
            Console.WriteLine("5. Умножить A на B");
            Console.WriteLine("6. Разделить A на B");

            for ( ; ; )
            {
                Console.Write("Введите номер пункта меню (или другое число, если хотите выйти): ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    A = Enter_A();
                }
                else if (choice == 2)
                {
                    B = Enter_B();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Число A = {0}, число B = {1}, результат сложения = {2}", A, B, A+B);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Число A = {0}, число B = {1}, результат вычитания B из A = {2}", A, B, A - B);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Число A = {0}, число B = {1}, результат умножения = {2}", A, B, A * B);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Число A = {0}, число B = {1}, результат деления A на B = {2}", A, B, A / B);
                }
                else
                    break;
            }

            Console.ReadKey();
        }

        static int Enter_B()
        {
            Console.Write("Введите число B: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Enter_A()
        {
            Console.Write("Введите число A: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        int Addition(int A, int B)
        {
            return A + B;
        }

        int Subtraction(int A, int B)
        {
            return A - B;
        }

        int Multiplication(int A, int B)
        {
            return A * B;
        }

        int Division(int A, int B)
        {
            return A / B;
        }
    }
}
