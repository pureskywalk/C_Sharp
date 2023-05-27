using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 为什么要使用委托
{

    public delegate string StrMethod(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //将方法作为参数传递给另一个方法
            //三个需求
            //将一个字符串数组中每个元素都转换为大写
            //将一个字符串数组中每个元素都转换为小写
            //将一个字符串数组中每个元素两边都加上 双引号
            string[] names = {"abCDefG","HiJklmN","OpqrTu","VwxYz"};
            //ProcessStrToUpper(names);
            //ProStr(names, StrSYH);
            ProStr(names, delegate(string name)//匿名函数，没有方法名，当方法只使用一次时考虑使用
            {
                return name.ToUpper();
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            

            Console.ReadKey();
        }

        public static void ProStr(string[] name, StrMethod str)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = str(name[i]);
            }
        }

        //public static string StrToUpper(string name)
        //{
        //    return name.ToUpper();
        //}

        //public static string StrToLower(string name)
        //{
        //    return name.ToLower();
        //}

        //public static string StrSYH(string name)
        //{
        //    return "\""+name+"\"";
        //}

        //public static void ProcessStrToUpper(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToUpper();
        //    }
        //}

        //public static void ProcessStrToLower(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToLower();
        //    }
        //}

        //public static void ProcessStrSYH(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = "\"" + name[i] + "\"";
        //    }
        //}
    }
}
