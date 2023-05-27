using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值传递和引用传递
            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            Person p1 = new Person();
            p1.Name = "张三";
            Person p2 = p1;//这句话表示，P1（堆中）的地址（栈中）被赋值给了P2（栈中），表示两个变量指向了堆中的同一块内存
            p2.Name = "李四";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            //字符串的不可变性
            //string s1 = "张三";
            //string s2 = s1;
            //s2 = "李四";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            int[,] ints= new int[2,5];
            int a = ints.GetLength(0);
            int b = ints.GetLength(1);

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我是{0}",this.Name);
        }
    }
}
