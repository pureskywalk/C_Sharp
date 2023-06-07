using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;

            //客户端代码应该能够使用任何预配置的抽象-实现组合。
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            Console.ReadKey();
        }
    }
}
