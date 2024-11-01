using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 8 бит числа: ");
            string bits = Console.ReadLine();
            int[] bitss= strToBin(bits);
            Console.Write("Число в десятичном виде: " + binToSByte(bitss));
            Console.ReadKey();
        }
        static int[] strToBin(string n)
        {
            int[] bits = new int[8];
            for (int i = 0; i < 8; i++)
            {
                bits[i] = Convert.ToInt32(n[i] - '0');
            }
            return bits;
        }
        static sbyte binToSByte(int[] n)
        {
            sbyte num = 0;
            for (int i = 0; i < 8; i++)
            {
                num = (sbyte)(num << 1); 
                num = (sbyte)(num | Convert.ToSByte(n[i]));
            }
            return num;
        }

    }
}
