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
            Console.WriteLine("Вести число от -128 до 128: ");
            sbyte n = sbyte.Parse(Console.ReadLine());
            int[] bin = sbyteToBin(n);
            string str = binToStr(bin);
            Console.WriteLine("число в 2: ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static int[] sbyteToBin(sbyte n)
        {
            int[] bin = new int[8];
            int x = 0;
            for(sbyte i = 1;i !=0;i=(sbyte)(i<< 1))
            {
                sbyte d = (sbyte)(n & i);
                if (d == 0)
                bin[x] = 0;
                else
                bin[x] = 1;
                x++;
            }
            return bin;
        }
        static string binToStr(int[] n)
        {
            string s = "";
            for (int i = 7, j = 0; i >= 0; i--, j++)
            {
                if (n[i] == 0)
                    s = s.Insert(j, "0");
                else s = s.Insert(j, "1");
            }
            return s;
        }
    }
}