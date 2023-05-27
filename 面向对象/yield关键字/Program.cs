using System;
using System.Collections.Generic;

namespace yield关键字
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;
            foreach (var item in F1(2, 5))
            {
                str1 += item + "_";
            }
            Console.WriteLine(str1.TrimEnd('_'));
            Program program = new Program();
            int a = program.F3(1, 2);//静态方法中引用非静态成员时，需要将对象实例化才可调用，建议将方法写成static
            Console.WriteLine(a);
            Console.ReadKey();
        }

        int F3(int a1,int a2)
        {
            return a1 + a2;
        }

        static IEnumerable<int> F1(int num, int exp)
        {
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= num;
                yield return result;
            }
            yield break;
        }

        public static IEnumerable<int> F2(int num, int exp)
        {
            List<int> temp = new List<int>();
            int result = 1;
            for (int i = 0; i < exp; i++)
            {
                result = result * num;
                temp.Add(result);
            }

            return temp;
        }
    }
}
