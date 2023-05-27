using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 匿名函数
{

    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del = delegate(string name)
            //{
            //    Console.WriteLine("你好" + name);
            //};
            //del("张三");

            //lamda表达式  => goes to
            DelSayHi del = (string name) => { Console.WriteLine("你好" + name); };
            del("张三");

            Console.ReadKey();
        }
    }
}
