﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.AddRange(new int[]{ 1, 2, 3, 4, 5, 6 });
            list.AddRange(list);
            
            //List泛型集合可以转换为数组,数组也可以转化为集合
            //int[] nums = list.ToArray();
            //List<int> listTwo = nums.ToList();

            //char[] chs = new char[] { 'c', 'b', 'a' };
            //List<char> listChar = chs.ToList();
            //for (int i = 0; i < listChar.Count; i++)
            //{
            //    Console.WriteLine(listChar[i]);
            //}


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
