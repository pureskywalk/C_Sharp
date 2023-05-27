using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //object o = n;//装箱
            //int nn = (int)o;//拆箱

            //ArrayList list = new ArrayList();//00:00:00.9246818

            //List<int> list = new List<int>();//00:00:00.0802927
            //这个循环进行了1000万次的装箱操作
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();

            //Console.WriteLine(sw.Elapsed);


            //这个地方没有拆箱
            //string str = "124";
            //int n = Convert.ToInt32(str);


            //int n = 16;
            //IComparable i = n;//装箱
            Console.ReadKey();
        }
    }
}
