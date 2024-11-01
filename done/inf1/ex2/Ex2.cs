using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите 8 бит числа: ");
            string str = Console.ReadLine();
            Console.WriteLine("Число в десятичном виде: " + binToSByte(strToBin(str)));
            Console.ReadKey();//Остановка программы
        }
        static int[] strToBin(string n)//преобразовываем строку в массив
        {
            int[] bin = new int[8];
            for (int i = 0; i < 8; i++)
            {
                bin[i] = int.Parse(Char.ToString(n[i]));
            }
            return bin;
        }
        static sbyte binToSByte(int[] n)//преобразовываем массив в переменную типа сбайт
        {
            sbyte num = 0;
            for (int i = 0; i < 8; i++)
            {
                num <<= 1; //сдвигает на 1 влево (умножает на 2) 
                num = (sbyte)(num | (sbyte)n[i]);//складывает число с элементом массива
            }
            return num;
        }
    }
}