using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите 8 бит числа: ");
            string str = Console.ReadLine();
            Console.WriteLine("Число в десятичном виде: " + binToInt(strToBin(str)));
            Console.ReadKey();//Остановка программы
        }
        static int binToInt(int[] n) //преобразование массива целых чисел в целое число
        {
            int num = binToDecimal(n);

            if (num > 127) // для отрицательного числа
            {
                num = binToDecimal(invers(n)); // n - 1
                num++;                         // n - 1 + 1  =  n
                num *= -1;                     // n * -1 = -n
            }
            return num;
        }
        static int binToDecimal(int[] n)// алгоритм преобразования числа
        {
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum += n[i] * (int)(Math.Pow(2, 8 - i - 1));
            }
            return sum;
        }
        static int[] invers(int[] n) //функция инвертирования значений
        {
            for (int i = 7; i >= 0; i--)
            {
                if (n[i] == 0) n[i] = 1;
                else n[i] = 0;
            }
            return n;
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
    }
}