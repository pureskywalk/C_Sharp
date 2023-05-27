using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace 进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取电脑上所有进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    Console.WriteLine(item);
            //}

            //通过进程打开应用程序
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore","http://www.baidu.com");

            //通过进程打开一个指定的文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\CONNTEK32\Desktop\new.txt");

            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();
            Console.ReadKey();
        }
    }
}
