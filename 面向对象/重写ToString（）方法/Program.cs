using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 重写ToString__方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }

    public class Person
    {
        public override string ToString()//重写的只是Person的ToString(),不影响其他的，这里说明ToString方法为虚方法
        {
            return "Hello World";
        }
    }
}
