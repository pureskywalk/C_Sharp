using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Client
    {
        //客户端代码使用组件接口处理所有对象。这样，它可以独立于它所处理的具体组件类。
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
