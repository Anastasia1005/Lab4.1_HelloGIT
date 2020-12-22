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
            Console.Write("Ведите число A: ");
            int A = Enter_A();
        }

        static int Enter_A()
        {
            Console.Write("Введите число A: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
