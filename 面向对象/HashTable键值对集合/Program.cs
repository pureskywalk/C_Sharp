using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HashTable键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht.Add("abc","哈哈哈");
            //这种添加方式会出现键一样的异常
            //ht.Add(1,"张三无法被替换，报错");

            //另一种添加数据的方式，如果键一样，则替换值的数据
            ht[6] = "新来的";
            ht[1] = "张三被替换掉";

            if (!ht.ContainsKey("abc"))//判断是否包含某个键
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经包含“abc”这个键了");
            }

            //ht.Clear();//移除集合中所有的元素
            ht.Remove(3);//根据键移除数据


            //使用foreach循环遍历键值对集合
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是——{0}====值是{1}", item, ht[item]);
            }
            //在键值对集合中，是根据键去找值的
            //Console.WriteLine(ht[1]);


            //使用foreach循环遍历键值对集合

            Console.ReadKey();
        }
    }
}
