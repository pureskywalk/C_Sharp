using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayList的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //添加集合元素使用AddRange
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.AddRange(new int[]{1,2,3,4,5,6,7});

            //list.AddRange(list);

            //删除单个元素,这里有两个
            //list.Remove(true);
            //list.Remove(true);

            //根据下标删除元素
            //list.RemoveAt(0);

            //根据下标(索引)移除一定范围的元素
            //list.RemoveRange(0, 5);

            //list.Sort();//升序排列，注意，集合类型必须一样才能排序，否则报异常

            //反转集合
            //list.Reverse();

            //在指定的地方之前插入元素
            //list.Insert(1, "插入");

            //在指定的地方之前插入集合
            //list.InsertRange(0, new string[] { "张三", "李四" });

            //判断是否包含某个指定的元素
            //bool b = list.Contains(1);




            //删除整个集合
            //list.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
