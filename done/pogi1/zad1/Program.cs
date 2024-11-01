using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teoria1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tТАБЛИЦА УМНОЖЕНИЯ!");
          
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(i + "*" + j + "=" + (i * j) + "\t");
                }
            }

            Console.ReadKey();
        }
    }
}
















