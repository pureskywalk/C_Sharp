using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        //客户端代码选取一个具体的策略并将其传递给上下文。
        //客户应该意识到策略之间的差异，以便做出正确的选择。
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadKey();
        }
    }
}
