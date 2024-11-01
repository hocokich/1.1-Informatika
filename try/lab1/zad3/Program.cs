using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace zad3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число в диапозоне от -128 до 127: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] bin = intToBin(n);
            string str = binToStr(bin);
            string reverse = str.reverse();
            Console.Write("Число в двоичном виде: " + reverse);
            Console.ReadKey();
        }

        static int[] intToBin(int n)
        {
            int n1 = n;
            if (n < 0)
            {
                n1 *= -1;
            }
            int[] a = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (n1 % 2 == 0)
                {
                    a[i] = 0;
                }
                else
                {
                    a[i] = 1;
                }
                n1 = n1 / 2;
            }
            if (n < 0)
            {
                a = addOne(invers(a));
            }
            return (a);
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
        static string binToStr(int[] n)
        {
            string str = "";
            for (int i = 0; i < 8; i++)
                str = str.Insert(i, Convert.ToString(n[i]));
            return str;
        }
    }
    public static class Extensions
    {
        public static string reverse(this string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}