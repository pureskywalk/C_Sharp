using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个新文件，如果已经有一个相同的文件名，则会修改该文件
            //File.Create(@"C:\Users\17667\Desktop\new.txt");
            //Console.WriteLine("创建成功");

            //删除一个文件
            //File.Delete(@"C:\Users\17667\Desktop\new.txt");
            //Console.WriteLine("删除成功");

            //复制一个文件,true表示当文件存在时允许覆盖，如果不加则会报异常
            //File.Copy(@"C:\Users\CONNTEK32\Desktop\new.txt", @"C:\Users\CONNTEK32\Desktop\new1.txt",true);
            //Console.WriteLine("复制成功");

            //判断一个文件是否存在
            //if (File.Exists(@"C:\Users\CONNTEK32\Desktop\new.txt"))
            //{
            //    Console.WriteLine("文件存在");
            //}



            //移动一个文件到新的位置，可以改变文件名，但是内容不会改变
            //File.Move(@"C:\Users\CONNTEK32\Desktop\new.txt", @"D:\new1.txt");
            //Console.WriteLine("移动成功");

            //创建一个文件，将byte[]的内容写到文件中，如果存在则覆盖
            //string str = "国家关键人物王超";
            //File.WriteAllBytes(@"C:\Users\CONNTEK32\Desktop\new.txt", Encoding.Default.GetBytes(str));

            //创建一个文件，将strin[]按行写入，如果重名则覆盖
            //File.WriteAllLines(@"C:\Users\CONNTEK32\Desktop\new.txt", new string[]{"aoe","iwu"},Encoding.Default);

            //创建一个文件，将string写入，重名则覆盖
            //string str = "国家关键人物王超";
            //File.WriteAllText(@"C:\Users\CONNTEK32\Desktop\new.txt", str);

            //向指定文件夹追加string内容，同样也有File.AppendAllLines,按行写入string[]
            //string str = "国家关键人物王超\r";//对文本操作时，\r\n不起作用
            //File.AppendAllText(@"C:\Users\CONNTEK32\Desktop\new.txt", str);
            


            //以二进制方式读回所有文件(包括音频文件等，另外两种方式只能读文本文件)，如果对数组对象使用ToString，得到的是数组的命名空间，所以用到解码
            //byte[] b = File.ReadAllBytes(@"C:\Users\CONNTEK32\Desktop\new.txt");
            //Console.WriteLine(Encoding.Default.GetString(b));

            //读取所有文本,返回string
            //Console.WriteLine(File.ReadAllText(@"C:\Users\CONNTEK32\Desktop\new.txt", Encoding.Default));

            //按行读取文件所有数据，返回string[]，可以对每一行进行操作
            //string[] str = File.ReadAllLines(@"C:\Users\CONNTEK32\Desktop\new.txt", Encoding.Default);
            //Console.WriteLine(str[0]);//展示第一行
            //foreach (string item in str)//展示所有
            //{
            //    Console.WriteLine(item);
                                
            //}
            //Console.ReadKey();

            Console.ReadKey();
        }
    }
}
