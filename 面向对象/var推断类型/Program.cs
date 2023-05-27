using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace var推断类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //c#是一门强类型语言：在代码当中，必须对每一个变量有一个明确的定义int n = 15;
            //js是一门弱类型语言js中的var： var 12; var:3.14;


            //int n = 5;
            //string n2 = "张三";
            //double n3 = 3.14;
            //decimal n4 = 5000m;
            //bool n5 = true;
            //char n6 = '男';

            //根据值能够推断出来类型
            //var n = 5;
            //var n2 = "张三";
            //var n3 = 3.14;
            //var n4 = 5000m;
            //var n5 = true;
            //var n6 = '男';
            //Console.WriteLine(n.GetType());
            //Console.WriteLine(n2.GetType());
            //Console.WriteLine(n3.GetType());
            //Console.WriteLine(n4.GetType());
            //Console.WriteLine(n5.GetType());
            //Console.WriteLine(n6.GetType());

            //在初始化var变量时，必须赋初值
            //var input;
            //input = "张三";

            Console.ReadKey();
        }
    }
}
