using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 求任意数组最大值_泛型委托_
{
    class Program
    {
        public delegate int DelCompare<T>(T t1, T t2);
        static void Main(string[] args)
        {
            string[] strs = { "afgabg", "FFaGFwgbW", "ffSDAWVwbgES", "FafdAFE" };
            string max = GetMax<string>(strs, (string t1, string t2) =>
            {
                return t1.Length - t2.Length;
            });

            Console.WriteLine(max);
            Console.ReadKey();
        }

        private static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
