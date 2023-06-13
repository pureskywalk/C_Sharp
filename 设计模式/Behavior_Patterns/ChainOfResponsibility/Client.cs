using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    //客户端代码通常适合使用单个处理程序。在大多数情况下，
    //它甚至不知道处理程序是链的一部分。
    class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
