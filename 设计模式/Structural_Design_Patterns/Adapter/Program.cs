using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");
            //客户端只需调用理想的接口方法，无需看到适配器的行为就可以调用到Adaptee的特殊方法
            Console.WriteLine(target.GetRequest());
            Console.ReadKey();
        }
    }
}
