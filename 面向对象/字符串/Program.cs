using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            //s[0] = 'b';不能这样做，因为字符串是只读的
            //如果想改变，首先将字符串转换为char类型的数组
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为字符串
            s = new string(chs);
            Console.WriteLine(s[0]);
            Console.ReadKey();
        }
    }
}
