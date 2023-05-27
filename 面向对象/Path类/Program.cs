using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\Conntek\C#\test\USB\王超.wav";

            //获取文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得没有拓展名的文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的拓展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件所在的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //连接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\a\","b.tex"));


            //int index = str.LastIndexOf("\\");
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}
