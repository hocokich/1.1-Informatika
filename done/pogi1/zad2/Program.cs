using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tВведи ровно один символ и узнай цифра ли это!");
            ConsoleKeyInfo key = Console.ReadKey();
            char ch = key.KeyChar;
            int num = (int)Char.GetNumericValue(ch);
            if (num == -1)
            {
                Console.WriteLine(" = Не цифра");
            }
            else
            {
                Console.WriteLine(" = Цифра");
            }
            /*if (char.IsDigit(ch))
            {
                Console.WriteLine(" Это цифра");
            }
            else
            {
                Console.WriteLine(" Это не цифра");
            }*/
            Console.ReadKey();
        }
    }
}