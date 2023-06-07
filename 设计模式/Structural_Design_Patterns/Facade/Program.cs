using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //客户端代码可能已创建某些子系统的对象。在这种情况下，
            //可能值得使用这些对象初始化外观，而不是让外观创建新实例。
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);

            Console.ReadKey();
        }
    }
}
