using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 0, 0, 0, 0, 0, 1, 1, 1 };
            int[] ar1 = new int[] { 0, 0, 0, 0, 0, 1, 0, 1 };
            Console.WriteLine(binToStr(binaryAdd(ar, ar1)));
            Console.ReadKey();//Остановка программы
        }
        static int[] binaryAdd(int[] n1, int[] n2)
        {
            int[] num = new int[8];
            int ntrans = 0;//перенос
            for (int i = 7; i >= 0; i--)
            {
                num[i] = n1[i] + n2[i] + ntrans;
                if (num[i] == 0) { num[i] = 0; ntrans = 0; }
                if (num[i] == 1) { num[i] = 1; ntrans = 0; }
                if (num[i] == 2) { num[i] = 0; ntrans = 1; }
                if (num[i] == 3) { num[i] = 1; ntrans = 1; }
            }
            return num;
        }
        static string binToStr(int[] n) // преобразуем массив в строку
        {
            string str = String.Join(" ", n); //https://learn.microsoft.com/ru-ru/dotnet/api/system.string.join?view=net-7.0
            return str;
        }
    }
}