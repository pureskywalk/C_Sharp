using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多播委托
{
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = T1;
            del += T2;
            del += T3;
            del += T4;
            del -= T2;
            del();

            Console.ReadKey();
        }

        public static void T1()
        {
            Console.WriteLine("T1");
        }

        public static void T2()
        {
            Console.WriteLine("T2");
        }

        public static void T3()
        {
            Console.WriteLine("T3");
        }

        public static void T4()
        {
            Console.WriteLine("T4");
        }
    }
}
