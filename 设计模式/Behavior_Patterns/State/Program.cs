using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //客户端代码
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.ReadKey();
        }
    }
}
