using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 8 бит числа: ");
            string n = Console.ReadLine();
            int[] b = strTobin(n);
            int c = binToInt(b);
            Console.Write("Число в десятичном виде: " + c);
            Console.ReadKey();
        }
        static int binToInt(int[] n)
        {
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (n[i] == 1)
                {
                    a = a + Convert.ToInt32(Math.Pow(2, 7 - i));
                }
            }
            if (a > 127)
            {
                return (127 - a);
            }
            else
                return a;
        }
        static int[] invers(int[] n)
        {
            for (int i = 0; i < 8; i++)
            {
                if (n[i] == 0)
                {
                    n[i] = 1;
                }
                else
                {
                    n[i] = 0;
                }
            }
            return n;
        }
        static int[] addOne(int[] n)
        {
            for (int i = 0; i < 8; i++)
            {
                if (n[i] == 0)
                {
                    n[i] = 1;
                    break;
                }
                else
                {
                    n[i] = 0;
                }
            }
            return n;
        }
        static int[] strTobin(string n)
        {
            int[] b = new int[8];
            for(int i = 0; i < 8; i++)
            {
                b[i] = Convert.ToInt32(n[i] - '0');
            }
            return b;
        }
    }
}