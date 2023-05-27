using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作字符
            //创建StreamReader来读取文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\CONNTEK32\Desktop\new.txt",Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());//默认按行读取
            //    }
            //}

            //使用StreamWriter写入一个文件，覆盖源文件，加上true表示追加
            using (StreamWriter sw = new StreamWriter(@"C:\Users\CONNTEK32\Desktop\new.txt",true))
            {
                sw.Write("今天天气");
            }
            Console.ReadKey();
        }
    }
}
