using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Простые числа от ({0}, {1})", 0, n);
            for (uint i = 0; i < n; i++)
            {
                if (prostoe(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
        static bool prostoe(uint n)
        {
            bool result = true;
            if (n > 1)
            {
                for (uint i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}