using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zad7.Program;

namespace zad7
{

    internal class Program

    {
        public struct student
        {
            public string fio;
            public byte math;
            public byte phys;
        }
        static student enter()
        {
            student st = new student();
            Console.Write("enter fio: ");
            st.fio = Console.ReadLine();
            Console.Write("enter score math: ");
            st.math = byte.Parse(Console.ReadLine());
            Console.Write("enter score phys: ");
            st.phys = byte.Parse(Console.ReadLine());
            return st;
        }
        static void show(student st)
        {
            Console.WriteLine("fio " + st.fio);
            Console.WriteLine("math " + st.math);
            Console.WriteLine("phys " + st.phys);
        }
        static void Main(string[] args)
        {
            int c = 0;
            student[] students = new student[10];
            for (c = 0; c < 9; c++) 
            {
                Console.Write("Another? ");
                string answer = Console.ReadLine();
                if (answer == "no") break;
                students[c] = enter();
            }
            Console.WriteLine("All students: ");
            for (int i = 0; i < c; i++)
            {
                show(students[i]);
            }
            Console.WriteLine("Students with only 5: ");
            for (int i = 0; i < c; i++)
            {
                if (students[i].math == 5 && students[i].phys == 5) 
                show(students[i]);
            }
            Console.WriteLine("Students with one unsat: ");
            for (int i = 0; i < c; i++)
            {
                if (students[i].math < 3 || students[i].phys < 3)
                    show(students[i]);
            }
            Console.ReadKey();
        }
    }
}




/*namespace zad7
{

    internal class Program

    {
        public struct student
        {
            public string fio;
            public int math;
            public int phys;
        }
        static void Main(string[] args)
        {
            info();
            string[] list = new string[10];
            for (uint i = 0; i < 10; i++)
            {
                list[i] = info();
            }
            Console.ReadKey();
        }
        static void info()
        {
            student student = new student();
            Console.Write("ФИО ученика: ");
            string fio = Console.ReadLine();
            Console.Write("Оценка: ");
            //
            int math = int.Parse(Console.ReadLine());
            student.math = math;
            int phys = int.Parse(Console.ReadLine());
            student.phys = phys;
        }
    }
}*/