using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1; //переменная типа double со значением 1
            double b = 2; //переменная типа double со значением 2
            Console.WriteLine(a + " " + b); //
            Obmen(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
        static void Obmen(ref double a, ref double b)
        {
            double c = a; a = b; b = c;
        }
    }
}