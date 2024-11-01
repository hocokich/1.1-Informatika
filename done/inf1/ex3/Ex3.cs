using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите число в диапозоне от -128 до 127: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число в двоичном виде: " + binToStr(intToBin(n)));
            Console.ReadKey();//Остановка программы
        }
        static int[] intToBin(int n)// преобразование числа в массив
        {
            int n1 = n;//создаем вторую переменную чтобы не потерять минус
            if (n1 < 0) n1 = n1 * -1;
            int[] bin = new int[8];
            for (int i = 7; i >= 0; i--)
            {
                bin[i] = n1 % 2;//записываем остаток от деления на 2 
                n1 = n1 / 2;//целочисленное деление на 2
            }
            if (n < 0) bin = addOne(invers(bin));
            return bin;
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
        static int[] addOne(int[] n) //функция добавления единицы к числу
        {
            for (int i = 7; i >= 0; i--)
            {
                if (n[i] == 1) n[i] = 0;// -5^10 != 1111 101[0]^2 != [1]
                else                    // ||
                {                       // \/
                    n[i] = 1;           // 1111 101[1] = 1
                    break; //прерываем цикл отправляем на золото
                }
            }
            return n;
        }
        static string binToStr(int[] n) //преобразуем массив в строку
        {
            string str = String.Join(" ", n); //https://learn.microsoft.com/ru-ru/dotnet/api/system.string.join?view=net-7.0
            return str;
        }
    }
}