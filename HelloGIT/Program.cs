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
            int A;

            Console.WriteLine("Hello GIT!");

            Console.Write("Введите A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nНажмите любую клавишу, дотвидания");
            Console.ReadKey();
        }

        static int Enter_A()
        {
            Console.Write("Введите A: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
