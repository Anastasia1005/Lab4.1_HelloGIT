using System;
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
            Console.WriteLine("1. Ввести число A");
            Console.WriteLine("2. Ввести число B");
            Console.WriteLine("3. Сложить A и B");
            Console.WriteLine("4. Вычесть B из A");
            Console.WriteLine("5. Умножить A на B");
            Console.WriteLine("6. Разделить A на B");

            Console.Write("Введите номер пункта меню: ");

            Console.ReadKey();
            Console.Write("Ведите число B: ");
            int B = Enter_B();
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
    }
}
