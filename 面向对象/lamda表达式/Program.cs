using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lamda表达式
{
    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DelOne del = () => { };
            DelTwo del2 = (string name) => { };
            DelThree del3 = (string name) => { return name; };

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7 };
            list.RemoveAll(n => false/*n < 4*/);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(); 
        }
    }
}
