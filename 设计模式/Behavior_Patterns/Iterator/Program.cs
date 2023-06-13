using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //客户端代码可能知道也可能不知道具体迭代器或集合类，
            //具体取决于要在程序中保留的间接级别。
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");
            //foreach in 在编译时做了如下工作
            //IEnumerator<string> element = collection.GetEnumertor();
            //while(element.MoveNext())
            //{
            //      Console.WriteLine(element);
            //}
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
