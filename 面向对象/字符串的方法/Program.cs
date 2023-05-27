using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("这个人名的长度是{0}",name.Length);
            //Console.ReadKey();


            //string s = "a  b    dahfj   _+  = ,,, fjsgj";
            ////分割字符串split,去除不需要的字符，移除空项
            //char[] chs = { ' ', '_', '+', '=', ',' };
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //Console.ReadKey();

            //string s = "2008-08-08";
            ////char[] chs = {'-'};
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",date[0],date[1],date[2]);
            //Console.ReadKey();

            //string str = "国家关键人物王超";
            //if(str.Contains("王超"))//判断字符串中是否包含特定字符
            //{
            //    str = str.Replace("王超", "**");//替换字符
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            string str = "今天天气好晴朗，处处好风光";
            str = str.Substring(1, 2);//截取字符串
            Console.WriteLine(str);
            Console.ReadKey();

            //string str = "今天天气好晴朗，处处好风光";
            //if (str.StartsWith("今天"))//判断字符串是否以特定字符串开始，结束为endswith
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();


            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.IndexOf('天',1);//从指定位置开始找特定字符第一次出现的位置，返回所在的位置，如果没有，返回-1
            //Console.WriteLine(index);
            //Console.ReadKey();

            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.LastIndexOf('天');//从指定位置开始找特定字符最后一次的位置，返回所在的位置
            //Console.WriteLine(index);
            //Console.ReadKey();

            //LastIndexOf  Substring
            //string path = @"\a\b\c\d\e\f\g";//@取到取消\在字符串中的转译作用，取消字符换行打断
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index + 1);//因为截取的时候会把\也截取进来，所以移一位
            //Console.WriteLine(path);
            //Console.ReadKey();


            //string str = "    hahahaha    ";
            //str = str.Trim();//移除字符串前后的空格
            //str = str.TrimStart();//移除字符前的空格
            //str = str.TrimEnd();//移除字符后的空格
            //Console.Write(str);//write writeline的区别是运行后光标停在最后 还是 换行的位置
            //Console.ReadKey();

            //string str = null;
            //if (string.IsNullOrEmpty(str))//判断字符串是不是null或者空
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();

            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            ////string strNew = string.Join("|", names);
            //string strNew = string.Join("|", "张三","李四","王五","田七","赵六");
            //Console.WriteLine(strNew);
            //Console.ReadKey();
        }
    }
}
