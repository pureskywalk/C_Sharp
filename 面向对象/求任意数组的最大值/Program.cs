using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 求任意数组的最大值
{

    public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "afgabg", "FFaGFwgbW", "ffSDAWVwbgES", "FafdAFE" };
            object max = GetMax(strs,(object o1,object o2) =>//GetMax(strs, delegate(object o1, object o2) 
            {
                string str1 = (string)o1;
                string str2 = (string)o2;
                return str1.Length - str2.Length;
            });

            Console.WriteLine(max);
            Console.ReadKey();
        }

        private static object GetMax(object[] os, DelCompare del)
        {
            object max = os[0];
            for (int i = 0; i < os.Length; i++)
            {
                if (del(max, os[i]) < 0)
                {
                    max = os[i];
                }
            }
            return max;
        }
    }
}
