using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace 正则表达式Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex.IsMatch();//用于判断给定的字符串是否匹配给定的正则表达式
            //Regex.Match();//用来从给定的字符串中按照正则表达式的要求提取【一个】匹配的字符串
            //Regex.Matches();//用来从给定的字符串中按照正则表达式的要求提取【所有】匹配的字符串
            //Regex.Replace();//替换【所有】正则表达式匹配的字符串为另一个字符串

            //Console.WriteLine("请输入一个邮政编码");
            //string str = Console.ReadLine();
            ////验证给定的字符串是否为一个合法的邮政编码
            ////bool b = Regex.IsMatch(str, "^[0-9]{6}$");//开始符与结尾符加上之后为完全限定
            //bool b = Regex.IsMatch(str, @"^\d{6}$");//也可以写成这种形式，注意要加上@取消转义作用形成转换，使他成为一个简写表达式
            //Console.WriteLine("{0}", b);

            //Console.WriteLine("请输入一个10-25之间的数字");
            //string str = Console.ReadLine();
            ////验证给定的字符串是否为10-25中的任意一个字符
            //bool b = Regex.IsMatch(str, "^（1[0-9]|2[0-5]）$");//注意：此处如果不加（），则由于|符号优先级最低，会只满足开始符^和结尾符$其中的一个
            //Console.WriteLine("{0}", b);

            //while (true)
            //{
            //    Console.WriteLine("请输入一个email地址");
            //    string email = Console.ReadLine();
            //    //+号表示一次或多次,此处由于\与.符号发生了转换，不能再是两个组合，只能是一个点(与[]中的单独点的意义相同)，若希望两个符号组合匹配，则应该写成\\.
            //    Console.WriteLine(Regex.IsMatch(email, @"^\\[0-9a-zA-Z]+@[a-zA-Z0-9]+([a-zA-Z.]+){1,2}$"));
            //}

            //string str = "123";
            //bool b = Regex.IsMatch(str, @"\d+", RegexOptions.ECMAScript);//将\d限定为只能读取ASCII编码的字符（\d可包括unicode的字符）
            //Console.WriteLine(b);


            //string msg = "abciqbiqbvi____8723e2891fgun你好";
            //bool b = Regex.IsMatch(msg, @"^\w+$", RegexOptions.ECMAScript);//由于限定了ASCII模式，\w所以不包含中文
            //Console.WriteLine(b);


            #region 字符串提取
            //string str = "10.26qfbq07.25qefq10.27ofhwiq08.09";
            //MatchCollection matchcol = Regex.Matches(str, @"(\d{2})\.(\d{2})");
            //foreach (Match item in matchcol)
            //{
            //    //item.Value表示本次提取到的字符串
            //    //item.Groups表示集合中所有的分组信息
            //    //item.Groups[0].Value与item.Groups等价，表示本次提取到的内容，item.Groups[1].Value表示本次第一组的内容，以此类推
            //    Console.WriteLine("{0}\t{1}",item.Groups[1].Value,item.Groups[2]);
            //}
            #endregion
            string str = @"C:\Users\17667\Desktop\太行数字输出版本演示\test.txt";
            //因为“贪婪模式的存在，这里会匹配到最后一个\ ”
            Match match =  Regex.Match(str, @".+\\(.+)");
            Console.WriteLine(match.Groups[1].Value);
            Console.ReadKey();

        }
    }
}
