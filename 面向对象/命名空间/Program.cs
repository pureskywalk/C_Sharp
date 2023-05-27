using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 面向对象;

namespace 命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Person zsPerson = new Person("张三",18,'男');
            zsPerson.CHLSS();
            Console.ReadKey();
        }
    }
}
