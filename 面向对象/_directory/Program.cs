using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Path FileStream StreamReader StreamWriter
            //Directory 操作文件 目录

            //创建文件夹
            //Directory.CreateDirectory(@"C:\Users\CONNTEK32\Desktop\新来的文件夹");

            //彻底（回收站不能找到）删除文件夹,如果文件夹内有内容，则报异常，保护内部文件，如果不要保护，加上true
            //Directory.Delete(@"C:\Users\CONNTEK32\Desktop\新来的文件夹",true);

            //剪切粘贴,或者重命名，内部内容不改变
            //Directory.Move(@"C:\Users\CONNTEK32\Desktop\新来的文件夹", @"C:\Users\CONNTEK32\Desktop\新来的文件夹1");

            //获取指定文件夹下所有文件的路径
            //string[] path = Directory.GetFiles(@"C:\Users\CONNTEK32\Desktop\新来的文件夹1","*.jpg");//*.jpg表示只需要该文件格式的文件
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}

            //获取指定目录下所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"C:\Users\CONNTEK32\Desktop\新来的文件夹1");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}

            //判断是否存在指定文件夹
            //if (Directory.Exists(@"C:\Users\CONNTEK32\Desktop\新来的文件夹1"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"C:\Users\CONNTEK32\Desktop\新来的文件夹1\" + i);
            //    }
            //}
            Console.ReadKey();
        }
    }
}
