using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        //客户端代码通过基接口处理所有组件。
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        //由于子管理操作是在基组件类中声明的，
        //因此客户端代码可以使用任何组件（简单或复杂），而不依赖于其具体类。
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
