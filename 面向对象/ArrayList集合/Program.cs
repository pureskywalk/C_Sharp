using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个集合对象
            ArrayList list = new ArrayList();
            //集合：很多数组的一个集合
            //数组：长度不可变、类型单一
            //集合的好处：长度可以任意改变 类型随便
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("zs");
            
            list.Add(5000m);
            list.Add(new int[]{0,1,2,3,4,5,6});
            list.Add(list);

            Person p = new Person();
            list.Add(p);

            //我们将对象输出到控制台，默认情况下，打印的就是这个对象所在的类的命名空间
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);
                    }
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
                //Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
