using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            //string str = null;
            //创建一个计时器，用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i = 0; i < 10000; i++)
            {
                //str += i;//00:00:00.0277274
                sb.Append(i);//00:00:00.0006926
            }
            sw.Stop();//停止计时
            Console.WriteLine(sb.ToString());//将stringbuilder转换为string
            Console.WriteLine(sw.Elapsed);//打印出总运行时间
            Console.ReadKey();

        }
    }
}
