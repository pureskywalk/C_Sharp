using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1,2,3,4,5,6,7,8,9};
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.WriteLine("-------------");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            int[] nums = new int[10000000];
            //00:00:00.0199503
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < nums.Length; i++)
            //{

            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //00:00:00.0334917
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //foreach (var item in nums)
            //{

            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
    }
}
