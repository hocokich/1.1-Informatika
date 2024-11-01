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
            Console.WriteLine("Введите минимальное и максимальное значение ниже: ");
            Random rnd = new Random();
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int[,] dvmas = new int[5,5];
            Console.WriteLine("Рандомный массив5x5: ");
            for (uint i = 0; i <= 4; i++)
            {
                dvmas[i,0] = rnd.Next(min, max);
                dvmas[i,1] = rnd.Next(min, max);
                dvmas[i,2] = rnd.Next(min, max);
                dvmas[i,3] = rnd.Next(min, max);
                dvmas[i,4] = rnd.Next(min, max);
            }
            for (uint i = 0; i <= 4; i++)
            {
                Console.WriteLine(dvmas[i, 0] + " " + dvmas[i, 1] + " " + dvmas[i, 2] + " " + dvmas[i, 3] + " " + dvmas[i, 4]);
            }

            Console.ReadKey();
        }
    }
}