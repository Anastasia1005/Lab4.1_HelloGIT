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
            Console.Write("Ведите число B: ");
            int B = Enter_B();
        }

        static int Enter_B()
        {
            Console.Write("Введите число B: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
