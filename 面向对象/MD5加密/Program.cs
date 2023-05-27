using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //123
            //202cb962ac59075b964b07152d234b70
            string s = GetMD5("123");
            
            
            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();//模拟创建
            //开始加密
            //将字符串转换为字符数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5Buffer = md5.ComputeHash(buffer);
            //将字节数组转换为字符串
            //return Encoding.Default.GetString(MD5Buffer);//这种方式可能出现错误
            string strNew = "";
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                //strNew += MD5Buffer[i].ToString();//以16进制显示//3244185981728979115075721453575112
                //strNew += MD5Buffer[i].ToString("x");//202cb962ac5975b964b7152d234b70,7前面少一个0
                strNew += MD5Buffer[i].ToString("X2");//202CB962AC59075B964B07152D234B70
            }
            return strNew;
        }
    }
}
