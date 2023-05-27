using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托概念
{

    //声明一个委托指向一个函数，委托所指向的函数必须跟委托具有相同的参数和返回值
    public delegate void DelSayHello(string name);


    class Program
    {
        static void Main(string[] args)
        {
            //可以直接将方法赋值给一个委托对象
            //DelSayHello del = SayHello;//new DelSayHello(SayHello);
            //del("张三");

            Test("张三", SayHello);
            Console.ReadKey();

            
        }

        public static void Test(string name,DelSayHello del)
        {
            //调用
            del(name);
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("吃了吗？"+name);
        }

        public static void SayHelloEN(string name)
        {
            Console.WriteLine("nice to meet you" + name);
        }
    }
}
