using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    
    internal class Ex1
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число в диапозоне от -128 до 127: ");
            sbyte n = sbyte.Parse(Console.ReadLine());
            Console.Write("Число в двоичном виде: " + binToStr(sbyteToBin(n)));
            Console.ReadKey();//Остановка программы
        }
        static int[] sbyteToBin(sbyte n) // преобразуем число в массив
        {
            int[] bin = new int[8];//инициализаруем новый массив
            for (int i = 7; i >= 0; i--)
            {
                bin[i] = Convert.ToInt32((sbyte)(n & 1));//записывает остаток от деления в элемент массива
                n = (sbyte)(n >> 1);// целочисленное деление на 2(сдвиг на 1 разряд в право)
            }
            return bin;
        }
        static string binToStr(int[] n) // преобразуем массив в строку
        {
            string str = String.Join(" ", n); //https://learn.microsoft.com/ru-ru/dotnet/api/system.string.join?view=net-7.0
            return str;
        }
    }
}