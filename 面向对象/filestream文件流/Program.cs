using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace filestream文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Stream 操作字节，而StreamWriter\Streamreader是操作字符的
            //读取数据
            ////1.创建FileStream对象
            //FileStream fsReader = new FileStream(@"C:\Users\CONNTEK32\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////返回实际读到的字节数
            //int r = fsReader.Read(buffer,0,buffer.Length);
            ////将字节数组中的每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.Default.GetString(buffer,0,r);
            ////关闭流
            //fsReader.Close();

            ////释放流所占用的资源
            //fsReader.Dispose();
            //Console.WriteLine(s);

            //写入数据,创建时写在using里会自动释放资源
            //using(FileStream fsWrite = new FileStream(@"C:\Users\CONNTEK32\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
                
            //    string str = "能否覆盖";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    //不会全部覆盖，只会修改一部分
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.ReadKey();
        }
    }
}
