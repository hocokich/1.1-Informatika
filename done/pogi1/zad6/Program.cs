using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца от 1 до 12: ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 3 | n == 4 | n == 5)
                Console.Write("Весна");
            if (n == 6 | n == 7 | n == 8)
                Console.Write("Лето");
            if (n == 9 | n == 10 | n == 11)
                Console.Write("Осень");
            if (n == 12 | n == 1 || n == 2)
                Console.Write("Зима");
            Console.ReadKey();
        }
    }
}