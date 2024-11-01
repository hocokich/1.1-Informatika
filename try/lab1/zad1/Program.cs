using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число в диапозоне от -128 до 127: ");
            sbyte n = sbyte.Parse(Console.ReadLine());
            int[] bin = sbyteToBin(n);
            string str = binToStr(bin);
            Console.WriteLine("Число в двоичном виде: " + str);
            Console.ReadKey();
        }
        static int[] sbyteToBin(sbyte n)
        {
            int[] bin = new int[8];
            for (int i = 7; i >= 0; i--)
            {
                bin[i] = Convert.ToInt32((sbyte)(n & 1));
                n = (sbyte)(n >> 1);
            }
            return bin;
        }
        static string binToStr(int[] n)
        {
            string str = "";
            for (int i = 0; i < 8; i++)
                str = str.Insert(i, Convert.ToString(n[i]));
            return str;
        }
    }
}