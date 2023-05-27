using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //对应于hashtable键值对集合，list泛型集合对应于arraylist集合
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2,"李四");
            dic.Add(3,"王五");

            dic[1] = "新来的";
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}----{1}", kv.Key, kv.Value);
            //}
            //foreach (int item in dic.Keys)
            //{
            //    Console.WriteLine("{0}----{1}",item,dic[item]);
            //}

            string str = "123456";

            List<char> list = new List<char>();
            list = str.ToList();
            char[] chs = list.ToArray();
            foreach (char item in chs)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
